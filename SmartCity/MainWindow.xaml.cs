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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HomePage p1 = new HomePage();
            frame1.NavigationService.Navigate(p1);            
        }
        public static int on = 0;
        public static int off = 1;
        public static int flag = 1;
        public static int coffee = 1;
        public static int help1 = 1;
        public static int help2 = 1;
        public static int help3 = 1;
        public static int help4 = 1;
        public static int help5 = 1;
        public static int help6 = 1;        
    }
}
