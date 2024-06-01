using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajadores_de_empresa
{
    internal class Fechas
    {
        public string Edad {  get; set; }
        public DateTime Fdn { get; set; }
        public void Nombreyfecha(string edad,DateTime FDN)
        {
            Fdn = FDN.Date;
            Edad = edad;
          
        }


        public override string ToString()
        {
            return "Edad"+Edad.ToString()+"Fecha de nacimiento"+Fdn.ToString();
        }
    }
}
