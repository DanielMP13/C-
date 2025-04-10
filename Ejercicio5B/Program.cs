namespace Ejercicio5B;

class Program
{
    static void Main(string[] args)
    {
       Console.Clear();
       Console.WriteLine("Introduzca una nota: ");
       string input = Console.ReadLine();

       if(int.TryParse(input, out int nota)) 
       {
        Console.WriteLine($"Eres: {ClasificarNota(nota)}");
       }
       else 
       {
        Console.WriteLine("Por favor, introduce una nota.");
       }
    }
    public static string ClasificarNota(int nota) 
    {
        if (nota == 10 || nota == 9) 
        {
            return "Excelente";
        }
        else if (nota == 8 || nota == 7)
        {
            return "Bueno";
        }
        else
        {
            return "Ceporro";
        }
    }
}
