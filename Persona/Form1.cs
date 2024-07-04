using Persona.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefinirIMC_Click(object sender, EventArgs e)
        {
            calcularImc();
        }
        public void calcularImc()
        {
            double peso = double.Parse(txtPeso.Text);
            double estatura = double.Parse(txtEstatura.Text);

            double imc = peso /  (estatura * estatura); 

            MessageBox.Show("El IMC Indice de masa corporal es de: " + imc);
            txtResultadoCalculoIMC.Text = imc.ToString();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            calcuEdad();
        }
        private void calcuEdad()
        {
            int year = int.Parse(txtAnoNacimiento.Text);
            int month = int.Parse(txtMesNacimiento.Text);
            int day = int.Parse(txtDiaNacimiento.Text);

            DateTime birthDate  = new DateTime(year, month, day);
            TimeSpan age = DateTime.Now.Subtract(birthDate);

            int years = (int)(age.TotalDays / 365.25);

            MessageBox.Show(" Tienes: " + years + " años. ");

           txtResultadoEdad.Text = years.ToString();

        }

        private void txtResultadoEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
