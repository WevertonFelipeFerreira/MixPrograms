using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPrograms.Modelos.BuscaERecur
{
   public class BuscaERecursividade
    {
        public static int BuscaSequencialRecursiva(int[] vetor, int numeroAprocurar, int leitor)
        {
            if (vetor[leitor] == numeroAprocurar)
            {
                return leitor;
            }
            else
            {
                return BuscaSequencialRecursiva(vetor, numeroAprocurar, leitor + 1);
            }
        }
        public static int BuscaBinariaRecursiva(int[] vetor, int valorProcurado, int i, int f)
        {
            if (i > f)
            {
                return -1;
            }
            int m = (i + f) / 2;
            if (vetor[m] == valorProcurado)
            {
                return m;
            }
            if (valorProcurado < vetor[m])
            {
                return BuscaBinariaRecursiva(vetor, valorProcurado, i, m - 1);
            }
            else return BuscaBinariaRecursiva(vetor, valorProcurado, m + 1, f);
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
