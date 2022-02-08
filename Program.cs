using System;
using System.Collections.Generic;
using System.Linq;

namespace Magnety
{
    class Program
    {
        static void Main(string[] args)
        {

            //ZAPSÁNÍ MAGNETŮ DO POLE


            
            string[] pole = VstupStringPole();

            

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




            Vystup(delkaRetezce);
            


             static void Vystup(int delkaRetezce)
             {

                Console.WriteLine("Řetězec je dlouhý: " + delkaRetezce);
             }

            static string[] VstupStringPole()
            {
                string popis = "Při zadání magnetů se vrátí délka řetězce. ";
                Console.WriteLine(popis);

                System.Collections.Generic.List<string> pole = new List<string>();
                string tmpString = "";
                {
                    Console.Write("Zadejte magnety: ");
                    tmpString = Console.ReadLine();
                    pole.Append(tmpString);

                } while (tmpString == "") ;

                return pole.ToArray();

            }
               

        }
    }
}
