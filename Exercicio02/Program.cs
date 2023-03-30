/*2. Dada uma string contendo uma frase, escreva um programa em C# 
que conte o número de palavras na frase e imprima o resultado.*/
using System.Diagnostics;

namespace Exercicio02
{
    class Frase
    {
        public static int[] PalavrasCaracteres(string frase)
        {
            int palavras = 0;
            int caracteresTotal = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ' || frase[i] == '.')
                {
                    palavras++;
                }
            }
            int[] PalavrasCaracteres = new int[2];
            caracteresTotal = frase.Length - palavras;
            PalavrasCaracteres[0] = palavras;
            PalavrasCaracteres[1] = caracteresTotal;
            return PalavrasCaracteres;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();
            int[] resultado = Frase.PalavrasCaracteres(frase);
            Console.WriteLine("A frase tem {0} palavras", resultado[0]);
            Console.WriteLine("A frase tem {0} caracteres", resultado[1]);
            Console.ReadKey();
        }
    }
}