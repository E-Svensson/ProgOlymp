using System;
namespace aaa{
    class Program{
        static void Main(string[] args){
            bool godkäntOrd = false;
            bool godkäntUpprepningar = false;
            string ordet = "";
            string upprepningarStr = "";
            int upprepningar = 0;

            // Ordet
            while (!godkäntOrd){ 
                Console.Write("Ordet ? "); 
                ordet = Console.ReadLine();
                if (ordet.Length > 9)
                    Console.WriteLine("Ord måste vara under 9 bokstäver, försök igen");
                else{
                    godkäntOrd = true;
                }
            }

            // Antal upprepningar
            while (!godkäntUpprepningar){ 
                Console.Write("Antal upprepningar ? "); 
                upprepningarStr = Console.ReadLine();
                if (int.TryParse(upprepningarStr, out upprepningar)){
                    if (upprepningar > 9)
                        Console.WriteLine("Antal upprepningar får inte vara fler än 9, försök igen");
                    else{
                        godkäntUpprepningar = true;
                    }
                } 
                else{
                    Console.WriteLine("Antal uppreningar måste vara ett heltal, försök igen");
                }
            }

            Console.Write("Svar: ");
            for (int i = 0; i < upprepningar; i++){
                Console.Write(ordet);
            }
        }
    }
}