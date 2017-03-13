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
    /// Interaction logic for Cafe2.xaml
    /// </summary>
    public partial class Cafe2 : Page
    {
        public Cafe2(int flag)
        {
            InitializeComponent();
            if (flag == 1)
            {
                Belle_MMM_PNG.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                Belle_MMM.Visibility = System.Windows.Visibility.Visible;
            }
            else if (flag == 2)
            {
                Belle_pezh_PNG.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                Belle_Pezh.Visibility = System.Windows.Visibility.Visible;
            }
            else if (flag == 3)
            {
                belle_car_PNG.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                Belle_Car.Visibility = System.Windows.Visibility.Visible;
            }
            else if (flag == 4)
            {
                Lostre_MMM_PNG.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                Lostre_MMM.Visibility = System.Windows.Visibility.Visible;
            }
            else if (flag == 5)
            {
                Lostre_pezh_PNG.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                Lostre_Pezh.Visibility = System.Windows.Visibility.Visible;
            }
            else if (flag  == 6)
            {
                Lostre_car_PNG.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                Lostre_Car.Visibility = System.Windows.Visibility.Visible;
            }
            else if (flag == 7)
            {
                College_MMM_PNG.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                College_MMM.Visibility = System.Windows.Visibility.Visible;
            }
            else if (flag == 8)
            {
                College_Pezh_PNG.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                College_Pezh.Visibility = System.Windows.Visibility.Visible;
            }
            else if (flag == 9)
            {
                College_Car_PNG.Visibility = System.Windows.Visibility.Visible;   //ονομαζεις την εικονα συνταγμα-πανεπιστημιο-μεσα μαζικης μεταφορας spmmm
                College_Car.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            UserHomePage p1 = new UserHomePage();
            this.NavigationService.Navigate(p1);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
