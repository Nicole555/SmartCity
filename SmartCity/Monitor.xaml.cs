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
using WpfAnimatedGif;

namespace SmartCity
{
    /// <summary>
    /// Interaction logic for Monitor.xaml
    /// </summary>
    public partial class Monitor : Page
    {
        public Monitor()
        {
            InitializeComponent();
            if (MainWindow.help1 == 0)
            {
                button.IsEnabled = false;                
            }
            if (MainWindow.help2 == 0)
            {
                button_Copy.IsEnabled = false;

            }
            if (MainWindow.help3 == 0)
            {
                button_Copy1.IsEnabled = false;

            }
            if (MainWindow.help4 == 0)
            {
                button_Copy2.IsEnabled = false;

            }
            if (MainWindow.help5 == 0)
            {
                button_Copy3.IsEnabled = false;

            }
            if (MainWindow.help6 == 0)
            {
                button_Copy4.IsEnabled = false;

            }


        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Βοήθεια στάλθηκε στον ηλικιωμένο!",
                           "Βοήθεια στάλθηκε!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            button.IsEnabled = false;
            MainWindow.help1 = 0;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Βοήθεια στάλθηκε στον ηλικιωμένο!",
                           "Βοήθεια στάλθηκε!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            button_Copy.IsEnabled = false;
            MainWindow.help2 = 0;
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Βοήθεια στάλθηκε στον ηλικιωμένο!",
                           "Βοήθεια στάλθηκε!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            button_Copy1.IsEnabled = false;
            MainWindow.help3 = 0;
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Βοήθεια στάλθηκε στον ηλικιωμένο!",
                           "Βοήθεια στάλθηκε!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            button_Copy2.IsEnabled = false;
            MainWindow.help4 = 0;
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Βοήθεια στάλθηκε στον ηλικιωμένο!",
                           "Βοήθεια στάλθηκε!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            button_Copy3.IsEnabled = false;
            MainWindow.help5 = 0;
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Βοήθεια στάλθηκε στον ηλικιωμένο!",
                           "Βοήθεια στάλθηκε!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            button_Copy4.IsEnabled = false;
            MainWindow.help6 = 0;
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HomePage());
        }
    }
}
