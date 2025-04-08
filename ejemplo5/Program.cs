namespace ejemplo5;

class Program
{
    static void Main(string[] args)
    {
        Calculadora c = new Calculadora();
        int resultado = c.Sumar(4,5);
        Console.WriteLine($"Resultado: {resultado}");
    }
}

public class Calculadora {
    public int Sumar(int a, int b) {
        return a + b;
    }
}