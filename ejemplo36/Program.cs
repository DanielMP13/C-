namespace ejemplo36;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca edad: ");
        int edad = int.Parse(Console.ReadLine());
        
        if(edad < 18)
        {
            Console.WriteLine("Es menor de 18");
        }
        else if (edad == 18)
        {
            Console.WriteLine("Tiene 18");
        }
        else
        {
            Console.WriteLine("Es mayor de 18");
        }
    }
}
