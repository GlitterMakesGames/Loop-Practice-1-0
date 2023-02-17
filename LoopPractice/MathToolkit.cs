public class MathToolkit
{
    //For Problem #2
    private static int[] sumArray = new int[10];
    private static int sumArray_Index = 0;
    private static bool firstIteration = true;
    private static int tempIndex = 0;
    //For Problem #4
    private static Random rng = new Random();
    private static int chosenNum = 0;
    //For Problem #5
    private static string[] numList_String;
    private static int[] numList_Int;
    private static int num;
    private static int counter = 0;
    private static int biggest;
    public static int divisibleByThree(int dividend)
    {
        int count = 0;
        for(int i = 1; i <= dividend; i++)
        {
            if ((i%3) == 0)
            {
                count++;
            }
        }
        return count;
    }

    public static int sumAllInputs(int addend)
    {
        if(firstIteration)
        {
            if(sumArray_Index <= 9)
            {
                sumArray[sumArray_Index] = addend;
            }
            tempIndex = sumArray_Index;
            sumArray_Index++;
            firstIteration = false;
        }

        if (tempIndex > 0)
        {
            return addend + sumAllInputs(sumArray[--tempIndex]);
        }
        else
        {
            firstIteration = true;
            return addend;
        }
    }

    public static int factorial(int facBase)
    {
        if (facBase == 1)
        {
            return 1;
        }
        else
        {
            return facBase * factorial(--facBase);
        }
    }

    public static void getRandNum()
    {
        chosenNum = rng.Next(1, 11);
    }

    public static bool guessingGame(int guess)
    {
        if (guess == chosenNum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //WARNING! DOES NOT ACCOUNT FOR NUMBERS WITH MORE THAN ONE DIGIT!
    //Replace foreach loop with for loop
    //Iterate through a nested loop (but keep incrementing the outer loop variable)
    //until a comma is found (use ASCII)
    public static int getBiggestNum(string input)
    {
        numList_String = new string[input.Length];
        foreach (char c in input)
        {
            if (Int32.TryParse(c + "", out num))
            {
                numList_String[counter] = c + "";
                counter++;
            }
        }
        numList_Int = new int[counter];
        for (int i = 0; i < counter; i++)
        {
            numList_Int[i] = Int32.Parse(numList_String[i]);
        }
        biggest = numList_Int[0];
        for(int i = 1; i < counter; i++)
        {
            if (numList_Int[i] > biggest)
            {
                biggest = numList_Int[i];
            }
        }
        return biggest;
    }
}