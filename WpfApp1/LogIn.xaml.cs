using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                

                SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-0K9CBJP\SQLEXPRESS; Initial Catalog=f1; Integrated Security=True");

                try
                {
                    string query = "Select username from UserInfo where username = '" + username.Text + "'";
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        
                        if(reader["username"].ToString() == username.Text)
                        {
                            
                            User currentUser = new User();
                            currentUser.Id = reader["username"].ToString();
                            MainWindow obj = new MainWindow();
                            obj.Show();
                            this.Close();
                        }
                    }
                    else {
                        MessageBox.Show("Username or Password Inncorrect");
                    }
                    
                    reader.Close();
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
        private void Sign_Up_Click(object sender, RoutedEventArgs e)
        {
            SignUp obj = new SignUp();
            obj.Show();
            this.Close();
        }
    }
    public class User
    {
        static string id = "";

        public string Id
        {
            get
            {
                return id;
            }
            set { id = value; }

        }
    }
}
