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
using System.Windows.Controls.Primitives;
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
                

                SqlConnection sqlCon = new SqlConnection(@"Data Source=DLAPTOP; Initial Catalog=f1; Integrated Security=True");
                User currentUser = new User();
                bool pass = false;
                bool user = false;
                try
                {


                    string queryPass = "Select pass from UserInfo where username = '" + username.Text + "'";
                    sqlCon.Open();
                    SqlCommand cmdPass = new SqlCommand(queryPass, sqlCon);
                    SqlDataReader readerPass;
                    readerPass = cmdPass.ExecuteReader();



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
                    readerGetId.Close();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }





                try
                {


                    string queryGetBio = $"Select bio from UserInfo where id = {currentUser.Id} ";

                    SqlCommand cmdGetBio = new SqlCommand(queryGetBio, sqlCon);
                    SqlDataReader readerGetBio;
                    readerGetBio = cmdGetBio.ExecuteReader();
                    if (readerGetBio.Read())
                    {


                        currentUser.Bio = readerGetBio["bio"].ToString();

                    }
                    else
                    {

                    }
                    readerGetBio.Close();


                }
                catch (Exception ex)
                {
                    
                }



                try
                {


                    string queryGetFavTrack = $"Select favTrackId from UserInfo where id = {currentUser.Id} ";

                    SqlCommand cmdGetFavTrack = new SqlCommand(queryGetFavTrack, sqlCon);
                    SqlDataReader readerGetFavTrack;
                    readerGetFavTrack = cmdGetFavTrack.ExecuteReader();
                    if (readerGetFavTrack.Read())
                    {


                        currentUser.FavTrack = currentUser.GetTrackImage((int)readerGetFavTrack["favTrackId"]);

                    }
                    else
                    {

                    }
                    readerGetFavTrack.Close();


                }
                catch (Exception ex)
                {
                    
                }
                try
                {


                    string queryGetFavDriver = $"Select favDriverId from UserInfo where id = {currentUser.Id} ";

                    SqlCommand cmdGetFavDriver = new SqlCommand(queryGetFavDriver, sqlCon);
                    SqlDataReader readerGetFavDriver;
                    readerGetFavDriver = cmdGetFavDriver.ExecuteReader();
                    if (readerGetFavDriver.Read())
                    {


                        currentUser.FavDriver = currentUser.GetDriverImage((int)readerGetFavDriver["favDriverId"]);

                    }
                    else
                    {

                    }
                    readerGetFavDriver.Close();

                }
                catch (Exception ex)
                {
                    
                }



                try
                {


                    string queryGetFavTeam = $"Select favTeamId from UserInfo where id = {currentUser.Id} ";


                    SqlCommand cmdGetFavTeam = new SqlCommand(queryGetFavTeam, sqlCon);
                    SqlDataReader readerGetFavTeam;
                    readerGetFavTeam = cmdGetFavTeam.ExecuteReader();
                    if (readerGetFavTeam.Read())
                    {


                        currentUser.FavTeam = currentUser.GetTeamImage((int)readerGetFavTeam["favTeamId"]);

                    }
                    else
                    {

                    }

                    readerGetFavTeam.Close();

                }
                catch (Exception ex)
                {
                    
                }

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
                sqlCon.Close();
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
        static string favTeam = "pack://application:,,,/Resources(Images)\\no-image-icon-32.png";
        static string favDriver = "pack://application:,,,/Resources(Images)\\no-image-icon-32.png";
        static string favTrack = "pack://application:,,,/Resources(Images)\\no-image-icon-32.png";
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


        public string GetTrackImage(int TrackId)
        {
            
                string imageTrack = "";
                switch (TrackId)
                {
                    case 1:
                        return imageTrack = "pack://application:,,,/Resources(Images)\\Tracks\\Bahrain.png";
                        break;

                    case 2:
                        return imageTrack = "pack://application:,,,/Resources(Images)\\Tracks\\Jeddah.png";

                        break;

                    case 3:
                        return imageTrack = "pack://application:,,,/Resources(Images)\\Tracks\\Melbourne.png";


                        break;

                    case 4:
                        return imageTrack = "pack://application:,,,/Resources(Images)\\Tracks\\Baku.png";


                        break;

                    case 5:
                        return imageTrack = "pack://application:,,,/Resources(Images)\\Tracks\\Miami.png";

                        break;

                    case 6:
                        return imageTrack = "pack://application:,,,/Resources(Images)\\Tracks\\Imola.png";

                        break;

                    case 7:
                        return imageTrack = "pack://application:,,,/Resources(Images)\\Tracks\\Monaco.png";

                        break;

                    default:
                        return imageTrack;
                        break;



                }
            
            
        }

        public string GetDriverImage(int DriverId)
        {
            string imageDriver = "";
            switch (DriverId)
            {
                case 1:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Verstappen.jpg";
                    break;

                case 2:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Sargeant.png";
                    break;

                case 3:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Norris.png";
                    break;

                case 4:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\DeVries.png";
                    break;

                case 5:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Hulkenberg.png";
                    break;

                case 6:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Gasly.png";
                    break;

                case 7:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Perez.jpg";
                    break;

                case 8:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Alonso.png";
                    break;

                case 9:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Leclerc.jpg";
                    break;

                case 11:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Stroll.jpg";
                    break;

                case 12:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Magnussen.png";
                    break;

                case 13:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Tsunoda.png";
                    break;

                case 14:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Albon.png";
                    break;

                case 15:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Zhou.png";
                    break;

                case 16:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Ocon.png";
                    break;

                case 17:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Hamilton.png";
                    break;

                case 18:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Piastri.png";
                    break;

                case 19:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Sainz.jpg";
                    break;

                case 20:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Russel.png";
                    break;

                case 10:
                    imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Bottas.jpg";
                    break;



            }

            return imageDriver;
        }

        public string GetTeamImage(int TeamId)
        {
            string imageTeam = "";
            switch (TeamId)
            {
                case 1:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\redbull.png";
                    break;

                case 2:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\alphatauri.png";
                    break;

                case 3:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\ferrari.png";
                    break;

                case 4:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\alfaromeo.png";
                    break;

                case 5:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\haas.png";
                    break;

                case 6:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\alpine.png";
                    break;

                case 7:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\mercedes.png";
                    break;

                case 8:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\williams.png";
                    break;

                case 9:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\aston.png";
                    break;

                case 10:
                    imageTeam = "pack://application:,,,/Resources(Images)\\Team\\mclaren.png";
                    break;



            }

            return imageTeam;
        }
    }
}
