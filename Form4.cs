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
    public partial class formpeso : Form
    {
        public formpeso()
        {
            InitializeComponent();
        }

        private void bttregreso_Click(object sender, EventArgs e)
        {
            Form frmprincipal = new FormPrincipal();
            this.Close();
            frmprincipal.Visible = true;
        }

        private void formpeso_Load(object sender, EventArgs e)
        {
            txtkilolibras.Enabled = false;
        }

        private void txtkilogramos_TextChanged(object sender, EventArgs e)
        {
            double kilogramos, respuesta;
            kilogramos = Convert.ToDouble(txtkilogramos.Text);
            respuesta = kilogramos * 2.205;
            txtkilolibras.Text = respuesta.ToString();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            Form frmprincipal = new FormPrincipal();
            this.Close();
            frmprincipal.Visible = true;
        }
    }
}
