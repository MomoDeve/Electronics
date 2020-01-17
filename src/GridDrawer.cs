using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Electronics
{
    class GridDrawer
    {
        public Dictionary<string, TextureBrush> Brushes { get; private set; }

        Grid grid;

        public GridDrawer(Grid grid)
        {
            this.grid = grid;
            Brushes = new Dictionary<string, TextureBrush>();
        }

        public void AddFolder(string folderName, int imageSize, int imageScale)
        {
            string[] filePaths = Directory.GetFiles(folderName);

            foreach(string file in filePaths)
            {
                Image image = Image.FromFile(file);
                string fileName = file.Substring(folderName.Length + 1);
                Brushes.Add(fileName, new TextureBrush(new Bitmap(image, imageSize / imageScale, imageSize / imageScale)));
            }
        }

        public void DrawGrid(Graphics g, int size, int scale)
        {
            for(int x = 0; x < grid.xsize; x++)
            {
                for(int y = 0; y < grid.ysize; y++)
                {
                    BaseElement element = grid.elements[x, y];
                    if(element != null)
                    {
                        int cellSize = size / scale;
                        TextureBrush brush = Brushes[element.imagePath];
                        g.FillRectangle(brush, x * cellSize, y * cellSize, cellSize, cellSize);
                    }
                }
            }
        }

        public void DrawLines(Graphics g, int defaultCellSize, int scale, Pen p)
        {
            int cellSize = defaultCellSize / scale;
            for (int i = 0; i < grid.ysize + 1; i++)
            {
                g.DrawLine(p, 0, i * cellSize, grid.xsize * cellSize, i * cellSize);
            }
            for (int i = 0; i < grid.xsize + 1; i++)
            {
                g.DrawLine(p, i * cellSize, 0, i * cellSize, grid.ysize * cellSize);
            }
        }

        public static void DrawLines(Graphics g, int defaultCellSize, int scale, Pen p, int xsize, int ysize, int defaultX = 0, int defaultY = 0)
        {
            int cellSize = defaultCellSize / scale;
            g.DrawLine(p, defaultX, defaultY, xsize * cellSize + defaultX, defaultY);
            g.DrawLine(p, defaultX, ysize * cellSize + defaultY, xsize * cellSize + defaultX, ysize * cellSize + defaultY);
            g.DrawLine(p, defaultX, defaultY, defaultX, ysize * cellSize + defaultY);
            g.DrawLine(p, xsize * cellSize + defaultX, defaultY, xsize * cellSize + defaultX, ysize * cellSize + defaultY);
        }

        Dictionary<Guid, Label> labels = new Dictionary<Guid, Label>();
        HashSet<Guid> existingLabels = new HashSet<Guid>();

        public void DrawLabels(PictureBox canvas, int textSize, int size, int scale)
        {
            existingLabels.Clear();
            for (int x = 0; x < grid.xsize; x++)
            {
                for (int y = 0; y < grid.ysize; y++)
                {
                    BaseElement element = grid.elements[x, y];
                    if (element != null && element.SupportsLabeling)
                    {
                        if (string.IsNullOrEmpty(element.Name))
                        {
                            element.LabelId = null; // do not search for label as it not exists
                        }
                        else
                        {
                            if (!element.LabelId.HasValue)
                            {
                                int cellSize = size / scale;
                                element.LabelId = Guid.NewGuid();
                                Label label = new Label
                                {
                                    Text = element.Name,
                                    Location = new Point(x * cellSize + cellSize / 4, y * cellSize - cellSize / 4),
                                    AutoSize = true,
                                    Font = new Font("Consolas", textSize / scale),
                                    UseMnemonic = false,
                                    ForeColor = Color.White,
                                    BorderStyle = BorderStyle.FixedSingle,
                                };
                                labels.Add(element.LabelId.Value, label);
                                canvas.Controls.Add(label);
                            }
                            else
                            {
                                labels[element.LabelId.Value].Text = element.Name;
                            }
                            existingLabels.Add(element.LabelId.Value);
                        }
                    }
                }
            }

            // remove not existing labels from form and dictionary
            foreach(var pair in labels)
            {
                if (!existingLabels.Contains(pair.Key))
                {
                    canvas.Controls.Remove(pair.Value);
                }
            }
            labels = labels.Where(p => existingLabels.Contains(p.Key)).ToDictionary(t => t.Key, t => t.Value);
        }

        public void Dispose(PictureBox canvas)
        {
            grid.Resize(grid.xsize, grid.ysize); // update labels

            foreach(var pair in labels)
            {
                canvas.Controls.Remove(pair.Value);
            }
        }
    }
}
