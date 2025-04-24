namespace ejemploClaseColeccion;

public class Persona
{
    public Persona(string nombre, string poblacion, int edad)
    {
        Nombre = nombre;
        Poblacion = poblacion;
        Edad = edad;
    }

    public Persona() { }

    public string Nombre { get; set; }
    public string Poblacion { get; set; }
    public int Edad { get; set; }

    public static string ValidarTexto(string mensaje)
    {
        string? entrada;
        do
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(entrada));
        return entrada;
    }

    public static int ValidarEntero(string mensaje)
    {
        int valor;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("❌ Valor no válido. " + mensaje);
        }
        return valor;
    }

    public static bool Existe(List<Persona> personas, string nombre)
    {
        foreach (var p in personas)
        {
            if (p.Nombre.ToLower() == nombre.ToLower())
            {
                return true;
            }
        }
        return false;
    }

    public static void Insertar(List<Persona> personas)
    {
        string nombre = ValidarTexto("Nombre: ");
        if (Existe(personas, nombre))
        {
            Console.WriteLine("⚠️ Ya existe una persona con ese nombre.");
            return;
        }

        string poblacion = ValidarTexto("Población: ");
        int edad = ValidarEntero("Edad: ");

        personas.Add(new Persona(nombre, poblacion, edad));
        Console.WriteLine("✅ Persona insertada correctamente. ");
    }

    public static void Borrar(List<Persona> personas)
    {
        string nombre = ValidarTexto("Nombre de la persona a borrar: ");
        bool encontrada = false;

        for (int i = 0; i < personas.Count; i++)
        {
            if (personas[i].Nombre.ToLower() == nombre.ToLower())
            {
                personas.RemoveAt(i);
                Console.WriteLine("🗑️ Persona eliminada correctamente. ");
                encontrada = true;
                break;
            }
        }
        if (!encontrada)
        {
            Console.WriteLine("❌ Esa persona no existe y no se puede eliminar. ");
        }
    }

    public static void MostrarLista(List<Persona> personas)
    {
        if (personas.Count == 0)
        {
            Console.WriteLine("📫 La lista está vacía. ");
            return;
        }
        foreach (var p in personas)
        {
            Console.WriteLine($"🧍 {p.Nombre} - {p.Poblacion} - {p.Edad} años");
        }
    }
}