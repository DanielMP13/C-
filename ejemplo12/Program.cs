namespace ejemplo12;

class Program
{
    static void Main(string[] args)
    {
        double promedio = CalcularPromedio(80, 97, 100);
        Console.WriteLine($"El promedio es: {promedio}");
    }
    static double CalcularPromedio(int nota1, int nota2, int nota3)
    {
        return(nota1 + nota2 + nota3) /3.0;
    }
}
