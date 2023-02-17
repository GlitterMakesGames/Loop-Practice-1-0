using static MathToolkit;
class MainClass
{
    public static void Main(string[] args)
    {
        string input = "";
        string output = "";
        int temp;
        bool win = false;

        //Problem #1
        Console.Write("Please enter a positive integer: ");
        int dividend = Int32.Parse(Console.ReadLine());
        output = divisibleByThree(dividend) + "";
        Console.WriteLine("There are " + output + " numbers divisible by three between 1 and " + dividend);
        Console.WriteLine();

        //Problem #2
        Console.WriteLine("Please enter all the integers you would like to add (maximum of 10).");
        Console.WriteLine("One at a time, please. Otherwise, enter \"ok\" to move on.\n");
        for(int i = 0; i < 10; i++)
        {
            Console.Write("Enter the Next Number: ");
            input = Console.ReadLine();

            if (input.Equals("ok", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            temp = Int32.Parse(input);
            output = sumAllInputs(temp) + "";
            Console.WriteLine("The total sum is now " + output);

            if (i == 9)
            {
                Console.WriteLine("\nYou have used up all your numbers.\n");
            }
        }

        //Problem #3
        Console.Write("Please enter an integer for the factorial calculation: ");
        input = Console.ReadLine();
        output = factorial(Int32.Parse(input)) + "";
        Console.WriteLine(input + "! is equal to " + output);

        //Problem #4
        getRandNum();
        for (int attempts = 0; attempts < 4; attempts++)
        {
            Console.Write("Enter your guess (1-10): ");
            input = Console.ReadLine();
            if (guessingGame(Int32.Parse(input)))
            {
                win = true;
                Console.WriteLine("You Win!");
            }
            else
            {
                win = false;
                Console.WriteLine("Incorrect!");
            }
        }
        if (!win)
        {
            Console.WriteLine("You Lose!");
        }

        //Problem #5
        Console.WriteLine("Please enter a list of integers separated by commas.");
        Console.WriteLine("Press \"Enter\" when done.");
        Console.Write("Type Here: ");
        input = Console.ReadLine();
        output = getBiggestNum(input) + "";
        Console.WriteLine("The biggest number in the list provided is " + output);
    }
}