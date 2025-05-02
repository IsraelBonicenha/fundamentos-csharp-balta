namespace CalculadoraConsole
{
    class Calculadora
    {
        public static float Somar(float num1, float num2) => num1 + num2;
        public static float Subtrair(float num1, float num2) => num1 - num2;
        public static float Multiplicar(float num1, float num2) => num1 * num2;
        public static float Dividir(float num1, float num2)
        {
            if (num2 == 0)
            {
                ConsoleMsg.Red("Não é possível dividir por zero.");
                return 0;
            }
            return num1 / num2;
        }
        public static float Exponenciar(float num1, float num2) => (float)Math.Pow(num1, num2);
    }
}
