using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        // Save input in character array
        char[] individualCharacters = Console.ReadLine().ToCharArray();

        // Create dictionary using the the char array
        Dictionary<char, int> characterFrequencyDictionary = new Dictionary<char, int>();

        // Fill the created dictionary
        foreach (char c in individualCharacters)
        {
            if (characterFrequencyDictionary.ContainsKey(c))
            {
                characterFrequencyDictionary[c]++;
            }
            else
            {
                characterFrequencyDictionary.Add(c, 1);
            }
        }

        // Initialize pair removal integer
        int j = 2;

        // Initialize bool for final answer
        bool seperate = true;

        // Logic to sequentially extract pairs from characterFrequencyDictionary
        do
        {
            foreach (KeyValuePair<char, int> pair in characterFrequencyDictionary.ToList())
            {
                if (pair.Value > 0)
                {
                    characterFrequencyDictionary[pair.Key]--;
                    j--;
                    if (j == 0)
                    {
                        break;
                    }
                }
            }

            // Check if all pair are extracted
            if (j > 0 && characterFrequencyDictionary.Where(x => x.Value > 0).Count() > 0)
            {
                seperate = false;
                break;
            }

            // Else continue removing pair
            else
            {
                j = 2;
            }
        } while (characterFrequencyDictionary.Where(x => x.Value > 0).Count() > 0);

        // Provide output
        Console.WriteLine(seperate);
        Console.ReadLine();
    }
}