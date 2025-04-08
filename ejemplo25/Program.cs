namespace ejemplo25;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        int resultado1 = ++a; // Primero se incrementa a 6, luego se asigna
        int resultado2 = --b; // primero se decrementa a 9, luego se asigna

        Console.WriteLine("Resultado 1: " + resultado1); // 6
        Console.WriteLine("Resultado 2: " + resultado2); // 9
    }
}
