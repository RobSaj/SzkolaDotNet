using System;
namespace Petle
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Podaj liczbę");
            // int max = int.Parse(Console.ReadLine());
            
            //int x = 1;
            //int i=1;
            int length = 50;
            //int row = 1;

             for (int row = 1; row <= 20; row++)
             {

              for (int w = 1; w <= row; w++)
              {
                Console.Write(w + " ");
                w++;
             }

             Console.WriteLine($"\n");

             }


            //wypisuje ciąg od0 do length
       
            
           
          

            
          
        }
    }
}