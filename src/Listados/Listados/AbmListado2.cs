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
    public partial class AbmListado2 : Form
    {
        private String anio = null;

        private String semestre = null;

        private int mes1;
        private int mes2;
        private int mes3;
        private int mes4;
        private int mes5;
        private int mes6;

        BindingSource bindingSource = null;

        public AbmListado2()
        {
            InitializeComponent();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AbmListado2_Load(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            AbmRol.AbmRolAdministrador abmRolAdministrador = new AbmRol.AbmRolAdministrador();
            this.Hide();
            abmRolAdministrador.ShowDialog();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.anio = npckAnio.Value.ToString();

            this.semestre = cmbSemestre.GetItemText(cmbSemestre.SelectedItem);

            //se guardan los meses
            guardarSemestre(semestre);

            //nuevo
            bindingSource = new BindingSource();
            //
            dataGridView.DataSource = bindingSource;

            //se carga el dataGrid
            buscarLoNecesario();
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
            String conslt = querySegunListadoPedido(cmbTop5.GetItemText(cmbTop5.SelectedItem));

            //a cargar el datagrid
            cargarDatagrid(conslt);


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

        private string querySegunListadoPedido(String queryPedido)
        {
            if (queryPedido == "Especialidades con mas cancelaciones")
                {
                //edito nombre de columnas del datagrid
                dataGridView.Columns[0].HeaderText = "Afiliado";
                dataGridView.Columns[1].HeaderText = "Cantidad de bonos";
                dataGridView.Columns[2].HeaderText = "Pertenece a grupo familiar";

                String conslt = "SELECT TOP 5 ";
                conslt += "SELECT ";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                return conslt;
                }

            if (queryPedido == "Profesionales más consultados")
                {
                //edito nombre de columnas del datagrid
                dataGridView.Columns[0].HeaderText = "Profesional";
                dataGridView.Columns[1].HeaderText = "Especialidad";
                dataGridView.Columns[2].HeaderText = "Consultas";

                String conslt = "SELECT TOP 5 ";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                return conslt;
                }

            if (queryPedido == "Profesionales más perezosos")
                {
                //edito nombre de columnas del datagrid
                dataGridView.Columns[0].HeaderText = "Plan";
                dataGridView.Columns[1].HeaderText = "Especialidad";
                dataGridView.Columns[2].HeaderText = "Profesional";
                dataGridView.Columns[3].HeaderText = "Horas";

                String conslt = "SELECT TOP 5 ";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                return conslt;
                }

             if (queryPedido == "Afiliado con más bonos comprados")
                {
                //edito nombre de columnas del datagrid
                dataGridView.Columns[0].HeaderText = "Afiliado";
                dataGridView.Columns[1].HeaderText = "Cantidad de bonos";
                dataGridView.Columns[2].HeaderText = "Pertenece a grupo familiar";

                String conslt = "SELECT TOP 5 ";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                conslt += "";
                return conslt;
                }

             else //Listado de especialidades con mas bonos de consultas utilizados
             {
                 //edito nombre de columnas del datagrid
                 dataGridView.Columns[0].HeaderText = "Especialidad";
                 dataGridView.Columns[1].HeaderText = "Bonos de consultas utilizados";

                 String conslt = "SELECT TOP 5 ";
                 conslt += "";
                 conslt += "";
                 conslt += "";
                 conslt += "";
                 conslt += "";
                 conslt += "";
                 conslt += "";
                 conslt += "";
                 conslt += "";
                 conslt += "";
                 return conslt;
             }
             
            
        }
    }
}