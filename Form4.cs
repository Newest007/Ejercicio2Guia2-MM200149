﻿using System;
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
    }
}
