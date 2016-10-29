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
            public int afiliado_id { get; set; }

            public AfiliadoSimple() { }

        public AfiliadoSimple(string pUsername, int pAfiliado_id)
        {
            this.username = pUsername;
            this.afiliado_id = pAfiliado_id;
  
        }
    }
}

