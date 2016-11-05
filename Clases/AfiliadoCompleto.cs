using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba
{
   public class AfiliadoCompleto
    {
    

            //public string username { get; set; }
            public string doc_tipo { get; set; }
            public Int64 doc_nro { get; set; }
            public string contrasenia { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public DateTime fec_nac { get; set; }
            public string sexo { get; set; }
            public string domicilio { get; set; }
            public string mail { get; set; }
            public Int64 telefono { get; set; }
            public List<int> hijos  { get; set; }
            public string afiliado_estado_civil { get; set; }

            public AfiliadoCompleto() { }

            public AfiliadoCompleto(/*string pUsername,*/ string pDoc_tipo, int pDoc_nro, string pContrasenia, string pNombre, string pApellido, DateTime pFec_nac, string pSexo, string pDomicilio, string pMail, int pTelefono, List<Int32> pHijos, string pAfiliado_estado_civil)
            {
                //this.username = pUsername;
                this.doc_tipo = pDoc_tipo;
                this.doc_nro = pDoc_nro;
                this.contrasenia = pContrasenia;
                this.nombre = pNombre;
                this.apellido = pApellido;
                this.fec_nac = pFec_nac;
                this.sexo = pSexo;
                this.domicilio = pDomicilio;
                this.mail = pMail;
                this.telefono = pTelefono;
                //this.hijos = pHijos;
                this.afiliado_estado_civil = pAfiliado_estado_civil;

            }

        }
    
}
