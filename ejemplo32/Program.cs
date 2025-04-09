namespace ejemplo32;

class Program
{
    static void Main(string[] args)
    {
        List<string> nombres= new List<string>{"Maxi", "Arancha", "Victoria", "Ana"};
        for(int i=0; i<nombres.Count; i++)
        {
            Console.WriteLine($"El nombre es: {nombres[i]}");
        }
    }
}
