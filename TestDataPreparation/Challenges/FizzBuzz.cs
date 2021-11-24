using System;

namespace TestDataPreparation.Challenges
{
    public static class FizzBuzz
    {
        public static void Execute(int startNumber = 1, int endNumber = 100)
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
    }
}
