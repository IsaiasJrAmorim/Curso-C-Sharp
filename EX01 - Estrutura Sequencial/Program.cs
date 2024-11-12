namespace EX01___Estrutura_Sequencial__entrada__processamento__saída_ {
    internal class Program {
        static void Main(string[] args) {

            // Leitura dos valores inteiros
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            // Cálculo da soma
            int soma = valor1 + valor2;

            // Exibição do resultado
            Console.WriteLine("SOMA = " + soma);

            // Espera até que uma tecla seja pressionada
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
