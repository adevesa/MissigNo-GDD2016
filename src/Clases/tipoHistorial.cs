using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Clases
{
    public class tipoHistorial
    {
        public DateTime fecha { get; set; }
        public string motivo { get; set; }
           

         public tipoHistorial() { }

         public tipoHistorial(DateTime pFecha, string pMotivo) 
         {
             this.fecha = pFecha;
             this.motivo = pMotivo;
            
         }
    }
}
