namespace Supermercado;
using System;
using Microsoft.Data.SqlClient;

class Program
{
    static string CadenaConexion = "SERVER=CANTABRICO15\\SQLEXPRESS;" +
                                    "Database=Supermercados;" +
                                    "trusted_connection=True;" +
                                    "Encrypt=False";

    static void Main(string[] args)
    {

        static bool UsuarioExistente(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM usuarios WHERE Nombre = @nombre";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    int existe = (int)comando.ExecuteScalar();
                    return existe > 0;
                }
            }
        }

        Console.WriteLine("Introduzca su nombre: ");
        string Nombre = Console.ReadLine()!;

        if (!UsuarioExistente(Nombre))
        {
            Console.WriteLine($"❌ Usuario '{Nombre}' no encontrado. Por favor, pongase en contacto con el adminisrador para ser dada de alta en la base de datos de nuestro supermercado.");
            return;
        }


        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine($"\n--- Bienvenido {Nombre} a su supermercado de confianza, escoja la opción que mas le convenga en el día {DateTime.Now:dd/MM/yyyy} ---");
            Console.WriteLine("1. Consultar productos");
            Console.WriteLine("2. Insertar un nuevo producto");
            Console.WriteLine("3. Modificar el producto");
            Console.WriteLine("4. Eliminar el producto");
            Console.WriteLine("5. Venta de un producto");
            Console.WriteLine("6. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine()!;
            switch (opcion)
            {
                case "1":
                    ConsultarProducto();
                    break;
                case "2":
                    InsertarProducto();
                    break;
                case "3":
                    ModificarProducto();
                    break;
                case "4":
                    EliminarProducto();
                    break;
                case "5":
                    VentaDelProducto();
                    break;
                case "6":
                    continuar = false;
                    Console.WriteLine($"¡Gracias por la compra del día de hoy {Nombre}!");
                    break;
                default:
                    Console.WriteLine(" ⚠️ Opción no válida. Por favor, inténtelo nuevamente.");
                    break;
            }
        }
    }
    static bool RegistroExistente(int id)
    {
        using (SqlConnection conexion = new SqlConnection(CadenaConexion))
        {
            conexion.Open();
            string consulta = "SELECT COUNT(*) FROM Productos WHERE id = @id";
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@id", id);
                int existe = (int)comando.ExecuteScalar();
                return existe > 0;
            }
        }
    }
    static void ConsultarProducto()
    {
        using (SqlConnection conexion = new SqlConnection(CadenaConexion))
        {
            conexion.Open();
            string consulta = "select * from Productos";
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            using (SqlDataReader lector = comando.ExecuteReader())
            {
                Console.WriteLine("\n📋 Registros actuales:");
                while (lector.Read())
                {
                    Console.WriteLine($"ID: {lector["Id"]}, Nombre: {lector["Nombre"]}, Cantidad: {lector["Cantidad"]}, Precio: {lector["Precio"]} €");
                }
            }
        }
    }
    static void InsertarProducto()
    {
        Console.WriteLine("Nombre: ");
        string nombre = (Console.ReadLine()!);
        Console.WriteLine("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Precio: ");
        decimal precio = decimal.Parse(Console.ReadLine()!);

        using (SqlConnection conexion = new SqlConnection(CadenaConexion))
        {
            conexion.Open();
            string consulta = "INSERT INTO Productos (Nombre, Cantidad, Precio) VALUES (@nombre, @cantidad, @precio)";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@precio", precio);

                int filas = comando.ExecuteNonQuery();
                Console.WriteLine($"✅ Se insertó {filas} registro(s).");
            }
        }
    }
    static void ModificarProducto()
    {
        Console.Write("ID del registro del producto a modificar: ");
        int id = int.Parse(Console.ReadLine()!);

        if (!RegistroExistente(id))
        {
            Console.WriteLine($"❌ No existe ningún registro de un producto con el id {id}");
            return;
        }
        Console.Write("Nueva cantidad: ");
        int cantidad = int.Parse(Console.ReadLine()!);

        using (SqlConnection conexion = new SqlConnection(CadenaConexion))
        {
            conexion.Open();
            string consulta = "UPDATE productos SET Cantidad = @cantidad WHERE Id = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@cantidad", cantidad);

                int filas = comando.ExecuteNonQuery();

                Console.WriteLine($"✅ Se modificó {filas} registro(s).");
            }
        }
    }
    static void EliminarProducto()
    {
        Console.WriteLine("ID del registro del producto que quieres eliminar: ");
        int id = int.Parse(Console.ReadLine()!);

        if (!RegistroExistente(id))
        {
            Console.WriteLine($"❌ No existe ningún registro de un producto con el id {id}");
            return;
        }

        using (SqlConnection conexion = new SqlConnection(CadenaConexion))
        {
            conexion.Open();
            string consulta = "DELETE FROM productos WHERE id = @id";

            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@id", id);

                int filas = comando.ExecuteNonQuery();

                Console.WriteLine($"✅ Se eliminó {filas} registro(s).");
            }
        }
    }
    static void VentaDelProducto()
    {
        string seguir = "S";
        decimal totalVentas = 0; // Acumulador para las ventas totales

        while (seguir.ToUpper() == "S"!)
        {
            Console.Write("ID del producto que deseas vender: ");
            int id = int.Parse(Console.ReadLine()!);

            if (!RegistroExistente(id))
            {
                Console.WriteLine($"❌ No existe ningún registro de un producto con el ID {id}.");
            }
            else
            {
                Console.Write("Cantidad a vender: ");
                int cantidadAVender = int.Parse(Console.ReadLine()!);

                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();

                    string consultaStock = "SELECT Cantidad, Precio FROM Productos WHERE Id = @id";
                    decimal precio = 0;
                    using (SqlCommand comandoStock = new SqlCommand(consultaStock, conexion))
                    {
                        comandoStock.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader lector = comandoStock.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                int cantidadActual = (int)lector["Cantidad"];
                                precio = (decimal)lector["Precio"];

                                if (cantidadAVender > cantidadActual)
                                {
                                    Console.WriteLine($"⚠️ No hay suficiente stock. Stock actual: {cantidadActual}");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"❌ No se encontró el producto con ID {id}.");
                                continue;
                            }
                        }
                    }

                    string consultaVenta = "UPDATE Productos SET Cantidad = Cantidad - @cantidadAVender WHERE Id = @id";
                    using (SqlCommand comandoVenta = new SqlCommand(consultaVenta, conexion))
                    {
                        comandoVenta.Parameters.AddWithValue("@id", id);
                        comandoVenta.Parameters.AddWithValue("@cantidadAVender", cantidadAVender);
                        comandoVenta.ExecuteNonQuery();
                    }

                    string consultaRegistroVenta = "INSERT INTO Ventas (IdProducto,Cantidad,FechaVenta, Precio) VALUES (@idProducto,@cantidad, @fecha, @precio)";
                    using (SqlCommand comandoRegistroVenta = new SqlCommand(consultaRegistroVenta, conexion))
                    {
                        comandoRegistroVenta.Parameters.AddWithValue("@idProducto", id);
                        comandoRegistroVenta.Parameters.AddWithValue("@cantidad", cantidadAVender);
                        comandoRegistroVenta.Parameters.AddWithValue("@fecha", DateTime.Now);
                        comandoRegistroVenta.Parameters.AddWithValue("@precio", precio);

                        comandoRegistroVenta.ExecuteNonQuery();
                    }

                    decimal totalProducto = cantidadAVender * precio; // Total por producto
                    totalVentas += totalProducto; // Acumula el total
                    Console.WriteLine($"✅ Se registró la venta de {cantidadAVender} unidad(es) del producto con ID {id}. Total: {totalProducto} €");
                }
            }

            Console.WriteLine("Desea continuar(S/N)");
            seguir = Console.ReadLine()!;
        }

        Console.WriteLine($"💰 Total acumulado de todas las ventas del dia {DateTime.Now:dd/MM/yyyy}: {totalVentas} €"); // Muestra el total acumulado
    }
}