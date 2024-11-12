/*
 Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B.
 */
using System.Globalization;

namespace EX06___Estrutura_Sequancial {
    internal class Program {
        static void Main(string[] args) {

            double A, B, C, pi = 3.14159, Circulo, Quadrado, Triangulo, Retangulo, Trapezio;

            // Ler o valor
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calcular a área
            Triangulo = (A * C) / 2;
            Circulo = Math.PI * Math.Pow(C, 2);
            Trapezio = ((B + C) * C)/2;
            Quadrado = B * B;
            Retangulo = A * B;

            // Mostrar a área com quatro casas decimais
            Console.WriteLine("Triangulo =" + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo =" + Circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio =" + Trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado =" + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo =" + Retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
