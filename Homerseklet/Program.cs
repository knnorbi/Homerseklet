using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat
            Console.WriteLine("Melyik nap adatait fogod megadni?");
            string nap = Console.ReadLine();

            // 2. feladat
            double[] ertekek = new double[24];

            // 3. feladat c verzió
            //double[] ertekek = { 2, 3, 4 };

            // 3. feladat b verzió
            //double[] ertekek = new double[24];
            //for (int i = 0; i < ertekek.Length; i++)
            //{
            //    ertekek[i] = double.Parse(Console.ReadLine());
            //}

            // 3. feladat
            string adatok = Console.ReadLine();
            string[] tmp = adatok.Split(',');
            for (int i = 0; i < tmp.Length; i++)
            {
                ertekek[i] = double.Parse(tmp[i]);
            }

            // 4. feladat
            Console.WriteLine(nap + " hőmérsékletei:");
            for (int i = 0; i < ertekek.Length; i++)
            {
                Console.WriteLine($"{i} óra\t{ertekek[i]} C");
            }

            // 5. feladat
            for (int i = 0; i < ertekek.Length; i++)
            {
                //ertekek[i] = ertekek[i] - 2;
                ertekek[i] -= 2;
            }

            // 6. feladat
            double min = ertekek.Min();
            double max = ertekek.Max();
            double avg = ertekek.Average();
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Átlag: " + avg);

            // 7. feladat
            if (avg > 20)
            {
                Console.WriteLine("Az átlag 20 fok fölött volt.");
            }
            else
            {
                Console.WriteLine("Az átlag nem volt 20 fok.");
            }

            // 8. feladat
            int idx = 0;
            while (idx < ertekek.Length && ertekek[idx] >= 0)
            {
                idx++;
            }
            if (idx < ertekek.Length)
            {
                Console.WriteLine("Volt fagypont alatt.");
            }
            else
            {
                Console.WriteLine("Nem volt fagypont alatt.");
            }

            // 9. feladat
            for (int i = 0; i < ertekek.Length; i++)
            {
                if (ertekek[i] == max)
                {
                    Console.WriteLine($"A(z) {i}. óra a legmelegebbek egyike.");
                }
            }

            // 10. feladat
            for (int i = 1; i < ertekek.Length; i++)
            {
                if(ertekek[i] < ertekek[i - 1])
                {
                    Console.WriteLine($"A(z) {i}. órában hűlt az idő.");
                }
            }

            // 11. feladat
            //    string[] asd = new string[ertekek.Length];
            //    for (int i = 0; i < ertekek.Length; i++)
            //    {
            //        asd[i] = ertekek[i].ToString();
            //    }
            //    File.WriteAllLines("temeratures.txt", asd);

            StreamWriter sw = new StreamWriter("temeratures.txt");
            for (int i = 0; i < ertekek.Length; i++)
            {
                sw.WriteLine(ertekek[i]);
            }
            sw.Close();

            Console.ReadKey();
        }
    }
}
