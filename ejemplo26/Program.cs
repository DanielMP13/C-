namespace ejemplo26;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        int resultado1 = a++; // primero se usa(5), luego a = 6
        int resultado2 = b--; // primero se usa(6), luego b = 9

        Console.WriteLine("Resultado 1: " + resultado1); // 5
        Console.WriteLine("Valor actual de a: " + a); // 6
        Console.WriteLine("Resultado 2: " + resultado2); // 10
        Console.WriteLine("Valor actual de b: " + b); //9
    }
}
