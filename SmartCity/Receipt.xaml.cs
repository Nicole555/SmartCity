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
    /// Interaction logic for Receipt.xaml
    /// </summary>
    public partial class Receipt : Page
    {
        public Receipt(string items, string sum, string name, string address, string phone)
        {
            InitializeComponent();
            textBox.Text = " Ηλεκτρονική Απόδειξη \r\n------------------------------\r\nΠροϊόντα παραγγελίας:\r\n------------------------------\r\n" + items + "------------------------------\r\nΤο συνολικό ποσό είναι " + sum + "\r\n------------------------------\r\n" + "Στοιχεία Παραγγελίας: " + "\r\n------------------------------\r\n" + "'Ονομα: " + name + "\r\n" + "Διευθυνση: " + address + "\r\n" + "Τηλέφωνο: " + phone;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserHomePage());
        }
    }
}
