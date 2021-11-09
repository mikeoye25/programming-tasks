using System;

namespace TestDataPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // FizzBuzz();
            // Palindrome();
            Anagram("dear", "dream");
        }
        public static void Anagram(string firstword = null, string secondword = null)
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

        public static void FizzBuzz(int startNumber = 1, int endNumber = 100)
        {
            if (startNumber > endNumber)
            {
                Console.WriteLine("Start number cannot be greater than end number");
            }
            else
            {
                for (int i = startNumber; i <= endNumber; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }

        public static void Palindrome(string str = null)
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
