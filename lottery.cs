using System;
using System.ComponentModel.Design;
using System.Numerics;

class Program
{
    static int LinearSearch(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                return i;
            }
        }
        return -1;
    }
    static int BinarySearch(int[] array, int value, int low, int high)
    {
        if (high >= low)
        {
            int mid = (low + high) / 2;

            if (array[mid] == value) return mid;

            if (array[mid] > value) return BinarySearch(array, value, low, mid - 1);

            return BinarySearch(array, value, mid + 1, high);
        }

        return -1;
    }
    static void Main()
    {
        int drawSize = 6;
        int minNumber = 1;
        int maxNumber = 40;

        int[] userNumbers = new int[drawSize];

        //random numbers here first for debugging

        Random rnd = new Random();
        int[] randomNumbers = new int[drawSize];

        for (int i = 0; i < drawSize; i++)
        {
            randomNumbers[i] = rnd.Next(minNumber, maxNumber + 1);
        }
        Array.Sort(randomNumbers);

        Console.Write("The random numbers are: ");
        Console.WriteLine(string.Join(", ", randomNumbers));

        while (true)
        {
            Console.WriteLine("\nEnter " + drawSize + " numbers between " + minNumber + " and " + maxNumber + "\n(You must use a space between each number)\n");
            string[] parts = Console.ReadLine().Split(' ');

            if (parts.Length != drawSize)
            {
                Console.WriteLine("You must enter exactly " + drawSize + " numbers. Try again.\n");
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
                    Console.WriteLine("Boooo. Don't you know how a lotto works? " + parts[i] + " is an invalid entry. You must try again.\n");
                    allValid = false;
                    break;
                }
            }

            if (allValid) break;
        }

        Console.WriteLine("\nYour numbers are: " + string.Join(", ", userNumbers) + "\n");

        //random number block here later

        int matches = 0;

        foreach (int userPick in userNumbers)
        {
        //int result = LinearSearch(randomNumbers, userPick);
        //if (result != -1)
        //    Console.WriteLine(userPick + " was drawn! :) (Linear, index " + result + ")");
        //else
        //    Console.WriteLine(userPick + " was not drawn :( (Linear)");

            int binaryResult = BinarySearch(randomNumbers, userPick, 0, randomNumbers.Length - 1);
            if (binaryResult != -1)
            {
                Console.WriteLine(userPick + " was drawn! :) (Binary, index " + binaryResult + ")\n");
                matches++;
            }
            else
            {
                Console.WriteLine(userPick + " was not drawn :( (Binary)\n");
            }
        }
        if (matches == drawSize)
        {
            Console.WriteLine("Congratulations! You won the jackpot lottery!");
        }
        else if (matches > 0)
        {
            Console.WriteLine("You got " + matches + " lucky numbers.");
        }
        else
        {
            Console.WriteLine("You didn't get any lucky numbers. Loser.");
        }
        

        

    }
}

    

