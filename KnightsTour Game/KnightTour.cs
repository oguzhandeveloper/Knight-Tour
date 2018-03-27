using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightsTour_Game
{
    class KnightTour
    {
        int Size = 0;
        int count = 0;
        object[,] tahta;

        public KnightTour(int Size)
        {
            this.Size = Size;
            tahta = new object[Size,Size];
        }

        public void Define()
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    tahta[i,j] = -1;
        }

        public int Click(PointCord point)
        {
            count++;
            tahta[point.X, point.Y]=count;
            return count;
        }

        public PointCord[] Identify(PointCord p)
        {
            PointCord[] point = new PointCord[8];
            int i = 0;

            int x = p.X;
            int y = p.Y;

            //X Koordinatı Üzerinde
            if ((int)tahta[x, y] != -1)
            {
                tahta[x, y] = count;

                if (x + 2 < Size && y + 1 < Size)
                {   
                    
                    if ((int)tahta[x + 2, y + 1] == -1)
                    {
                        point[i] = new PointCord { X = x + 2, Y = y + 1 };
                        i++;
                    }
                }

                if (x + 2 < Size && y - 1 >= 0)
                {
                    if ((int)tahta[x + 2, y - 1] == -1)
                    {
                        point[i] = new PointCord { X = x + 2, Y = y - 1 };
                        i++;
                    }
                }

                if (x - 2 >= 0 && y + 1 < Size)
                {
                    if ((int)tahta[x - 2, y + 1] == -1)
                    {
                        point[i] = new PointCord { X = x - 2, Y = y + 1 };
                        i++;
                    }
                }

                if (x - 2 >= 0 && y - 1 >= 0)
                {
                    if ((int)tahta[x - 2, y - 1] == -1)
                    {
                        point[i] = new PointCord { X = x - 2, Y = y - 1 };
                        i++;
                    }
                }


                //Y Kordinatı Üzerinde

                if (x + 1 < Size && y + 2 < Size)
                {
                    if ((int)tahta[x + 1, y + 2] == -1)
                    {
                        point[i] = new PointCord { X = x + 1, Y = y + 2 };
                        i++;
                    }
                }

                if (x + 1 < Size && y - 2 >= 0)
                {
                    if ((int)tahta[x + 1, y - 2] == -1)
                    {
                        point[i] = new PointCord { X = x + 1, Y = y - 2 };
                        i++;
                    }
                }

                if (x - 1 >= 0 && y + 2 < Size)
                {
                    if ((int)tahta[x - 1, y + 2] == -1)
                    {
                        point[i] = new PointCord { X = x - 1, Y = y + 2 };
                        i++;
                    }
                }

                if (x - 1 >= 0 && y - 2 >= 0)
                {
                    if ((int)tahta[x - 1, y - 2] == -1)
                    {
                        point[i] = new PointCord { X = x  -1, Y = y - 2};
                        i++;
                    }
                }

                return point;

            }
            else
            {
                return null;
            }
        }

    }
}
