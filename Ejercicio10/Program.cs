namespace Ejercicio10;

class Program
{
    static int mayusculas;
    static int minusculas;
    static int digitos;
    static int especiales;
    static List<string> ListaPasswords = new List<string>();
    static void Main(string[] args)
    {
        // Lista de contraseñas a validar
        string[] passwords =
        {
            "Welcome@123",
            "weakpass",
            "Strong#Pass1",
            "Repeat@This",
            "Welcome@123", // Repetida
            "NoSpecialsAA",
            "NoDigits@@AA",
            "TTaa1234#"
   };
   Existe(passwords, ListaPasswords);
    }
    static void Existe(string[] passwords, List<string> ListaPasswords)
    {
        foreach (string password in passwords)
        {
            if (ListaPasswords.Contains(password))
            {
                Console.WriteLine("Invalid password (duplicada): " + password);
                continue;
            }
            ListaPasswords.Add(password);
            Contar(password);
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
                Console.WriteLine("Contraseña Válida: " +  password);
            }
            else 
            {
                Console.WriteLine("Contraseña No Válida:  " + password);
            }
    }
}
