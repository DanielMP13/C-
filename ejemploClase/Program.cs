namespace ejemploClase;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        /* Persona p = new Persona();
         p.fijarNombre("Dani");
         Console.WriteLine(p.obtenerNombre());
         p.Poblacion = "Avilés";
         Console.WriteLine(p.Poblacion);
         p.Edad = 22;
         Console.WriteLine(p.Edad);

         Persona p1 = new Persona("Arancha");
         p1.Poblacion = "Gijón";
         p1.Edad = 40;

         Console.WriteLine($"Se llama {p1.obtenerNombre()} que vive en {p1.Poblacion} y tiene {p1.Edad} años");
         Console.WriteLine(p1.Saludar());
         Console.WriteLine(p1.Saludar("Dani"));*/

        /*Alumno a = new Alumno();
        a.fijarNombre("Dani");
        a.Poblacion = "Avilés";
        a.Edad = 22;
        Console.WriteLine(a.Saludar());

        Empleado e = new Empleado();
        e.fijarNombre("Victoria");
        e.Poblacion = "Gijón";
        e.Puesto = "Profesora";
        e.Edad = 34;
        e.Sueldo = 3000;
        Console.WriteLine(e.Saludar());
        Console.WriteLine(e.Salario());*/
        //Coleccion();
        Lista();
        Persona p = new Persona();
        p.fijarNombre("Pepe");
        Persona x = p;
        x.fijarNombre("Arancha");
        Console.WriteLine(x.obtenerNombre());
        Console.WriteLine(p.obtenerNombre());
    }
    static void Coleccion()
    {
        Persona[] personas = new Persona[3];
        for (int x = 0; x < 3; x++)
        {
            personas[x] = new Persona();
            Console.Write("Nombre: ");
            personas[x].fijarNombre(Console.ReadLine());
            Console.Write("Población: ");
            personas[x].Poblacion = Console.ReadLine();
            Console.Write("Edad: ");
            personas[x].Edad = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Pulse una tecla para continuar......");
        Console.ReadKey();

        foreach (Persona p in personas)
        {
            Console.WriteLine(p.Saludar());
        }
    }
    static void Lista()
    {
        List<Persona> personas = new List<Persona>();
        Alumno a = new Alumno();
        a.fijarNombre("Dani");
        a.Poblacion = "Avilés";
        a.Edad = 22;
        personas.Add(a);

        Empleado e = new Empleado();
        e.fijarNombre("Victoria");
        e.Poblacion = "Gijón";
        e.Puesto = "Profesora";
        e.Edad = 34;
        e.Sueldo = 3000;
        personas.Add(e);

        Console.WriteLine("Pulse una tecla para continuar......");
        Console.ReadKey();

        foreach (Persona p in personas)
        {
            Console.WriteLine(p.Saludar());
        }
    }
}
