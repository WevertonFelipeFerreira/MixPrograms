using System;


namespace MixPrograms
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Inicio();

        }
        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            return 1;
        }
        // Calculadora
        public static void Inicio()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("(1) Soma");
            Console.WriteLine("(2) Subtração");
            Console.WriteLine("(3) Multiplicação");
            Console.WriteLine("(4) Divisão");
            Console.WriteLine("(5) Potência");
            Console.WriteLine("(6) Sair");
            string leitor = Console.ReadLine();
            int operador = Convert.ToInt32(leitor);
            if (operador > 6 || operador < 1)
            {
                Console.WriteLine("O valor digitado esta incorreto!");
                Console.Clear();
                Inicio();
            }

            if (operador == 1)
            { Console.Clear(); Soma(); }
            else if (operador == 2)
            { Console.Clear(); Subtração(); }
            else if (operador == 3)
            { Console.Clear(); Multiplicação(); }
            else if (operador == 4)
            { Console.Clear(); Divisao(); }
            else if (operador == 5)
            { Console.Clear(); Potência(); }
            else if (operador == 6)
            { Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema");Console.ReadLine(); }


        }
        public static void Soma()
        {
            Console.WriteLine("A Soma foi escolhida");
            Console.WriteLine("Digite o primeiro valor: ");
            string leitor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            string leitor2 = Console.ReadLine();
            int num1 = Convert.ToInt32(leitor1);
            int num2 = Convert.ToInt32(leitor2);
            int soma = (num1 + num2);
            Console.WriteLine("A soma de " + num1 + " + " + num2 + " = " + soma);
            Console.WriteLine("Deseja fazer outro calculo? s/ para sim. n/ para não.");
            string leitor3 = Console.ReadLine();
            if (leitor3 == "s")
            {
                Console.Clear();
                Inicio();
            }
            else Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema");

        }
        public static void Subtração()
        {
            Console.WriteLine("A Subtração foi escolhida");
            Console.WriteLine("Digite o primeiro valor: ");
            string leitor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            string leitor2 = Console.ReadLine();
            int num1 = Convert.ToInt32(leitor1);
            int num2 = Convert.ToInt32(leitor2);
            int soma = (num1 - num2);
            Console.WriteLine("A Subtração de " + num1 + " - " + num2 + " = " + soma);
            Console.WriteLine("Deseja fazer outro calculo? s/ para sim. n/ para não.");
            string leitor3 = Console.ReadLine();
            if (leitor3 == "s")
            {
                Console.Clear();
                Inicio();
            }
            else Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema");

        }
        public static void Multiplicação()
        {
            Console.WriteLine("A Multiplicação foi escolhida");
            Console.WriteLine("Digite o primeiro valor: ");
            string leitor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            string leitor2 = Console.ReadLine();
            int num1 = Convert.ToInt32(leitor1);
            int num2 = Convert.ToInt32(leitor2);
            int soma = (num1 * num2);
            Console.WriteLine("A Multiplicação de " + num1 + " * " + num2 + " = " + soma);
            Console.WriteLine("Deseja fazer outro calculo? s/ para sim. n/ para não.");
            string leitor3 = Console.ReadLine();
            if (leitor3 == "s")
            {
                Console.Clear();
                Inicio();
            }
            else Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema");

        }
        public static void Divisao()
        {
            Console.WriteLine("A Divisão foi escolhida");
            Console.WriteLine("Digite o primeiro valor: ");
            string leitor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            string leitor2 = Console.ReadLine();
            int num1 = Convert.ToInt32(leitor1);
            int num2 = Convert.ToInt32(leitor2);
            int soma = (num1 / num2);
            Console.WriteLine("A Divisão de " + num1 + " / " + num2 + " = " + soma);
            Console.WriteLine("Deseja fazer outro calculo? s/ para sim. n/ para não.");
            string leitor3 = Console.ReadLine();
            if (leitor3 == "s")
            {
                Console.Clear();
                Inicio();
            }
            else Console.Clear(); Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema");
        }
        public static void Potência()
        {
            Console.WriteLine("A Potência foi escolhida");
            Console.WriteLine("Digite o primeiro valor: ");
            string leitor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            string leitor2 = Console.ReadLine();
            int num1 = Convert.ToInt32(leitor1);
            int num2 = Convert.ToInt32(leitor2);
            int soma = (int)Math.Pow(num1, num2);
            Console.WriteLine("A Potência de " + num1 + " elevado a " + num2 + " = " + soma);
            Console.WriteLine("Deseja fazer outro calculo? s/ para sim. n/ para não.");
            string leitor3 = Console.ReadLine();
            if (leitor3 == "s")
            {
                Console.Clear();
                Inicio();
            }
            else Console.Clear(); Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema");
        }
        // Fim Calculadora
        //Busca Binaria
        public static void NumerosAleatorios(int[] vetor,int quantidadeDeNumeros)
         {
            Random rand = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(quantidadeDeNumeros);
            }
        }
        public static int BuscaBinaria(int[] vetor,int numeroProcurado, int comeco=0,int fim=-3) 
        {
            if (fim == -3) 
            {
                fim = vetor.Length - 1;
            }
            if (comeco <= fim) 
            {
                int meio = (comeco + fim) / 2;
                if (vetor[meio] == numeroProcurado) 
                {
                    return meio;
                }
                if(numeroProcurado < vetor[meio])
                {
                    return BuscaBinaria(vetor, numeroProcurado, comeco, meio - 1);
                }else return BuscaBinaria(vetor, numeroProcurado, meio+1, fim);
            }
            return -1;
        }
        public static void BuscaSequencial(int [] vetor, int numeroProcurado) 
        {
            for (int i = 0; i < vetor.Length; i++) 
            {
                if (vetor[i] == numeroProcurado)
                {
                    Console.WriteLine("Valor encontrado: " + vetor[i] + " || Posição [" + i + "] do indice.");
                }
            }
        }
        // Fim Busca Binária
    }
}
