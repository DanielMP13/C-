namespace Ejercicio6;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Array de entradas de ejemplo
        string[] entries = {"ValidEntry", "TooLongEntryName123"};

        // Validar las entradas y mostrar el resultado
        Console.WriteLine($"Entradas Válidas: {ValidateEntries(entries)}");
    }
    static bool ValidateEntries(string [] entries) 
    {
        // Bucle 'foreach' para recorrer cada entrada en el array
        foreach (string entry in entries)
        {
            // Si alguna entrada tiene más de 10 caracteres, devuelve 'false'
            
            if(entry.Length > 10)
            {
                return false;
            }
        }
        // Si ninguna entrada tiene más de 10 caracteres, devuelve 'true'
        return true;
    }
}
