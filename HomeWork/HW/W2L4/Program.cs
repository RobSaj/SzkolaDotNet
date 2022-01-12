using System;


namespace Week02
{
    public class Program
    {
        public static void Main(string[] args)
        {   // Zadanie 1
            Console.WriteLine("Zadanie 1");
            string firstName = "Jak";
            string lastName = "Kowalski";
            byte age = 34;
            char sex = 'M';
            ulong id = 85040404138;
            ulong userNumber = 5956655;
            Console.WriteLine($"Dane pracownika o peselu: {id} to: {firstName} {lastName}, wiek {age}, płeć {sex}, numer pracownika {userNumber}.");
            Console.WriteLine(".................");

            //Zadanie 2
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

            //Zadanie 3
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

            //Zadanie 4
            Console.WriteLine("Zadanie Czwarte");
                        int myInt44;
            string myString44;
            double myDouble44;

            myInt44 = 10;
            myString44 = "Szkoła DotNeta";
            myDouble44 = 12.5;
            Console.WriteLine($" Int:{myInt44} String:{myString44} Double:{myDouble44}") ;
                        Console.WriteLine(".................");

            //Zadanie 5
            Console.WriteLine("Zadanie Piąte");
            Console.WriteLine("Podaj swoje imię");
            string firstName5 = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko");
            string lastName5 = Console.ReadLine();
            Console.WriteLine("Podaj swój email");
            string eMail5 = Console.ReadLine();
            Console.WriteLine("Podaj swój wiek");
            byte age5 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost w cm");
            byte height5 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoją wagę");
            float weight5 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Twoje dane: {firstName5} {lastName5}, {eMail5}, {age5}, {height5}, {weight5} .");
            Console.WriteLine(".................");
        }
    }
}