namespace ejemplo39;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo con if-else tradicional
        int edad = 20;
        string mensaje;

        if(edad >= 18)
        {
            mensaje = "Es mayor de edad";
        }
        else 
        {
            mensaje = "Es menor de edad";
        }
        Console.WriteLine(mensaje);

        // Equivalente usando un operador ternario
        mensaje = (edad >= 18) ? "Es mayor de edad" : "Es menor de edad";
        Console.WriteLine(mensaje); 
    }
}
