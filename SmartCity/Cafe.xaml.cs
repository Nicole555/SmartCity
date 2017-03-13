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
    /// Interaction logic for Cafe.xaml
    /// </summary>
    public partial class Cafe : Page
    {
        public Cafe()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            University p1 = new University();
            this.NavigationService.Navigate(p1);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void belleamie_Click(object sender, RoutedEventArgs e)
        {
            CafeLocations p1 = new CafeLocations(1);
            this.NavigationService.Navigate(p1);
        }

        private void gazicollege_Click(object sender, RoutedEventArgs e)
        {
            CafeLocations p1 = new CafeLocations(2);
            this.NavigationService.Navigate(p1);
        }

        private void lostre_Click(object sender, RoutedEventArgs e)
        {
            CafeLocations p1 = new CafeLocations(3);
            this.NavigationService.Navigate(p1);
        }

        private void back_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Parking());
        }
    }
}
