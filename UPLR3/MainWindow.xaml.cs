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
using UPLR3.BurgerPlaceDataSetTableAdapters;

namespace UPLR3
{
 
    public partial class MainWindow : Window
    {
        Orders_CustomersTableAdapter orders_customers = new Orders_CustomersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            Orders_CustomersDataGrid.ItemsSource = orders_customers.GetData();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }
    }
}
