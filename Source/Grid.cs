using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Electronic
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
            if(!CheckBounds(x, y))
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
                if(!(element is PowerElement) && element != null)
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
            for(int i = 0; i < xsize; i++)
            {
                for(int j = 0; j < ysize; j++)
                {
                    elements[i, j] = null;
                }
            }
        }

        public Grid Resize(int xsize, int ysize)
        {
            Grid resizedGrid = new Grid(xsize, ysize);

            xsize = Math.Min(xsize, this.xsize);
            ysize = Math.Min(ysize, this.ysize);

            for(int i = 0; i < xsize; i++)
            {
                for(int j = 0; j < ysize; j++)
                {
                    resizedGrid.elements[i, j] = elements[i, j];
                }
            }
            return resizedGrid;
        }
    }
}
