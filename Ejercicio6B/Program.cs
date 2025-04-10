namespace Ejercicio6B;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Introduce una contraseña: ");
        string input = Console.ReadLine();

        // Validar las entradas y mostrar el resultado
        Console.WriteLine($"Entradas Válidas: {ValidateEntries(input)}");
    }
    static bool ValidateEntries(string input)
    {
        // Bucle 'foreach' para recorrer cada entrada en el array
        foreach (char entry in input)
        {
            // Si alguna entrada tiene más de 10 caracteres, devuelve 'false'

            if (input.Length > 10)
            {
                return false;
            }
        }
        // Si ninguna entrada tiene más de 10 caracteres, devuelve 'true'
        return true;
    }
}
