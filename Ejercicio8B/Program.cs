namespace Ejercicio8B;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduzca contraseña: ");
        string password = Console.ReadLine();

        int upper = 0, lower = 0, digits = 0, specials = 0;

        foreach (char c in password) 
        {
            if (char.IsUpper(c)) upper++;
            else if (char.IsLower(c)) lower++;
            else if (char.IsDigit(c)) digits++;
            else specials++;
        }
        Console.WriteLine("Mayúsculas: " + upper);
        Console.WriteLine("Minúsculas: " + lower);
        Console.WriteLine("Dígitos: " + digits);
        Console.WriteLine("Especiales: " + specials);
    }
}
