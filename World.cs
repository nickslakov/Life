using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Life
{
    class World
    {
        Cell[,] cells;
        bool[,] tempStates;
        int width, height;

        public World(int Width, int Height)
        {
            width = Width;
            height = Height;

            cells = new Cell[height / 2, width / 2];
            tempStates = new bool[height / 2, width / 2];

            for (int j = 0; j < height / 2; j++)
            {
                for (int i = 0; i < width / 2; i++)
                {
                    cells[j, i] = new Cell(false);

                    tempStates[j,i] = cells[j,i].State;
                }
            }
        }

        public void update()
        {
            for (int j = 0; j < height / 2; j++)
            {
                for (int i = 0; i < width / 2; i++)
                {
                    int numCells = adjacentLiveCells(j, i);

                    if (cells[j,i].State)
                    {
                        if (numCells > 3)
                            tempStates[j, i] = false;
                        else if (numCells < 2)
                            tempStates[j, i] = false;
                        else
                            tempStates[j, i] = true;
                    }
                    else
                    {
                        if (numCells == 3)
                            tempStates[j, i] = true;
                        else
                            tempStates[j, i] = false;
                    }
                }
            }

            for (int j = 0; j < height / 2; j++)
            {
                for (int i = 0; i < width / 2; i++)
                {
                    cells[j,i].State = tempStates[j,i];
                }
            }
        }

        public void draw(Graphics gfx)
        {
            for (int j = 0; j < height / 2; j++)
            {
                for (int i = 0; i < width / 2; i++)
                {
                    if (cells[j, i].State)
                        gfx.FillRectangle(Brushes.GreenYellow, i * 2, j * 2, 2, 2);
                    else
                        gfx.FillRectangle(Brushes.Black, i * 2, j * 2, 2, 2);
                }
            }

        }

        private int adjacentLiveCells(int j, int i)
        {
            int numCells = 0;
            List<int[]> indices = new List<int[]>();

            indices.Add(new int[] { j - 1, i - 1 });
            indices.Add(new int[] { j - 1, i });
            indices.Add(new int[] { j - 1, i + 1 });
            indices.Add(new int[] { j, i - 1 });
            indices.Add(new int[] { j, i + 1 });
            indices.Add(new int[] { j + 1, i - 1 });
            indices.Add(new int[] { j + 1, i });
            indices.Add(new int[] { j + 1, i + 1 });

            coordsInBounds(indices);

            foreach (int[] coord in indices)
            {
                if (cells[coord[0], coord[1]].State)
                    numCells++;
            }

            return numCells;
        }

        public void spawn(int j, int i)
        {
            cells[j, i].State = true;
        }

        public void reset()
        {
            for (int j = 0; j < height / 2; j++)
            {
                for (int i = 0; i < width / 2; i++)
                {
                    cells[j, i].State = false;
                }
            }
        }

        private void coordsInBounds(List<int[]> indices)
        {
            foreach (int[] coord in indices)
            {
                if (coord[0] >= height / 2)
                {
                    coord[0] -= height / 2;
                }
                if (coord[0] < 0)
                {
                    coord[0] += height / 2;
                }
                if (coord[1] >= width / 2)
                {
                    coord[1] -= width / 2;
                }
                if (coord[1] < 0)
                {
                    coord[1] += width / 2;
                }
            }
        }

        public void createShape(int shapeIndex, int[] location)
        {
            if (shapeIndex == 0)
                createBlock(location);
            else if (shapeIndex == 1)
                createBeehive(location);
            else if(shapeIndex == 2)
                createLoaf(location);
            else if(shapeIndex == 3)
                createBoat(location);
            else if(shapeIndex == 4)
                createBlinker(location);
            else if(shapeIndex == 5)
                createToad(location);
            else if(shapeIndex == 6)
                createBeacon(location);
            else if(shapeIndex == 7)
                createGlider(location);
            else
                createLWSS(location);
        }

        private void createBlock(int[] location)
        {
            List<int[]> indices = new List<int[]>();

            indices.Add(location);
            indices.Add(new int[] { location[0] + 1, location[1] });
            indices.Add(new int[] { location[0], location[1] + 1 });
            indices.Add(new int[] { location[0] + 1, location[1] + 1 });

            coordsInBounds(indices);

            foreach (int[] coord in indices)
            {
                cells[coord[0], coord[1]].State = true;
            }
        }

        private void createBeehive(int[] location)
        {
            List<int[]> indices = new List<int[]>();
      
            indices.Add(new int[] { location[0] + 1, location[1] });
            indices.Add(new int[] { location[0], location[1] + 1 });
            indices.Add(new int[] { location[0] + 2, location[1] + 1 });
            indices.Add(new int[] { location[0], location[1] + 2 });
            indices.Add(new int[] { location[0] + 2, location[1] + 2 });
            indices.Add(new int[] { location[0] + 1, location[1] + 3 });

            coordsInBounds(indices);
          
            foreach (int[] cell in indices)
            {
                cells[cell[0], cell[1]].State = true;
            }
        }

        private void createLoaf(int[] location)
        {
            List<int[]> indices = new List<int[]>();

            indices.Add(new int[] { location[0] + 1, location[1] });
            indices.Add(new int[] { location[0], location[1] + 1 });
            indices.Add(new int[] { location[0] + 2, location[1] + 1 });
            indices.Add(new int[] { location[0], location[1] + 2 });
            indices.Add(new int[] { location[0] + 3, location[1] + 2 });
            indices.Add(new int[] { location[0] + 1, location[1] + 3 });
            indices.Add(new int[] { location[0] + 2, location[1] + 3 });

            coordsInBounds(indices);

            foreach (int[] cell in indices)
            {
                cells[cell[0], cell[1]].State = true;
            }    
        }

        private void createBoat(int[] location)
        {
            List<int[]> indices = new List<int[]>();

            indices.Add(location);
            indices.Add(new int[] { location[0] + 1, location[1] });
            indices.Add(new int[] { location[0], location[1] + 1 });
            indices.Add(new int[] { location[0] + 2, location[1] + 1 });
            indices.Add(new int[] { location[0] + 1, location[1] + 2 });
          
            coordsInBounds(indices);

            foreach (int[] cell in indices)
            {
                cells[cell[0], cell[1]].State = true;
            }    
        }

        private void createBlinker(int[] location)
        {
            List<int[]> indices = new List<int[]>();

            indices.Add(location);
            indices.Add(new int[] { location[0], location[1] + 1});
            indices.Add(new int[] { location[0], location[1] + 2 });

            coordsInBounds(indices);

            foreach (int[] cell in indices)
            {
                cells[cell[0], cell[1]].State = true;
            }    
        }

        private void createToad(int[] location)
        {
            createBlinker(new int[] { location[0], location[1] + 1 });
            createBlinker(new int[] { location[0] + 1, location[1] });
        }

        private void createBeacon(int[] location)
        {
            createBlock(location);
            createBlock(new int[] { location[0] + 2, location[1] + 2 });
        }

        private void createGlider(int[] location)
        {
            createBlinker(new int[] { location[0] + 2, location[1] });

            List<int[]> indices = new List<int[]>();
           
            indices.Add(new int[] { location[0], location[1] + 1 });
            indices.Add(new int[] { location[0] + 1, location[1] + 2 });

            coordsInBounds(indices);

            foreach (int[] cell in indices)
            {
                cells[cell[0], cell[1]].State = true;
            }    
        }

        private void createLWSS(int[] location)
        {
            List<int[]> indices = new List<int[]>();

            indices.Add(location);
            indices.Add(new int[] { location[0] + 1, location[1] });
            indices.Add(new int[] { location[0] + 2, location[1] });
            indices.Add(new int[] { location[0], location[1] + 1 });
            indices.Add(new int[] { location[0] + 3, location[1] + 1 });
            indices.Add(new int[] { location[0], location[1] + 2 });
            indices.Add(new int[] { location[0], location[1] + 3 });
            indices.Add(new int[] { location[0] + 1, location[1] + 4 });
            indices.Add(new int[] { location[0] + 3, location[1] + 4 });

            coordsInBounds(indices);

            foreach (int[] cell in indices)
            {
                cells[cell[0], cell[1]].State = true;
            }    
        }

        public void randomize()
        {
            Random rng = new Random();

            for (int j = 0; j < height / 2; j++)
            {
                for (int i = 0; i < width / 2; i++)
                {
                    if (rng.Next(0, 100) > 90)
                        cells[j, i].State = true;
                    else
                        cells[j, i].State = false;
                }
            }
        }
    }
}
