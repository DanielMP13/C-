namespace ejemploSQLClasesProcedimientos;

public class Nombres
{
    public Nombres(int id, string nombre, string poblacion, int edad)
    {
        Id = id;
        Nombre = nombre;
        Poblacion = poblacion;
        Edad = edad;
    }
    public Nombres() { }

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Poblacion { get; set; }
    public int Edad { get; set; }
}