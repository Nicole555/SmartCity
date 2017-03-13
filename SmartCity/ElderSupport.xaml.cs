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

namespace SmartCity
{
    /// <summary>
    /// Interaction logic for ElderSupport.xaml
    /// </summary>
    public partial class ElderSupport : Page
    {
        DispatcherTimer timer;

        public ElderSupport()
        {
            InitializeComponent();
           
            if (MainWindow.flag == 1)
            {
                button1.IsEnabled = true;
            }
            else
            {
                button1.IsEnabled = false;
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Υπενθυμίζουμε ότι ασθενοφόρο έχει ήδη σταλθεί",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
                       }
        }       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text)|| string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox.Text))
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Παρακαλώ συμπληρώστε τα πεδία!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);               
            }
            else
            {
                if (kala.IsChecked == true || metria.IsChecked == true || asxima.IsChecked == true)
                {
                    if (Convert.ToDouble(textBox.Text)<6 || Convert.ToDouble(textBox1.Text) < 3|| Convert.ToDouble(textBox2.Text) < 20 || Convert.ToDouble(textBox.Text)>22 || Convert.ToDouble(textBox1.Text) > 12 || Convert.ToDouble(textBox2.Text) > 180)
                    {
                        var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Παρακαλώ συμπληρώστε τα πεδία σωστά\r\nΠίεση μεγάλη τιμές: 6-22\r\nΠίεση μικρή τιμές: 3-12\n\rΣφυγμοί τιμές: 20-180",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
                    }
                    else
                    {
                        if(Convert.ToDouble(textBox.Text) < 9 || Convert.ToDouble(textBox1.Text) < 6 || Convert.ToDouble(textBox2.Text) < 60 || Convert.ToDouble(textBox.Text) > 18 || Convert.ToDouble(textBox1.Text) > 10 || Convert.ToDouble(textBox2.Text) > 100)
                        {
                            timer.Stop();
                            NavigationService.Navigate(new Result(2));                            
                        }
                        else if(asxima.IsChecked == true || metria.IsChecked==true)
                        {
                            timer.Stop();
                            NavigationService.Navigate(new Result(3));
                        }
                        else
                        {
                            timer.Stop();
                            NavigationService.Navigate(new Result(1));
                        }


                    }

                }
                else
                {
                    var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Παρακαλώ συμπληρώστε τα πεδία!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
                }
            }
            
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
            
        }

        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void textBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Είσαι σίγουρος ότι θες να καλέσεις ασθενοφόρο;",
                           "Είσαι σίγουρος;",
                           MessageBoxButton.YesNo,
                           MessageBoxImage.None);

            if ("No" == res.ToString())
            {
            }
            else if ("Yes" == res.ToString())
            {
                var va = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Ασθενοφόρο έχει σταλθεί!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
                button1.IsEnabled = false;
                MainWindow.flag = 0;
                timer.Stop();
                NavigationService.Navigate(new UserHomePage());

            }
            else
            {
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            UserHomePage p1 = new UserHomePage();
            this.NavigationService.Navigate(p1);
            timer.Stop();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ElderSupport_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer != null)
            {
                timer.Tick -= timer_Tick;
            }
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 30);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                            "Είστε ανενεργός για πάνω από 30 δευτερόλεπτα! Στέλνουμε βοήθεια!",
                            "Βοήθεια στάλθηκε!",
                            MessageBoxButton.OK,
                            MessageBoxImage.None);
            timer.Stop();
        }
    }
}
