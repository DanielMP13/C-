namespace ejemplo30;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        int i = 0;
        do
        {
            Console.WriteLine($"Número: {numeros[i]}");
            i++;
        }
        while
        (i < numeros.Length);
    }
}
