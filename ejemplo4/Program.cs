namespace ejemplo4;

class Program
{
    static void Main(string[] args)
    {
       Utilidad u = new Utilidad();
       u.MonstrarMensaje();
    }
}

public class Utilidad {
        public void MonstrarMensaje() {
            Console.WriteLine("Este es un método NO estático.");
        }
}