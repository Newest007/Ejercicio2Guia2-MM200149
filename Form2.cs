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

    public partial class formtemp : Form
    {
        public formtemp()
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

        private void formtemp_Load(object sender, EventArgs e)
        {
            txtcelsiusfaren.Enabled = false;
            
        }

        private void txtcelsius_TextChanged(object sender, EventArgs e)
        {
            double celsius, respuesta;
            celsius = Convert.ToDouble(txtcelsius.Text);

            respuesta = (celsius * 9 / 5) + 32;
            txtcelsiusfaren.Text = respuesta.ToString();

        }

     

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form frmprincipal = new FormPrincipal();
            this.Close();
            frmprincipal.Visible = true;
        }
    }
}
