using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Deret
    {
        public static int[] fibo(int nMax)
        {

            int[] array = new int[nMax];
            for (int i = 0; i < nMax; i++)
            {
                //inisialisasi nilai 1
                if (i < 2)
                    array[i] = 1;
                else
                    array[i] = array[i - 2] + array[i - 1];
            }
            return array;
        }

        public static int[] lipat3(int nMax)
        {
            int n = 1;
            int[] array = new int[nMax];
            for (int i = 0; i < nMax; i++)
            {
                array[i] = n;
                n += 3;
            }
            return array;
        }

        public static int[] lipat4(int nMax)
        {
            int n = 1;
            int[] array = new int[nMax];
            for (int i = 0; i < nMax; i++)
            {
                array[i] = n;
                n += 4;
            }
            return array;
        }
    }
}
