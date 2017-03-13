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

namespace SmartCity
{
    /// <summary>
    /// Interaction logic for Alarm.xaml
    /// </summary>
    public partial class Alarm : Page
    {
        public Alarm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "1";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "2";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "3";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "4";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "5";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "6";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "7";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "8";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "9";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 4)
            {
                textBox.Text += "0";
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ο κωδικός είναι τετραψήφιος!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "1235")
            {
                NavigationService.Navigate(new RemoteControl());
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Πληκτρολογήσατε λάθος κωδικό!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
                
                textBox.Text = "";
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserHomePage());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
