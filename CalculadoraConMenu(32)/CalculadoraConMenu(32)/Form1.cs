using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraConMenu_32_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa calculadora con menú");
        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txb1.Text, out float numero1) || !float.TryParse(txb2.Text, out float numero2))
            {
                lbl1.Text = "Valores incorrectos";
            }
            else
            {
                float suma = numero1 + numero2;
                lbl1.Text = Convert.ToString(suma);
            }
        }

        private void restarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txb1.Text, out float numero1) || !float.TryParse(txb2.Text, out float numero2))
            {
                lbl1.Text = "Valores incorrectos";
            }
            else
            {
                float resta = numero1 - numero2;
                lbl1.Text = Convert.ToString(resta);
            }
        }

        private void multiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txb1.Text, out float numero1) || !float.TryParse(txb2.Text, out float numero2))
            {
                lbl1.Text = "Valores incorrectos";
            }
            else
            {
                float multiplicacion = numero1 * numero2;
                lbl1.Text = Convert.ToString(multiplicacion);
            }
        }

        private void dividirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txb1.Text, out float numero1) || !float.TryParse(txb2.Text, out float numero2))
            {
                lbl1.Text = "Valores incorrectos";
            }
            else
            {
                if (numero2 == 0)
                {
                    lbl1.Text = "No se puede dividir entre 0.";
                }
                else
                {
                    float suma = numero1 / numero2;
                    lbl1.Text = Convert.ToString(suma);
                }
            }
        }
    }
}
