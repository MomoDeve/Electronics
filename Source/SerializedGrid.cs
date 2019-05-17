using System;
using Newtonsoft.Json;

namespace Electronic
{
    class SerializedGrid
    {
        public int xsize, ysize;
        public string[,] elements;

        public SerializedGrid()
        {
            xsize = ysize = 0;
            elements = new string[xsize, ysize];
        }

        public SerializedGrid(Grid grid)
        {
            xsize = grid.xsize;
            ysize = grid.ysize;
            elements = new string[xsize, ysize];
            for (int i = 0; i < xsize; i++)
            {
                for (int j = 0; j < ysize; j++)
                {
                    if(grid.elements[i, j] == null)
                    {
                        elements[i, j] = null;
                    }
                    else
                    {
                        elements[i, j] = grid.elements[i, j].GetType().Name;
                    }
                }
            }
        }

        public SerializedGrid(string jsonString)
        {
            var grid = JsonConvert.DeserializeObject<SerializedGrid>(jsonString);
            xsize = grid.xsize;
            ysize = grid.ysize;
            elements = grid.elements;
        }

        public string GetJsonSerialization()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
