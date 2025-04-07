namespace ejemplo2;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine("Argumentos recibidos: ");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        else
        {
            Console.WriteLine("No se recibieron argumentos. ");
        }
    }
}
