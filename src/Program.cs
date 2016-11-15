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

        public static DateTime fecha = Properties.Settings.Default.fecha;
        

        //METODOS GLOBALES//
        public static void setUsuario(string nameUsuario)
        {
            usuario = nameUsuario;
        }

        public static void setUsuario(DateTime pFecha )
        {
            fecha = pFecha;
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
                //ClinicaFrba.Abm_Afiliado.AbmCrearAfiliado login = new ClinicaFrba.Abm_Afiliado.AbmCrearAfiliado();
                //ClinicaFrba.Registro_Llegada.RegistroDeLlegada login = new ClinicaFrba.Registro_Llegada.RegistroDeLlegada();
                //ClinicaFrba.Cancelar_Atencion.AbmPedirTurno login = new ClinicaFrba.Cancelar_Atencion.AbmPedirTurno();
                //ClinicaFrba.Registro_Resultado.AbmRegistroResultado login = new ClinicaFrba.Registro_Resultado.AbmRegistroResultado();
              

                ClinicaFrba.Login.frm_login login = new ClinicaFrba.Login.frm_login();
                Application.Run(login);

        }
    }
}
