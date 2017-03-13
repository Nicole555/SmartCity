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
    /// Interaction logic for University.xaml
    /// </summary>
    public partial class University : Page
    {
        public University()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox.Text))
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Παρακαλώ επιλέξτε πριν πατήσετε επόμενο!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
            else
            {
                if (comboBox1.Text == "ΜΜΜ")
                {
                    S_P_MME p1 = new S_P_MME(1);
                    this.NavigationService.Navigate(p1);

                }
                else if (comboBox1.Text == "Πόδια")
                {
                    S_P_MME p1 = new S_P_MME(2);
                    this.NavigationService.Navigate(p1);
                }
                else
                {
                    S_P_MME p1 = new S_P_MME(3);
                    this.NavigationService.Navigate(p1);
                }
            }

            
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
             DayPlanner p1 = new DayPlanner();
            this.NavigationService.Navigate(p1);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
