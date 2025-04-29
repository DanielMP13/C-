using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace EjercicioPracticoDanielMartinezPerez;

public class ConexionSQL
{
    private readonly string cadenaConexion = "SERVER=CANTABRICO15\\SQLEXPRESS;" +
                                   "Database=FormacionPractica;" +
                                   "trusted_connection=True;" +
                                   "Encrypt=False";

    public bool Existe(int id)
    {
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        using SqlCommand comando = new SqlCommand("prExisteCurso", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@id", id);

        int resultado = (int)comando.ExecuteScalar();
        return resultado > 0;
    }
    public List<Cursos> Consultar()
    {
        List<Cursos> lista = new List<Cursos>();
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        using SqlCommand comando = new SqlCommand("prSeleccionCursos", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;
        using SqlDataReader lector = comando.ExecuteReader();
        while (lector.Read())
        {
            lista.Add(new Cursos(
               (int)lector["id"],
               lector["nombreCurso"].ToString()!,
               lector["familiaProfesional"].ToString()!,
                (int)lector["horas"]
           ));
        }
        return lista;
    }

    public bool Insertar(Cursos cursos)
    {
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        using SqlCommand comando = new SqlCommand("prInsertarCurso", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;

        comando.Parameters.AddWithValue("@id", cursos.Id);
        comando.Parameters.AddWithValue("@nombrecurso", cursos.NombreCurso);
        comando.Parameters.AddWithValue("@familiaprofesional", cursos.FamiliaProfesional);
        comando.Parameters.AddWithValue("@horas", cursos.Horas);

        return comando.ExecuteNonQuery() > 0;
    }

    public bool Modificar(Cursos cursos)
    {
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        using SqlCommand comando = new SqlCommand("prModificarCurso", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;

        comando.Parameters.AddWithValue("@id", cursos.Id);
        comando.Parameters.AddWithValue("@nombrecurso", cursos.NombreCurso);
        comando.Parameters.AddWithValue("@familiaprofesional", cursos.FamiliaProfesional);
        comando.Parameters.AddWithValue("@horas", cursos.Horas);

        return comando.ExecuteNonQuery() > 0;
    }

      public bool Eliminar(int id)
    {
        using SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();

        using SqlCommand comando = new SqlCommand("prBorrarCurso", conexion);
        comando.CommandType = System.Data.CommandType.StoredProcedure;

        comando.Parameters.AddWithValue("@id", id);

        return comando.ExecuteNonQuery() > 0;
    }
}