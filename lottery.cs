using System;

class Program
{ 
    static void Main()
    { 
        int drawSize = 3;
        int minNumber = 1;
        int maxNumber = 10;

        int[] userNumbers = new int[drawSize];
        int count = 0;
        //int[] randomNumbers= new int[drawSize];

        Console.WriteLine("Enter " + drawSize + " numbers between " + minNumber + " and " + maxNumber + " : ");
        string userInput = Console.ReadLine();

                string[] parts = userInput.Split(' ');

        for (int i = 0; i <parts.Length && count < drawSize; i++)
        {
            int number;
            if (int.TryParse(parts[i], out number) && number >= minNumber && number <= maxNumber) 
            {
                userNumbers[count] = number;
                count++;
            }
            else
            {
                Console.WriteLine(parts[i] + " are invalid entries. Try again.");
            }
        }

        Console.WriteLine("Your numbers are: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(userNumbers[i]);
            if (i < count - 1 ) Console.Write(", ");
        }
        Console.WriteLine();
    }
}
//userNumbers[0] = 0;
//userNumbers[1] = 1;
//userNumbers[2] = 2;
//userNumbers[3] = 3;
//userNumbers[4] = 4;
//userNumbers[5] = 5;

//Array.Sort(userNumbers);

