using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPrograms.Modelos.Calculadora
{
    /// <summary>
    /// Usado para criar uma calculadora.
    /// </summary>
    public class Calculadora
    {

        private int _valor1 { get; set; }
        private int _valor2 { get; set; }
        private int _operador { get; set; }
        private int _resultado { get; set; }
        /// <summary>
        /// Método Essencial para execução da calculadora.
        /// </summary>
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
                Console.Clear();
                Inicio();
            }
            switch (_operador) 
            {
                case 1:
                    Console.Clear(); Soma();break;
                case 2:
                    Console.Clear(); Subtracao(); break;
                case 3:
                    Console.Clear(); Multiplicacao(); break;
                case 4:
                    Console.Clear(); Divisao(); break;
                case 5:
                    Console.Clear(); Potencia(); break;
                case 6:
                    Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema"); Console.ReadLine();break;
            }
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
        /// <summary>
        /// Utilizado para realizar o caluclo.
        /// </summary>
        /// <param name="Valor1">Recebe o primeiro valor de <see cref="_valor1"/></param>
        /// <param name="Valor2">Recebe o segundo valor de <see cref="_valor2"/></param>
        private void Calculo(int Valor1,int Valor2) 
        {
            switch (_operador) 
            {
                case 1:
                    _resultado = Valor1 + Valor2;break;
                case 2:
                    _resultado = Valor1 - Valor2;break;
                case 3:
                    _resultado = Valor1 * Valor2; break;
                case 4:
                    _resultado = Valor1 / Valor2;break;
                case 5:
                    _resultado = (int)Math.Pow(Valor2, Valor2); break;
            }
         }
        private void Soma()
        {
            Console.WriteLine("A Soma foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " + " + _valor2 + " = " + _resultado);
            Continuar();
        }
        private void Subtracao()
        {
            Console.WriteLine("A Subtração foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " - " + _valor2 + " = " + _resultado);
            Continuar();
        }
        private void Multiplicacao()
        {
            Console.WriteLine("A Multiplicãção foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " * " + _valor2 + " = " + _resultado);
            Continuar();
        }
        private void Divisao()
        {
            Console.WriteLine("A Divisão foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " / " + _valor2 + " = " + _resultado);
            Continuar();
        }
        private void Potencia()
        {
            Console.WriteLine("A Divisão foi escolhida");
            GetValores();
            Calculo(_valor1, _valor2);
            Console.WriteLine(_valor1 + " Elevado a " + _valor2 + " = " + _resultado);
            Continuar();
        }

    }
}
