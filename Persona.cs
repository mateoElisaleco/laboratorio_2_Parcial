using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClasesParcial1
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;

        public int Edad 
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }
        public string NombreCompleto
        {
            get {return $"{this.apellido},{this.nombre}"; }
        }

        internal abstract string FichaExtra();

        public string FichaPersonal(Persona p)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{this.apellido}{this.nombre}");
            stringBuilder.AppendLine($"{this.Edad}");
            stringBuilder.AppendLine($"{this.barrioRecidencia}");

            return stringBuilder.ToString();
        }
        
        public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{this.apellido}{this.nombre}");
            return stringBuilder.ToString();
        }
    }
}