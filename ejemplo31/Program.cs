namespace ejemplo31;

class Program
{
    static void Main(string[] args)
    {
        List<string> nombres= new List<string>{"Maxi", "Arancha", "Victoria", "Ana"};
        foreach(string nombre in nombres)
        {
            Console.WriteLine($"El nombre es: {nombre}");
        }
    }
}
