namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        // Declarar tres variables enteras
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;
         
         // Crear el array 'numeros' e inicializarlo con num1, num2 y num3
         int [] numeros = {1, 2, 3};

        // Usar un bucle 'foreach' para imprimir los valores del array
         foreach(int num in numeros) 
         {
            Console.WriteLine(num);
         }
    }
}
