using System;

namespace Week02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz liczbę od 1 do 5");
            int myInt = int.Parse(Console.ReadLine());

            if(myInt== 1)
            {

                Console.WriteLine("Wybrałeś 1");

            }
            else if(myInt== 2)
            {
                Console.WriteLine("Wybrałeś 2");
            }
            else
            {

                Console.WriteLine("cos innego");
            }
            myInt = myInt ==1 ? 1 : 0;
            Console.WriteLine(myInt);

        }        


    }
}