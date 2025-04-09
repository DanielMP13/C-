namespace Ejercicio2B;

class Program
{
    public static List <int> numeros = new List<int>();
    static void Main(string[] args)
    {
       IntroducirEnLista();

        foreach(int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
    public static void IntroducirEnLista() 
    {
        string seguir="S";
        while(seguir.ToUpper()=="S")
        {
            Console.Clear();
            Console.WriteLine("Introduzca un número");
            numeros.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Desea continuar(S/N)");
            seguir=Console.ReadLine();
        }
        
        
    }
}
