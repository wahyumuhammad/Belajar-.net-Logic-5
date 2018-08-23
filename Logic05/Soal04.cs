using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal04: baseLogic
    {
        public Soal04(int x, int y)
        {
            n1 = x;
            n2 = y;
            totKolom = y;
            baris = x;
            kolom = x * y;
            array = new string[baris, kolom];

        }

        public void isiArray()
        {
            int geser = 0;

            for (int bangun = 1; bangun <= n2; bangun++)
            {
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (i - j == 0 || j == 0 || (i == baris - 1 && j <= totKolom - 1))
                        {
                            if (bangun % 4 == 1)
                            {
                                array[i, j + geser] = "*";
                            }
                            else if (bangun % 4 == 2)
                            {
                                array[n1 - 1 - i, j + geser] = "*";
                            }
                            else if (bangun % 4 == 3)
                            {
                                array[n1-1-i, n1 - 1 - j + geser] = "*";

                            }else if(bangun % 4 == 0)
                            {
                                array[i, n1 - 1 - j + geser] = "*";
                            }
                            
                        }
                    }
                }
                geser = geser + totKolom;
            }

            cetakArray();
        }

        public void isiArrayCopy2()
        {
            int minggir = 0;

            for (int cetak = 1; cetak <= n2; cetak++)
            {
                for (int m = 0; m < baris; m++)
                {
                    for (int n = 0; n < kolom; n++)
                    {
                        if (m - n == 0 || n == 0 || (m == baris - 1 && n <= totKolom - 1))
                        {
                            if (cetak % 4 == 1)
                            {
                                array[m, n + minggir] = "*";
                            }
                            else if (cetak % 4 == 2)
                            {
                                array[n1 - 1 - m, n + minggir] = "*";
                            }
                            else if (cetak % 4 == 3)
                            {
                                array[n1 - 1 - m, n1 - 1 - n + minggir] = "*";

                            }
                            else if (cetak % 4 == 0)
                            {
                                array[m, n1 - 1 - n + minggir] = "*";
                            }

                        }
                    }
                }
                minggir = minggir + totKolom;
            }

            cetakArray();
        }

        public void isiArrayCopy3()
        {
            int g = 0;

            for (int print = 1; print <= n2; print++)
            {
                for (int x = 0; x < baris; x++)
                {
                    for (int y = 0; y < kolom; y++)
                    {
                        if (x- y == 0 || y == 0 || (x == baris - 1 && y <= totKolom - 1))
                        {
                            if (print % 4 == 1)
                            {
                                array[x, y + g] = "*";
                            }
                            else if (print % 4 == 2)
                            {
                                array[n1 - 1 - x, y + g] = "*";
                            }
                            else if (print % 4 == 3)
                            {
                                array[n1 - 1 - x, n1 - 1 - y + g] = "*";

                            }
                            else if (print % 4 == 0)
                            {
                                array[x, n1 - 1 - y + g] = "*";
                            }

                        }
                    }
                }
                g = g + totKolom;
            }
            cetakArray();
        }

        public void isiArrayCopy4()
        {
            int x = 0;

            for (int copy = 1; copy <= n2; copy++)
            {
                for (int a = 0; a < baris; a++)
                {
                    for (int b = 0; b < kolom; b++)
                    {
                        if (a - b == 0 || b == 0 || (a == baris - 1 && b <= totKolom - 1))
                        {
                            if (copy % 4 == 1)
                            {
                                array[a, b + x] = "*";
                            }
                            else if (copy % 4 == 2)
                            {
                                array[n1 - 1 - a, b + x] = "*";
                            }
                            else if (copy % 4 == 3)
                            {
                                array[n1 - 1 - a, n1 - 1 - b + x] = "*";

                            }
                            else if (copy % 4 == 0)
                            {
                                array[a, n1 - 1 - b + x] = "*";
                            }

                        }
                    }
                }
                x = x + totKolom;
            }
            cetakArray();
        }
    }
}
