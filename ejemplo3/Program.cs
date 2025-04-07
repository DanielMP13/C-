namespace ejemplo3;

class Program
{
    static void Main(string[] args)
    {
        Utilidad.MostrarMensaje();
    }
}

public class Utilidad {
    public static void MostrarMensaje() {
        Console.WriteLine("Este es un método estático.");
    }
}