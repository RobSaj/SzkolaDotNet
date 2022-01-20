using System;

namespace Petle
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count = 1;
            
            do
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count);
                }
               count++;

            } while (count<=100);
           
        }

    }

}