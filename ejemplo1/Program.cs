namespace ejemplo1;

class Program
{
    static void Main(string[] args)
    {
        Persona p = new Persona();
        p.Nombre = "Daniel";
        p.Edad = 23;
        p.Saludar();
    }
}
public class Persona
{
    public string Nombre;
    public int Edad;

    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}