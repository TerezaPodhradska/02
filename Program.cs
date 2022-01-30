using System;
using System.Collections.Generic;

namespace Magnety
{
    class Program
    {
        static void Main(string[] args)
        {

            //ZAPSÁNÍ MAGNETŮ DO POLE


            string popis = "Při zadání magnetů se vrátí délka řetězce. ";
            string[] pole = VstupStringPole(popis);

            
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine("Položte magnet");
                pole[i] = Console.ReadLine(); 
               
            }

            //ZJIŠTĚNÍ DÉLKY ŘETĚZCE

            int delkaRetezce = 0;
            for (int p = 0; p < pole.Length - 1; p++)
            {

                if (string.Equals(pole[p], pole[p + 1]) == false) {

                    delkaRetezce++;

                 }

            }
            if(delkaRetezce > 0)
            {
                delkaRetezce++;
            }



            Console.WriteLine("Řetězec je dlouhý: " + delkaRetezce);


            static void Vystup(int[] numbers)
            {

                foreach (int number in numbers)
                {
                    Console.WriteLine("\t {0} ", number);
                }
            }

            static string[] VstupStringPole(string popis )
            {
                System.Collections.Generic.List<string> pole = new List<string>();
                Console.WriteLine(popis);
                string tmpString = "";
                {
                    Console.Write("Zadejte magnety: ");
                    tmpString = Console.ReadLine();

                } while (tmpString == "") ;

                return pole.ToArray();

            }
               

        }
    }
}
