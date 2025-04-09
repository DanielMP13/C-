namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        CountDown(5);
    }
    public static void CountDown(int start)
    {
        for(int i = start; i>=0; i--)
        {
            Console.WriteLine($"El número es el: {i}");
        }
    }
}
