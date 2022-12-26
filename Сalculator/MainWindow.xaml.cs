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

namespace Сalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ControlTemplate curTemplate = new ControlTemplate();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void InputNum(string num)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = num;
            }
            else
            {
                Screen.Text += num;
            }
        }
        private void One_Click_1(object sender, RoutedEventArgs e)
        {
            InputNum("1");
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            InputNum("2");
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            InputNum("3");
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            InputNum("4");
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            InputNum("5");
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            InputNum("6");
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            InputNum("7");
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            InputNum("8");
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            InputNum("9");
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            InputNum("0");
        }
        private void InputSign(string sign)
        {
            if (Screen.Text != "0")
            {
                Screen.Text += sign;
            }
        }
        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            InputSign(".");
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text != "0")
            {
                Screen.Text = "0";
            }
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            string str ="";
            if (Screen.Text != "0" && Screen.Text.Length > 1)
            {
                for (int i = 0; i < Screen.Text.Length - 1; i++)
                {
                    str += Screen.Text[i];
                }
                Screen.Text = str;
            }
            else if (Screen.Text != "0" && Screen.Text.Length == 1)
            {
                Screen.Text = "0";
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            InputSign("*");
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            InputSign("/");
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            InputSign("-");
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            InputSign("+");
        }

        private void Equally_Click(object sender, RoutedEventArgs e)
        {
            SearchExpression se = new SearchExpression();
            Screen.Text = se.SearchResults(Screen.Text);
        }
    }
}
