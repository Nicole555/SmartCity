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
    /// Interaction logic for RemoteControl.xaml
    /// </summary>
    public partial class RemoteControl : Page
    {
        public RemoteControl()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.coffee == 1)
            {
                CoffeeMaker p2 = new CoffeeMaker();
                this.NavigationService.Navigate(p2);
            }
            else
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Έχετε ήδη φτιάξει καφέ!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
         }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            UserHomePage p2 = new UserHomePage();
            this.NavigationService.Navigate(p2);
        }

        private void microwave_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Microwave());
        }

        private void water_heater_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Water_heater());
        }
    }
}
