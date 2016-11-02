using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClinicaFrba.Listados
{
    public partial class top5_profesional_menos_horas : Form
    {
        private String anio;

        private int mes1;
        private int mes2;
        private int mes3;
        private int mes4;
        private int mes5;
        private int mes6;

        BindingSource bindingSource = null;

        public top5_profesional_menos_horas()
        {
            InitializeComponent();
        }

        public top5_profesional_menos_horas(String anio, String semestre)
            : this()
        {
            txtAnio.Text = anio;
            txtSemestre.Text = semestre;

            //se guardan los meses
            guardarSemestre(semestre);

            //nuevo
            bindingSource = new BindingSource();
            //
            dataGridView.DataSource = bindingSource;

            llenarcmbPlanes();
            llenarcmbEspecialidades();

            //se carga el dataGrid
            buscarLoNecesario();

        }

        private void llenarcmbPlanes()
        {
            //comsulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select P.Plan_descripcion from MISSINGNO.Planes as p ";
            cmd.Connection = BDComun.ObtenerConexion();
            //ejecuto
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmbPlanes.Items.Add(reader["Plan_descripcion"].ToString());
                }
            }

            cmbPlanes.SelectedIndex = 0;

            //libero                 
            reader.Close();
            //libero
            cmd.Dispose();
        }

        private void llenarcmbEspecialidades()
        {
            //comsulta
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select P.Plan_descripcion from MISSINGNO.Planes as p ";
            cmd.Connection = BDComun.ObtenerConexion();
            //ejecuto
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmbEspecialidades.Items.Add(reader["Plan_descripcion"].ToString());
                }
            }

            cmbEspecialidades.SelectedIndex = 0;

            //libero                 
            reader.Close();
            //libero
            cmd.Dispose();
        }

        private void guardarSemestre(String semestre)
        {
            if (semestre == "Primer semestre")
            {
                this.mes1 = 1;
                this.mes2 = 2;
                this.mes3 = 3;
                this.mes4 = 4;
                this.mes5 = 5;
                this.mes6 = 6;
            }
            if (semestre == "Segundo semestre")
            {
                this.mes1 = 7;
                this.mes2 = 8;
                this.mes3 = 9;
                this.mes1 = 10;
                this.mes2 = 11;
                this.mes3 = 12;
            }

        }

        private void buscarLoNecesario()
        {
            // Aca va la consulta que hay que armar
            // Para acceder al valor seleccionado en el combobox Planes -> cmbPlanes.SelectedItem.ToString()
            // Para acceder al valor seleccionado en el combobox Especialidades -> cmbEspecialidades.SelectedItem.ToString()
            
           String conslt = "SELECT TOP 5 u.NOMBRE, u.APELLIDO, sum(d.horario_hasta - d.horario_desde)";
           conslt += "from MISSINGNO.Usuario as u";
           conslt += "join MISSINGNO.Profesional as p on u.username = p.username";
           conslt += "join MISSINGNO.Especialida_de_profesional as edp on edp.profesional_id = p.profesional_id";
           conslt += "join MISSINGNO.Agenda as ag on ag.prof_esp_id = edp.prof_esp_id";
           conslt += "join MISSINGNO.Dia as d on d.agenda_id = ag.agenda_id";
           conslt += "";
           conslt += "";
           conslt += "";
           conslt += "";
           conslt += "";
           conslt += "";
           conslt += "group by u.NOMBRE, u.APELLIDO";
           conslt += "order by sum(d.horario_hasta - d.horario_desde) desc";
             
            

            //a cargar el datagrid
           cargarDatagrid(conslt);

            //edito nombre de columnas del datagrid
            dataGridView.Columns[0].HeaderText = "Nombre";
            dataGridView.Columns[0].HeaderText = "Apellido";
            dataGridView.Columns[2].HeaderText = "Horas trabajadas";
        }

        private void cargarDatagrid(String consulta)
        {
            //nuevo
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            //consulta para llenar el datagrid
            dataAdapter.SelectCommand = new SqlCommand();
            dataAdapter.SelectCommand.CommandText = consulta;
            dataAdapter.SelectCommand.Connection = BDComun.ObtenerConexion();

            //nuevo
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            //nueva
            DataTable tabla = new DataTable();
            //
            bindingSource.DataSource = tabla;

            //cargamos el datagrid
            dataAdapter.Fill(tabla);

            //libero
            dataAdapter.Dispose();
            //libero
            commandBuilder.Dispose();
            //libero
            tabla.Dispose();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Listados.AbmListados frmAbmListados = new Listados.AbmListados();
            this.Hide();
            frmAbmListados.ShowDialog();
            this.Close();
        }
    }
}
