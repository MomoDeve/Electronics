using System;
using Newtonsoft.Json;

namespace Electronics
{ 
    class SerializedElement
    {
        public string Type = string.Empty;
        public string Name = string.Empty;
    }

    class SerializedGrid
    {
        public int xsize, ysize;
        public SerializedElement[,] elements;

        public SerializedGrid()
        {
            xsize = ysize = 0;
            elements = new SerializedElement[xsize, ysize];
        }

        public SerializedGrid(Grid grid)
        {
            xsize = grid.xsize;
            ysize = grid.ysize;
            elements = new SerializedElement[xsize, ysize];
            for (int i = 0; i < xsize; i++)
            {
                for (int j = 0; j < ysize; j++)
                {
                    if (grid.elements[i, j] == null)
                    {
                        elements[i, j] = null;
                    }
                    else
                    {
                        elements[i, j] = new SerializedElement()
                        {
                            Type = grid.elements[i, j].GetType().Name,
                            Name = grid.elements[i, j].Name,
                        };
                    }
                }
            }
        }

        public SerializedGrid(string jsonString)
        {
            // TODO: remove in next release
            if (!jsonString.Contains("Type"))
            {
                DeserializeGridCompat(jsonString);
                return;
            }

            try
            {
                var grid = JsonConvert.DeserializeObject<SerializedGrid>(jsonString);
                xsize = grid.xsize;
                ysize = grid.ysize;
                elements = grid.elements;
            }
            catch(JsonSerializationException)
            {
                throw new InvalidCastException();
            }
        }

        class CompatSerializedGrid
        {
            public int xsize = 0, ysize = 0;
            public string[,] elements = null;
        }
        private void DeserializeGridCompat(string jsonString)
        {
            try
            {
                var grid = JsonConvert.DeserializeObject<CompatSerializedGrid>(jsonString);
                xsize = grid.xsize;
                ysize = grid.ysize;
                elements = new SerializedElement[xsize, ysize];
                for(int i = 0; i < xsize; i++)
                {
                    for(int j = 0; j < ysize; j++)
                    {
                        if (grid.elements[i, j] != null && grid.elements[i, j] != "null")
                            elements[i, j] = new SerializedElement
                            {
                                Type = grid.elements[i, j]
                            };
                    }
                }
            }
            catch (JsonSerializationException)
            {
                throw new InvalidCastException();
            }
        }

        public string GetJsonSerialization()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
