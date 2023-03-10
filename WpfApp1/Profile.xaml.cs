using System;
using System.Collections.Generic;
using System.Data;
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
            Console.WriteLine("test");
            User currentUser = new User();

            List<string> Teams = new List<string>();
            try
            {
                
                //Get username

                obj.username.Text = currentUser.Username;



                ////Get  bio

                obj.bio.Text = currentUser.Bio;


                

                //Get favorite track
                

                obj.Track.Source = new BitmapImage(new Uri(currentUser.FavTrack));


                //Get favorite driver

                obj.Driver.ImageSource = new BitmapImage(new Uri(currentUser.FavDriver));


                //Get favorite team

               
                obj.TeamYeah.Source = new BitmapImage(new Uri(currentUser.FavTeam));



                SqlConnection SqlCon2 = new SqlConnection(@"Data Source=DLAPTOP; Initial Catalog=f1; Integrated Security=True");
                
                SqlCon2.Open();
                SqlCommand cmdAddToList = new SqlCommand("Select First_name from drivers", SqlCon2);
                SqlDataReader readerAddToList;
                readerAddToList = cmdAddToList.ExecuteReader();
                int i = 0;
                while (readerAddToList.Read() && i <20)
                {
                    i++;
                    obj.DriversBox.Items.Add(readerAddToList["First_name"].ToString());
                }
                
                readerAddToList.Close();



                SqlCommand cmdAddToListTeams = new SqlCommand("Select name from teams", SqlCon2);
                SqlDataReader readerAddToListTeams;
                readerAddToListTeams = cmdAddToListTeams.ExecuteReader();
                while (readerAddToListTeams.Read())
                {

                    obj.TeamsBox.Items.Add(readerAddToListTeams["name"].ToString());
                }

                readerAddToListTeams.Close();


                SqlCommand cmdAddToListTracks = new SqlCommand("Select name from tracks", SqlCon2);
                SqlDataReader readerAddToListTracks;
                readerAddToListTracks = cmdAddToListTracks.ExecuteReader();
                while (readerAddToListTracks.Read())
                {

                    obj.TracksBox.Items.Add(readerAddToListTracks["name"].ToString());
                }

                readerAddToListTracks.Close();


            }
            catch (Exception ex)
            {

                
            }

            //MessageBox.Show(Teams[1]);
            obj.Show();
            this.Close();
        }
    }
}
