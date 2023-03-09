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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent(); 
            //string username = "Username";
            //DataContext = this;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            obj.Show();
            this.Close();
        }

        private void Tracks_Click(object sender, RoutedEventArgs e)
        {
            Tracks obj = new Tracks();
            obj.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            Edit_Profile obj = new Edit_Profile();
            obj.Show();
            this.Close();
        }
    }
}
