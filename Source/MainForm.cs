using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Electronic
{
    public partial class MainForm : Form
    {
        readonly int defaultCellSize = 64;
        readonly string resourcePath = "Misc/Resources";

        int scale = 1;
        bool drawLines = true;
        bool updateEnabled = true;
        bool gridLoaded = false;
        int loadX, loadY;
        bool fileSaved = false;
        string lastFileDirectory = null;

        SerializedGrid gridToAdd;
        Grid grid;
        GridDrawer drawer;
        Type drawObjectType = typeof(Wire);
        Color BackgroundColor;


        public MainForm()
        {
            InitializeComponent();
            BackgroundColor = Color.FromArgb(33, 33, 33);

            int numOfRows = 64;
            int numOfColumns = 64;
            grid = new Grid(numOfColumns, numOfRows);

            drawer = new GridDrawer(grid);
            drawer.AddFolder(resourcePath, defaultCellSize, scale);

            var fileItem = new ToolStripMenuItem("File");

            var newFileItem = new ToolStripMenuItem("New file");
            newFileItem.Click += (object sender, EventArgs e) =>
            {
                SaveFile(sender, e);
                lastFileDirectory = null;
                grid.Clear();
            };
            newFileItem.ShortcutKeys = Keys.Control | Keys.F;
            fileItem.DropDownItems.Add(newFileItem);


            var saveAsItem = new ToolStripMenuItem("SaveAs");
            saveAsItem.Click += SaveAsFile;
            saveAsItem.ShortcutKeys = Keys.Control | Keys.T;
            fileItem.DropDownItems.Add(saveAsItem);

            var saveItem = new ToolStripMenuItem("Save");
            saveItem.Click += SaveFile;
            saveItem.ShortcutKeys = Keys.Control | Keys.S;
            fileItem.DropDownItems.Add(saveItem);

            var loadItem = new ToolStripMenuItem("Load");
            loadItem.Click += (object sender, EventArgs e) =>
            {
                Stream fileStream;
                OpenFileDialog loadFileDialog = new OpenFileDialog();

                loadFileDialog.Filter = "(*.elc)|*.elc";
                loadFileDialog.FilterIndex = 2;
                loadFileDialog.RestoreDirectory = true;

                if (loadFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((fileStream = loadFileDialog.OpenFile()) != null)
                    {
                        try
                        {
                            byte[] bytes = new byte[fileStream.Length];
                            fileStream.Read(bytes, 0, bytes.Length);
                            gridToAdd = new SerializedGrid(Encoding.ASCII.GetString(bytes));
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Проверьте, присутствует ли Newtonsoft.Json.dll в папке программы", "Произошла ошибка при открытии файла");
                            gridLoaded = false;
                        }
                        finally
                        {
                            fileStream.Close();
                        }
                        gridLoaded = true;
                    }
                }
            };
            loadItem.ShortcutKeys = Keys.Control | Keys.D;
            fileItem.DropDownItems.Add(loadItem);

            MenuItems.Items.Add(fileItem);


            ToolStripMenuItem settingsItem = new ToolStripMenuItem("Settings");

            var updateItem = new ToolStripMenuItem("Auto-update");
            updateItem.Checked = true;
            updateItem.Click += (object sender, EventArgs e) =>
            {
                var element = (ToolStripMenuItem)sender;
                element.Checked = updateEnabled = !element.Checked;
            };
            updateItem.ShortcutKeys = Keys.Control | Keys.U;
            settingsItem.DropDownItems.Add(updateItem);


            var drawLinesItem = new ToolStripMenuItem("Grid");
            drawLinesItem.Checked = true;
            drawLinesItem.Click += (object sender, EventArgs e) =>
            {
                var element = (ToolStripMenuItem)sender;
                element.Checked = drawLines = !element.Checked;
                mainGrid.Invalidate();
            };
            drawLinesItem.ShortcutKeys = Keys.Control | Keys.G;
            settingsItem.DropDownItems.Add(drawLinesItem);


            var gridResizeItem = new ToolStripMenuItem("Size");
            var textbox = new ToolStripTextBox("Enter Sizes:");
            textbox.Text = string.Format("Xsize Ysize");
            textbox.LostFocus += (object sender, EventArgs e) =>
            {
                string[] sizes = textbox.Text.Split(";, ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    int xsize = int.Parse(sizes[0]);
                    int ysize = int.Parse(sizes[1]);
                    grid = grid.Resize(xsize, ysize);
                    ChangeScale(scale);
                }
                catch(Exception) { }
            };
            gridResizeItem.DropDownItems.Add(textbox);
            settingsItem.DropDownItems.Add(gridResizeItem);

            var clearItem = new ToolStripMenuItem("Clear");
            clearItem.Click += (object sender, EventArgs e) => { grid.Clear(); mainGrid.Invalidate(); };
            clearItem.ShortcutKeys = Keys.Control | Keys.C;
            settingsItem.DropDownItems.Add(clearItem);

            MenuItems.Items.Add(settingsItem);

            var speeditem = new ToolStripMenuItem("Speed");

            for (int i = 1; i < 9; i++)
            {
                int k = 1000 / (int)Math.Pow(2, i);
                var speedOption = new ToolStripMenuItem(k.ToString() + " ms");
                speedOption.Click += (object sender, EventArgs e) => mainTimer.Interval = k;
                speeditem.DropDownItems.Add(speedOption);
            }
            MenuItems.Items.Add(speeditem);

            var scaleGridSettings = new ToolStripMenuItem("Scale");

            for (int i = 1; i < 8; i++)
            {
                int k = i;
                var scaleOption = new ToolStripMenuItem((100 / i).ToString() + '%');
                scaleOption.Click += (object sender, EventArgs e) => ChangeScale(k);
                scaleGridSettings.DropDownItems.Add(scaleOption);
            }

            MenuItems.Items.Add(scaleGridSettings);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            mainGrid.BackColor = BackgroundColor;
        }

        private void mainGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellSize = defaultCellSize / scale;
            Pen p = new Pen(Color.LightGray);

            drawer.DrawGrid(g, defaultCellSize, scale);

            if(drawLines)
            {
                drawer.DrawLines(g, defaultCellSize, scale, p);
            }

            if(gridLoaded)
            {
                GridDrawer.DrawLines(g, defaultCellSize, scale, new Pen(Color.Red, 2), gridToAdd.xsize, gridToAdd.ysize, loadX, loadY);
            }
        }

        private void SaveAsFile(object sender, EventArgs e)
        {
            Stream fileStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "(*.elc)|*.elc";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveFileDialog.OpenFile()) != null)
                {
                    try
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(new SerializedGrid(grid).GetJsonSerialization());
                        fileStream.Write(bytes, 0, bytes.Length);
                        lastFileDirectory = saveFileDialog.FileName;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Проверьте, присутствует ли Newtonsoft.Json.dll в папке программы", "Произошла ошибка при сохранении файла");
                    }
                    finally
                    {
                        fileStream.Close();
                    }
                }
                fileSaved = true;
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (!File.Exists(lastFileDirectory))
            {
                SaveAsFile(sender, e);
            }
            else
            {
                try
                {
                    using (Stream fileStream = File.Open(lastFileDirectory, FileMode.Create))
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(new SerializedGrid(grid).GetJsonSerialization());
                        fileStream.Write(bytes, 0, bytes.Length);
                        fileStream.Close();
                        fileSaved = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Проверьте, присутствует ли Newtonsoft.Json.dll в папке программы", "Произошла ошибка при сохранении файла");
                }
            }
        }

        private void mainGrid_MouseDown(object sender, MouseEventArgs e)
        {
            fileSaved = false;
            if(e.Button == MouseButtons.Right)
            {
                gridToAdd = null;
                gridLoaded = false;
                return;
            }

            int x = e.X * scale;
            int y = e.Y * scale;
            x -= x % defaultCellSize;
            y -= y % defaultCellSize;
            if (x >= (grid.xsize * defaultCellSize) || y >= (grid.ysize * defaultCellSize)) return;

            if (gridLoaded)
            {
                gridLoaded = false;
                PlaceGridOnField(x, y);
                gridToAdd = null;
                return;
            }

            IElement element = null;
            if (drawObjectType != null)
            {
                element = (IElement)Activator.CreateInstance(drawObjectType);
            }

            int gridX = x / defaultCellSize;
            int gridY = y / defaultCellSize;

            if(grid.elements[gridX, gridY] != null && element != null)
            {
                grid.elements[gridX, gridY].Click();
            }
            else
            {
                grid.SetElement(element, gridX, gridY);
            }
            mainGrid.Invalidate();
        }

        void ChangeScale(int newScale)
        {
            scale = newScale;

            drawer = new GridDrawer(grid);
            drawer.AddFolder(resourcePath, defaultCellSize, scale);

            mainGrid.Invalidate();
        }

        private void ElementSelectButton_click(object sender, EventArgs e)
        {
            drawObjectType = Type.GetType("Electronic." + (string)((ButtonBase)sender).Tag);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (updateEnabled)
            {
                grid.Update();
            }
            mainGrid.Invalidate();
        }

        private void mainGrid_MouseMove(object sender, MouseEventArgs e)
        {
            loadX = e.X;
            loadY = e.Y;
            loadX -= loadX % (defaultCellSize / scale);
            loadY -= loadY % (defaultCellSize / scale);
            mainGrid.Invalidate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!fileSaved)
            {
                SaveAsFile(sender, e);
            }
        }

        private void PlaceGridOnField(int x, int y)
        {
            for(int i = 0; i < gridToAdd.xsize; i++)
            {
                for(int j = 0; j < gridToAdd.ysize; j++)
                {
                    IElement element = null;
                    if (gridToAdd.elements[i, j] != null)
                    {
                        element = (IElement)Activator.CreateInstance(gridToAdd.elements[i, j]);
                    }
                    grid.SetElement(element, x / defaultCellSize + i, y / defaultCellSize + j);
                }
            }
        }
    }
}
