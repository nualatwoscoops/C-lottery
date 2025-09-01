using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int drawSize = 3;
        int minNumber = 1;
        int maxNumber = 10;

        int[] userNumbers = new int[drawSize];

        while (true)
        {

            Console.WriteLine("Enter " + drawSize + " numbers between " + minNumber + " and " + maxNumber + " : ");
            string[] parts = Console.ReadLine().Split(' ');

            if (parts.Length != drawSize)
            {
                Console.WriteLine("You must enter exactly " + drawSize + " numbers. Try again.");
                continue;
            }

            bool allValid = true;
            for (int i = 0; i < drawSize; i++)
            {
                if (int.TryParse(parts[i], out int number) && number >= minNumber && number <= maxNumber)
                {
                    userNumbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Boooo. Don't you know how a lotto works? " + parts[i] + " is an invalid entry. You must try again.");
                    allValid = false;
                    break;
                }
            }

            if (allValid) break;
        }

        Console.WriteLine("Your numbers are: " + string.Join(", ", userNumbers));


        Random rnd = new Random();
        int[] randomNumbers = new int[drawSize];

        for (int i = 0; i < drawSize; i++)
        {
            randomNumbers[i] = rnd.Next(minNumber, maxNumber + 1);
        }
        Console.Write("The random numbers are: ");
        Console.WriteLine(string.Join(", ", randomNumbers));
    }
}
//Array.Sort(userNumbers);


//for (int i = 0; i < count; i++)
//{
//    Console.Write(userNumbers[i]);
//    if (i < count - 1) Console.Write(", ");
//}
//Console.WriteLine();

//Random rnd = new Random();
//int[] randomNumbers = new int[drawSize];

//for (int i = 0; i < drawSize; i++)
//{
//    randomNumbers[i] = rnd.Next(minNumber, maxNumber + 1);
//}
//Console.Write("The random numbers are: ");
//for (int i = 0; i < drawSize; i++)
//{
//    Console.Write(randomNumbers[i] + " ");
//    if (i < drawSize - 1) Console.Write(", ");
//}
//Console.WriteLine();
//        }