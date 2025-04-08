namespace ejemplo9;

class Program
{
    static void Main(string[] args)
    {
        string saludo = ObtenerSaludo();
        Console.WriteLine(saludo);
    }
    static string ObtenerSaludo() 
    {
        return "¡Hola desde un método que devuelve un saludo!";
    }
}
