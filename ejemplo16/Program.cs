namespace ejemplo16;

class Program
{
    static void Main(string[] args)
    {
    //Leer una cadena
    Console.Write("Introduzca tu nombre: ");
    string nombre = Console.ReadLine();
    Console.WriteLine($"Hola, {nombre}!");
    //Leer un número entero
    Console.Write("Introduce tu edad: ");
    int edad = int.Parse(Console.ReadLine());
    Console.WriteLine($"Tienes {edad} años");
    //Leer un número decimal
    Console.Write("Introduce tu altura: ");
    double altura = double.Parse(Console.ReadLine());
    Console.WriteLine($"Tu altura es {altura} metros.");
    //Leer un valor booleano
    Console.Write("¿Te gusta programar? (true/false): ");
    bool respuesta = bool.Parse(Console.ReadLine());
    Console.WriteLine($"Respuesta: {respuesta}");
    //Validar con un try parse 
    Console.Write("Introduce un número: ");
    if(int.TryParse(Console.ReadLine(), out int numero))
    {
        Console.WriteLine($"Número válido: {numero}");
    }
    else 
    {
        Console.WriteLine("Entrada inválida. ");
    }
    //Leer múltiples valores
    Console.Write("Introduce tu nombre y edad separados por espacio: ");
    string[] datos = Console.ReadLine().Split(' ');
    string otroNombre = datos[0];
    int otraEdad = int.Parse(datos[1]);
    Console.WriteLine($"Hola, {nombre}. Tienes {edad} años.");
    }
}
