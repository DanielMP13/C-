using System;
namespace ejemploSQLClases;

class Program
{
    static void Main(string[] args)
    {
        ConexionSQL conexion = new ConexionSQL();

        Console.WriteLine("1. Consultar");
        Console.WriteLine("2. Insertar");
        Console.WriteLine("3. Modificar");
        Console.WriteLine("4. Eliminar");
        int opcion = Validador.LeerEntero("Opción: ");

        switch (opcion)
        {
            case 1:
                List<Nombres> lista = conexion.Consultar();
                int i = 0;
                while (i < lista.Count)
                {
                    Nombres p = lista[i];
                    Console.WriteLine($"{p.Id} - {p.Nombre} - {p.Poblacion} - {p.Edad}");
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
                Nombres nuevo = new Nombres
                {
                    Id = IdIn,
                    Nombre = Validador.LeerTexto("Nombre: "),
                    Poblacion = Validador.LeerTexto("Población: "),
                    Edad = Validador.LeerEntero("Edad: ")
                };
                if (conexion.Insertar(nuevo))
                    Console.WriteLine("✅ Registro insertado correctamente. ");
                break;
                case 3:
                int idMod = Validador.LeerEntero("ID a modificar. ");
                if (!conexion.Existe(idMod))
                {
                    Console.WriteLine("❌ No existe ese ID. ");
                    break;
                }

                Nombres mod = new Nombres
                {
                    Id = idMod,
                    Nombre = Validador.LeerTexto("Nuevo nombre: "),
                    Poblacion = Validador.LeerTexto("Nueva población: "),
                    Edad = Validador.LeerEntero("Nueva edad: ")
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

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
