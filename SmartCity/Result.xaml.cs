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
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Page
    {
        public Result(int number)
        {
            InitializeComponent();
            if (number == 1)
            {
                sun.Visibility = Visibility.Visible;
                textBox.Visibility = Visibility.Visible;
            }
            else if(number==2)
            {
                surgeon_animation_1_gif.Visibility = Visibility.Visible;
                textBox1.Visibility = Visibility.Visible;
            }
            else
            {
                surgeon_animation_1_gif.Visibility = Visibility.Visible;
                textBox2.Visibility = Visibility.Visible;
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            UserHomePage p1 = new UserHomePage();
            this.NavigationService.Navigate(p1);
        }
    }
}
