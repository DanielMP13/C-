namespace ejemplo18;

class Program
{
    static void Main(string[] args)
    {
        double numeroGrande = 12345.6789;
        int numeroEntero = (int)numeroGrande;

        Console.WriteLine("Número original: " + numeroGrande); // 12345.6789
        Console.WriteLine("Número convertido a int: " + numeroEntero); // 12345
    }
}
