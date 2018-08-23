using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal10:baseLogic
    {
        public Soal10(int x, int y, int a, int lipat)
        {
            n1 = x;
            n2 = y;
            kelipatan = lipat;
            totKolom = x;
            baris = x;
            kolom = (x * y) + 2;
            array = new string[baris, kolom];
        }

        public void isiArray()
        {
            int geser = 0;
            int[] lipat3 = Deret.lipat3(n1 * kelipatan);

            for (int bangun = 0; bangun < n2; bangun++)
            {
                int index = 0;
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < n1; j++)
                    {
                        if (i == 0 && j <= 3)
                        {
                            //array[i, j+geser] = "*" + lipat3[index].ToString(); index++;
                            array[i, j + geser] = lipat3[index].ToString(); index++;
                            //array[i, j] = index.ToString(); index++;

                        }
                        else if (j == 3 && i <= baris - 1)
                        {
                            //array[i, j + geser] = "#" + lipat3[index].ToString(); index++;
                            array[i, j + geser] = lipat3[index].ToString(); index++;
                            //array[i, j] = index.ToString(); index++;
                        }
                        else if (i == baris - 1 && j <= 3)
                        {
                            //array[i, j + geser] = "@" + lipat3[index].ToString(); index++;
                            array[i, j + geser] = lipat3[index].ToString(); index++;
                            //array[i, j] = index.ToString(); index++;
                        }
                        else if (j == 0 && i <= baris - 1)
                        {
                            //array[i, j + geser] = "%" + lipat3[index].ToString(); index++;
                            array[i, j + geser] = lipat3[index].ToString(); index++;
                            //array[i, j] = index.ToString(); index++;
                        }

                    }
                }
                geser = geser + totKolom;
            }
            cetakArray();
        }
    }
}
