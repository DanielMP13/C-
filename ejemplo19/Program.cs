namespace ejemplo19;

class Program
{
    static void Main(string[] args)
    {
       // Crear y mostrar string
       string saludo = "Hola, mundo!";
       Console.WriteLine(saludo);
       // Concatenar cadenas con +
       string nombre = "Juan";
       string mensaje = "Hola, " + nombre + "!";
       Console.WriteLine(mensaje);
       // Interpolación de cadenas $"" (moderno y recomendado)
       string otroNombre = "Daniel";
       int edad = 23;
       Console.WriteLine($"Mi nombre es {otroNombre} y tengo {edad} años");
       // Comparar cadenas
       string palabra1 = "Hola";
       string palabra2 = "Hola";
       Console.WriteLine(palabra1 == palabra2); // False
       Console.WriteLine(palabra1.Equals(palabra2)); //False
       Console.WriteLine(palabra1.Equals(palabra2, StringComparison.OrdinalIgnoreCase)); // True
       // Longitud de cadena
       string palabra = "CSharp";
       Console.WriteLine("Longitud: " + palabra.Length); // 6
       // Formato de cadenas con string.Format()
       string otroNombreMas = "Maxi";
       int otraEdad = 40;
       string otroMensaje = string.Format("Mi nombre es {0} y tengo {1} años.", otroNombreMas, otraEdad);
       Console.WriteLine(otroMensaje);
    }
}
