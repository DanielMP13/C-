using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ejemploSQLClasesProcedimientos;

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
        using SqlCommand comando = new SqlCommand("prExisteId", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@id", id);

        int resultado = (int)comando.ExecuteScalar();
        return resultado > 0;
    }

    public List<Nombres> Consultar()
    {
        List<Nombres> lista = new List<Nombres>();
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        using SqlCommand comando = new SqlCommand("prSeleccion", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;

        using SqlDataReader lector = comando.ExecuteReader();
        while (lector.Read())
        {
            lista.Add(new Nombres(
                (int)lector["id"],
                lector["nombre"].ToString()!,
                lector["poblacion"].ToString()!,
                 (int)lector["edad"]
            ));
        }
        return lista;
    }

    public bool Insertar(Nombres persona)
    {
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        using SqlCommand comando = new SqlCommand("prInsertar", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;

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
        using SqlCommand comando = new SqlCommand("prModificar", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;


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

        using SqlCommand comando = new SqlCommand("prBorrar", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;

        comando.Parameters.AddWithValue("@id", id);

        return comando.ExecuteNonQuery() > 0;
    }
}