namespace Ejercicio1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el número del cual quieres que comience a contar desde atrás: ");
            string input = Console.ReadLine();

            // Intentamos convertir el input a un número entero
            if (int.TryParse(input, out int numero))
            {
                CountDown(numero);
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }

        public static void CountDown(int numero)
        {
            for (int i = numero; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
