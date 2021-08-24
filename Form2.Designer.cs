
namespace Ejercicio2Guia2_MM200149
{
    partial class formtemp
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
            this.txtcelsius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcelsiusfaren = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttregreso
            // 
            this.bttregreso.Location = new System.Drawing.Point(184, 223);
            this.bttregreso.Name = "bttregreso";
            this.bttregreso.Size = new System.Drawing.Size(131, 41);
            this.bttregreso.TabIndex = 0;
            this.bttregreso.Text = "Regresar";
            this.bttregreso.UseVisualStyleBackColor = true;
            this.bttregreso.Click += new System.EventHandler(this.bttregreso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para transformar Celsius a Farenheit";
            // 
            // txtcelsius
            // 
            this.txtcelsius.Location = new System.Drawing.Point(114, 97);
            this.txtcelsius.Name = "txtcelsius";
            this.txtcelsius.Size = new System.Drawing.Size(143, 20);
            this.txtcelsius.TabIndex = 2;
            this.txtcelsius.TextChanged += new System.EventHandler(this.txtcelsius_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserte los grados Celsius a transformar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Los grados °C a °F son:";
            // 
            // txtcelsiusfaren
            // 
            this.txtcelsiusfaren.Location = new System.Drawing.Point(114, 170);
            this.txtcelsiusfaren.Name = "txtcelsiusfaren";
            this.txtcelsiusfaren.Size = new System.Drawing.Size(143, 20);
            this.txtcelsiusfaren.TabIndex = 6;
            this.txtcelsiusfaren.TextChanged += new System.EventHandler(this.txtcelsiusfaren_TextChanged);
            // 
            // formtemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(376, 275);
            this.Controls.Add(this.txtcelsiusfaren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcelsius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttregreso);
            this.Name = "formtemp";
            this.Text = "Convirtiendo Temperaturas...";
            this.Load += new System.EventHandler(this.formtemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttregreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcelsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcelsiusfaren;
    }
}