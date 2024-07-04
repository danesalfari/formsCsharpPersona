namespace Persona
{
    partial class Form1
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
            this.btnCalcularEdad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnDefinirIMC = new System.Windows.Forms.Button();
            this.txtResultadoCalculoIMC = new System.Windows.Forms.TextBox();
            this.txtResultadoEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaNacimiento = new System.Windows.Forms.TextBox();
            this.txtMesNacimiento = new System.Windows.Forms.TextBox();
            this.txtAnoNacimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcularEdad
            // 
            this.btnCalcularEdad.Location = new System.Drawing.Point(343, 182);
            this.btnCalcularEdad.Name = "btnCalcularEdad";
            this.btnCalcularEdad.Size = new System.Drawing.Size(123, 23);
            this.btnCalcularEdad.TabIndex = 0;
            this.btnCalcularEdad.Text = "Calcular Edad";
            this.btnCalcularEdad.UseVisualStyleBackColor = true;
            this.btnCalcularEdad.Click += new System.EventHandler(this.btnCalcularEdad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 20);
            this.textBox4.TabIndex = 6;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(153, 277);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(106, 20);
            this.txtEstatura.TabIndex = 8;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(153, 321);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(106, 20);
            this.txtPeso.TabIndex = 9;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dia de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estatura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(41, 321);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 14;
            this.lblPeso.Text = "Peso";
            // 
            // btnDefinirIMC
            // 
            this.btnDefinirIMC.Location = new System.Drawing.Point(343, 297);
            this.btnDefinirIMC.Name = "btnDefinirIMC";
            this.btnDefinirIMC.Size = new System.Drawing.Size(123, 23);
            this.btnDefinirIMC.TabIndex = 16;
            this.btnDefinirIMC.Text = "Definir IMC";
            this.btnDefinirIMC.UseVisualStyleBackColor = true;
            this.btnDefinirIMC.Click += new System.EventHandler(this.btnDefinirIMC_Click);
            // 
            // txtResultadoCalculoIMC
            // 
            this.txtResultadoCalculoIMC.Location = new System.Drawing.Point(518, 299);
            this.txtResultadoCalculoIMC.Name = "txtResultadoCalculoIMC";
            this.txtResultadoCalculoIMC.Size = new System.Drawing.Size(124, 20);
            this.txtResultadoCalculoIMC.TabIndex = 17;
            // 
            // txtResultadoEdad
            // 
            this.txtResultadoEdad.Location = new System.Drawing.Point(514, 182);
            this.txtResultadoEdad.Name = "txtResultadoEdad";
            this.txtResultadoEdad.Size = new System.Drawing.Size(128, 20);
            this.txtResultadoEdad.TabIndex = 18;
            this.txtResultadoEdad.TextChanged += new System.EventHandler(this.txtResultadoEdad_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mes de Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Año de Nacimiento";
            // 
            // txtDiaNacimiento
            // 
            this.txtDiaNacimiento.Location = new System.Drawing.Point(514, 37);
            this.txtDiaNacimiento.Name = "txtDiaNacimiento";
            this.txtDiaNacimiento.Size = new System.Drawing.Size(126, 20);
            this.txtDiaNacimiento.TabIndex = 22;
            // 
            // txtMesNacimiento
            // 
            this.txtMesNacimiento.Location = new System.Drawing.Point(514, 84);
            this.txtMesNacimiento.Name = "txtMesNacimiento";
            this.txtMesNacimiento.Size = new System.Drawing.Size(126, 20);
            this.txtMesNacimiento.TabIndex = 23;
            // 
            // txtAnoNacimiento
            // 
            this.txtAnoNacimiento.Location = new System.Drawing.Point(514, 133);
            this.txtAnoNacimiento.Name = "txtAnoNacimiento";
            this.txtAnoNacimiento.Size = new System.Drawing.Size(128, 20);
            this.txtAnoNacimiento.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAnoNacimiento);
            this.Controls.Add(this.txtMesNacimiento);
            this.Controls.Add(this.txtDiaNacimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtResultadoEdad);
            this.Controls.Add(this.txtResultadoCalculoIMC);
            this.Controls.Add(this.btnDefinirIMC);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularEdad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnDefinirIMC;
        private System.Windows.Forms.TextBox txtResultadoCalculoIMC;
        private System.Windows.Forms.TextBox txtResultadoEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaNacimiento;
        private System.Windows.Forms.TextBox txtMesNacimiento;
        private System.Windows.Forms.TextBox txtAnoNacimiento;
    }
}

