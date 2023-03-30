/*5. Crie um programa em C# que solicite ao usuário que digite uma frase. Em seguida, o programa deve utilizar
métodos da classe string para realizar as seguintes operações:
 Imprimir a frase em letras maiúsculas;
 Imprimir a frase em letras minúsculas;
 Imprimir a quantidade de caracteres da frase;
 Imprimir a primeira palavra da frase;
 Imprimir a última palavra da frase.*/
using System.Globalization;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();

            Console.ReadLine();

            //Imprimir a frase em letras maiúsculas;

            Console.WriteLine("- Imprime a frase em letras maiúsculas -");
            Console.WriteLine(frase.ToUpper());

            Console.ReadLine();

            //Imprimir a frase em letras minúsculas;

            Console.WriteLine("- Imprime a frase em letras minisculas -");
            Console.WriteLine(frase.ToLower());

            Console.ReadLine();

            //Imprimir a quantidade de caracteres da frase;

            int palavras = 1;
            int caracteresTotal = 1;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ' || frase[i] == '.')
                {
                    palavras++;
                }
            }
            int[] PalavrasCaracteres = new int[2];
            caracteresTotal = frase.Length - palavras;
            PalavrasCaracteres[1] = caracteresTotal;

            Console.WriteLine("- quantidade de caracteres da frase -");
            Console.WriteLine(caracteresTotal);

            Console.ReadLine();
            //Imprimir a primeira palavra da frase;

            Console.WriteLine("- Imprime apenas a primeira palavra da frase -");
            Console.Write(frase.Remove(frase.IndexOf(" ")));

            Console.ReadLine();
            //Imprimir a última palavra da frase

            Console.WriteLine("- Imprime apenas a ultima palavra da frase -");
            Console.Write(frase.Remove(frase.LastIndexOf(" ")));

            Console.ReadLine();
        }
    }
}