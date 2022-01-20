using System;

namespace Petle
{
    class Program
    {
        public static void Main(string[] args)
        {
            static bool czyPierwsza(int a)
            {
                
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
               return true;
            }

            int n = 100;
            int count = 0;

            for (int i = 2; i <= n; i++)
            {
                             
               if(czyPierwsza(i))
                {
                    Console.WriteLine(i);
                    count++;
                   
                }
                               
            }
            Console.WriteLine($"Od zera do {n} jest {count} liczb pierwszych");
        }
            
    }

}