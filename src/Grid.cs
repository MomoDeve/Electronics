using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Electronics
{
    class Grid
    {
        public BaseElement[,] elements { get; private set; }

        public readonly int xsize, ysize;

        private bool CheckBounds(int x, int y)
        {
            return x >= 0 && x < xsize && y >= 0 && y < ysize;
        }

        private void UpdateRelatives(int x, int y)
        {
            var element = elements[x, y];
            if (CheckBounds(x - 1, y))
            {
                element.Connect(elements[x - 1, y], RelativePosition.Left);
            }
            if (CheckBounds(x + 1, y))
            {
                element.Connect(elements[x + 1, y], RelativePosition.Right);
            }
            if (CheckBounds(x, y + 1))
            {
                element.Connect(elements[x, y + 1], RelativePosition.Down);
            }
            if (CheckBounds(x, y - 1))
            {
                element.Connect(elements[x, y - 1], RelativePosition.Up);
            }
        }

        public Grid(int xsize, int ysize)
        {
            elements = new BaseElement[xsize, ysize];
            this.xsize = xsize;
            this.ysize = ysize;
        }

        public void SetElement(IElement element, int x, int y)
        {
            if (!CheckBounds(x, y))
            {
                return;
            }

            if (element != null && elements[x, y] == null)
            {
                elements[x, y] = (BaseElement)element;
                UpdateRelatives(x, y);
            }
            else if (elements[x, y] != null)
            {
                IElement el = elements[x, y];
                foreach (var connection in el.connections)
                {
                    if (connection.Value != null)
                    {
                        connection.Value.Connect(element, ~connection.Key);
                    }
                }
                elements[x, y] = (BaseElement)element;
            }
        }

        public void Update()
        {
            foreach (var element in elements)
            {
                if (!(element is PowerElement) && element != null)
                {
                    element.isOn = false;
                }
            }

            foreach (var element in elements)
            {
                if (element is PowerElement)
                {
                    element.PushEnergy();
                }
            }
        }

        public void Clear()
        {
            for (int i = 0; i < xsize; i++)
            {
                for (int j = 0; j < ysize; j++)
                {
                    elements[i, j] = null;
                }
            }
        }

        public Grid Resize(int xsize, int ysize)
        {
            Grid resizedGrid = new Grid(xsize, ysize);

            int xbound = Math.Min(xsize, this.xsize);
            int ybound = Math.Min(ysize, this.ysize);

            for (int i = 0; i < this.xsize; i++)
            {
                for (int j = 0; j < this.ysize; j++)
                {
                    if (elements[i, j] != null)
                        elements[i, j].LabelId = null;
                }
            }

            for (int i = 0; i < xbound; i++)
            {
                for (int j = 0; j < ybound; j++)
                {
                    resizedGrid.elements[i, j] = elements[i, j];
                }
            }
            return resizedGrid;
        }

        public Grid Shrink()
        {
            int xUp = xsize, yUp = ysize, xDown = -1, yDown = -1;

            for (int i = 0; i < xsize; i++)
            {
                for (int j = 0; j < ysize; j++)
                {
                    if (elements[i, j] != null)
                    {
                        xUp = Math.Min(xUp, i);
                        yUp = Math.Min(yUp, j);
                        xDown = Math.Max(xDown, i);
                        yDown = Math.Max(yDown, j);
                    }
                }
            }
            if (xDown == -1 || yDown == -1) return this;

            Grid newGrid = new Grid(xDown - xUp + 1, yDown - yUp + 1);
            for (int i = 0; i < newGrid.xsize; i++)
            {
                for (int j = 0; j < newGrid.ysize; j++)
                {
                    if(elements[xUp + i, yUp + j] != null)
                        elements[xUp + i, yUp + j].LabelId = null;
                    newGrid.SetElement(elements[xUp + i, yUp + j], i, j);

                }
            }
            return newGrid;
        }
    }
}