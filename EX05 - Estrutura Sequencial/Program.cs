/*
 Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
 */

using System.Globalization;

namespace EX05___Estrutura_Sequencial {
    internal class Program {
        static void Main(string[] args) {

            int CodPeca, Unit;
            double Preco, ValorTotal;

            Console.WriteLine("Insira o codigo da peça:");
            CodPeca = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero de unidades:");
            Unit = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o preço por unidade da peça:");
            Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)

            ValorTotal = Preco*Unit;

            Console.WriteLine("O valor a pagar é de: {0}", ValorTotal);

        }
    }
}
