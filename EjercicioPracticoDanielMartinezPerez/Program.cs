namespace EjercicioPracticoDanielMartinezPerez;

class Program
{
    static void Main(string[] args)
    {
        ConexionSQL conexion = new ConexionSQL();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("1. Consultar todos los cursos.");
            Console.WriteLine("2. Insertar un nuevo curso.");
            Console.WriteLine("3. Modificar un curso.");
            Console.WriteLine("4. Eliminar un curso.");
            Console.WriteLine("5. Salir del Programa.");
            int opcion = Validador.LeerEntero("Opción: ");

            switch (opcion)
            {
                case 1:
                    List<Cursos> lista = conexion.Consultar();
                    int i = 0;
                    while (i < lista.Count)
                    {
                        Cursos c = lista[i];
                        Console.WriteLine($"{c.Id} - {c.NombreCurso} - {c.FamiliaProfesional} - {c.Horas}");
                        i++;
                    }
                    break;
                case 2:
                    int IdIn = Validador.LeerEntero("Id: ");
                    if (conexion.Existe(IdIn))
                    {
                        Console.WriteLine("❌ Ya existe ese ID.");
                        break;
                    }
                    Cursos nuevo = new Cursos
                    {
                        Id = IdIn,
                        NombreCurso = Validador.LeerTexto("Nombre del curso: "),
                        FamiliaProfesional = Validador.LeerTexto("Familia Profesional: "),
                        Horas = Validador.LeerEntero("Horas: ")
                    };
                    if (conexion.Insertar(nuevo))
                        Console.WriteLine("✅ Registro insertado correctamente. ");
                    break;
                case 3:
                    int idMod = Validador.LeerEntero("ID a modificar: ");
                    if (!conexion.Existe(idMod))
                    {
                        Console.WriteLine("❌ No existe ese ID. ");
                        break;
                    }
                    Cursos mod = new Cursos
                    {
                        Id = idMod,
                        NombreCurso = Validador.LeerTexto(" Nuevo nombre del curso: "),
                        FamiliaProfesional = Validador.LeerTexto(" Nueva familia Profesional: "),
                        Horas = Validador.LeerEntero(" Nueva Horas: "),
                    };
                    if (conexion.Modificar(mod))
                        Console.WriteLine("✅ Registro modificado. ");
                    break;
                case 4:
                    int idDel = Validador.LeerEntero("ID a eliminar: ");
                    if (!conexion.Existe(idDel))
                    {
                        Console.WriteLine("❌ No existe ese ID. ");
                        break;
                    }
                    if (conexion.Eliminar(idDel))
                        Console.WriteLine("✅ Registro eliminado.");
                    break;
                case 5:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

    }
}