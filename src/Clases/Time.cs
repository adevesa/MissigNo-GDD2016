using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba
{
   public class Time
    {
        
            public int hora { get; set; }
            public int minuto { get; set; }

         public Time() { }

         public Time(int pHora, int pMinuto) 
         {
             this.hora = pHora;
             this.minuto = pMinuto;
         }
    }
}
