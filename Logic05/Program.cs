using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Kode Soal (bintang atau deret) : ");
            string soal = Console.ReadLine();
            
            if (soal == "bintang")
            {
                Console.Write("Masukan Nomor Soal Bintang : ");
                int no = int.Parse(Console.ReadLine());

                Console.Write("Masukan Nilai 1 : ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai 2 : ");
                int n2 = int.Parse(Console.ReadLine());
                switch (no)
                {
                    case 1:
                        {
                            Soal01 soal1 = new Soal01(n1, n2);
                            soal1.isiArray();
                            break;
                        }
                    case 2:
                        {
                            Soal02 soal2 = new Soal02(n1, n2);
                            soal2.isiArray();
                            break;
                        }
                    case 3:
                        {
                            Soal03 soal3 = new Soal03(n1, n2);
                            soal3.isiArray();
                            break;
                        }
                    case 4:
                        {
                            Soal04 soal4 = new Soal04(n1, n2);
                            soal4.isiArray();
                            break;
                        }
                    case 5:
                        {

                            Soal05 soal5 = new Soal05(n1, n2);
                            soal5.isiArray();
                            break;
                        }
                    default:
                        Console.WriteLine("Soal Tidak Ada");
                        break;
                }
            }
            else if (soal == "deret")
            {
                Console.Write("Masukan Nomor Soal Deret : ");
                int no = int.Parse(Console.ReadLine());

                Console.Write("Masukan Nilai 1 : ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai 2 : ");
                int n2 = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai 3 : ");
                int n3 = int.Parse(Console.ReadLine());
                Console.Write("Masukan Nilai 4 : ");
                int n4 = int.Parse(Console.ReadLine());

                switch (no)
                {
                    case 6:
                        {
                            Soal06 soal6 = new Soal06(n1, n2);
                            soal6.isiArray();
                            break;
                        }
                    case 7:
                        {
                            Soal07 soal7 = new Soal07(n1, n2, n3, n4);
                            soal7.isiArray();
                            break;
                        }
                    case 8:
                        {
                            Soal08 soal8 = new Soal08(n1, n2, n3, n4);
                            soal8.isiArray();
                            break;
                        }
                    case 9:
                        {
                            Soal09 soal9 = new Soal09(n1, n2, n3, n4);
                            soal9.isiArray();
                            break;
                        }
                    case 10:
                        {

                            Soal10 soal10 = new Soal10(n1, n2, n3, n4);
                            soal10.isiArray();
                            break;
                        }
                    default:
                        Console.WriteLine("Soal Tidak Ada");
                        break;
                }
            }


            Console.ReadLine();

        }
    }
}
