namespace Ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Declarar e inicializar el array con valores y nulls
        string[] nombres = new string[5];

        nombres[0] = "Arancha";
        nombres[1] = null;
        nombres[2] = "Maxi";
        nombres[3] = "Salir";
        nombres[4] = "Pepe";

        // Recorrer el array usando un bucle for
        for (int t = 0; t < nombres.Length; t++)
        {
            // Si el valor es null, continuar con la siguiente iteración
            if (nombres[t] == null)
            {
                continue;
            }
            // Si el valor es "Salir", salir del bucle
            else if (nombres[t] == "Salir")
            {
                break;
            }
            // Imprimir el valor si no es null ni "Salir"
            Console.WriteLine(nombres[t]);
        }
    }
}
