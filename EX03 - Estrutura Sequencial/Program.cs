/* 
Fazer um programa para ler quatro valores inteiros A, B, C e D. 
A seguir, calcule e mostre a diferença do produto de A e B pelo 
produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
*/

namespace EX03___Estrutura_Sequencial {
    internal class Program {
        static void Main(string[] args) {

            // Declaração das variáveis
            int A, B, C, D, Diferenca;

            // Leitura dos valores inteiros
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            // Cálculo da diferença do produto de A e B pelo produto de C e D
            Diferenca = A * B - C * D;

            // Exibição do resultado
            Console.WriteLine(Diferenca);

            // Mensagem de espera para que o usuário pressione uma tecla para sair
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
