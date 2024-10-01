using System.Collections;
using System.Text;
using System.Threading.Tasks;

class Dia
{
    private String nombre;
    private double temperatura;
    
    public String Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            this.nombre = value;
            this.PropertyChanges(value);
        }
    }
    public Dia(String nombre, double temperatura)
    {
        this.nombre = nombre;
        this.temperatura = temperatura;
    }


}