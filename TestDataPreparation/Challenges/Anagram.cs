using System;

namespace TestDataPreparation.Challenges
{
    public static class Anagram
    {
        public static void Execute(string firstword = null, string secondword = null)
        {
            var isAnagram = false;
            if (!string.IsNullOrWhiteSpace(firstword) &&
                !string.IsNullOrWhiteSpace(secondword) &&
                firstword.Length == secondword.Length)
            {
                var s1Array = firstword.ToLower().ToCharArray();
                var s2Array = secondword.ToLower().ToCharArray();

                Array.Sort(s1Array);
                Array.Sort(s2Array);

                firstword = new string(s1Array);
                secondword = new string(s2Array);

                isAnagram = firstword == secondword;
            }
            if (isAnagram)
            {
                Console.WriteLine($"This is an anagram");
            }
            else
            {
                Console.WriteLine($"This is NOT an anagram");
            }
        }
    }
}
