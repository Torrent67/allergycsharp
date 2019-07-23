using System;
using System.Collections.Generic;

namespace AllergyCalc
{
    class Program
    {
        public static void Main()
        {
            string repeat = "";
            do
            {
                Console.WriteLine("Enter your allergy score: \n");
                int score = int.Parse(Console.ReadLine());
                List<string> allergies = Calculator.GetAllergens(score);
                foreach(string item in allergies)
                {
                    Console.WriteLine("Allergy: ");
                    Console.WriteLine(item+"\n");
                }
                Console.WriteLine("Repeat? ('yeet' to stop)");
                repeat = Console.ReadLine();
            } while (repeat != "yeet");
            
        }
    }
}