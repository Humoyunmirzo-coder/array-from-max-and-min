using System;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write(" Enter number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write(" Enter number: ");
            int number2 = int.Parse(Console.ReadLine());

            int[,] array = new int[number1, number2];
            {
                for (int i = 0; i < number1; i++)
                {
                    for (int j = 0; j < number2; j++)
                    {
                        array[i, j] = random.Next(1, 10);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                int sum = 0;
                int max = 0;
                int min = 1000000;
                for (int i = 0; i < number1; i++)
                {
                    for (int j = 0; j < number2; j++)
                    {
                        sum += array[i, j];
                    }
                    Console.WriteLine($" Sum of Numbers:    {sum}");
                    if (max < sum)
                    {
                        max = sum;

                    }
                    if (min > sum)
                    {
                        min = sum;
                    }
                    sum = 0;
                }
                Console.WriteLine($" The maximum number  {max}");
                Console.WriteLine($" The minimum number  {min}");
            }

        }
    }
}