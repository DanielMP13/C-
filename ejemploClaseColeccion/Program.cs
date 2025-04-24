namespace ejemploClaseColeccion;

class Program
{
    static void Main(string[] args)
    {
       List<Persona> personas = new List<Persona>();
       bool salir = false;

       while(!salir)
       {
        Console.WriteLine("\n--- Menú ---");
        Console.WriteLine("1. Insertar persona");
        Console.WriteLine("2. Borrar persona");
        Console.WriteLine("3. Mostrar lista");
        Console.WriteLine("4. salir");
        Console.Write("Opción: ");
        string? opcion = Console.ReadLine();

        switch(opcion)
        {
            case "1":
            Persona.Insertar(personas);
            break;
            case "2":
            Persona.Borrar(personas);
            break;
            case "3":
            Persona.MostrarLista(personas);
            break;
            case "4":
            salir = true;
            break;
            default:
            Console.WriteLine("❌ Opción no válida.");
            break;
        }
       }
       Console.WriteLine("👋 Fin del programa. ");
    }
}
