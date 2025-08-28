using System.Text;

Console.WriteLine("Enter a number: ");
string userInput = Console.ReadLine();

int number;

if (int.TryParse(userInput, out number))
{ 
   Console.WriteLine("Your number is: " + number);
}
else 
{
    Console.WriteLine("Not a valid entry. Try again.");
}


int drawSize = 6;
int minNumber = 1;
int maxNumber = 10; 

int[] userNumbers= new int[drawSize];
int[] randomNumbers= new int[drawSize];

Array.Sort(userNumbers); 

//replace from input later
userNumbers[0] =0;
userNumbers[1] = 1;
userNumbers[2] = 2;
userNumbers[3] = 3;
userNumbers[4] = 4;
userNumbers[5] = 5;
