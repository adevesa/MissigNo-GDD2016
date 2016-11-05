using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba
{
   public class Palabra
    {


            public string unElemento { get; set; }

         public Palabra() { }

         public Palabra(string pUnaEspecialidad) 
         {
             this.unElemento = pUnaEspecialidad;
         }



    }
}
