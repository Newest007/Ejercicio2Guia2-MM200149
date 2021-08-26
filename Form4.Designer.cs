
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkilogramos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkilolibras = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para transformar de kilogramos a libras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese los kilogramos a transformar";
            // 
            // txtkilogramos
            // 
            this.txtkilogramos.Location = new System.Drawing.Point(116, 85);
            this.txtkilogramos.Name = "txtkilogramos";
            this.txtkilogramos.Size = new System.Drawing.Size(143, 20);
            this.txtkilogramos.TabIndex = 6;
            this.txtkilogramos.TextChanged += new System.EventHandler(this.txtkilogramos_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Los kilogramos a libras son:";
            // 
            // txtkilolibras
            // 
            this.txtkilolibras.Location = new System.Drawing.Point(116, 151);
            this.txtkilolibras.Name = "txtkilolibras";
            this.txtkilolibras.Size = new System.Drawing.Size(143, 20);
            this.txtkilolibras.TabIndex = 8;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Location = new System.Drawing.Point(237, 185);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(125, 43);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "Regresar";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // formpeso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(179)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(374, 240);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtkilolibras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtkilogramos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formpeso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convirtiendo Pesos...";
            this.Load += new System.EventHandler(this.formpeso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkilogramos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkilolibras;
        private System.Windows.Forms.Button btnsalir;
    }
}