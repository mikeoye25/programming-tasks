using System;

namespace TestDataPreparation.Challenges
{
    public static class Palindrome
    {
        public static void Execute(string str = null)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length < 2)
            {
                Console.WriteLine("Word cannot be null or lesser than 2");
            }
            else
            {
                var revStr = "";
                for (var i = str.Length - 1; i >= 0; i--)
                {
                    revStr += str[i].ToString();
                }
                if (revStr == str)
                {
                    Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", str, revStr);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", str, revStr);
                }

            }
        }
    }
}
