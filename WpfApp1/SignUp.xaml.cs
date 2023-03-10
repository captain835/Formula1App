using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Sign_Up_Click(object sender, RoutedEventArgs e)
        {
            bool allTestspassed = true;
            if (username.Text.Equals(""))
            {
                MessageBox.Show("Username is empty");
                allTestspassed = false;
            }
            if (password.Equals(""))
            {
                MessageBox.Show("Password is empty");
                allTestspassed = false;

            }
            if (password.Password!=passwordCheck.Password)
            {
                MessageBox.Show("Passwords don't match");
                allTestspassed = false;

            }
            if (allTestspassed == true)
            {
               

                SqlConnection sqlCon = new SqlConnection(@"Data Source=DLAPTOP; Initial Catalog=f1; Integrated Security=True");

                try
                {
                    string query = "INSERT INTO UserInfo( username, pass) VALUES('"+ username.Text +"', '"+ password.Password +"');";
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.ExecuteNonQuery();
                    LogIn obj = new LogIn();
                    obj.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }

            }
        }
        private void myTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = "";
        }
    }
}
