namespace ejemplo15;

class Program
{
    static void Main(string[] args)
    {
       //Ejemplo 1
       Console.WriteLine("Hola Daniel");
       //Ejemplo 2
       Console.Write("Hola ");
       Console.WriteLine("Daniel");
       //Ejemplo 3
       string nombre = "Daniel";
       Console.WriteLine("Hola, " + nombre + "!");
       //Ejemplo 4
       string otroNombre = "Daniel";
       int edad = 23;
       Console.WriteLine($"Mi nombre es {otroNombre} y tengo {edad} años.");
       //Ejemplo 5
       Console.WriteLine("Primera línea \nSegunda línea");
       //Ejemplo 6
       double precio = 1234.56789;
       Console.WriteLine($"El precio es: {precio:F2}");
    }
}
