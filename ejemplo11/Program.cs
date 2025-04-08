namespace ejemplo11;

class Program
{
    static void Main(string[] args)
    {
        PresentarPersona("Daniel", 23);
    }
    static void PresentarPersona(string nombre, int edad) 
    {
        Console.WriteLine($"Mi nombre es {nombre} y tengo {edad} años");
    }
}
