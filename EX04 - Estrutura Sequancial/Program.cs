/*
 Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
decimais.
 */

using System;
using System.Globalization;

namespace EX04___Estrutura_Sequancial {
    internal class Program {
        static void Main(string[] args) {

            int NumFuncionario, HorasTrabalhadas;
            double ValorHora, Salario;

            Console.WriteLine("Informa o numero do funcionario: ");
            NumFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Informa a quantidade de horas trabalhadas do funcionario: ");
            HorasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informa o valor que o funcionario recebe por hora de trabalho: ");
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = HorasTrabalhadas * ValorHora;

            Console.Clear();

            Console.WriteLine("O funcionario: {0}", NumFuncionario);
            Console.WriteLine("Recebe o salario de: R${0}", Salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
