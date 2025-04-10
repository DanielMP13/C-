namespace Ejercicio9B;

class Program
{
    public static List<string> frutas = new List<string>();
    static void Main(string[] args)
    {
        IntroducirFrutasEnLista();
        foreach (string f in frutas)
        {
            Console.WriteLine(f);
        }
    }
    public static void IntroducirFrutasEnLista()
    {
        string seguir = "S";
        while (seguir.ToUpper() == "S")
        {
            Console.Clear();
            Console.WriteLine("Introduce una fruta: ");
            string nuevaFruta = Console.ReadLine();

            // Validación: comprobar si la fruta ya existe en la lista
            if (frutas.Contains(nuevaFruta))
            {
                Console.WriteLine($"La fruta \"{nuevaFruta}\" ya esta añadida a la lista.");
            }
            else
            {
                frutas.Add(nuevaFruta);
                Console.WriteLine($"La fruta  \"{nuevaFruta}\" se ha añadido correctamente.");
            }
            Console.WriteLine("Desea continuar(S/N)");
            seguir = Console.ReadLine();
        }
    }
}
