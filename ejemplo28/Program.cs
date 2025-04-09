namespace ejemplo28;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = {1, 2, 3, 4, 5};
        foreach (int n in numeros)
        {
            Console.WriteLine($"Número: {n}");
        }
    }
}
