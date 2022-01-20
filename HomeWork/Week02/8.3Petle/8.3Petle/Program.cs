using System;

    namespace Petle
    {
        class Program
        {
           

            public static void Main(string[] args)
                          
            {
       
            long a = 0;
            long b = 1;
            long c = 0;


            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < 50; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
                

                

            }

        }


    }


