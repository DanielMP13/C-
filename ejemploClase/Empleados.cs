namespace ejemploClase;
class Empleado:Persona, ISalario
{
    private string puesto;
    private int sueldo;

    public string Puesto 
    {
        get 
        {
            return puesto;
        }
        set
        {
            puesto = value;
        }
    }

    public int Sueldo 
    {
        get
        {
            return sueldo;
        }
        set
        {
            sueldo = value;
        }
    }
    public override string Saludar()
    {
        return $"Hola, soy {obtenerNombre()} y trabajo como {puesto}";
    }

    public string Salario()
    {
        return $"Soy {obtenerNombre()} y tengo un salario de {sueldo} €";
    }
}