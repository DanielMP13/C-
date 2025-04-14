namespace ConexionSqlB;
using System;
using Microsoft.Data.SqlClient;
class Program
{
    static string CadenaConexion = "SERVER=CANTABRICO15\\SQLEXPRESS;" +
                                   "Database=Dani;" +
                                   "trusted_connection=True;" +
                                   "Encrypt=False";
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca su nombre: ");
        string Nombre = Console.ReadLine();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine($"\n--- Bienvenido {Nombre}, escoja una de las siguientes opciones del menú ---");
            Console.WriteLine("1. Consultar registros");
            Console.WriteLine("2. Insertar un nuevo registro");
            Console.WriteLine("3. Modificar un registro");
            Console.WriteLine("4. Eliminar un registro");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Consultar();
                    break;
                case "2":
                    Insertar();
                    break;
                case "3":
                    Modificar();
                    break;
                case "4":
                    Eliminar();
                    break;
                case "5":
                    continuar = false;
                    Console.WriteLine($"¡Hasta luego {Nombre}!");
                    break;
                default:
                    Console.WriteLine("⚠ Opción no válida. Por favor, inténtelo nuevamente.");
                    break;
            }
        }
    }
    static void Consultar()
    {
        using (SqlConnection conexion = new SqlConnection(CadenaConexion))
        {
            conexion.Open();
            string consulta = "select * from nombre";
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            using (SqlDataReader lector = comando.ExecuteReader())
            {
                Console.WriteLine("Registros Actuales");
                while (lector.Read())
                {
                    Console.WriteLine($"ID: {lector["Id"]}, Nombre: {lector["Nombre"]}, Población: {lector["Poblacion"]}, Edad: {lector["Edad"]}");
                }
            }
        }
    }
    static void Insertar()
    {
        Console.WriteLine("Nombre: ");
        string nombre = (Console.ReadLine()!);
        Console.WriteLine("Población: ");
        string poblacion = (Console.ReadLine()!);
        Console.WriteLine("Edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        using (SqlConnection conexion = new SqlConnection(CadenaConexion))
        {
            conexion.Open();
            string consulta = "INSERT INTO Nombre (Nombre, Poblacion, Edad) VALUES (@nombre, @poblacion, @edad)";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@poblacion", poblacion);
                comando.Parameters.AddWithValue("@edad", edad);

                int filas = comando.ExecuteNonQuery();
                Console.WriteLine($"✔ Se insertó {filas} registro(s).");
            }
        }
    }
    static void Modificar()
    {
        Console.Write("ID del registro a modificar: ");
        int id = int.Parse(Console.ReadLine()!);

        string consultaExistencia = "SELECT COUNT(*) FROM nombre WHERE Id = @id";
        SqlConnection conecta = new SqlConnection(CadenaConexion);
        conecta.Open();
        SqlCommand cmdExistencia = new SqlCommand(consultaExistencia, conecta);
        cmdExistencia.Parameters.AddWithValue("@id", id);
        int existe = (int)cmdExistencia.ExecuteScalar();

        if (existe == 0)
        {
            Console.WriteLine($"❌ No existe ningún registro con el id {id}");
        }
        else
        {
            Console.Write("Nuevo nombre: ");
            string nombre = (Console.ReadLine()!);
            Console.Write("Nueva Población: ");
            string poblacion = (Console.ReadLine()!);
            Console.Write("Nueva Edad: ");
            int edad = int.Parse(Console.ReadLine()!);

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                string consulta = "UPDATE nombre SET Nombre = @nombre, Poblacion = @poblacion, Edad = @Edad WHERE Id = @id";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@poblacion", poblacion);
                    comando.Parameters.AddWithValue("@edad", edad);

                    int filas = comando.ExecuteNonQuery();
                    if (filas == 0)
                    {
                        Console.WriteLine($"El registro con el {id} no existe.");
                    }
                    Console.WriteLine($"✔ Se modificó {filas} registro(s).");
                }
            }
        }
    }
    static void Eliminar()
    {
        Console.WriteLine("ID del registro a eliminar: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection conexion = new SqlConnection(CadenaConexion))
        {
            conexion.Open();
            string consulta = "DELETE FROM Nombre WHERE id = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@id", id);

                int filas = comando.ExecuteNonQuery();
                if (filas == 0)
                {
                    Console.WriteLine($"El registro con el {id} no se ha podido eliminar, ya que no existe.");
                }
                Console.WriteLine($"✔ Se eliminó {filas} registro(s).");
            }
        }
    }
}
