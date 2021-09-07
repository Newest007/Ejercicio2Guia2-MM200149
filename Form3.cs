using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Guia2_MM200149
{
    public partial class formlong : Form
    {
        public formlong()
        {
            InitializeComponent();
        }

        private void bttregreso_Click(object sender, EventArgs e)
        {
            Form frmprincipal = new FormPrincipal();
            this.Close();
            frmprincipal.Visible = true;
        }

        private void txtcelsiusfaren_TextChanged(object sender, EventArgs e)
        {

        }

        private void formlong_Load(object sender, EventArgs e)
        {
            txtmetrospies.Enabled = false;
        }

        private void txtmetros_TextChanged(object sender, EventArgs e)
        {
            double metros, respuesta;
            metros = Convert.ToDouble(txtmetros.Text);
            respuesta = (metros * 3.28084);

            txtmetrospies.Text = respuesta.ToString();

            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form frmprincipal = new FormPrincipal();
            this.Close();
            frmprincipal.Visible = true;
        }
    }
}
