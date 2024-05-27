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
    /// Логика взаимодействия для start.xaml
    /// </summary>
    public partial class start : Window
    {
        public start()
        {
            InitializeComponent();
            App.DB = new Model.shop();
        }
        private void s100_Click(object sender, RoutedEventArgs e)
        {
            swechi100 window = new swechi100();
            this.Hide();
            window.ShowDialog();
            this.Show();
        }
        private void s50_Click(object sender, RoutedEventArgs e)
        {
            swechi50 window = new swechi50();
            this.Hide();
            window.ShowDialog();
            this.Show();
        }
        private void other_Click(object sender, RoutedEventArgs e)
        {
            otherwin window = new otherwin();
            this.Hide();
            window.ShowDialog();
            this.Show();
        }
        private void shop_Click(object sender, RoutedEventArgs e)
        {
            shopwin window = new shopwin();
            this.Hide();
            window.ShowDialog();
            this.Show();
        }
        private void user_Click(object sender, RoutedEventArgs e)
        {
            users window = new users();
            this.Hide();
            window.ShowDialog();
            this.Show();
        }
        private void startb_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
