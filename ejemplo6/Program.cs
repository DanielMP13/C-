namespace ejemplo6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola, Dani!");
        string nombre = "Dani";
        Console.WriteLine($"Hola, {nombre}!");
        Saludar();
    }
    static void Saludar() 
    {
        Console.WriteLine("Bienvenidos al curso de C# en Inadeco");
    }
}