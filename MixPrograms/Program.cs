using System;
using MixPrograms.Modelos;
using MixPrograms.Modelos.Calculadora;
using MixPrograms.Modelos.Conversor;
using MixPrograms.Modelos.BuscaERecur;
using MixPrograms.Modelos.Filas;

namespace MixPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conversor con = new Conversor();
            con.Inicio();
           Console.ReadLine();
        }
    }
}
