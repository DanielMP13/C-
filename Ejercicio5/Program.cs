namespace Ejercicio5;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int grado = 8;

        switch(grado)
        {
            case 10:
            case 9:
            Console.WriteLine("Excelente");
            break;

            case 8:
            case 7:
            Console.WriteLine("Bueno");
            break;

            default:
            Console.WriteLine("Ceporro");
            break;
        }
    }
}
