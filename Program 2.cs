using System;

namespace Magnety
{
    class Program
    {
        static void Main(string[] args)
        {

            //ZAPSÁNÍ MAGNETŮ DO POLE

            Console.WriteLine("Kolik máme magnetů: ");
            int pocetMagnetu = int.Parse(Console.ReadLine());

            string[] pole = new string[pocetMagnetu];
            
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

        }
    }
}
