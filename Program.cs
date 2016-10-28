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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //con esto nos conectamos
                SqlConnection sqlCon = null;
                //creo una instancia del conector de la base de datos
                sqlCon = new SqlConnection("server=localhost\\SQLSERVER2012; initial catalog=GD2C2016; user id=gd; password=1234");
                //nos conectamos
                sqlCon.Open();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Principal(sqlCon));

                //cerramos la conexion
                sqlCon.Close();

            }
            catch (SqlException e)
            {
                //le informamos al usuario
                MessageBox.Show(e.Message, "Error: " + e.Number);
            }
        }
    }
}
