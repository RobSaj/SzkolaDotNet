using System;


namespace Week02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            string firstName = "Jak";
            string lastName = "Kowalski";
            byte age = 34;
            char sex = 'M';
            ulong id = 85040404138;
            ulong userNumber = 5956655;
            Console.WriteLine($"Dane pracownika o peselu: {id} to: {firstName} {lastName}, wiek {age}, płeć {sex}, numer pracownika {userNumber}.");
            Console.WriteLine(".................");

            Console.WriteLine("Zadanie drugie");
            Console.WriteLine("Podaj pierwszą literę");
            string myString1 = Console.ReadLine();
            Console.WriteLine("Podaj drugą literę");
            string myString2 = Console.ReadLine();
            Console.WriteLine("Podaj tezecią literę");
            string myString3 = Console.ReadLine();
            Console.WriteLine($"Podana przez Ciebie kolejność to :{myString1}, {myString2}, {myString3}");
            Console.WriteLine($"Odwrotna kolejność to :{myString3}, {myString2}, {myString1}");
            Console.WriteLine(".................");

            Console.WriteLine("Zadanie Trzecie");
            Console.WriteLine("Podaj długość pierwszego boku");
            double myDouble1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość pdrugiego boku");
            double myDouble2 = double.Parse(Console.ReadLine());
            myDouble1 = Math.Pow(myDouble1, 2);
            myDouble2 = Math.Pow(myDouble2, 2);
            double myDouble3 = Math.Sqrt(myDouble1 + myDouble2);
            myDouble3 = Math.Round(myDouble3, 2);
            Console.WriteLine($"Przekątna prostokatu ma długość  {myDouble3}");
            Console.WriteLine(".................");

            Console.WriteLine("Zadanie Czwarte");

            int myInt44;
            string myString44;
            double myDouble44;

            myInt44 = 10;
            myString44 = "Szkoła DotNeta";
            myDouble44 = 12.5;
            Console.WriteLine($" Int:{myInt44} String:{myString44} Double:{myDouble44}") ;

        }
    }
}