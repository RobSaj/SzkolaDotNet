using System;

namespace Petle
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            int i = 0;

            do
            {
                if (count % 2 == 0)
                {
                    i++;
                }
                count++;

            } while (count<=10);
            Console.WriteLine(i);
        }

    }

}