using System;
using System.Collections.Generic;


namespace AllergyCalc
{
    class Calculator
    {        
        public static List<string> userAllergies = new List<string>();
        private static Dictionary<int, string> Allergens = new Dictionary<int, string>
     {{128,"cats"}, {64, "pollen"}, {32, "chocloate"}, {16, "tomatos"}, {8, "strawberries"}, {4,"shellfish"}, {2, "peanuts"},{ 1,"egg"}  };
    
        public static List<string> GetAllergens(int userScore)
        {
            userAllergies.Clear();
            foreach(KeyValuePair<int,string> key in Allergens)
            {
                if (userScore >=key.Key&& !userAllergies.Contains(key.Value))
                {
                    userAllergies.Add(key.Value);
                    userScore -= key.Key;
                }
            }
            return userAllergies;
        }
        
    }
}



