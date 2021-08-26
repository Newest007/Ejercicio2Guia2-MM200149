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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form frmtemperatura = new formtemp();
            this.Visible = false;
            frmtemperatura.Visible = true;
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form frmlongitudes = new formlong();
            this.Visible = false;
            frmlongitudes.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmpeso = new formpeso();
            this.Visible = false;
            frmpeso.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
