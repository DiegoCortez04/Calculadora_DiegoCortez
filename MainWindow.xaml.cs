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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            char operador;
            double num1,num2;
        }

        private void BtnN0_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 0;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw(new Exception("ERROR"));
            }
        }

        private void BtnN1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 1;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnN2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 2;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnN3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 3;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnN4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 4;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnN5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 5;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnN6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 6;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnN7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 7;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnN8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 8;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnN9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valor = 9;
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                char valor = '.';
                TxtBoxResul.Text += valor.ToString();
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnBorrarN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TxtBoxResul.Text = "";
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TxtBoxResul.Text = "";
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnSuma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                operador = '+';
                num1 = double.Parse(TxtBoxResul.Text);
                TxtBoxResul.Text = "";
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }

        private void BtnResul_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double result = 0;
                switch (operador)
                {
                    case '+':
                        result = suma.ToString(); 
                        break;
                }
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }
    }
}
