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
    /// Interaction logic for Microwave.xaml
    /// </summary>
    public partial class Microwave : Page
    {
        DispatcherTimer introTime = new DispatcherTimer();
        public Microwave()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var controller = ImageBehavior.GetAnimationController(this.gif);
            controller.Play();
            button.IsEnabled = false;
            introTime.Interval = TimeSpan.FromSeconds(4);
            introTime.Tick += new EventHandler(introTime_Tick);
            introTime.Start();
            back1.IsEnabled = false;
            label1.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Visible;            
        }
        public void introTime_Tick(object sender, EventArgs e)
        {
            introTime.Stop();
            back1.IsEnabled = true;
            label.Visibility = Visibility.Visible;
            label1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RemoteControl());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RemoteControl());
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ακυρώθηκε το αίτημα σας!",
                           "Ακύρωση!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
        }
    }
   
    
}
