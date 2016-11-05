using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AbmConsultaFamiliar : Form
    {
        BDComun conexion = new BDComun();
        public string userPadre;
        public string direccionPadre;
        public List<AfiliadoSimple> listaFamiliares = new List <AfiliadoSimple>();
        public AfiliadoSimple nuevoFamiliar = new AfiliadoSimple();
        //public List<string> listaFamiliares;
        public string userHijo;
        public string nombreHijo;
        public string apellidoHijo;
        int posicion;
    
        public void actualizar(){
            dgvFamiliares.DataSource = listaFamiliares;
        }

        public AbmConsultaFamiliar(List<AfiliadoSimple> lista,string padre, string direccion)
        {
            this.listaFamiliares = lista;
            this.userPadre = padre;
            this.direccionPadre = direccion;
            InitializeComponent();
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            AbmAdministrarAfiliado abmAfiliado = new AbmAdministrarAfiliado();
            this.Hide();
            abmAfiliado.ShowDialog();
            this.Close();
        }



        private void AbmConsultaFamiliar_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
            dgvFamiliares.DataSource = listaFamiliares;

        }

        private void butonAgregar_Click(object sender, EventArgs e)
        {
            AgregarFamiliar abmFamiliar = new AgregarFamiliar(listaFamiliares, userPadre, direccionPadre);
            this.Hide();
            abmFamiliar.ShowDialog();
            this.Close();
        }

        private void botonQuitar_Click(object sender, EventArgs e)
        {
            if (dgvFamiliares.SelectedRows.Count == 1)
            {
               // string afiliado = Convert.ToString(dgvFamiliares.CurrentRow.Cells[1].Value);
              //  UsuarioDAL.borrarAfiliado(afiliado);
            }
            else
                MessageBox.Show("debe de seleccionar un afiliado");
        }

        private void dgvFamiliares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userHijo != null)
            {
                conexion.borrarAfiliado(userHijo);
                MessageBox.Show("Afiliado borrado exitosamente");
                //dgvFamiliares.Rows.RemoveAt(posicion);
            }
            else MessageBox.Show("Elija un Afiliado");
        }

        private void dgvFamiliares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvFamiliares.CurrentRow.Index;
            userHijo = Convert.ToString(dgvFamiliares[0, posicion].Value);
          
        }
    }
}
