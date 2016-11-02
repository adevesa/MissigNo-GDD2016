using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicaFrba
{
    static class Program
    {
        //ATRIBUTOS GLOBALES//
        public static string usuario;

        //METODOS GLOBALES//
        public static void setUsuario(string nameUsuario)
        {
            usuario = nameUsuario;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                
                //List<AfiliadoSimple> lista = new List<AfiliadoSimple>();
                //ClinicaFrba.Abm_Afiliado.AbmConsultaFamiliar login = new ClinicaFrba.Abm_Afiliado.AbmConsultaFamiliar(lista, "afi", "mi casa");
                //ClinicaFrba.Abm_Afiliado.AbmCrearAfiliado2 login = new ClinicaFrba.Abm_Afiliado.AbmCrearAfiliado2();
               // ClinicaFrba.Registro_Llegada.RegistroDeLlegada login = new ClinicaFrba.Registro_Llegada.RegistroDeLlegada();
                //ClinicaFrba.Cancelar_Atencion.AbmPedirTurno login = new ClinicaFrba.Cancelar_Atencion.AbmPedirTurno();
                //ClinicaFrba.Registro_Resultado.AbmRegistroResultado login = new ClinicaFrba.Registro_Resultado.AbmRegistroResultado();
                Palabra x = new Palabra();
                Palabra y = new Palabra();
                y.unElemento = "Neurofisiología Clínica";
                x.unElemento = "renzo_Toledo@gmail.com";
        
                ClinicaFrba.Cancelar_Atencion.AbmElegirHorario login = new ClinicaFrba.Cancelar_Atencion.AbmElegirHorario(x, y, 95210);

                //ClinicaFrba.Login.frm_login login = new ClinicaFrba.Login.frm_login();
                Application.Run(login);

        }
    }
}
