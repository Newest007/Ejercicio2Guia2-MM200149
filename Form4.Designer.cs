﻿
namespace Ejercicio2Guia2_MM200149
{
    partial class formpeso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttregreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttregreso
            // 
            this.bttregreso.Location = new System.Drawing.Point(327, 167);
            this.bttregreso.Name = "bttregreso";
            this.bttregreso.Size = new System.Drawing.Size(131, 41);
            this.bttregreso.TabIndex = 2;
            this.bttregreso.Text = "Regresar";
            this.bttregreso.UseVisualStyleBackColor = true;
            this.bttregreso.Click += new System.EventHandler(this.bttregreso_Click);
            // 
            // formpeso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 220);
            this.Controls.Add(this.bttregreso);
            this.Name = "formpeso";
            this.Text = "Convirtiendo Pesos...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttregreso;
    }
}