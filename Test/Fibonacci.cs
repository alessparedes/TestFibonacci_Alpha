using System;
namespace Test
{
	public class Fibonacci
	{
		public Fibonacci()
		{
		}
        //CAP - funtionalty
        public static void Funtion(int fib)
        {
            if (fib < 0) Console.WriteLine("F0");
            if (fib == 0) Console.Write($"F{fib}");
            if (fib == 1) Console.Write($"F{fib}");

            int number = 0;
            int number2 = 1;
            int numberFib;

            for (int i = 1; i < fib + 1; i++)
            {
                numberFib = number + number2;
                if (numberFib == fib)
                {
                    Console.WriteLine($"F{fib} = {number} + {number2}");
                }

                number = number2;
                number2 = numberFib;
            }
        }
    }
}

