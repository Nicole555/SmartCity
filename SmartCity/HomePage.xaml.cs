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
using System.Diagnostics;

namespace SmartCity
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {

        public HomePage()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            UserHomePage p2 = new UserHomePage();
            this.NavigationService.Navigate(p2);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Visible;
            enter.Visibility = Visibility.Visible;
            passwordBox.Focus();            
            
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == ("1235"))
            {
                
                NavigationService.Navigate(new Monitor());
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Παρακαλούμε πληκτρολογήστε σωστό κωδικό.",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
                passwordBox.Focus();
            }

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("Manual.chm");
        }
    }
    }

