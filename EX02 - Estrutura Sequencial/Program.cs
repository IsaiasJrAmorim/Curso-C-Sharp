/* 
Faça um programa para ler o valor do raio de um círculo,
e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.

Fórmula da área: area = π * raio^2
Considere o valor de π = 3.14159
*/

using System;
using System.Globalization;

namespace EX2___Estrutura_Sequencial {
    internal class Program {
        static void Main(string[] args) {

            double R, A, pi = 3.14159;

            // Ler o valor do raio
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calcular a área
            A = pi * Math.Pow(R, 2);

            // Mostrar a área com quatro casas decimais
            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
