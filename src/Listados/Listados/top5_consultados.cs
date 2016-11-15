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
    public partial class top5_consultados : Form
    {
        private String anio;

        private int mes1;
        private int mes2;
        private int mes3;
        private int mes4;
        private int mes5;
        private int mes6;

        BindingSource bindingSource = null;

        public top5_consultados()
        {
            InitializeComponent();
        }

        public top5_consultados(String anio, String semestre)
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
            // Tener en cuenta que la especialidad_descripcion estaría bueno tenerla en la consulta_medica

           String conslt = "SELECT TOP 5 u.NOMBRE, u.APELLIDO, c.ESPECIALIDAD_DESCRIPCION, count(c.CONSULTA_ID)";
           conslt += "from MISSINGNO.Usuario as u";
           conslt += "join MISSINGNO.Profesional as pr on u.username = pr.username ";
           conslt += "join MISSINGNO.Consulta_medica as c on pr.profesional_id = c.profesional_id";
           conslt += "joid MISSINGNO.Afiliado as a on c.afiliado_id = a.afiliado_id";
           conslt += "join MISSINGNO.Plan as pl on pl.plan_id = a.plan_id";
           conslt += "join MISSINGNO.Turno as t on c.turno_id = t.turno_id";
           conslt += "where pl.plan_descripcion = '" + cmbPlanes.SelectedItem.ToString() + "' AND ";
           conslt += "YEAR(t.fecha) = '" + txtAnio.Text + "' AND";
           conslt += "MONTH(t.fecha) IN ('" + mes1 + "', '" + mes2 + "', '" + mes3 + "', '" + mes4 + "', '" + mes5 + "', '" + mes6 + "') ";
           conslt += "group by u.NOMBRE, u.APELLIDO, c.ESPECIALIDAD_DESCRIPCION ";
           conslt += "order by count(c.CONSULTA_ID) desc";
             
            //a cargar el datagrid
            cargarDatagrid(conslt);

            //edito nombre de columnas del datagrid
            dataGridView.Columns[0].HeaderText = "Nombre";
            dataGridView.Columns[1].HeaderText = "Apellido";
            dataGridView.Columns[2].HeaderText = "Especialidad";
            dataGridView.Columns[3].HeaderText = "Consultas";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbTop5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
