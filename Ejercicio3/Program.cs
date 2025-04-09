namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        // Definir la edad y pasarla a 'ClasificarEdad'
        int edad = 23;

        // Mostrar la clasificación de la edad
        Console.WriteLine($"Clasification: {ClasificarEdad(edad)}");
    }
    static string ClasificarEdad(int edad)
    {
        // Si la edad es mayor o igual 65, devuelve "Senior"
        if(edad >= 65)
        {
            return "Senior";
        }
        // Si la edad es mayor o igual 20, devuelve "Adulto"
        else if(edad >= 20)
        {
            return "Adulto";
        }
        // Si la edad es menor a 20, devuelve "Joven"
        else
        {
            return "Joven";
        }
    }
}
