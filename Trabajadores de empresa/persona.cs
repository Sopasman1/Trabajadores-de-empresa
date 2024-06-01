using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajadores_de_empresa
{
    internal class persona
    {
        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public persona() : base() 
        {
            Nombre = "";
            ApellidoPaterno = "";
            ApellidoMaterno = "";
        }
        

        public override string ToString()
        {
            return "Nombre"+Nombre.ToString()+"ApellidoPaterno"+ApellidoPaterno.ToString()+"ApellidoMaterno"+ApellidoMaterno.ToString();
        }

    }
}
