/*Escreva um programa que receba uma frase do usuário e converta todas 
as palavras para o formato &quot;Title Case&quot;, ou
seja, todas as primeiras letras das palavras devem ser maiúsculas. */
using System.Globalization;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var textInfo = CultureInfo.CurrentCulture.TextInfo;

            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine(textInfo.ToTitleCase($"{frase}"));


            Console.ReadLine(); 


        }
    }
}