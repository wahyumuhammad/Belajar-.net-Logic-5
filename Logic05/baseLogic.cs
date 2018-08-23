using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class baseLogic
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int baris { get; set; }
        public int kolom { get; set; }
        public string[,] array { get; set; }
        public int kelipatan { get; set; }
        public int bts { get; set; }
        public int totKolom { get; set; }


        public void cetakArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + "\t" );
                }
                Console.WriteLine("\n");
            }
        }
    }
}
