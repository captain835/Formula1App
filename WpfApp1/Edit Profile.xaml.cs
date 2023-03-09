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
    /// Interaction logic for Edit_Profile.xaml
    /// </summary>
    public partial class Edit_Profile : Window
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }
        private void myTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = "";
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // tuka tr se savenat promenite kum database-a
            Profile obj = new Profile();
            obj.Show();
            this.Close();
        }
    }
}
