namespace ejemplo13;

class Program
{
    static void Main(string[] args)
    {
        MostrarMultiplicacion(4, 5);
    }
    static void MostrarMultiplicacion(int a, int b)
    {
        int resultado = a * b;
        Console.WriteLine($"El resultado de multiplicar {a} y {b} es: {resultado}");
    }
}
