using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_tiempo_de_llenado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl3.Text = "";

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            double tiempoLlenadoDoble = 0;
            int tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
            int horas = tiempoLlenadoEntero / 3600;
            int minutos = (tiempoLlenadoEntero % 3600) / 60;
            int segundos = (tiempoLlenadoEntero % 3600) % 60;
            string caudal = comboBox1.SelectedItem.ToString();
            string deposito = comboBox2.SelectedItem.ToString();
            double numCaulal = Convert.ToDouble(textBox1.Text);
            double tamanyoDeposito = Convert.ToDouble(textBox2.Text);
  
            switch (caudal)
            {
                case "cm3/seg":

                    if(deposito == "cm3")
                    {
                        tiempoLlenadoDoble = tamanyoDeposito / numCaulal;
                        tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
                        horas = tiempoLlenadoEntero / 3600;
                        minutos = (tiempoLlenadoEntero % 3600) / 60;
                        segundos = (tiempoLlenadoEntero % 3600) % 60;
                    }
                    else if(deposito == "dm3")
                    {
                        tiempoLlenadoDoble = (tamanyoDeposito * 1000) / numCaulal;
                        tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
                        horas = tiempoLlenadoEntero / 3600;
                        minutos = (tiempoLlenadoEntero % 3600) / 60;
                        segundos = (tiempoLlenadoEntero % 3600) % 60;
                    }
                    else 
                    {
                        tiempoLlenadoDoble = (tamanyoDeposito * 1000000) / numCaulal;
                        tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
                        horas = tiempoLlenadoEntero / 3600;
                        minutos = (tiempoLlenadoEntero % 3600) / 60;
                        segundos = (tiempoLlenadoEntero % 3600) % 60;
                    }
                    break;

                case "dm3/seg":
               
                    if (deposito == "cm3")
                    {
                        tiempoLlenadoDoble = tamanyoDeposito / (numCaulal * 1000);
                        tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
                        horas = tiempoLlenadoEntero / 3600;
                        minutos = (tiempoLlenadoEntero % 3600) / 60;
                        segundos = (tiempoLlenadoEntero % 3600) % 60;
                    }
                    else if (deposito == "dm3")
                    {
                        tiempoLlenadoDoble = tamanyoDeposito / numCaulal;
                        tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
                        horas = tiempoLlenadoEntero / 3600;
                        minutos = (tiempoLlenadoEntero % 3600) / 60;
                        segundos = (tiempoLlenadoEntero % 3600) % 60;
                    }
                    else 
                    {
                        tiempoLlenadoDoble = (tamanyoDeposito * 1000) / numCaulal;
                        tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
                        horas = tiempoLlenadoEntero / 3600;
                        minutos = (tiempoLlenadoEntero % 3600) / 60;
                        segundos = (tiempoLlenadoEntero % 3600) % 60;
                    }
                    break;

                case "m3/seg":
                   
                    if (deposito == "cm3")
                    {
                        tiempoLlenadoDoble = tamanyoDeposito / (numCaulal * 1000000);
                        tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
                        horas = tiempoLlenadoEntero / 3600;
                        minutos = (tiempoLlenadoEntero % 3600) / 60;
                        segundos = (tiempoLlenadoEntero % 3600) % 60;
                    }
                    else if (deposito == "dm3")
                    {
                        tiempoLlenadoDoble = tamanyoDeposito / (numCaulal * 1000);
                        tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
                        horas = tiempoLlenadoEntero / 3600;
                        minutos = (tiempoLlenadoEntero % 3600) / 60;
                        segundos = (tiempoLlenadoEntero % 3600) % 60;
                    }
                    else
                    {
                        tiempoLlenadoDoble = tamanyoDeposito / numCaulal;
                        tiempoLlenadoEntero = (int)tiempoLlenadoDoble;
                        horas = tiempoLlenadoEntero / 3600;
                        minutos = (tiempoLlenadoEntero % 3600) / 60;
                        segundos = (tiempoLlenadoEntero % 3600) % 60;
                    }
                    break;
                default:
                    break;

            }
            if (segundos >= 1)
            {
                lbl3.Text = "Tiempo estimado requerido para el llenado: " + horas + " horas, " + minutos + " minutos, y " + segundos + " segundos.";
            }
            else
            {
                lbl3.Text = "Tiempo estimado requerido para el llenado: Menos de un segundo.";
            }
            

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            lbl3.Text = "";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
