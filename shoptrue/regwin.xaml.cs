using shoptrue.window;
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

namespace shoptrue
{
    /// <summary>
    /// Логика взаимодействия для regwin.xaml
    /// </summary>
    public partial class regwin : Window
    {
        public regwin()
        {
            InitializeComponent();
        }
        private void s100_Click(object sender, RoutedEventArgs e)
        {
            swechi100 window = new swechi100();
            this.Close();
            window.ShowDialog();
            this.Show();
        }
        private void s50_Click(object sender, RoutedEventArgs e)
        {
            swechi50 window = new swechi50();
            this.Close();
            window.ShowDialog();
            this.Show();
        }
        private void other_Click(object sender, RoutedEventArgs e)
        {
            otherwin window = new otherwin();
            this.Close();
            window.ShowDialog();
            this.Show();
        }
        private void shop_Click(object sender, RoutedEventArgs e)
        {
            shopwin window = new shopwin();
            this.Close();
            window.ShowDialog();
            this.Show();
        }
        private void user_Click(object sender, RoutedEventArgs e)
        {

        }
        private void startb_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            App.Current.Windows[0].ShowDialog();
            this.Show();
        }
            private void enter_Click(object sender, RoutedEventArgs e)
        {
            users window = new users();
            this.Close();
            window.ShowDialog();
            this.Show();
        }
        private void reg_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
