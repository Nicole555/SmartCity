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
    /// Interaction logic for DayPlanner.xaml
    /// </summary>
    public partial class DayPlanner : Page
    {
        public DayPlanner()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, RoutedEventArgs e)
        {
           University p1 = new University();
            this.NavigationService.Navigate(p1);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            UserHomePage p1 = new UserHomePage();
            this.NavigationService.Navigate(p1);
        }

        private void no_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cafe1());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
