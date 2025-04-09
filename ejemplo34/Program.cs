namespace ejemplo34;

class Program
{
    static void Main(string[] args)
    {
        List<string> nombres = new List<string>{"Maxi", "Arancha", "Victoria", "Ana"};
        int i = 0;
        do 
        {
            Console.WriteLine($"El nombre es: {nombres[i]}");
            i++;
        }
        while 
        (i<nombres.Count);
    }
}
