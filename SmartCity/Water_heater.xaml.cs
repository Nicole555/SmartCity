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
using System.Windows.Threading;
using WpfAnimatedGif;

namespace SmartCity
{
    /// <summary>
    /// Interaction logic for Water_heater.xaml
    /// </summary>
    public partial class Water_heater : Page
    {
        public Water_heater()
        {
            InitializeComponent();
            if (MainWindow.on == 0 && MainWindow.off==1)
            {
                off.Visibility = Visibility.Visible;
                on.Visibility = Visibility.Hidden;
            }
            else
            {
                off.Visibility = Visibility.Hidden;
                on.Visibility = Visibility.Visible;
                tel_png.Visibility = Visibility.Visible;

            }

        }

        private void off_Click(object sender, RoutedEventArgs e)
        {
            tel_png.Visibility = Visibility.Hidden;
            var controller = ImageBehavior.GetAnimationController(this.gif);
            controller.Play();
            off.Visibility = Visibility.Hidden;
            on.Visibility = Visibility.Visible;
            textBlock1.Visibility = Visibility.Visible;
            MainWindow.off = 0;
            MainWindow.on = 1;
        }
        

        private void on_Click(object sender, RoutedEventArgs e)
        {
            tel_png.Visibility = Visibility.Hidden;
            var controller = ImageBehavior.GetAnimationController(this.gif);
            controller.GotoFrame(1);
            controller.Pause();
            on.Visibility = Visibility.Hidden;
            off.Visibility = Visibility.Visible;
            textBlock1.Visibility = Visibility.Hidden;
            MainWindow.off = 1;
            MainWindow.on = 0;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RemoteControl());
        }
    }
}
