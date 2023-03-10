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

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // tuka tr se savenat promenite kum database-a

            User currentUser = new User();
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-0K9CBJP\SQLEXPRESS; Initial Catalog=f1; Integrated Security=True");
            Profile obj = new Profile();
            try
            {
                sqlCon.Open();

                if (username.Text!="")
                {
                    string queryUsername = "UPDATE UserInfo SET username ='" + username.Text + "' WHERE id = " + currentUser.Id;
                    SqlCommand cmdUsername = new SqlCommand(queryUsername, sqlCon);
                    cmdUsername.ExecuteNonQuery();
                    currentUser.Username = username.Text;
                }

                if (bio.Text != "")
                {
                    string queryBio = "UPDATE UserInfo SET bio ='" + bio.Text + "' WHERE id = " + currentUser.Id;
                    SqlCommand cmdBio = new SqlCommand(queryBio, sqlCon);
                    cmdBio.ExecuteNonQuery();
                    currentUser.Bio = bio.Text;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
