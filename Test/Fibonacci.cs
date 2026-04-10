namespace Test
{
	public static class Fibonacci
	{
        //CAP - functionality
        public static void Function(int fib)
        {
            if (fib < 0) return;

            var a = 0;
            var b = 1;
            var series = "0";
            
            if (fib > 0) series += ", 1";
            var numberFib = b;

            while (numberFib <= fib) 
            {
                series += $", {numberFib}";
                if (numberFib == fib)
                {
                    Console.WriteLine($"Result {fib} = {a} + {b}");
                }

                a = b;
                b = numberFib;
                numberFib = a + b;
            }
            Console.WriteLine(series);
        }
    }
}

