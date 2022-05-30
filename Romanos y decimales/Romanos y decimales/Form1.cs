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

namespace Romanos_y_decimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultado.Text = "";
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            Regex regexRomano = new Regex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
            Regex regexArabigo = new Regex("^[0-9]{1,4}$");
            if(regexRomano.IsMatch(txb1.Text))
            {
                lblResultado.Text = "En números decimales es: " + cadenaRomana(txb1.Text); 
            }            
            else if(regexArabigo.IsMatch(txb1.Text))
            {
                int.TryParse(txb1.Text, out int numDecimal);
                lblResultado.Text = "En numeros romanos es: " + conversionDecimales(numDecimal);
            }
            else
            {
                lblResultado.Text = "Error en el parametro introducido.";
            }
        }

        private int cadenaRomana(string numeroRomano)
        {
            int numero = 0;
            foreach (char letra in numeroRomano)
            {
                numero = numero + obtenerLetra(letra);
            }
            if(numeroRomano.Contains("IV") || numeroRomano.Contains("IX"))
            {
                numero -= 2;
            }
            if (numeroRomano.Contains("Xl") || numeroRomano.Contains("XC"))
            {
                numero -= 20;
            }
            if (numeroRomano.Contains("CD") || numeroRomano.Contains("CM"))
            {
                numero -= 200;
            }
            return numero;
        }

        private int obtenerLetra(char letra)
        {
            switch(letra)
            {
                case 'M': return 1000; break;
                case 'D': return 500; break;
                case 'C': return 100; break;
                case 'L': return 50; break;
                case 'X': return 10; break;
                case 'V': return 5; break;
                case 'I': return 1; break;
                default: return 0; break;
            }
        }

        private string conversionDecimales(int numeroDecimal)
        {
            if(numeroDecimal > 3999)
            {
                lblResultado.Text = "No hay número superiores al 3999";
            }
            else if(numeroDecimal >= 1000)
            {
                return "M" + conversionDecimales(numeroDecimal - 1000);
            }
            else if (numeroDecimal >= 900)
            {
                return "CM" + conversionDecimales(numeroDecimal - 900);
            }
            else if (numeroDecimal >= 500)
            {
                return "D" + conversionDecimales(numeroDecimal - 500);
            }
            else if (numeroDecimal >= 400)
            {
                return "CD" + conversionDecimales(numeroDecimal - 400);
            }
            else if (numeroDecimal >= 100)
            {
                return "C" + conversionDecimales(numeroDecimal - 100);
            }
            else if (numeroDecimal >= 90)
            {
                return "XC" + conversionDecimales(numeroDecimal - 90);
            }
            else if (numeroDecimal >= 50)
            {
                return "L" + conversionDecimales(numeroDecimal - 50);
            }
            else if (numeroDecimal >= 40)
            {
                return "XL" + conversionDecimales(numeroDecimal - 40);
            }
            else if (numeroDecimal >= 10)
            {
                return "X" + conversionDecimales(numeroDecimal - 10);
            }
            else if (numeroDecimal >= 9)
            {
                return "IX" + conversionDecimales(numeroDecimal - 9);
            }
            else if (numeroDecimal >= 5)
            {
                return "V" + conversionDecimales(numeroDecimal - 5);
            }
            else if (numeroDecimal >= 4)
            {
                return "IV" + conversionDecimales(numeroDecimal - 4);
            }
            else if (numeroDecimal >= 1)
            {
                return "I" + conversionDecimales(numeroDecimal - 1);
            }
            else if(numeroDecimal < 1)
            {
                return "";
            }
            return "Error";
        }
    }
}
