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
    /// Interaction logic for UserHomePage.xaml
    /// </summary>
    public partial class UserHomePage : Page
    {
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
            DayPlanner p2 = new DayPlanner();
            this.NavigationService.Navigate(p2);
        }

        private void calendar_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DayPlanner());
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
             HomePage p1 = new HomePage();
            this.NavigationService.Navigate(p1);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void online_Click(object sender, RoutedEventArgs e)
        {
            OnlineCafe p1 = new OnlineCafe();
            this.NavigationService.Navigate(p1);
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            nolight p1 = new nolight();
            this.NavigationService.Navigate(p1);
        }

        private void old_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ElderSupport());
        }
    }
}
