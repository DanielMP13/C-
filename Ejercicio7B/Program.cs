namespace Ejercicio7B;

class Program
{
    public static List<string> nombres = new List<string>();

    static void Main(string[] args)
    {
        IntroducirEnLista();
        foreach (string n in nombres)
        {
            Console.WriteLine(n);
        }
    }
 public static void IntroducirEnLista()
    {
        string seguir = "S";
        while (seguir.ToUpper() == "S")
        {
            Console.Clear();
            Console.WriteLine("Introduzca un nombre: ");
            string nuevoNombre = Console.ReadLine();

            // Validación: comprobar si el nombre ya existe en la lista
            if (nombres.Contains(nuevoNombre))
            {
                Console.WriteLine($"El nombre \"{nuevoNombre}\" ya está en la lista. Introduzca otro nombre.");
            }
            else
            {
                nombres.Add(nuevoNombre);
                Console.WriteLine($"Nombre \"{nuevoNombre}\" añadido a la lista.");
            }

            Console.WriteLine("Desea continuar(S/N)");
            seguir = Console.ReadLine();
        }
    }

}