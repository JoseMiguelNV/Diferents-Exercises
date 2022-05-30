using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculo_de_llenado__WPS_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblResultado.Content = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cmbx1.Text = "Seleccionar";
            cmbx2.Text = "Seleccionar";
            txb1.Text = "";
            txb2.Text = "";
            lblResultado.Content = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double.TryParse(txb1.Text, out double caudal);
            double.TryParse(txb2.Text, out double tamanyoDeposito);
            double total, milisegundos;
            long horas;
            int minutos, segundos;


            if (cmbx1.SelectedIndex == -1 || cmbx2.SelectedIndex == -1)
            {
                lblResultado.Content = "Debe seleccionar el caudal y el tamaño.";
            }
            else if (txb1.Text == "0" || txb2.Text == "0" || txb1.Text.Contains("") || txb2.Text.Contains(""))
            {
                lblResultado.Content = "Debe introducir valores superiores a 0 en ambos campos, no puede haber campos vacíos..";
            }
            if (cmbx1.SelectedIndex == 1)
            {
                caudal *= 1000;
            }
            if (cmbx1.SelectedIndex == 2)
            {
                caudal *= 1000000;
            }
            if (cmbx2.SelectedIndex == 1)
            {
                tamanyoDeposito *= 1000;
            }
            if (cmbx2.SelectedIndex == 2)
            {
                tamanyoDeposito *= 1000000;
            }

            total = tamanyoDeposito / caudal * 1000;
            horas = (long)(total / 1000 / 60 / 60); 
            minutos = (int)(total / 1000 / 60 % 60);
            segundos = (int)(total / 1000 % 60);
            milisegundos = total % 1000;

            if (total > 0)
            {
                lblResultado.Content = $"El tiempo estimado de llenado es: {horas} horas, {minutos} minutos, {segundos} segundos y {milisegundos} milisegundos.";
            }
           




            //double total = tamanyoDeposito / caudal;
            //int tiempoTotal = (int)total;
            //horas = tiempoTotal / 3600;
            //minutos = (tiempoTotal % 3600) / 60;
            //segundos = (tiempoTotal % 3600) % 60;

            //if (segundos >= 1)
            //{
            //    //lblResultado.Content = $"El tiempo estimado de llenado es: {horas} horas, {minutos} minutos y {segundos} segundos.";
            //    lblResultado.Content = $"El tiempo estimado de llenado es: {horas} horas, {minutos} minutos, {segundos} segundos y {milisegundos} milisegundos.";

            //}
            //else
            //{
            //    lblResultado.Content = "El tiempo estimado de llenado es: Inferior a 1 minuto.";
            //}









        }
    }
}
