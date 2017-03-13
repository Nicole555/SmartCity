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
    /// Interaction logic for Parking.xaml
    /// </summary>
    public partial class Parking : Page
    {
        public Parking()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, RoutedEventArgs e)
        {
            Cafe p1 = new Cafe();
            this.NavigationService.Navigate(p1);
        }

        private void no_Click(object sender, RoutedEventArgs e)
        {
            UserHomePage p1 = new UserHomePage();
            this.NavigationService.Navigate(p1);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            University p2 = new University();
            this.NavigationService.Navigate(p2);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
