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

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool newButton;
        private double savedValue;
        private char myOperator;

        public MainWindow()
        {
            InitializeComponent();
        }

        //number btn
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string number = button.Content.ToString();

            if (txtResult.Text == "0" || newButton == true)
            {
                txtResult.Text = number;
                newButton = false;
            }
            else txtResult.Text = txtResult.Text + number;
        }

        //operator btn
        private void Button_Click_Opt(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            savedValue = double.Parse(txtResult.Text);
            myOperator = button.Content.ToString()[0];
            newButton = true;
        }

        //dot btn
        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            if (!txtResult.Text.Contains(".")) txtResult.Text += ".";
        }

        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            char operator1 = myOperator;
            switch (operator1)
            {
                case '+' :
                    txtResult.Text = (savedValue + double.Parse(txtResult.Text)).ToString();
                    break;
                case '-':
                    txtResult.Text = (savedValue - double.Parse(txtResult.Text)).ToString();
                    break;
                case '*':
                    txtResult.Text = (savedValue * double.Parse(txtResult.Text)).ToString();
                    break;
                case '/':
                    txtResult.Text = (savedValue / double.Parse(txtResult.Text)).ToString();
                    break;

            }
        }
    }
}
