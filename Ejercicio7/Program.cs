namespace Ejercicio7;

class Program
{
    static void Main(string[] args)
    {
        List<string> nombres = new List<string> {"Ana", "Luis", "Carlos"};
        string nombre = "Ana";

    if(nombres.Contains(nombre))
        {
            Console.WriteLine("El nombre ya está en la lista.");
        }
        else 
        {
            nombres.Add(nombre);
            Console.WriteLine("Nombre Agregado.");
        }
    }
}
