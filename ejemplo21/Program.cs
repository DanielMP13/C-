namespace ejemplo21;

class Program
{
    static void Main(string[] args)
    {
        // Length
        string texto = "Hola mundo";
        Console.WriteLine("Longitud: " +  texto.Length);
        // Substring(int StartIndex) y .Substring(int starIndex, int length)
        string mensaje = "Programación";
        Console.WriteLine(mensaje.Substring(0, 6)); // Progra
        Console.WriteLine(mensaje.Substring(6)); // macion
        //ToUpper() y ToLower()
        Console.WriteLine(texto.ToUpper()); // "HOLA MUNDO"
        Console.WriteLine(texto.ToLower()); // "hola mundo"
        // CharAt -> en C# se usa con índices directamente
        string saludo = "Hola";
        Console.WriteLine(saludo[1]); // 'o'
        // Contains (string value)
        Console.WriteLine(texto.Contains("mundo")); //  True
        // StartsWith() y EndsWith()
        string ruta = "archivo.txt";
        Console.WriteLine(ruta.StartsWith("arch")); // True
        Console.WriteLine(ruta.EndsWith(".txt"));  // True
    }
}
