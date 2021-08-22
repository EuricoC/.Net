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
using System.Xml.Schema;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private string result = null;
        private string number1 = null;
        private string number2 = null;
        private string operation = null;
        private float Fnumber1 = 0;
        private float Fnumber2 = 0;
        private float Fresult = 0;
        private double Dnumber = 0;
        private bool statement;


        public MainWindow()
        {
            InitializeComponent();
        }

        //numbers---------------------------------------------------
        private void B0_Click(object sender, RoutedEventArgs e)
        {
            number1 += "0";
            result = number1;
            Tresult.Text = number1;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            number1 += "1";
            result = number1;
            Tresult.Text = number1;
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            number1 += "2";
            result = number1;
            Tresult.Text = number1;
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            number1 += "3";
            result = number1;
            Tresult.Text = number1;
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            number1 += "4";
            result = number1;
            Tresult.Text = number1;
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            number1 += "5";
            result = number1;
            Tresult.Text = number1;
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            number1 += "6";
            result = number1;
            Tresult.Text = number1;
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            number1 += "7";
            result = number1;
            Tresult.Text = number1;
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            number1 += "8";
            result = number1;
            Tresult.Text = number1;
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            number1 += "9";
            result = number1;
            Tresult.Text = number1;
        }

        //operations

        private void Bmod_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (operation != null)
            {
                statement = Equals();
                if (statement == false) return;
                operation = "%";
                TfullEquation.Text += " " + operation;
                return;
            }

            if (number1 == null && result != null)
            {
                operation = "%";
                TfullEquation.Text += " " + operation;
                return;
            }

            if (number1 == null) return;
            operation = "%";
            TfullEquation.Text += " " + number1 + " " + operation;
            number2 = number1;
            number1 = null;
        }

        private void BclearE_Click(object sender, RoutedEventArgs e)
        {
            number1 = null;
            Tresult.Text = "";
        }

        private void Bclear_Click(object sender, RoutedEventArgs e)
        {
            Tresult.Text = "";
            TfullEquation.Text = "";
            number1 = null;
            number2 = null;
            operation = null;
            result = null;
        }

        private void Bback_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null) return;
            number1 = number1.Remove(number1.Length - 1);
            Tresult.Text = number1;
        }

        private void Bfraction_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (number1 == null && number2 != null)
            {
                Fnumber1 = float.Parse(number2);
                Fnumber1 = 1 / Fnumber1;
                result = Fnumber1.ToString();

                Tresult.Text = result;
                TfullEquation.Text = "1/" + number2;
                number2 = result;
                return;
            }

            if (number1 == null && result != null)
            {
                if (number1 == null) return;
                Fnumber1 = float.Parse(result);
                Fnumber1 = 1 / Fnumber1;
                result = Fnumber1.ToString();

                Tresult.Text = result;
                TfullEquation.Text += "1/" + result;
                number2 = result;
                number1 = null;
                operation = null;
                return;
            }

            if (number1 == null) return;
            Fnumber1 = float.Parse(number1);
            Fnumber1 = 1 / Fnumber1;
            result = Fnumber1.ToString();

            Tresult.Text = result;
            TfullEquation.Text += "1/" + number1;
            number2 = result;
            number1 = null;
            operation = null;
        }

        private void Bsquare_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (number1 == null && number2 != null)
            {
                Dnumber = double.Parse(number2);
                Dnumber = Math.Pow(Dnumber, 2);
                result = Dnumber.ToString();

                Tresult.Text = result;
                TfullEquation.Text = number2 + "²";
                number2 = result;
                return;
            }

            if (number1 == null && result != null)
            {
                Dnumber = double.Parse(result);
                Dnumber = Math.Pow(Dnumber, 2);
                result = Dnumber.ToString();

                Tresult.Text = result;
                TfullEquation.Text += result + "²";
                number2 = result;
                number1 = null;
                operation = null;
                return;
            }

            if (number1 == null) return;
            Dnumber = double.Parse(number1);
            Dnumber = Math.Pow(Dnumber, 2);
            result = Dnumber.ToString();

            Tresult.Text = result;
            TfullEquation.Text += number1 + "²";
            number2 = result;
            number1 = null;
            operation = null;
        }

        private void Broot_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (number1 == null && number2 != null)
            {
                Dnumber = double.Parse(number2);
                Dnumber = Math.Sqrt(Dnumber);
                result = Dnumber.ToString();

                Tresult.Text = result;
                TfullEquation.Text = "sqrt(" + number2 + ")";
                number2 = result;
                return;
            }

            if (number1 == null && result != null)
            {
                if (number1 == null) return;
                Dnumber = double.Parse(result);
                Dnumber = Math.Sqrt(Dnumber);
                result = Dnumber.ToString();

                Tresult.Text = result;
                TfullEquation.Text += "sqrt(" + result + ")";
                number2 = result;
                number1 = null;
                operation = null;
            }

            if (number1 == null) return;
            Dnumber = double.Parse(number1);
            Dnumber = Math.Sqrt(Dnumber);
            result = Dnumber.ToString();

            Tresult.Text = result;
            TfullEquation.Text += "sqrt(" + number2 + ")";
            number2 = result;
            number1 = null;
            operation = null;
        }

        private void Bdivide_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (operation != null)
            {
                statement = Equals();
                if (statement == false) return;
                operation = "/";
                TfullEquation.Text += " " + operation;
                return;
            }

            if (number1 == null && result != null)
            {
                operation = "/";
                TfullEquation.Text += " " + operation;
            }

            if (number1 == null) return;
            operation = "/";
            TfullEquation.Text += " " + number1 + " " + operation;
            number2 = number1;
            number1 = null;
        }

        private void Bmultiply_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (operation != null)
            {
                statement = Equals();
                if (statement == false) return;
                operation = "*";
                TfullEquation.Text += " " + operation;
                return;
            }

            if (number1 == null && result != null)
            {
                operation = "*";
                TfullEquation.Text += " " + operation;
            }

            if (number1 == null) return;
            operation = "*";
            TfullEquation.Text += " " + number1 + " " + operation;
            number2 = number1;
            number1 = null;
        }

        private void Bminus_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (operation != null)
            {
                statement = Equals();
                if (statement == false) return;
                operation = "-";
                TfullEquation.Text += " " + operation;
                return;
            }

            if (number1 == null && result != null)
            {
                operation = "-";
                TfullEquation.Text += " " + operation;
            }

            if (number1 == null) return;
            operation = "-";
            TfullEquation.Text += " " + number1 + " " + operation;
            number2 = number1;
            number1 = null;
        }

        private void Bplus_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (operation != null)
            {
                statement = Equals();
                if (statement == false) return;
                operation = "+";
                TfullEquation.Text += " " + operation;
                return;
            }

            if (number1 == null && result != null)
            {
                operation = "+";
                TfullEquation.Text += " " + operation;
            }

            if (number1 == null) return;
            operation = "+";
            TfullEquation.Text += " " + number1 + " " + operation;
            number2 = number1;
            number1 = null;
        }

        private void Bequals_Click(object sender, RoutedEventArgs e)
        {
            Equals();
        }

        private void Bperiod_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (number1 == null && number2 != null)
            {
                if (number2.EndsWith(".") || number2.Contains(".") || number2.Contains("/")) return;

                number2 += ".";
                Tresult.Text = number2;
            }

            if (number1 == null || number1.Contains(".") || number1.Contains("/")) return;
            number1 += ".";
            Tresult.Text = number1;
        }

        private void BvalueChange_Click(object sender, RoutedEventArgs e)
        {
            if (number1 == null && number2 == null) return;

            if (number1 == null && number2 != null)
            {
                Dnumber = double.Parse(number2);
                Dnumber = Dnumber * -1;
                result = Dnumber.ToString();

                Tresult.Text = result;
                TfullEquation.Text = number2;
                number2 = result;
            }

            if (number1 == null) return;
            Dnumber = double.Parse(number1);
            Dnumber = Dnumber * -1;
            result = Dnumber.ToString();

            Tresult.Text = result;
            TfullEquation.Text += number1;
            number2 = result;
            number1 = null;
        }

        //equals operation

        private bool Equals()
        {
            if (number1 == null && number2 == null) return false;

            if (number1 != null)
            {
                switch (operation)
                {
                    case "%":
                        Fnumber1 = float.Parse(number1);
                        Fnumber2 = float.Parse(number2);
                        Fresult = Fnumber2 % Fnumber1;

                        result = Fresult.ToString();
                        number2 = result;
                        Tresult.Text = result;
                        TfullEquation.Text += " " + number1;
                        number1 = null;
                        operation = null;
                        break;
                    case "/":
                        Fnumber1 = float.Parse(number1);
                        Fnumber2 = float.Parse(number2);
                        Fresult = Fnumber2 / Fnumber1;

                        result = Fresult.ToString();
                        number2 = result;
                        Tresult.Text = result;
                        TfullEquation.Text += " " + number1;
                        number1 = null;
                        operation = null;
                        break;
                    case "*":
                        Fnumber1 = float.Parse(number1);
                        Fnumber2 = float.Parse(number2);
                        Fresult = Fnumber2 * Fnumber1;

                        result = Fresult.ToString();
                        number2 = result;
                        Tresult.Text = result;
                        TfullEquation.Text += " " + number1;
                        number1 = null;
                        operation = null;
                        break;
                    case "-":
                        Fnumber1 = float.Parse(number1);
                        Fnumber2 = float.Parse(number2);
                        Fresult = Fnumber2 - Fnumber1;

                        result = Fresult.ToString();
                        number2 = result;
                        Tresult.Text = result;
                        TfullEquation.Text += " " + number1;
                        number1 = null;
                        operation = null;
                        break;
                    case "+":
                        Fnumber1 = float.Parse(number1);
                        Fnumber2 = float.Parse(number2);
                        Fresult = Fnumber2 + Fnumber1;

                        result = Fresult.ToString();
                        number2 = result;
                        Tresult.Text = result;
                        TfullEquation.Text += " " + number1;
                        number1 = null;
                        operation = null;
                        break;
                }

                return true;
            }

            if (result == null) return false;
            switch (operation)
            {
                case "%":
                    Fnumber1 = float.Parse(result);
                    Fnumber2 = float.Parse(number2);
                    Fresult = Fnumber2 % Fnumber1;

                    TfullEquation.Text += " " + result;
                    result = Fresult.ToString();
                    number2 = result;
                    Tresult.Text = result;
                    number1 = null;
                    operation = null;
                    break;
                case "/":
                    Fnumber1 = float.Parse(result);
                    Fnumber2 = float.Parse(number2);
                    Fresult = Fnumber2 / Fnumber1;

                    TfullEquation.Text += " " + result;
                    result = Fresult.ToString();
                    number2 = result;
                    Tresult.Text = result;
                    number1 = null;
                    operation = null;
                    break;
                case "*":
                    Fnumber1 = float.Parse(result);
                    Fnumber2 = float.Parse(number2);
                    Fresult = Fnumber2 * Fnumber1;

                    TfullEquation.Text += " " + result;
                    result = Fresult.ToString();
                    number2 = result;
                    Tresult.Text = result;
                    number1 = null;
                    operation = null;
                    break;
                case "-":
                    Fnumber1 = float.Parse(result);
                    Fnumber2 = float.Parse(number2);
                    Fresult = Fnumber2 - Fnumber1;

                    TfullEquation.Text += " " + result;
                    result = Fresult.ToString();
                    number2 = result;
                    Tresult.Text = result;
                    number1 = null;
                    operation = null;
                    break;
                case "+":
                    Fnumber1 = float.Parse(result);
                    Fnumber2 = float.Parse(number2);
                    Fresult = Fnumber2 + Fnumber1;

                    TfullEquation.Text += " " + result;
                    result = Fresult.ToString();
                    number2 = result;
                    Tresult.Text = result;
                    number1 = null;
                    operation = null;
                    break;
            }

            return true;
        }
    }
}