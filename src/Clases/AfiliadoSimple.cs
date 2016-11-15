using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba
{
     public class AfiliadoSimple
    {

            public string username { get; set; }
            public String nombre { get; set; }
            public String apellido { get; set; }
            public String estado { get; set; }

            public AfiliadoSimple() { }

        public AfiliadoSimple(string pUsername, string pNombre, string pApellido, string pEstado)
        {
            this.username = pUsername;
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.estado = pEstado;
  
        }
    }
}

