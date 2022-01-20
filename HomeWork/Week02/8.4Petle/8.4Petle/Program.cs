using System;
namespace Petle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj liczbę");
            int max = int.Parse(Console.ReadLine());

           
            for (int i = 1; i <= max; i++)
            {

               // Console.WriteLine(i);
                Console.Write(i);

            }
            

           
           
        }
    }
}