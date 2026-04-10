namespace Test;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number to calculate the Fibonacci sequence:");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int n))
        {
            Fibonacci.Function(n);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

