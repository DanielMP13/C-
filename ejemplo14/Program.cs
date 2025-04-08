namespace ejemplo14;

class Program
{
    static void Main(string[] args)
    {
        SaludarUsuario("Daniel");
    }
    static void SaludarUsuario(string nombre) 
    {
        string saludo = CrearSaludo(nombre);
        Console.WriteLine(saludo);
    }
    static string CrearSaludo(string nombre)
    {
        return $"Hola, {nombre}! Bienvenido!";
    }
}
