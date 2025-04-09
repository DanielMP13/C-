namespace ejemplo40;

class Program
{
    static void Main(string[] args)
    {
        int dia = 3;

        switch(dia)
        {
            case 1:
            Console.WriteLine("Lunes");
            break;
            case 2:
            Console.WriteLine("Martes");
            break;
            case 3:
            Console.WriteLine("Miercoles");
            break;
            case 4:
            Console.WriteLine("Jueves");
            break;
            case 5:
            Console.WriteLine("Viernes");
            break;
            default:
            Console.WriteLine("Día no válido");
            break;
        }
    }
}
