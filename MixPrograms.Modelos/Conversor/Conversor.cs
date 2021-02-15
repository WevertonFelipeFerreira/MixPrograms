using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MixPrograms.Modelos.Calculadora;

namespace MixPrograms.Modelos.Conversor
{
    public class Conversor
    {

        private double _valor1 { get; set; }
        private double _valor2 { get; set; }
        private int _operador { get; set; }
        private double _resultado { get; set; }
        public void Inicio()
        {
            Console.WriteLine("Conversor de Temperatura");
            Console.WriteLine("(1) Celsius para Fahrenheit");
            Console.WriteLine("(2) Fahrenheit para Celsius");
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
                  Console.Clear(); CelsiusToFahrenheit(); break;
              case 2:
                  Console.Clear(); FahrenheitToCelsius(); break;
            }
        }
        private void GetValorTemperatura()
        {
            Console.WriteLine("Digite a temperatura: ");
            string leitor1 = Console.ReadLine();
            double num1 = Convert.ToDouble(leitor1);
            _valor1 = num1;
        }
        private void CalculoTemperatura(double Valor1)
        {
            switch (_operador) {
             case 1:
              _resultado = (Valor1 * 1.8) + 32;break;
             case 2:
              _resultado = (Valor1 - 32) / 1.8; break;

            }
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
            else if (leitor == "n") { Console.Clear(); Console.WriteLine("Obrigado por utilizar nosso sistema"); }

        }
        private void CelsiusToFahrenheit()
        {
            Console.WriteLine("Celsius para Fahrenheit foi escolhido.");
            GetValorTemperatura();
            CalculoTemperatura(_valor1);
            Console.WriteLine(_valor1+"°C = "+_resultado+"F");
            Continuar();
        }
        private void FahrenheitToCelsius()
        {
            Console.WriteLine("Fahrenheit para Celsius foi escolhido.");
            GetValorTemperatura();
            CalculoTemperatura(_valor1);
            Console.WriteLine(_valor1 + "F = " + _resultado + "°C");
            Continuar();
        }
    }
}
