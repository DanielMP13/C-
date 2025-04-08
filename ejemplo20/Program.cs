namespace ejemplo20;

class Program
{
    static void Main(string[] args)
    {
        // Casting entre primitivos 
        int numero = 10;
        double numeroDecimal = numero; // Implícito (ampliación)
        
        double doble = 9.99;
        int entero = (int)doble; // Explícito (reducción)

        Console.WriteLine("Entero a double: " + numeroDecimal); // 10.0
        Console.WriteLine("Double a entero: " + entero); // 9

        // Parsear cadenas a números
        string numeroEnTexto = "123";
        int otroNumero = int.Parse(numeroEnTexto);
        Console.WriteLine("Número: " + otroNumero);

        // Alternativa segura
        if (int.TryParse("456", out int n)) 
        {
            Console.WriteLine("Número válido: " + n);
        }
        else 
        {
            Console.WriteLine("Entrada inválida");
        }
    }
}
