using System.Text;

namespace ManipulacaoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                string linha = "";
                string[] linhaseparada = null;
                StreamReader reader = new StreamReader(@"C:\Users\jesi1\OneDrive\Documentos\Projetos\AcademiaProgramador\Cidades.csv", Encoding.UTF8, true);
                while (true)
                {
                    linha = reader.ReadLine();
                    if (linha == null) break;
                    linhaseparada = linha.Split(';');
                    string resultado = string.Format(
                    @"Linha - 
                    Campo 1: {0}
                    Campo 2: {1}
                    Campo 3: {2}
                    Campo 4: {3}
                    Campo 5: {4}", linhaseparada[0], linhaseparada[1], linhaseparada[2], linhaseparada[3], linhaseparada[4]);
                    Console.WriteLine(resultado);
                }
                Console.ReadKey();
            }
        }
    }