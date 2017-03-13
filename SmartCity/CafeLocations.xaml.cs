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
    /// Interaction logic for CafeLocations.xaml
    /// </summary>
    public partial class CafeLocations : Page
    {
        public CafeLocations(int number)
        {
            InitializeComponent();
            InitializeComponent();
            if (number == 1)
            {
                belleamie.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                textBox1.Visibility = System.Windows.Visibility.Visible; //οι οδηγιες για το να πας με μεσα βρισκονται στο textBox1
            }
            else if (number == 2)
            {
                gazi_college.Visibility = System.Windows.Visibility.Visible;
                textBox2.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                lostre.Visibility = System.Windows.Visibility.Visible;
                textBox3.Visibility = System.Windows.Visibility.Visible;

            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserHomePage());
        }
    }
}
