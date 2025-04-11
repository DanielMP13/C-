namespace Ejercicio10B;

class Program
{
    static int mayusculas;
    static int minusculas;
    static int digitos;
    static int especiales;
    static List<string> ListaPasswords = new List<string>();
    static void Main(string[] args)
    {
        Console.Write("Introduzca contraseña: ");
        string passwords = Console.ReadLine();

        Existe(passwords, ListaPasswords);
    }
    static void Existe(string passwords, List<string> ListaPasswords)
    {
        if (ListaPasswords.Contains(passwords))
        {
            Console.WriteLine("Invalid password (duplicada): " + passwords);
        }
        else
        {
            ListaPasswords.Add(passwords);
            Contar(passwords);
        }
    }
    static void Contar(string password)
    {
        mayusculas = 0;
        minusculas = 0;
        digitos = 0;
        especiales = 0;

        foreach (char c in password)
        {
            if (char.IsUpper(c)) mayusculas++;
            else if (char.IsLower(c)) minusculas++;
            else if (char.IsDigit(c)) digitos++;
            else if (!char.IsLetterOrDigit(c)) especiales++;
        }
        Mostrar(password);
    }
    static void Mostrar(string password)
    {
        if (password.Length >= 8 &&
            mayusculas >= 2 &&
            minusculas >= 2 &&
            especiales >= 1 &&
            digitos >= 1)
        {
            Console.WriteLine("Contraseña Válida: " + password);
        }
        else
        {
            Console.WriteLine("Contraseña No Válida:  " + password);
        }
    }
}

