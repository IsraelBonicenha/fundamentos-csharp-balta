namespace CalculadoraConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            ConsoleMsg.Blue("---------- CALCULADORA ----------");
            Console.WriteLine();
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            ConsoleMsg.Blue("---------------------------------");
            Console.Write("Digite uma opção: ");

            if (!short.TryParse(Console.ReadLine(), out short opcao))
            {
                Console.Clear();
                ConsoleMsg.Red("Opção inválida");
                Console.ReadKey();
                Menu();
            }

            if (opcao == 5)
                Environment.Exit(0);

            try
            {
                Console.Clear();
                float num1 = LerNumero("Digite o primeiro número: ");
                float num2 = LerNumero("Digite o segundo número : ");
                Console.WriteLine();
                Console.Write($"O resultado é: {RealizarOperacao(opcao, num1, num2)}");
            }
            catch (Exception ex)
            {
                ConsoleMsg.Red("Erro: " + ex.Message);
            }

            Console.ReadKey();
        }

        static float LerNumero(string msg)
        {
            float num;
            Console.Write(msg);
            while (!float.TryParse(Console.ReadLine(), out num))
            {
                Console.Clear();
                ConsoleMsg.Red("Valor inválido!");
                Console.Write("Por favor, tente novamente: ");
            }
            return num;
        }

        static float RealizarOperacao (short opcao, float num1, float num2)
        {
            return opcao switch
            {
                1 => Calculadora.Somar(num1, num2),
                2 => Calculadora.Subtrair(num1, num2),
                3 => Calculadora.Multiplicar(num1, num2),
                4 => Calculadora.Dividir(num1, num2),
                _ => throw new InvalidOperationException("Operação inválida!"),
            };
        }
    }
}
