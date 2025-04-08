namespace ejemplo22;

class Program
{
    static void Main(string[] args)
    {
        // Equals() y comparación con ==
        string a = "Hola";
        string b = "Hola";
        Console.WriteLine(a.Equals(b)); // False
        Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // True

        // Replace(char, char) o Replace(string, string)
        string frase = "banana";
        Console.WriteLine(frase.Replace('a', 'o')); // "bonono"
        Console.WriteLine(frase.Replace("ña", "ña")); // "bañaña"

        // Trim()
        string entrada = "Hola mundo ";
        Console.WriteLine(entrada.Trim()); //"Hola mundo"

        // Split(char[] delimitadores)
        string datos = "Juan, Pablo, Ana";
        string[] nombres = datos.Split(',');

        foreach (string nombre in nombres) 
        {
            Console.WriteLine(nombre);
        }
        // IndexOf() y .LastIndexOf()
        string otraFrase = "programar es programar";
        Console.WriteLine(otraFrase.IndexOf("programar")); // 0
        Console.WriteLine(otraFrase.LastIndexOf("programar")); // 13

        // IsNullOrEmpty() y . IsNullOrWhiteSpace()
        string vacia = "";
        Console.WriteLine(string.IsNullOrEmpty(vacia)); // True
        Console.WriteLine(string.IsNullOrWhiteSpace(" ")); // True
    }
}
