using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixPrograms.Modelos.Filas
{
   public class Fila
    {
        private int _filaTamanho { get; set; }
        private int _fim { get; set; }
        private int[] fila;
        public Fila(int tamanho) 
        {
            _filaTamanho = tamanho;
            fila = new int[_filaTamanho];
        }
        private bool EhVazia() 
        {
            return _fim == 0;
        }
        public int Primeiro() 
        {
            if (EhVazia() == true) 
            {
                throw new Exception("A lista está vazia");
            }
            return fila[0];
        }
        private int Fim()
        {
            return _fim;
        }
        public void Enfileirar(int numero) 
        {
            if (_fim++ > _filaTamanho) 
            {
                throw new IndexOutOfRangeException("A fila esta com capacidade maxima!");
            }
            fila[_fim-1] = numero;
        }
        public void imprimeFila() 
        {
            for (int i = 0; i < _filaTamanho; i++) 
            {
                Console.WriteLine(fila[i]+"- Na posição - "+i);
            }
        }
    }
}
