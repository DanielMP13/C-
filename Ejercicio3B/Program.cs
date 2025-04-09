namespace Ejercicio3B;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Introduzca una edad: ");
        string input = Console.ReadLine();

        // Intentamos convertir el input a un número entero
        if (int.TryParse(input, out int edad))
        {
            Console.WriteLine($"Clasification: {ClasificarEdad(edad)}");
        }
        else
        {
            Console.WriteLine("Por favor, introduce una edad.");
        }
    }
    static string ClasificarEdad(int edad)
    {
        // Si la edad es mayor o igual 65, devuelve "Senior"
        if (edad >= 65)
        {
            return "Senior";
        }
        // Si la edad es mayor o igual 20, devuelve "Adulto"
        else if (edad >= 20)
        {
            return "Adulto";
        }
        // Si la edad es menor a 20, devuelve "Joven"
        else
        {
            return "Joven";
        }
    }
}