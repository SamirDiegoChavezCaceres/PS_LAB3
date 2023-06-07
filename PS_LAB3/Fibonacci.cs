using System;

public class Fibonacci
{
    public int CalcularFibonacci(int n)
    {
        if (n <= 0)
            throw new ArgumentException("El número debe ser mayor que cero.", nameof(n));

        if (n == 1 || n == 2)
            return 1;

        int fib1 = 1;
        int fib2 = 1;
        int fibonacci = 0;

        for (int i = 3; i <= n; i++)
        {
            fibonacci = fib1 + fib2;

        }
        fib1 = fib2;
        fib2 = fibonacci;
    }
        return fibonacci;
    }
}

