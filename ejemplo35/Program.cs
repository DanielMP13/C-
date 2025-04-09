namespace ejemplo35;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce una palabra: ");
        string palabra = Console.ReadLine();
        string palabraAlReves = "";

        for (int i = palabra.Length - 1; i>=0; i--)
        {
            palabraAlReves += palabra[i];
        }
        Console.WriteLine("La palabra al revés es: " + palabraAlReves);
    }
}
