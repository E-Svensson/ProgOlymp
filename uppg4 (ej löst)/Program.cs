using System;
namespace aaa{
    class Program{
        static void Main(string[] args){
            
            bool godkäntProtein = false;
            string protein = "";

            // Input Protein
            while (!godkäntProtein){
                Console.Write("Björns protein ? ");
                protein = Console.ReadLine();

                bool endastBokstäver = true;

                char[] chars = protein.ToCharArray();
                for (int i = 0; i < chars.Length; i++){
                    if (!Char.IsLetter(chars[i]))
                        endastBokstäver = false;
                }

                if (endastBokstäver && protein.Length < 33 && protein.Length > 1)
                    godkäntProtein = true;
                else
                    Console.WriteLine("Ej godkänt protein, försök igen");
            }

            char[] newChars = protein.ToCharArray();
            
            bool godkäntK = false;
            int k = 0;
            string kStr = "";

            // Input k
            while (!godkäntK){
                Console.Write("k ? ");
                kStr = Console.ReadLine();
                if (int.TryParse(kStr, out k) && k >= 1)
                    godkäntK = true;
                else
                    Console.WriteLine("Icke godkänt, försök igen");
            }

            int svar = 100;

            for (int i = 0; i < newChars.Length; i++){
                char start = newChars[i]
                int antal = 0;
            }
        }
    }
}