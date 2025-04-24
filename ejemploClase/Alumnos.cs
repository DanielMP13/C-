namespace ejemploClase;

class Alumno:Persona
{
    private string curso;
    private string colectivo;

    public string Curso
    {
        get
        {
            return curso;
        }
        set 
        {
            curso = value;
        }
    }
    public string Colectivo
    {
        get
        {
            return colectivo;
        }
        set
        {
            colectivo = value;
        }
    }
}