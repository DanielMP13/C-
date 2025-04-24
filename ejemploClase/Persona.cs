namespace ejemploClase;

class Persona 
{
public Persona(string nombre)
{
    this.nombre = nombre;
}

public Persona() 
{

}
    private string nombre;
    private string poblacion;
    //private int edad;

    public void fijarNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string obtenerNombre()
    {
        return nombre;
    }

    public string Poblacion
    {
        get 
        {
            return poblacion;
        }
        set
        {
            poblacion = value;
        }
    }
    public int Edad {get; set;}

    public virtual string Saludar()
    {
        return $"Hola, soy {obtenerNombre()} vivo en {Poblacion} y tengo {Edad} años";
    }
    public string Saludar(string nombre)
    {
        return $"Hola {nombre}, soy {obtenerNombre()} vivo en {Poblacion} y tengo {Edad} años";
    }
}