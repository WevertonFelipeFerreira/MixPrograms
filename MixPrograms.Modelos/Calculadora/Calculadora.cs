using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPrograms.Modelos.Calculadora
{
    public class Calculadora
    {
        private int _valor1 { get; set; }
        private int _valor2 { get; set; }
        private int _operador { get; set; }
        private int _resultadoSoma { get; set; }
        private int _resultadoSub { get; set; }
        private int _resultadoMult { get; set; }
        private int _resultadoDiv { get; set; }
        private int _resultadoPot { get; set; }
        public void Inicio()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("(1) Soma");
            Console.WriteLine("(2) Subtração");
            Console.WriteLine("(3) Multiplicação");
            Console.WriteLine("(4) Divisão");
            Console.WriteLine("(5) Potência");
            Console.WriteLine("(6) Sair");
            string leitor = Console.ReadLine();
            _operador = Convert.ToInt32(leitor);
            if (_operador > 6 || _operador < 1)
            {
                Console.WriteLine("O valor digitado esta incorreto!");
                Console.Clear();
                Inicio();
            }

            if (_operador == 1)
          { Console.Clear(); Soma(); }
             else if (_operador == 2)
             { Console.Clear(); Subtracao(); }
             else if (_operador == 3)
             { Console.Clear(); Multiplicacao(); }
             else if (_operador == 4)
             { Console.Clear(); Divisao(); }
             else if (_operador == 5)
             { Console.Clear(); Potencia(); }
             else if (_operador == 6)
             { Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema"); Console.ReadLine(); }
        }
        private void GetValores() 
        {
            Console.WriteLine("Digite o primeiro valor: ");
            string leitor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            string leitor2 = Console.ReadLine();
            int num1 = Convert.ToInt32(leitor1);
            int num2 = Convert.ToInt32(leitor2);
            _valor1 = num1;
            _valor2 = num2;
        }
        private void Continuar() 
        {
            Console.WriteLine("Deseja fazer outro calculo? s/ para sim. n/ para não.");
            string leitor = Console.ReadLine();
            if (leitor == "s")
            {
                Console.Clear();
                Inicio();
            }
            else if (leitor == "n") { Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema");}

        }
        private void Calculo(int Valor1,int Valor2) 
        {
            if (_operador == 1)
            {
                _resultadoSoma = Valor1 + Valor2;
            }
            else if (_operador == 2)
            {
                _resultadoSub = Valor1 - Valor2;
            }
            else if (_operador == 3)
            {
                _resultadoMult = Valor1 * Valor2;
            }
            else if (_operador == 4)
            {
                _resultadoDiv = Valor1 / Valor2;
            }
            else if (_operador == 5)
            {
                _resultadoPot = (int)Math.Pow(Valor2,Valor2);
            }

        }
        private void Soma()
        {
            Console.WriteLine("A Soma foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " + " + _valor2 + " = " + _resultadoSoma);
            Continuar();
        }
        private void Subtracao()
        {
            Console.WriteLine("A Subtração foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " - " + _valor2 + " = " + _resultadoSub);
            Continuar();
        }
        private void Multiplicacao()
        {
            Console.WriteLine("A Multiplicãção foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " * " + _valor2 + " = " + _resultadoMult);
            Continuar();
        }
        private void Divisao()
        {
            Console.WriteLine("A Divisão foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " / " + _valor2 + " = " + _resultadoDiv);
            Continuar();
        }
        private void Potencia()
        {
            Console.WriteLine("A Divisão foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " Elevado a " + _valor2 + " = " + _resultadoPot);
            Continuar();
        }

    }
}
