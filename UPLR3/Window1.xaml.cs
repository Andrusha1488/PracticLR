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
using System.Windows.Shapes;

namespace UPLR3
{
    public partial class Window1 : Window
    {
        private BurgerPlaceEntities1 context = new BurgerPlaceEntities1();
        public Window1()
        {
            InitializeComponent();
            Orders_CustomersDataGrid.ItemsSource = context.Orders_Customers.ToList();
        }
    }
}
