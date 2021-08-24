
namespace Ejercicio2Guia2_MM200149
{
    partial class formlong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmetros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmetrospies = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttregreso
            // 
            this.bttregreso.Location = new System.Drawing.Point(190, 230);
            this.bttregreso.Name = "bttregreso";
            this.bttregreso.Size = new System.Drawing.Size(131, 41);
            this.bttregreso.TabIndex = 1;
            this.bttregreso.Text = "Regresar";
            this.bttregreso.UseVisualStyleBackColor = true;
            this.bttregreso.Click += new System.EventHandler(this.bttregreso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para transformar Metros a pies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese los metros a transformar";
            // 
            // txtmetros
            // 
            this.txtmetros.Location = new System.Drawing.Point(93, 101);
            this.txtmetros.Name = "txtmetros";
            this.txtmetros.Size = new System.Drawing.Size(143, 20);
            this.txtmetros.TabIndex = 5;
            this.txtmetros.TextChanged += new System.EventHandler(this.txtmetros_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Los metros a pies son:";
            // 
            // txtmetrospies
            // 
            this.txtmetrospies.Location = new System.Drawing.Point(93, 172);
            this.txtmetrospies.Name = "txtmetrospies";
            this.txtmetrospies.Size = new System.Drawing.Size(143, 20);
            this.txtmetrospies.TabIndex = 7;
            this.txtmetrospies.TextChanged += new System.EventHandler(this.txtcelsiusfaren_TextChanged);
            // 
            // formlong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(333, 283);
            this.Controls.Add(this.txtmetrospies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmetros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttregreso);
            this.Name = "formlong";
            this.Text = "Convirtiendo Longitudes...";
            this.Load += new System.EventHandler(this.formlong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttregreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmetros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmetrospies;
    }
}