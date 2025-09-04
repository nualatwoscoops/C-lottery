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

        //here first for checking

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

        //random number block here later

        foreach (int userPick in userNumbers)
        {
            int result = LinearSearch(randomNumbers, userPick);
            if (result != -1)
                Console.WriteLine(userPick + " was drawn! :) (Linear, index " + result + ")");
            else
                Console.WriteLine(userPick + " was not drawn :( (Linear)");

            int binaryResult = BinarySearch(randomNumbers, userPick, 0, randomNumbers.Length - 1);
            if (binaryResult != -1)
                Console.WriteLine(userPick + " was drawn! :) (Binary, index " + binaryResult + ")");
            else
                Console.WriteLine(userPick + " was not drawn :( (Binary)");
        }
    
        int LinearSearch(int[] array, int value)
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
            int BinarySearch(int[] array, int value, int low, int high)
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

        }
    }

    

