using System;
using System.Collections.Generic;
using System.Linq;

namespace VrazednaCisla
{
    class Program
    {
        static void Main(string[] args)
        {


            string hlaska = "Zadejte pocet čísel (N) a čísla jehož dělitele budeme hledat (Q): ";
                int[] pole = VstupDoPole(hlaska);







        }


        static int[] VstupDoPole(string popis)
        {
            string zadani = "Zadejte čísla ";
            System.Collections.Generic.List<int> pole = new List<int>();
            Console.WriteLine(popis);
            int n = int.Parse(Console.ReadLine());
            
            int q = int.Parse(Console.ReadLine());

            string tmpString = "";
            {
                Console.Write(zadani);
                int nn = int.Parse(Console.ReadLine());
                pole.Append(nn);

            } while (tmpString == "") ;

            return pole.ToArray();
            
            

        }
        static string VstupString()
        {
            Console.WriteLine("Zadejte číslo, jehož dělitele budeme hledat (Q): ");
            string q = Console.ReadLine();
            return q;
        }
    }
}
