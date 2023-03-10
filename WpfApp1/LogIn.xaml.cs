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
                User currentUser = new User();
                try
                {


                    string queryPass = "Select pass from UserInfo where username = '" + username.Text + "'";
                    sqlCon.Open();
                    SqlCommand cmdPass = new SqlCommand(queryPass, sqlCon);
                    SqlDataReader readerPass;
                    readerPass = cmdPass.ExecuteReader();

                    bool pass = false;
                    bool user = false;

                    if (readerPass.Read())
                    {

                        if (readerPass["pass"].ToString() == password.Password)
                        {

                            pass = true;
                        }
                        
                    }
                    

                    readerPass.Close();

                    string query = "Select username from UserInfo where username = '" + username.Text + "'";
                   
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    string Getusername = "";
                    if (reader.Read())
                    {

                        if (reader["username"].ToString() == username.Text)
                        {
                            Getusername = reader["username"].ToString();
                            currentUser.Username = Getusername;
                            user = true;
                        }
                        
                    }
                    else
                    {
                        
                    }

                    reader.Close();


                    string queryGetId = "Select id from UserInfo where username = '" + username.Text + "'";

                    SqlCommand cmdGetId = new SqlCommand(queryGetId, sqlCon);
                    SqlDataReader readerGetId;
                    readerGetId = cmdGetId.ExecuteReader();
                    if (readerGetId.Read())
                    {

                        
                        currentUser.Id = (int)readerGetId["id"];

                    }
                    else
                    {

                    }

                    reader.Close();


                    if (pass && user)
                    {
                        MainWindow obj = new MainWindow();
                        obj.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password Inncorrect");
                    }
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
        static int id = 0;
        static string favTeam = "";
        static string favDriver = "";
        static string favTrack = "";
        static string bio = "";
        static string username = "";

        public int Id
        {
            get
            {
                return id;
            }
            set { id = value; }

        }
        public string FavTeam
        {
            get { return favTeam; }
            set { favTeam = value; }
        }

        public string FavDriver
        {
            get { return favDriver; }  
            set { favDriver = value; } 
        }

        public string FavTrack
        {
            get { return favTrack; }
            set { favTrack = value; }
        }

        public string Bio
        {
            get { return bio; }
            set { bio = value; }
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
            }   
        }
    }
}
