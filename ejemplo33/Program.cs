namespace ejemplo33;

class Program
{
    static void Main(string[] args)
    {
        List<string> nombres= new List<string>{"Maxi", "Arancha", "Victoria", "Ana"};
        int i = 0;
        while (i<nombres.Count)
        {
            Console.WriteLine($"El nombre es: {nombres[i]}");
            i++;
        }
    }
}
