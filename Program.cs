using System;

namespace prvniHodina
{
    class Program
    {
        static void Main(string[] args)
        {

            Random x = new Random();

            /*int temp;
         for (int j = 0; j <= arr.Length - 2; j++) {
            for (int i = 0; i <= arr.Length - 2; i++) {
               if (arr[i] > arr[i + 1]) {
                  temp= arr[i + 1];
                  arr[i + 1] = arr[i];
                  arr[i] = temp;
               }
            }
         }
         Console.WriteLine("Sorted:");
         foreach (int p in arr)
            Console.Write(p + " ");
         Console.Read();*/

            int[] numbers = new int[5];

            for (int y = 0; y < 5; y++)
            {
                numbers[y] = x.Next(50);
            }


            /*
              int m = numbers.Max();
              int place = Array.IndexOf(numbers, m);
              int l = numbers.Last();
              numbers[place] = l;
              numbers[4] = m;


            for (int y = 0; y < numbers.Length - 1; y++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            foreach (int number in numbers)
            {
                Console.WriteLine("\t {0} ", number);


            }
               */

           
                for (int start = numbers.Length ; start > 0; start--)
                {

                    for (int i = 0; i < numbers.Length - 1; i++)
                    {


                        if (numbers[i + 1] < numbers[i])
                        {
                            int temp = numbers[i + 1];
                            numbers[i + 1] = numbers[i];
                            numbers[i] = temp;
                            

                        }
                     }

                }


            Vystup(numbers);






            /*
            Array.IndexOf(-jmeno array-, -to co v ni hledame-)  (kdyz zadame hodnotu, urci jeji pozici  ve array)
            Array.Min() /.Max() / .Lenght  /.Average()  /.First()  /.Last()  /.Skip()   /  .Distict().ToArray()  /  .Contains()

             */






            /*

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(i);
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            for (int n = 0; n < numbers.Length; n ++ )
            {
                Console.Write(numbers[n]);
            }


            int x = 11;
            do
            {
                Console.WriteLine(x++);
            }
            while (x < 20);


            foreach (int n in numbers)
            {
                Console.Write(n);
            }






            /* 
            Console.WriteLine("Zadejte sve jmeno:  ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte svuj vek:  ");
            int vek = int.Parse(Console.ReadLine());



            /*  SWITCH
            switch (vek)
            {
                case int n when (vek <= 6):
                    Console.WriteLine("Jste ve předškolním věku");
                    break;
                case int n when ( vek >= 7 & vek <= 17) :
                    Console.WriteLine("Jste v dorostovém období");
                    break;
                case int n when (vek >= 18 & vek <= 59) :
                    Console.WriteLine("Jste dospělý/á");
                    break;
                case int n when (vek >= 60) :
                    Console.WriteLine("Jste senior.");
                    break;



            } */



            /* IF n ELSE
            if (vek >= 18)
            {
                bool plnoletost = true;
                Console.WriteLine("Jste plnoletý/á.");
            } else
            {
                bool plnoletost = false;
                Console.WriteLine("Nejste plnoletý/á.");
            }
            */
        }
        static void Vystup(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine("\t {0} ", number);
            }

        }
    }
}


         
