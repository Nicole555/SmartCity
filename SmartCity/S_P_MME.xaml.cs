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
    /// Interaction logic for S_P_MME.xaml
    /// </summary>
    public partial class S_P_MME : Page
    {
        public S_P_MME(int picture)
        {
            InitializeComponent();
            if (picture == 1)
            {
                spmmm.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                textBox1.Visibility = System.Windows.Visibility.Visible; //οι οδηγιες για το να πας με μεσα βρισκονται στο textBox1
                button2.Visibility = System.Windows.Visibility.Hidden;
                label.Visibility = System.Windows.Visibility.Hidden;
                parking_icon_png.Visibility = System.Windows.Visibility.Hidden;

            }
            else if (picture == 2)
            {
                spp.Visibility = System.Windows.Visibility.Visible;
                textBox2.Visibility = System.Windows.Visibility.Visible;
                button2.Visibility = System.Windows.Visibility.Hidden;
                label.Visibility = System.Windows.Visibility.Hidden;
                parking_icon_png.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                spc.Visibility = System.Windows.Visibility.Visible;
                textBox3.Visibility = System.Windows.Visibility.Visible;
                button2.Visibility = System.Windows.Visibility.Visible;
                label.Visibility = System.Windows.Visibility.Visible;
                parking_icon_png.Visibility = System.Windows.Visibility.Visible;

            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Cafe p1 = new Cafe();
            this.NavigationService.Navigate(p1);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserHomePage());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Parking());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new University());
        }
    }
}
