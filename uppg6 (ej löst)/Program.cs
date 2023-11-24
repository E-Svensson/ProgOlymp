using System;
namespace aaa{
    class Program{
        static void Main(string[] args){

            bool godkäntStycke = false;
            string stycke = "";

            // Kollar stycket
            while (!godkäntStycke){
                Console.Write("Stycket ? ");
                stycke = Console.ReadLine();
                bool endastBokstäver = true;
                char[] chars = stycke.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                    if (!Char.IsLetter(chars[i]))
                        endastBokstäver = false;
                if (endastBokstäver && stycke.Length < 33)
                    godkäntStycke = true;
                else   
                    Console.WriteLine("Ej godkänt stycke, försök igen");
            }

            char[] styckeChars = stycke.ToCharArray();
            Array.Sort(styckeChars);
            int antalSek = 0;

            for (int i = 0; i < styckeChars.Length; i++){
                try{
                    char x = styckeChars[i];
                    char y = styckeChars[i + 1];
                    if (x.CompareTo(y) < 0){
                        Console.WriteLine("b");
                        char c = x;
                        while (c != y){
                            Console.WriteLine("a");
                            c++;
                            antalSek++;
                        }
                    }
                }
                catch{
                    break;
                }
            }

            Console.WriteLine($"Svar: {antalSek}");
        }
    }
}