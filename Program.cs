internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;

        int result;

        string answer;

        Console.WriteLine("Hello, Welcome to your Calculator!");
        Console.WriteLine("Please enter your first number.");

        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("Please enter your second number.");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What type of operation would you like to do?");
        Console.WriteLine("Please enter a for additon, s for subtraction, m for multiplication or any other key for division.");

        answer = Console.ReadLine();

        if(answer == "a") 
        {
            result = num1 + num2;
        }
        else if (answer == "s")
        {
            result = num1 - num2;
        }
        else if (answer == "m")
        {
            result = num1 * num2;
        }
        else
        {
            result = num1 / num2;
        }

        Console.WriteLine( "The result is " + result);
        Console.WriteLine("Thank You for using the Calculator");
    }
}
