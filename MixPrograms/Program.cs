using System;
using MixPrograms.Modelos;
using MixPrograms.Modelos.Calculadora;

namespace MixPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Inicio();

            Console.ReadLine();
        }
        public static int Fatorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else return x * Fatorial(x - 1);

        }
        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
