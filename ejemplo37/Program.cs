namespace ejemplo37;

class Program
{
    static void Main(string[] args)
    {
        int numero = 10;

        if(numero > 5 && numero < 15)
        {
            Console.WriteLine("El número está entre 5 y 15.");
        }
        if(numero == 10 || numero == 20) 
        {
            Console.WriteLine("El número es 10 o 20.");
        }
        if(numero != 5) 
        {
            Console.WriteLine("El número no es 5");
        }
    }
}
