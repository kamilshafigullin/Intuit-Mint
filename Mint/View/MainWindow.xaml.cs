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

namespace Mint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxItem1_Selected(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("View/Page1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ListBoxItem2_Selected(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("View/Page2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                MessageBox.Show(((TextBox)sender).Text);
            }
        }
    }
}
