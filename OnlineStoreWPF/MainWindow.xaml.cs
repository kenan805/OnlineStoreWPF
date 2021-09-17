using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnlineStoreWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> Products { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            

            Products = new List<Product>
            {
                new Product()
                {
                    Name = "Bread",
                    Price = 0.70,
                    ImagePath = "Images/Bread.png",
                },
                new Product()
                {
                    Name = "Cola",
                    Price = 1.5,
                    ImagePath = "Images/Cola.png",
                },
                new Product()
                {
                    Name = "Lays",
                    Price = 1.8,
                    ImagePath = "Images/Lays.png",
                },
                new Product()
                {
                    Name = "Pepsi",
                    Price = 1.4,
                    ImagePath = "Images/Pepsi.png",
                },
                new Product()
                {
                    Name = "Potato",
                    Price = 0.6,
                    ImagePath = "Images/Potato.png",
                },
                new Product()
                {
                    Name = "Snickers",
                    Price = 2.4,
                    ImagePath = "Images/Snickers.png",
                }
            };


        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();

        private void Image_Exit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => Close();

        private void Image_FullScreen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => WindowState = WindowState.Maximized;

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleButton tgbtn)
            {
                if (tgbtn.IsChecked == true)
                {
                    WindowState = WindowState.Maximized;
                    imgScreen.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\OnlineStoreWPF\OnlineStoreWPF\Images\shrink_50px.png"));
                    imgScreen.ToolTip = "Shrink screen";
                }
                else
                {
                    WindowState = WindowState.Normal;
                    imgScreen.Source = new BitmapImage(new Uri(@"C:\Users\user\source\repos\OnlineStoreWPF\OnlineStoreWPF\Images\toggle_full_screen_50px.png"));
                    imgScreen.ToolTip = "Full screen";
                }
            }
        }

        private void TextBoxSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txbSearch.Text == "Search")
            {
                txbSearch.Text = "";
                txbSearch.Foreground = Brushes.Black;
                txbSearch.FontWeight = FontWeights.Normal;
            }
        }

        private void TextBoxSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                txbSearch.Text = "Search";
                txbSearch.Foreground = Brushes.Silver;
                txbSearch.FontWeight = FontWeights.SemiBold;
            }
        }


    }
}
