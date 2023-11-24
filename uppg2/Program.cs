using System;
namespace aaa{
    class Program{
        static void Main(string[] args){

            bool godkäntInput = false;
            string inputStr = "";
            double input = 0;

            // Input
            while (!godkäntInput){
                Console.Write("N ? ");
                inputStr = Console.ReadLine();
                if (double.TryParse(inputStr, out input))
                    godkäntInput = true;
                else
                    Console.WriteLine("Inte ett heltal, försök igen");
            }

            bool stopp = false;
            double antal = 0;
            double a = 1;
            double produkt = 0;

            while (!stopp){
                produkt = a * (a + 1) * (a + 2);
                if (produkt < input)
                    antal++;
                else
                    stopp = true;
                a++;
            }

            Console.WriteLine($"Svar: {antal}");
        }
    }
}