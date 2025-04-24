using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ejemploSQLClases;

public class ConexionSQL
{
    private readonly string cadenaConexion = "SERVER=CANTABRICO15\\SQLEXPRESS;" +
                                   "Database=Dani;" +
                                   "trusted_connection=True;" +
                                   "Encrypt=False";

    public bool Existe(int id)
    {
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        string consulta = "SELECT COUNT(*) FROM nombres WHERE id = @id";
        using SqlCommand comando = new SqlCommand(consulta, conexion);
        comando.Parameters.AddWithValue("@id", id);
        int existe = (int)comando.ExecuteScalar();
        return existe > 0;
    }

    public List<Nombres> Consultar()
    {
        List<Nombres> lista = new List<Nombres>();
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        string consulta = "SELECT * FROM nombres";

        using SqlCommand comando = new SqlCommand(consulta, conexion);
        using SqlDataReader lector = comando.ExecuteReader();
        while(lector.Read())
        {
            lista.Add(new Nombres((int)lector["id"],lector["nombre"].ToString(),lector["poblacion"].ToString(),(int)lector["edad"]));
        }
        return lista;
    }

    public bool Insertar(Nombres persona)
    {
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        string consulta = "INSERT INTO nombres (id, nombre, poblacion, edad) VALUES (@id, @nombre, @poblacion, @edad)";
        using SqlCommand comando = new SqlCommand(consulta, conexion);
        comando.Parameters.AddWithValue("@id", persona.Id);
        comando.Parameters.AddWithValue("@nombre", persona.Nombre);
        comando.Parameters.AddWithValue("@poblacion", persona.Poblacion);
        comando.Parameters.AddWithValue("@edad", persona.Edad);
        return comando.ExecuteNonQuery() > 0;
    }

    public bool Modificar(Nombres persona)
    {
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        string consulta = "UPDATE nombres SET nombre = @nombre, poblacion = @poblacion, edad = @edad WHERE id = @id";
        using SqlCommand comando = new SqlCommand(consulta, conexion);
        comando.Parameters.AddWithValue("@id", persona.Id);
        comando.Parameters.AddWithValue("@nombre", persona.Nombre);
        comando.Parameters.AddWithValue("@poblacion", persona.Poblacion);
        comando.Parameters.AddWithValue("@edad", persona.Edad);
        return comando.ExecuteNonQuery() > 0;
    }

    public bool Eliminar(int id)
    {
         using SqlConnection conexion = new SqlConnection(cadenaConexion);
         conexion.Open();
         string consulta = "DELETE FROM nombres WHERE id = @id";
         using SqlCommand comando = new SqlCommand(consulta, conexion);
         comando.Parameters.AddWithValue("@id", id);
         return comando.ExecuteNonQuery() > 0;
    }
}