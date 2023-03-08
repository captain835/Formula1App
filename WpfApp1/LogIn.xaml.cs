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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Log_In_Click(object sender, RoutedEventArgs e)
        {
            if(username.Text.Equals(""))
            {
                MessageBox.Show("Username is empty");
            }
            if (password.Equals(""))
            {
                MessageBox.Show("Password is empty");
            }
            else if (!(username.Text.Equals("")) && !(password.Equals("")))
            {
                MainWindow obj = new MainWindow();
                obj.Show();
                this.Close();
            }
        }
    }
}
