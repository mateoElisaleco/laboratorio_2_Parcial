using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial1
{
    public class PersonalMedico :Persona
    {
        private bool esResidente;
        private List<Consulta> consultas;
         string FichaExtra()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(this.esResidente)
            { 
                stringBuilder.Append("SI"); 
            }
            else
            {
                stringBuilder.Append("NO");
            }

            foreach(Consulta c in this.consultas)
            stringBuilder.AppendLine($"{c.ToString}");

            return stringBuilder.ToString();

        }
    }

    public static  operator +(PersonalMedico doctor, paciente paciente)
    {
       

    }
}
