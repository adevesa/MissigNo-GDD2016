using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba
{
   public class tipoTurno
    {
       

            public int idTurno { get; set; }
            public DateTime fechaTurno { get; set; }
 
            
         public tipoTurno() { }

         public tipoTurno(int pIdTurno, DateTime pFechaTurno, Time pHoraTurno) 
         {
             this.idTurno = pIdTurno;
             this.fechaTurno = pFechaTurno;
         }


    }
}
