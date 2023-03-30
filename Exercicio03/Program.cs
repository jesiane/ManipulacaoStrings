/*Desenvolva uma aplicação troque cada letra de um texto por outra do alfabeto X posições a frente, onde X pode
ser escolhido por você (cifra de César)
a. Exemplo com X=2:
b. “DIEGO” passará a ser “FKGIQ”*/
namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis
            string palavra, encrypt = "";

            //Esta é a perfumaria que eu falei...
            //método write escreve na tela do prompt do usuario
            Console.Write("|---------------------------------|\n");
            Console.Write("|  - Criptografar um mensagem -   |\n");
            Console.Write("|---------------------------------|\n");

            Console.Write("Entre com a mensagem para ser criptografada: ");
            palavra = Console.ReadLine().ToUpper();

            Console.WriteLine("Qual a chave desejada: ");
            int chave = int.Parse(Console.ReadLine());

            //enquanto a palavra for menor que i
            for (int i = 0; i < palavra.Length; i++)

            {
                //Devolve o codigo ASCII da letra
                int ASCII = (int)palavra[i];

                //Coloca a chave fixa adicionando x posições no numero da tabela ASCII
                int ASCIIC = ASCII + chave;

                //Concatena o texto e o coloca na variável
                encrypt += Char.ConvertFromUtf32(ASCIIC);
            }

            //Mostra o resultado final, concatenando a variável em que está o texto cifrado
            Console.Write("Resultado: " + encrypt);

            //Aguarda o usuário pressionar uma tecla para sair
            Console.ReadKey();

        }

    }

}