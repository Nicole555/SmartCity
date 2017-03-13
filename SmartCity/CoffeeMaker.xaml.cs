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
    /// Interaction logic for CoffeeMaker.xaml
    /// </summary>
    public partial class CoffeeMaker : Page
    {
        DispatcherTimer introTime = new DispatcherTimer();
        public CoffeeMaker()
        {
            InitializeComponent();
            button.IsEnabled = false;
            scaner.Visibility = Visibility.Hidden;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox.Text))
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Δεν επιλέξατε κάτι!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
            else
            {
                var controller = ImageBehavior.GetAnimationController(this.scaner);
                controller.Play();
                button.IsEnabled = false;
                introTime.Interval = TimeSpan.FromSeconds(6);
                introTime.Tick += new EventHandler(introTime_Tick);
                introTime.Start();
                back1.IsEnabled = false;
                label2.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Visible;
            }
        }
        public void introTime_Tick(object sender, EventArgs e)
        {
            introTime.Stop();
            back1.IsEnabled = true;
            MainWindow.coffee = 0;
           NavigationService.Navigate(new SuccessCoffee());
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            RemoteControl p1 = new RemoteControl();
            this.NavigationService.Navigate(p1);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            introTime.Stop();
            NavigationService.Navigate(new RemoteControl());
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ακυρώθηκε το αίτημα σας!",
                           "Ακυρώθηκε!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
        }

        private void water_Click(object sender, RoutedEventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Νερό προστέθηκε!",
                           "Προστέθηκε!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            water.IsEnabled = false;
            if(cup.IsEnabled == false)
            {
                button.IsEnabled = true;
            }
           
        }

        private void cup_Click(object sender, RoutedEventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Δοχείο προστέθηκε!",
                           "Προστέθηκε!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            scaner.Visibility = Visibility.Visible;
            cm.Visibility = Visibility.Hidden;
            cup.IsEnabled = false;
            if (water.IsEnabled == false)
            {
                button.IsEnabled = true;
            }
        }
    }
}
