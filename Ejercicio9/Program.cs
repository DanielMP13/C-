namespace Ejercicio9;

class Program
{
    static void Main(string[] args)
    {
        string[] items = {"Manzana", "Pera", "Uva"};
        List<string> fruits = new List<string>();

        AddItemsToList(items, fruits);

        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
    public static void AddItemsToList(string[] array, List<string>list)
    {
        foreach(string item in array)
        {
            list.Add(item);
        }
    }
}
