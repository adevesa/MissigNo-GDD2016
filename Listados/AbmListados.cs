using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    public partial class AbmListados : Form
    {
        private String anio = null;

        private String semestre = null;

        public AbmListados()
        {
            InitializeComponent();
        }



          private void AbmListados_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

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
            //if (cmbSemestre.Text.Length != 0 || cmbTop5.Text.Length != 0)
           // {
                if (cmbTop5.GetItemText(cmbTop5.SelectedItem).Equals("Especialidades con más cancelaciones"))
                {

                    //nueva instancia del formulario correspondiente

                    top5_cancelaciones frmCancelaciones = new top5_cancelaciones(anio, semestre);

                    this.DialogResult = DialogResult.Yes;
                    this.Hide();
                    frmCancelaciones.ShowDialog();
                    this.Close();

                }

                if (cmbTop5.GetItemText(cmbTop5.SelectedItem).Equals("Profesionales más consultados"))
                {

                    //nueva instancia del formulario correspondiente

                    top5_consultados frmConsultados = new top5_consultados(anio, semestre);

                    this.DialogResult = DialogResult.Yes;
                    this.Hide();
                    frmConsultados.ShowDialog();
                    this.Close();

                }

                if (cmbTop5.GetItemText(cmbTop5.SelectedItem).Equals("Profesionales más perezosos"))
                {

                    //nueva instancia del formulario correspondiente

                    top5_profesional_menos_horas frmPMenosHoras = new top5_profesional_menos_horas(anio, semestre);

                    this.DialogResult = DialogResult.Yes;
                    this.Hide();
                    frmPMenosHoras.ShowDialog();
                    this.Close();

                }

                if (cmbTop5.GetItemText(cmbTop5.SelectedItem).Equals("Afiliado con más bonos comprados"))
                {

                    //nueva instancia del formulario correspondiente

                    top5_afiliados frmAfiMasBonos = new top5_afiliados(anio, semestre);

                    this.DialogResult = DialogResult.Yes;
                    this.Hide();
                    frmAfiMasBonos.ShowDialog();
                    this.Close();

                }


                if (cmbTop5.GetItemText(cmbTop5.SelectedItem).Equals("Especialidades con más consultas"))
                {

                    //nueva instancia del formulario correspondiente

                    top5_especialidades frmEspMasConsultas = new top5_especialidades(anio, semestre);

                    this.DialogResult = DialogResult.Yes;
                    this.Hide();
                    frmEspMasConsultas.Show();
                    this.Close();
                }

           // }
            //else MessageBox.Show("Faltan elegir opciones de busqueda");
        }
    }
}
