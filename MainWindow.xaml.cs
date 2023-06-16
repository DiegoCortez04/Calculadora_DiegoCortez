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
        }

        private void BtnN0_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HandleNumbers("0");
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
                HandleNumbers("1");
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
                HandleNumbers("2");
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
                HandleNumbers("3");
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
                HandleNumbers("4");
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
                HandleNumbers("5");
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
                HandleNumbers("6");
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
                HandleNumbers("7");
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
                HandleNumbers("8");
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
                
            }
            catch (Exception)
            {

                throw (new Exception("ERROR"));
            }
        }
        private void HandleNumbers(string value)
        {
            if (String.IsNullOrEmpty(TxtBoxResul.Text))
            {
                TxtBoxResul.Text = value;
            }
            else
            {
                TxtBoxResul.Text += value;
            }
        }
        private bool IsOperator(string PosOperador)
        {
            if (PosOperador == "+" || PosOperador == "-" || PosOperador == "*" || PosOperador == "/")
            {
                return true;
            }
            return false;
            return PosOperador == "+" || PosOperador == "-" || PosOperador == "*" || PosOperador == "/";
        }
        private void HandleOperators(string value)
        {
            if (!String.IsNullOrEmpty(TxtBoxResul.Text))
            {
                TxtBoxResul.Text += value;
            }
        }

    }
}
