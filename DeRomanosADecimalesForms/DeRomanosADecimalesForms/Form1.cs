using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeRomanosADecimalesForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl2.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3}$)");
            string numeroRomano = textBox1.Text;
            numeroRomano.ToUpper();

            if(rbtnRomanos.Checked == true)
            {
                if (regex.IsMatch(numeroRomano))
                {
                    int arabigo = CadenaRomana(numeroRomano);
                    lbl2.Text = "El resultado es : " + arabigo;
                }
                else
                {
                    lbl2.Text = "El resultado es : Número erroneo o fuera de rango";
                }
            } 
            else
            {
                int.TryParse(textBox1.Text, out int arabigo);
                if (arabigo > 0 && arabigo < 4000)
                {
                    int.TryParse(textBox1.Text, out int numeroDecimal);
                    lbl2.Text = "El resultado es : " + ConversionRomanos(numeroDecimal);
                }
                else
                {
                    lbl2.Text = "El resultado es : caca";
                }                                   
            }
        }
        private int CadenaRomana(string cadenaRomana)
        {
            int numero = 0;
            foreach (char letra in cadenaRomana)
            {
                numero = numero + obtenerLetra(Convert.ToChar(letra));
            }
            if (cadenaRomana.Contains("IV") || cadenaRomana.Contains("IX"))
            {
                numero -= 2;
            }
            if (cadenaRomana.Contains("XL") || cadenaRomana.Contains("XC"))
            {
                numero -= 20;
            }
            if (cadenaRomana.Contains("CD") || cadenaRomana.Contains("CM"))
            {
                numero -= 200;
            }
            return numero;
        }

        private int obtenerLetra(char letra)
        {
            switch (letra)
            {
                case 'I': return 1; break;
                case 'V': return 5; break;
                case 'X': return 10; break;
                case 'L': return 50; break;
                case 'C': return 100; break;
                case 'D': return 500; break;
                case 'M': return 1000; break;
                default: return 0; break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ConversionRomanos(int numeroDecimal)
        {
            if (numeroDecimal > 3999)
            {
                return "No hay numeros romanos mayores de 3999";
            }
            else if (numeroDecimal >= 1000)
            {
                return "M" + ConversionRomanos(numeroDecimal - 1000);
            }
            else if (numeroDecimal >= 900)
            {
                return "CM" + ConversionRomanos(numeroDecimal - 900);
            }
            else if (numeroDecimal >= 500)
            {
                return "D" + ConversionRomanos(numeroDecimal - 500);
            }
            else if (numeroDecimal >= 400)
            {
                return "CD" + ConversionRomanos(numeroDecimal - 400);
            }
            else if (numeroDecimal >= 100)
            {
                return "C" + ConversionRomanos(numeroDecimal - 100);
            }
            else if (numeroDecimal >= 90)
            {
                return "XC" + ConversionRomanos(numeroDecimal - 90);
            }
            else if (numeroDecimal >= 50)
            {
                return "L" + ConversionRomanos(numeroDecimal - 50);
            }
            else if (numeroDecimal >= 40)
            {
                return "XL" + ConversionRomanos(numeroDecimal - 40);
            }
            else if (numeroDecimal >= 10)
            {
                return "X" + ConversionRomanos(numeroDecimal - 10);
            }
            else if (numeroDecimal >= 9)
            {
                return "IX" + ConversionRomanos(numeroDecimal - 9);
            }
            else if (numeroDecimal >= 5)
            {
                return "V" + ConversionRomanos(numeroDecimal - 5);
            }
            else if (numeroDecimal >= 4)
            {
                return "IV" + ConversionRomanos(numeroDecimal - 4);
            }
            else if (numeroDecimal >= 1)
            {
                return "I" + ConversionRomanos(numeroDecimal - 1);
            }
            else if (numeroDecimal < 1)
            {
                return "";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
