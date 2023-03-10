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

        int updatedDriver = 0;
        bool haveToUpdateDriver = false;

        int updatedTeam = 0;
        bool haveToUpdateTeam = false;

        int updatedTrack = 0;
        bool haveToUpdateTrack = false;
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // tuka tr se savenat promenite kum database-a

            User currentUser = new User();
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DLAPTOP; Initial Catalog=f1; Integrated Security=True");
            Profile obj = new Profile();
            try
            {
                sqlCon.Open();

                if (username.Text!="")
                {
                    string query1 = "UPDATE UserInfo SET username ='" + username.Text + "' WHERE id = " + currentUser.Id;
                    SqlCommand cmd1 = new SqlCommand(query1, sqlCon);
                    cmd1.ExecuteNonQuery();
                    currentUser.Username = username.Text;
                }

                if (bio.Text != "")
                {
                    string query2 = "UPDATE UserInfo SET bio ='" + bio.Text + "' WHERE id = " + currentUser.Id;
                    SqlCommand cmd2 = new SqlCommand(query2, sqlCon);
                    cmd2.ExecuteNonQuery();
                    currentUser.Bio = bio.Text;
                }


                if (haveToUpdateDriver)
                {
                    string query3 = "UPDATE UserInfo SET favDriverID ='" + updatedDriver + "' WHERE id = " + currentUser.Id;
                    SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                    cmd3.ExecuteNonQuery();
                    currentUser.FavDriver = currentUser.GetDriverImage(updatedDriver);
                }

                if (haveToUpdateTeam)
                {
                    
                    string query4 = "UPDATE UserInfo SET favTeamId ='" + updatedTeam + "' WHERE id = " + currentUser.Id;
                    SqlCommand cmd4 = new SqlCommand(query4, sqlCon);
                    cmd4.ExecuteNonQuery();
                    currentUser.FavTeam = currentUser.GetTeamImage(updatedTeam);
                }

                if (haveToUpdateTrack)
                {
                    string query5 = "UPDATE UserInfo SET favTrackId ='" + updatedTrack + "' WHERE id = " + currentUser.Id;
                    SqlCommand cmd5 = new SqlCommand(query5, sqlCon);
                    cmd5.ExecuteNonQuery();
                    currentUser.FavTrack = currentUser.GetTrackImage(updatedTrack);
                }



                obj.username.Text = currentUser.Username;



                ////Get  bio

                obj.bio.Text = currentUser.Bio;




                //Get favorite track


                obj.Track.Source = new BitmapImage(new Uri(currentUser.FavTrack));


                //Get favorite driver

                obj.Driver.ImageSource = new BitmapImage(new Uri(currentUser.FavDriver));


                //Get favorite team


                obj.TeamYeah.Source = new BitmapImage(new Uri(currentUser.FavTeam));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            
            obj.Show();
            this.Close();
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

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            Profile obj = new Profile();
            obj.Show();
            this.Close();
        }

        private void TeamsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User currentUser = new User();
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DLAPTOP; Initial Catalog=f1; Integrated Security=True"))
            {
                sqlCon.Open();
                string queryTeams = $"Select id from teams where name = '{TeamsBox.SelectedItem.ToString()}' ";
                SqlCommand cmdTeams = new SqlCommand(queryTeams, sqlCon);
                SqlDataReader readerTeams;
                readerTeams = cmdTeams.ExecuteReader();
                if (readerTeams.Read())
                {
                    updatedTeam = (int)readerTeams["id"];
                    //MessageBox.Show(updatedTeam.ToString());
                    haveToUpdateTeam = true;
                }
            }


        }

        private void DriversBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User currentUser = new User();
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DLAPTOP; Initial Catalog=f1; Integrated Security=True"))
            {
                sqlCon.Open();
                string queryDriver = $"Select id from drivers where First_name = '{DriversBox.SelectedItem.ToString()}' ";
                SqlCommand cmdDriver = new SqlCommand(queryDriver, sqlCon);
                SqlDataReader readerDriver;
                readerDriver = cmdDriver.ExecuteReader();
                if (readerDriver.Read())
                {
                    updatedDriver = (int)readerDriver["id"];

                    haveToUpdateDriver = true;
                }
                
                
                
            }
        }

        private void TracksBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User currentUser = new User();
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DLAPTOP; Initial Catalog=f1; Integrated Security=True"))
            {
                sqlCon.Open();
                string queryTrack = $"Select id from tracks where name = '{TracksBox.SelectedItem.ToString()}' " ;
                SqlCommand cmdTrack = new SqlCommand(queryTrack, sqlCon);
                SqlDataReader readerTrack;
                readerTrack = cmdTrack.ExecuteReader();
                if (readerTrack.Read())
                {
                    updatedTrack = (int)readerTrack["id"];
                    haveToUpdateTrack = true;
                }
            }
        }
    }
}
//Get favorite track





//Get favorite driver



//Get favorite team


