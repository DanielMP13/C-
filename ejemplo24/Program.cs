namespace ejemplo24;

class Program
{
    // Crear Listas a nivel de clase para poder usarlas en distintos métodos
    static List<string> nombres = new List<string>();
    static List<int> numeros = new List<int>();
    static void Main(string[] args)
    {
        // Agregar elementos a la lista nombres
        nombres.Add("Juan");
        nombres.Add("Ana");
        nombres.Add("Luis");
        Mostrar();
        // Añadir en una posición específica: .Insert(index, item)
        nombres.Insert(0, "Arancha");
        Mostrar();
        // Obtener un elemento: .ElementAt(index) o acceso con []
        Console.WriteLine(nombres[1]); // Juan
        // Modificar un elemento: [] o Insert() con eliminación previa
        nombres[2] = "María"; // Reemplaza "Ana" con "María"
        Mostrar();
        // Eliminar un elemento: RemoveAt(index) y Remove(item)
        nombres.RemoveAt(1); // Elimina el segundo elemento (Juan)
        nombres.Remove("Luis"); // Elimina a "Luis" directamente
        Mostrar();
        // Tamaño de la lista: Count()
        Console.WriteLine("Cantidad de elementos: " + nombres.Count());
        // Verificar si contiene un elemento: Contains(item)
        if(nombres.Contains("Arancha")) 
        {
            Console.WriteLine("Arancha está en la lista. ");
        }
        // Vaciar la lista: Clear()
        nombres.Clear();
        Console.WriteLine("Elementos después de limpiar: " + nombres.Count()); // 0
    }
    static void Mostrar() 
    {
        foreach(string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}   
