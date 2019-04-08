using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Electronic
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
                    IElement element = grid.elements[x, y];
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
    }
}
