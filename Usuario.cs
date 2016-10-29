

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba
{
    class Usuario
    {

        public string username { get; set; }
        public string doc_tipo { get; set; }
        public int doc_nro { get; set; }
        public string contrasenia { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fec_nac { get; set; }
        public string sexo { get; set; }
        public string domicilio { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }


        public Usuario() { }

        public Usuario(string pUsername, string pDoc_tipo, int pDoc_nro, string pContrasenia, string pNombre, string pApellido, DateTime pFec_nac, string pSexo, string pDomicilio, string pMail, int pTelefono)
        {
            this.username = pUsername;
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
        }

    }
}
