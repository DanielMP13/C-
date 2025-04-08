namespace ejemplo10;

class Program
{
    static void Main(string[] args)
    {
       int resultado = Sumar(10, 5);
       Console.WriteLine($"El resultado de la suma es: {resultado}");
    }
    static int Sumar(int a , int b) 
    {
        return a + b;
    }
}
