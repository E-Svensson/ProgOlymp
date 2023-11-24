using System;
namespace aaa{
    class Program{
        static void Main(string[] args){

            bool godkänntN = false;
            bool godkänntM = false;
            int n = 0;
            int m = 7;
            string nStr = "";
            string mStr = "";

            // Input n
            while (!godkänntN){
                Console.Write("n ? ");
                nStr = Console.ReadLine();
                if (int.TryParse(nStr, out n) && n >= 1)
                    godkänntN = true;
                else
                    Console.WriteLine("Ej godkännt, försök igen");
            }

            // Input m
            while (!godkänntM){
                Console.Write("m ? ");
                mStr = Console.ReadLine();
                if (int.TryParse(mStr, out m) && m <= 6)
                    godkänntM = true;
                else
                    Console.WriteLine("Ej godkännt, försök igen");
            }

            string rad = "";
            char[] radChar = new char[m];
            char[,] plan = new char[n,m];

            // Input planet
            for (int i = 0; i < n; i++){

                bool godkändRad = false;

                // Input rad
                while (!godkändRad){
                    Console.Write($"Rad {i + 1} ? ");
                    rad = Console.ReadLine();
                    if (rad.Length == m)
                        godkändRad = true;
                    else
                        Console.WriteLine("Ej godkänd rad, försök igen");
                }

                radChar = rad.ToCharArray();

                // Delar ut värdena i planets kolonner
                for (int j = 0; j < m; j++){
                    plan[i,j] = radChar[j];
                }
            }

            for (int i = 0; i < n; i++){
                for (int j = 0; j < m; j++)
                    Console.Write(plan[i,j]);
                Console.WriteLine();
            }

            List<char> result = new List<char>();
            int savedColumn = 0;

            // Hitta meddelandet
            for (int i = 0; i < n; i++){
                for (int j = savedColumn; j < m; j++){
                    if (Char.IsLetter(plan[i,j])){
                        result.Add(plan[i,j]);
                        savedColumn = j;
                    }
                }
            }

            string resultStr = new string(result.ToArray());
            Console.WriteLine($"Svar: {resultStr}");
        }
    }
}