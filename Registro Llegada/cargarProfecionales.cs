using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class cargarProfecionales : Form
    {
        Palabra especialidad = new Palabra();
        public cargarProfecionales(Palabra especialidad)
        {
            InitializeComponent();
        }

        private void cargarProfecionales_Load(object sender, EventArgs e)
        {

        }
    }
}
