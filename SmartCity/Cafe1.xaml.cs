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
    /// Interaction logic for Cafe1.xaml
    /// </summary>
    public partial class Cafe1 : Page
    {
        public Cafe1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(comboBox.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Παρακαλώ επιλέξτε πριν πατήσετε επόμενο!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
            else
            {
                if (comboBox.Text == "BelleAmie")
                {
                    if (comboBox1.Text == "ΜΜΜ")
                    {
                        Cafe2 p1 = new Cafe2(1);
                        this.NavigationService.Navigate(p1);
                    }
                    else if (comboBox1.Text == "Πόδια")
                    {
                        Cafe2 p1 = new Cafe2(2);
                        this.NavigationService.Navigate(p1);
                    }
                    else
                    {
                        Cafe2 p1 = new Cafe2(3);
                        this.NavigationService.Navigate(p1);
                    }

                }
                else if (comboBox.Text == "Gazi College")
                {
                    if (comboBox1.Text == "ΜΜΜ")
                    {
                        Cafe2 p1 = new Cafe2(4);
                        this.NavigationService.Navigate(p1);
                    }
                    else if (comboBox1.Text == "Πόδια")
                    {
                        Cafe2 p1 = new Cafe2(5);
                        this.NavigationService.Navigate(p1);
                    }
                    else
                    {
                        Cafe2 p1 = new Cafe2(6);
                        this.NavigationService.Navigate(p1);
                    }
                }
                else 
                {
                    if (comboBox1.Text == "ΜΜΜ")
                    {
                        Cafe2 p1 = new Cafe2(7);
                        this.NavigationService.Navigate(p1);
                    }
                    else if (comboBox1.Text == "Πόδια")
                    {
                        Cafe2 p1 = new Cafe2(8);
                        this.NavigationService.Navigate(p1);
                    }
                    else
                    {
                        Cafe2 p1 = new Cafe2(9);
                        this.NavigationService.Navigate(p1);
                    }
                }
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            DayPlanner p1 = new DayPlanner();
            this.NavigationService.Navigate(p1);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserHomePage());
        }
    }
}
