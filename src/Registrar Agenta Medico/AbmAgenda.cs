using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class AbmAgenda : Form
    {
        String usernameProfesional = Program.usuario;
        BDComun conexion = new BDComun();

        public AbmAgenda()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DiaDeBaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void MesDeBaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void AnioDeBaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AbmAgenda_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

            conexion.obtenerEspecialidadesDelProf(Program.usuario, textoEspecialidad);

            dateTimePicker1.Value = Program.fecha;
            dateTimePicker2.Value = Program.fecha;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            int agendaId;
            if (textoEspecialidad.Text.Length == 0)
            {
                MessageBox.Show("Selecciona una especialidad");
            }
            else
            {
                if (desdeLunes.Value > hastaLunes.Value && desdeMartes.Value > hastaMartes.Value && desdeMiercoles.Value > hastaMiercoles.Value && desdeJueves.Value > hastaJueves.Value && desdeViernes.Value > HastaViernes.Value && desdeSabado.Value > hastaSabado.Value && desdeDomingo.Value > hastaDomingo.Value)
                {
                    MessageBox.Show("Horario/s mal asignado/s");
                }
                else
                {
                    if (botonLunes.Checked == false && botonMartes.Checked == false && botonMiercoles.Checked == false && botonJueves.Checked == false && botonViernes.Checked == false && botonSabado.Checked == false && botonDomingo.Checked == false)
                    {
                        MessageBox.Show("Agrega algún dia");
                    }
                    else
                    {
                        if (conexion.yaExisteAgendaParaElIntervalo(usernameProfesional, dateTimePicker1.Value, dateTimePicker2.Value))
                        {
                            MessageBox.Show("Ya existe agenda para ese intervalo en el profesional");
                        }
                        else
                        {
                            if (dateTimePicker2.Value < dateTimePicker1.Value)
                            {
                                MessageBox.Show("El dia de vigencia final es menor al dia de vigencia inicial");
                            }
                            else
                            {
                                agendaId = conexion.generarAgenda(usernameProfesional, dateTimePicker1.Value, dateTimePicker2.Value, textoEspecialidad.Text);
                                if (botonLunes.Checked == true)
                                {
                                    conexion.generarDia("Lunes", Convert.ToString(desdeLunes.Value) + ":00:00", Convert.ToString(hastaLunes.Value) + ":00:00", agendaId);
                                }
                                if (botonMartes.Checked == true)
                                {
                                    conexion.generarDia("Martes", Convert.ToString(desdeMartes.Value) + ":00:00", Convert.ToString(hastaMartes.Value) + ":00:00", agendaId);
                                }
                                if (botonMiercoles.Checked == true)
                                {
                                    conexion.generarDia("Miercoles", Convert.ToString(desdeMiercoles.Value) + ":00:00", Convert.ToString(hastaMiercoles.Value) + ":00:00", agendaId);
                                }
                                if (botonJueves.Checked == true)
                                {
                                    conexion.generarDia("Jueves", Convert.ToString(desdeJueves.Value) + ":00:00", Convert.ToString(hastaJueves.Value) + ":00:00", agendaId);
                                }
                                if (botonViernes.Checked == true)
                                {
                                    conexion.generarDia("Viernes", Convert.ToString(desdeViernes.Value) + ":00:00", Convert.ToString(HastaViernes.Value) + ":00:00", agendaId);
                                }
                                if (botonSabado.Checked == true)
                                {
                                    conexion.generarDia("Sabado", Convert.ToString(desdeSabado.Value) + ":00:00", Convert.ToString(hastaSabado.Value) + ":00:00", agendaId);
                                }
                                if (botonDomingo.Checked == true)
                                {
                                    conexion.generarDia("Domingo", Convert.ToString(desdeDomingo.Value) + ":00:00", Convert.ToString(hastaDomingo.Value) + ":00:00", agendaId);
                                }
                                MessageBox.Show("AGENDA CREADA CON ÉXITO");
                                AbmRol.AbmRolProfesional abmRolProfesional = new AbmRol.AbmRolProfesional();
                                this.Hide();
                                abmRolProfesional.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            AbmRol.AbmRolProfesional abmRolProfesional = new AbmRol.AbmRolProfesional();
            this.Hide();
            abmRolProfesional.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void desdeLunes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hastaLunes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void desdeMartes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hastaMartes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void desdeSabado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hastaMiercoles_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hastaJueves_ValueChanged(object sender, EventArgs e)
        {

        }

        private void desdeJueves_ValueChanged(object sender, EventArgs e)
        {

        }

        private void desdeViernes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HastaViernes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hastaSabado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void desdeMiercoles_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hastaDomingo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void desdeDomingo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textoEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
