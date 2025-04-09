namespace ejemplo29;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = {1, 2, 3, 4, 5};
        int i = 0;
        while (i<numeros.Length)
        {
            Console.WriteLine($"Numero: {numeros[i]}");
            i++;
        }
    }
}
