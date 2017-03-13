using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for OnlineCafe.xaml
    /// </summary>
    public partial class OnlineCafe : Page
    {
        int countespresso = 1;//espresso
        int countcappuccino = 1;//capuccino
        int countamericano = 1;//americano
        int countchocolate = 1;//chocolate
        int countgarides = 1;
        int countsnitsel = 1;
        int countxoirino = 1;
        int countsalata = 1;
        int countbeer = 1;
        int countredwine = 1;
        int countwhitewine = 1;

        public OnlineCafe()
        {
            InitializeComponent();
            espresso_Copy.IsEnabled = false;
            cappuccino_Copy.IsEnabled = false;
            americano_Copy.IsEnabled = false;
            chocolate_Copy.IsEnabled = false;
            xoirino_Copy.IsEnabled = false;
            salata_Copy.IsEnabled = false;
            snitsel_Copy.IsEnabled = false;
            garides_Copy.IsEnabled = false;
            beer_Copy.IsEnabled = false;
            redwine_Copy.IsEnabled = false;
            whitewine_Copy.IsEnabled = false;
        }

        public void add_to_cart(string txtblockname, string txtboxprice, int count, Button button)
        {
            if (cart.Text.Contains(txtblockname) == false)
            {
                cart.Text += txtblockname + " x" + count + "\r\n";
                button.IsEnabled = true;
            }
            else
            {
                cart.Text = cart.Text.Replace(txtblockname + " x" + (count - 1), txtblockname + " x" + count);
            }
            total_cost.Text = (Convert.ToDouble(total_cost.Text) + Convert.ToDouble(txtboxprice)).ToString();

        }



        public void remove_from_cart(string txtblockname, string txtboxprice, int count, Button button)
        {
            if (Convert.ToDouble(total_cost.Text) > 0 && cart.Text.Contains(txtblockname) == true && count > 1)
            {
                total_cost.Text = (Convert.ToDouble(total_cost.Text) - Convert.ToDouble(txtboxprice)).ToString();
                cart.Text = cart.Text.Replace(txtblockname + " x" + count, txtblockname + " x" + (count - 1));
                cart.Text = Regex.Replace(cart.Text, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd() + "\r\n";

            }
            else
            {
                total_cost.Text = (Convert.ToDouble(total_cost.Text) - Convert.ToDouble(txtboxprice)).ToString();
                cart.Text = cart.Text.Replace(txtblockname + " x" + count, "");
                cart.Text = Regex.Replace(cart.Text, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd() + "\r\n";
                button.IsEnabled = false;
                if (string.IsNullOrWhiteSpace(cart.Text))
                {
                   cart.Text = Regex.Replace(cart.Text, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();
                }

            }

        }

        private void espresso_Click(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock1.Text, esprice.Text, countespresso, espresso_Copy);
            countespresso++;            
        }

        private void espresso_Copy_Click(object sender, RoutedEventArgs e)
        {
            countespresso--;
            remove_from_cart(textBlock1.Text, esprice.Text, countespresso, espresso_Copy);
        }

        private void cappuccino_Click(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock2.Text, capprice.Text, countcappuccino, cappuccino_Copy);
            countcappuccino++;
        }

        private void cappuccino_Copy_Click(object sender, RoutedEventArgs e)
        {
            countcappuccino--;
            remove_from_cart(textBlock2.Text, capprice.Text, countcappuccino, cappuccino_Copy);
        }

        private void americano_Click(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock3.Text, amprice.Text, countamericano, americano_Copy);
            countamericano++;
        }

        private void americano_Copy_Click(object sender, RoutedEventArgs e)
        {
            countamericano--;
            remove_from_cart(textBlock3.Text, amprice.Text, countamericano, americano_Copy);
        }

        private void chocolate_Click(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock4.Text, chprice.Text, countchocolate, chocolate_Copy);
            countchocolate++;
        }

        private void chocolate_Copy_Click(object sender, RoutedEventArgs e)
        {
            countchocolate--;
            remove_from_cart(textBlock4.Text, chprice.Text, countchocolate, chocolate_Copy);
        }

        private void garides_Click(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock5.Text, gprice.Text, countgarides, garides_Copy);
            countgarides++;
        }

        private void garides_Copy_Click(object sender, RoutedEventArgs e)
        {
            countgarides--;
            remove_from_cart(textBlock5.Text, gprice.Text, countgarides, garides_Copy);
        }

        private void snitsel_Click(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock6.Text, sniprice.Text, countsnitsel, snitsel_Copy);
            countsnitsel++;

        }

        private void snitsel_Copy_Click(object sender, RoutedEventArgs e)
        {
            countsnitsel--;
            remove_from_cart(textBlock6.Text, sniprice.Text, countsnitsel, snitsel_Copy);
          }

        private void xoirino_Click(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock7.Text, xprice.Text, countxoirino, xoirino_Copy);
            countxoirino++;
        }

        private void xoirino_Copy_Click(object sender, RoutedEventArgs e)
        {
            countxoirino--;
           remove_from_cart(textBlock7.Text, xprice.Text, countxoirino, xoirino_Copy);            
        }

        private void salata_Click(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock8.Text, salprice.Text, countsalata, salata_Copy);
            countsalata++;
        }

        private void salata_Copy_Click(object sender, RoutedEventArgs e)
        {
            countsalata--;
            remove_from_cart(textBlock8.Text, salprice.Text, countsalata, salata_Copy);
        }         

        private void beer_Click_1(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock9.Text, beerprice.Text, countbeer, beer_Copy);
            countbeer++;
        }

        private void beer_Copy_Click_1(object sender, RoutedEventArgs e)
        {
            countbeer--;
            remove_from_cart(textBlock9.Text, beerprice.Text, countbeer, beer_Copy);
        }

        private void redwine_Click_1(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock10.Text, redprice.Text, countredwine, redwine_Copy);
            countredwine++;
        }

        private void redwine_Copy_Click_1(object sender, RoutedEventArgs e)
        {
            countredwine--;
            remove_from_cart(textBlock10.Text, redprice.Text, countredwine, redwine_Copy);
        }

        private void whitewine_Click_1(object sender, RoutedEventArgs e)
        {
            add_to_cart(textBlock11.Text, whprice.Text, countwhitewine, whitewine_Copy);
            countwhitewine++;
        }

        private void whitewine_Copy_Click_1(object sender, RoutedEventArgs e)
        {
            countwhitewine--;
            remove_from_cart(textBlock11.Text, whprice.Text, countwhitewine, whitewine_Copy);
        }

        private void finish_order_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(address.Text) || string.IsNullOrWhiteSpace(phone.Text))
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Συμπληρώστε τα στοιχεία σας",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
            else if (string.IsNullOrWhiteSpace(cart.Text))
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Δεν έχετε προσθέσει προϊόντα στο καλάθι!",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
            else if (phone.Text.Length < 10)
            {
                var res = Xceed.Wpf.Toolkit.MessageBox.Show(
                           "Το τηλέφωνο δεν είναι έγκυρο",
                           "Προσοχή!",
                           MessageBoxButton.OK,
                           MessageBoxImage.None);
            }
            else {
                Receipt p = new Receipt(cart.Text, total_cost.Text, name.Text, address.Text, phone.Text);
                NavigationService.Navigate(p);
            }
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            UserHomePage p = new UserHomePage();

            this.NavigationService.Navigate(p);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }
    }
}
