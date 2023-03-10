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
            int teamsCount = 0;
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

                obj.testBox.Items.Add("Alice");
                

                using (SqlConnection SqlCon = new SqlConnection(@"Data Source=DESKTOP-0K9CBJP\SQLEXPRESS; Initial Catalog=f1; Integrated Security=True"))
                {
                    SqlCon.Open();

                    SqlCommand cmd = new SqlCommand($"Select count(*) as count from drivers", SqlCon);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        teamsCount = (int)reader["count"];
                        
                    }
                    reader.Close();

                }

                SqlConnection SqlCon2 = new SqlConnection(@"Data Source=DESKTOP-0K9CBJP\SQLEXPRESS; Initial Catalog=f1; Integrated Security=True");
                
                SqlCon2.Open();
                SqlCommand cmdAddToList = new SqlCommand($"Select First_name from drivers", SqlCon2);
                SqlDataReader readerAddToList;
                readerAddToList = cmdAddToList.ExecuteReader();
                while (readerAddToList.Read())
                {

                    obj.testBox.Items.Add(readerAddToList["First_name"].ToString());
                }
                
                readerAddToList.Close();

                //using (SqlConnection SqlCon = new SqlConnection(@"Data Source=DESKTOP-0K9CBJP\SQLEXPRESS; Initial Catalog=f1; Integrated Security=True"))
                //{
                //    SqlCon.Open();
                //    SqlDataAdapter ProjectTableTableAdapter = new SqlDataAdapter("SELECT * FROM teams", SqlCon);
                //    DataSet ds = new DataSet();
                //    ProjectTableTableAdapter.Fill(ds, "First_name");

                //    obj.ProjectComboBox.ItemsSource = ds.Tables["First_name"].DefaultView;
                //    obj.ProjectComboBox.DisplayMemberPath = "ProjectName";
                //    obj.ProjectComboBox.SelectedValuePath = "RFIDirectory";
                //}
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
