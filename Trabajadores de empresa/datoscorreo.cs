using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajadores_de_empresa
{
    internal class datoscorreo
    {
        public string CURP { get; set; }

        public string RFC { get; set; }

        public string Correo {  get; set; }
        
        public string Phone {  get; set; }



        public datoscorreo(string cURP,string Rfc,string correo,string phone)
        {
            CURP =cURP;
            RFC =Rfc;
            Correo =correo;
            Phone =phone;
        }

       public void correo()
        {
            this.CURP = "";
            this.RFC = "";
            this.Correo = "";
            this.Phone = "";
        }

        public override string ToString()
        {
            return this.CURP.ToString() + this.RFC.ToString() + this.Correo.ToString() + this.Phone.ToString();
        }
    }
}
