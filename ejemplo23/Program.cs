namespace ejemplo23;

class Program
{
    static void Main(string[] args)
    {
        // Declarar y crear un array 
        string[] frutas = new string[3]; // Array con 3 elementos
        frutas[0] = "Manzana";
        frutas[1] = "Banana";
        frutas[2] = "Cereza";

        // Directamente con valores
        int[] numeros = {20, 10, 30};

        // Acceder y modificar elementos
        Console.WriteLine(frutas[1]); // Banana
        frutas[2] = "Naranaja"; // Cambia "Cereza" por "Naranja"
        Console.WriteLine(frutas[2]); // Naranja

        // Recorrer un array
        foreach(string fruta in frutas) 
        {
            Console.WriteLine(fruta);
        }

        // Obtener la longitud del array
        Console.WriteLine("Cantidad de frutas: " + frutas.Length); // 3
        
        // Array Multidimensional
        int[,] matriz = {
            {1, 2},
            {3, 4}
        };
        Console.WriteLine(matriz [0, 0]); // 1
        Console.WriteLine(matriz [1, 1]); // 4

        // Ordenar e invertir un array
        Array.Sort(numeros); // Ordenar el array
        Array.Reverse(numeros); // Invierte el array

        foreach(int n in numeros) 
        {
            Console.WriteLine(n);
        }
    }
}
