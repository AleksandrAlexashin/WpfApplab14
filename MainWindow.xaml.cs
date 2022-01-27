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

namespace WpfApplab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
                  
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName="Капуста",
                ProductPrice= 55.95,
                Image="Data/1.jpg",
                ProductTypes =ProductTypes.Food

            });

            products.Add(new Product()
            {
                ProductName = "Стиральная машина",
                ProductPrice = 54455.55,
                Image = "Data/2.jpg",
                ProductTypes = ProductTypes.Appliances

            });
            products.Add(new Product()
            {
                ProductName = "Картофель",
                ProductPrice = 45.35,
                Image = "Data/1.jpg",
                ProductTypes = ProductTypes.Food

            });
            products.Add(new Product()
            {
                ProductName = "Холодильник",
                ProductPrice =99999.99,
                Image = "Data/2.jpg",
                ProductTypes = ProductTypes.Appliances

            });
            lstBox.ItemsSource = products;
        }
    }
}
