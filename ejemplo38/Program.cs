namespace ejemplo38;

class Program
{
    static void Main(string[] args)
    {
        int edad = 20;
        bool tieneLicencia = true;

        if(edad >= 18)
        {
            if(tieneLicencia)
            {
                Console.WriteLine("Puedes conducir.");
            }
            else 
            {
                Console.WriteLine("No tienes licencia, no puedes conducir.");
            }
        } 
        else 
        {
            Console.WriteLine("Eres menor de edad, no puedes conducir");
        }
    }
}
