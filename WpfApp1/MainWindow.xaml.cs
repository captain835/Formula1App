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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Driver_Standings_Click(object sender, RoutedEventArgs e)
        {
            Driver_Standings obj = new Driver_Standings();
            obj.Show();

            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC21\LOCALHOST; Initial Catalog=f1; Integrated Security=True");

            try
            {
                sqlCon.Open();

                //Create a query


                string query = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 1 and season_id=22";
                string query2 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 2 and season_id=22";
                string query3 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 3 and season_id=22";
                string query4 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 4 and season_id=22";
                string query5 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 5 and season_id=22";
                string query6 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 6 and season_id=22";
                string query7 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 7 and season_id=22";
                string query8 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 8 and season_id=22";
                string query9 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 9 and season_id=22";
                string query10 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 10 and season_id=22";
                string query11 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 11 and season_id=22";
                string query12 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 12 and season_id=22";
                string query13 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 13 and season_id=22";
                string query14 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 14 and season_id=22";
                string query15 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 15 and season_id=22";
                string query16 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 16 and season_id=22";
                string query17 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 17 and season_id=22";
                string query18 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 18 and season_id=22";
                string query19 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 19 and season_id=22";
                string query20 = "Select First_name,Last_name from driver_standings inner join drivers on driver_standings.driver_id = drivers.id where driver_standings.position = 20 and season_id=22";


                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader["First_name"].ToString() + " " + reader["last_name"].ToString(); ;
                    obj.p1.Content = name;
                }
                reader.Close();


                SqlCommand cmd2 = new SqlCommand(query2, sqlCon);
                SqlDataReader reader2;
                reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    string name = reader2["First_name"].ToString() + " " + reader2["last_name"].ToString(); ;
                    obj.p2.Content = name;
                }
                reader2.Close();



                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                SqlDataReader reader3;
                reader3 = cmd3.ExecuteReader();
                if (reader3.Read())
                {
                    string name = reader3["First_name"].ToString() + " " + reader3["last_name"].ToString(); ;

                    obj.p3.Content = name;
                }
                reader3.Close();




                SqlCommand cmd4 = new SqlCommand(query4, sqlCon);
                SqlDataReader reader4;
                reader4 = cmd4.ExecuteReader();
                if (reader4.Read())
                {
                    string name = reader4["First_name"].ToString() + " " + reader4["last_name"].ToString(); ;

                    obj.p4.Content = name;
                }
                reader4.Close();



                SqlCommand cmd5 = new SqlCommand(query5, sqlCon);
                SqlDataReader reader5;
                reader5 = cmd5.ExecuteReader();
                if (reader5.Read())
                {
                    string name = reader5["First_name"].ToString() + " " + reader5["last_name"].ToString(); ;

                    obj.p5.Content = name;
                }
                reader5.Close();


                SqlCommand cmd6 = new SqlCommand(query6, sqlCon);
                SqlDataReader reader6;
                reader6 = cmd6.ExecuteReader();
                if (reader6.Read())
                {
                    string name = reader6["First_name"].ToString() + " " + reader6["last_name"].ToString(); ;

                    obj.p6.Content = name;
                }
                reader6.Close();




                SqlCommand cmd7 = new SqlCommand(query7, sqlCon);
                SqlDataReader reader7;
                reader7 = cmd7.ExecuteReader();
                if (reader7.Read())
                {
                    string name = reader7["First_name"].ToString() + " " + reader7["last_name"].ToString(); ;

                    obj.p7.Content = name;
                }
                reader7.Close();




                SqlCommand cmd8 = new SqlCommand(query8, sqlCon);
                SqlDataReader reader8;
                reader8 = cmd8.ExecuteReader();
                if (reader8.Read())
                {
                    string name = reader8["First_name"].ToString() + " " + reader8["last_name"].ToString(); ;

                    obj.p8.Content = name;
                }
                reader8.Close();




                SqlCommand cmd9 = new SqlCommand(query9, sqlCon);
                SqlDataReader reader9;
                reader9 = cmd9.ExecuteReader();
                if (reader9.Read())
                {
                    string name = reader9["First_name"].ToString() + " " + reader9["last_name"].ToString(); ;

                    obj.p9.Content = name;
                }
                reader9.Close();



                SqlCommand cmd10 = new SqlCommand(query10, sqlCon);
                SqlDataReader reader10;
                reader10 = cmd10.ExecuteReader();
                if (reader10.Read())
                {
                    string name = reader10["First_name"].ToString() + " " + reader10["last_name"].ToString(); ;

                    obj.p10.Content = name;
                }
                reader10.Close();


                SqlCommand cmd11 = new SqlCommand(query11, sqlCon);
                SqlDataReader reader11;
                reader11 = cmd11.ExecuteReader();
                if (reader11.Read())
                {
                    string name = reader11["First_name"].ToString() + " " + reader11["last_name"].ToString(); ;

                    obj.p11.Content = name;
                }
                reader11.Close();

                SqlCommand cmd12 = new SqlCommand(query12, sqlCon);
                SqlDataReader reader12;
                reader12 = cmd12.ExecuteReader();
                if (reader12.Read())
                {
                    string name = reader12["First_name"].ToString() + " " + reader12["last_name"].ToString(); ;

                    obj.p12.Content = name;
                }
                reader12.Close();



                SqlCommand cmd13 = new SqlCommand(query13, sqlCon);
                SqlDataReader reader13;
                reader13 = cmd13.ExecuteReader();
                if (reader13.Read())
                {
                    string name = reader13["First_name"].ToString() + " " + reader13["last_name"].ToString(); ;

                    obj.p13.Content = name;
                }
                reader13.Close();




                SqlCommand cmd14 = new SqlCommand(query14, sqlCon);
                SqlDataReader reader14;
                reader14 = cmd14.ExecuteReader();
                if (reader14.Read())
                {
                    string name = reader14["First_name"].ToString() + " " + reader14["last_name"].ToString(); ;

                    obj.p14.Content = name;
                }
                reader14.Close();



                SqlCommand cmd15 = new SqlCommand(query15, sqlCon);
                SqlDataReader reader15;
                reader15 = cmd15.ExecuteReader();
                if (reader15.Read())
                {
                    string name = reader15["First_name"].ToString() + " " + reader15["last_name"].ToString(); ;

                    obj.p15.Content = name;
                }
                reader15.Close();


                SqlCommand cmd16 = new SqlCommand(query16, sqlCon);
                SqlDataReader reader16;
                reader16 = cmd16.ExecuteReader();
                if (reader16.Read())
                {
                    string name = reader16["First_name"].ToString() + " " + reader16["last_name"].ToString(); ;

                    obj.p16.Content = name;
                }
                reader16.Close();




                SqlCommand cmd17 = new SqlCommand(query17, sqlCon);
                SqlDataReader reader17;
                reader17 = cmd17.ExecuteReader();
                if (reader17.Read())
                {
                    string name = reader17["First_name"].ToString() + " " + reader17["last_name"].ToString(); ;

                    obj.p17.Content = name;
                }
                reader17.Close();




                SqlCommand cmd18 = new SqlCommand(query18, sqlCon);
                SqlDataReader reader18;
                reader18 = cmd18.ExecuteReader();
                if (reader18.Read())
                {
                    string name = reader18["First_name"].ToString() + " " + reader18["last_name"].ToString(); ;

                    obj.p18.Content = name;
                }
                reader18.Close();




                SqlCommand cmd19 = new SqlCommand(query19, sqlCon);
                SqlDataReader reader19;
                reader19 = cmd19.ExecuteReader();
                if (reader19.Read())
                {
                    string name = reader19["First_name"].ToString() + " " + reader19["last_name"].ToString(); ;

                    obj.p19.Content = name;
                }
                reader19.Close();



                SqlCommand cmd20 = new SqlCommand(query20, sqlCon);
                SqlDataReader reader20;
                reader20 = cmd20.ExecuteReader();
                if (reader20.Read())
                {
                    string name = reader20["First_name"].ToString() + " " + reader20["last_name"].ToString(); ;

                    obj.p20.Content = name;
                }
                reader20.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            this.Close();


            this.Close();
        }

        private void Constructor_Standings_Click(object sender, RoutedEventArgs e)
        {
            Constructor_Standings obj = new Constructor_Standings();
            obj.Show();

            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC21\LOCALHOST; Initial Catalog=f1; Integrated Security=True");

            try
            {
                sqlCon.Open();

                //Create a query


                string query = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 1 and season_id=22";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    obj.p1.Content = reader1["name"].ToString();
                }
                reader1.Close();



                string query2 = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 2 and season_id=22";

                SqlCommand cmd2 = new SqlCommand(query2, sqlCon);

                SqlDataReader reader2;
                reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    obj.p2.Content = reader2["name"].ToString();
                }
                reader2.Close();


                string query3 = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 3 and season_id=22";

                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);

                SqlDataReader reader3;
                reader3 = cmd3.ExecuteReader();
                if (reader3.Read())
                {
                    obj.p3.Content = reader3["name"].ToString();
                }
                reader3.Close();



                string query4 = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 4 and season_id=22";

                SqlCommand cmd4 = new SqlCommand(query4, sqlCon);

                SqlDataReader reader4;
                reader4 = cmd4.ExecuteReader();
                if (reader4.Read())
                {
                    obj.p4.Content = reader4["name"].ToString();
                }
                reader4.Close();


                string query5 = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 5 and season_id=22";

                SqlCommand cmd5 = new SqlCommand(query5, sqlCon);

                SqlDataReader reader5;
                reader5 = cmd5.ExecuteReader();
                if (reader5.Read())
                {
                    obj.p5.Content = reader5["name"].ToString();
                }
                reader5.Close();

                string query6 = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 6 and season_id=22";

                SqlCommand cmd6 = new SqlCommand(query6, sqlCon);

                SqlDataReader reader6;
                reader6 = cmd6.ExecuteReader();
                if (reader6.Read())
                {
                    obj.p6.Content = reader6["name"].ToString();
                }
                reader6.Close();



                string query7 = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 7 and season_id=22";

                SqlCommand cmd7 = new SqlCommand(query7, sqlCon);

                SqlDataReader reader7;
                reader7 = cmd7.ExecuteReader();
                if (reader7.Read())
                {
                    obj.p7.Content = reader7["name"].ToString();
                }
                reader7.Close();



                string query8 = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 8 and season_id=22";

                SqlCommand cmd8 = new SqlCommand(query8, sqlCon);

                SqlDataReader reader8;
                reader8 = cmd8.ExecuteReader();
                if (reader8.Read())
                {
                    obj.p8.Content = reader8["name"].ToString();
                }
                reader8.Close();



                string query9 = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 9 and season_id=22";

                SqlCommand cmd9 = new SqlCommand(query9, sqlCon);

                SqlDataReader reader9;
                reader9 = cmd9.ExecuteReader();
                if (reader9.Read())
                {
                    obj.p9.Content = reader9["name"].ToString();
                }
                reader9.Close();


                string query10 = "Select [name] from team_standings inner join teams on team_standings.team_id = teams.id where team_standings.position = 10 and season_id=22";

                SqlCommand cmd10 = new SqlCommand(query10, sqlCon);

                SqlDataReader reader10;
                reader10 = cmd10.ExecuteReader();
                if (reader10.Read())
                {
                    obj.p10.Content = reader10["name"].ToString();
                }
                reader10.Close();








            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            this.Close();
        }

        private void Tracks_Click(object sender, RoutedEventArgs e)
        {
            Tracks obj = new Tracks();
            obj.Show();
            this.Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            obj.Show();
            this.Close();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            Profile obj = new Profile();
            User currentUser = new User();
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC21\LOCALHOST; Initial Catalog=f1; Integrated Security=True");
            try
            {
                sqlCon.Open();
                //Get username

                string queryUsername = "Select username from UserInfo where username = '" + currentUser.Id + "'";
                SqlCommand cmdUsername = new SqlCommand(queryUsername, sqlCon);
                SqlDataReader readerUsername;
                readerUsername = cmdUsername.ExecuteReader();
                if (readerUsername.Read())
                {
                    obj.username.Text = readerUsername["username"].ToString();
                    obj.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Username or Password Inncorrect");
                }

                readerUsername.Close();



                //Get  bio

                string queryBio = "Select bio from UserInfo where username = '" + currentUser.Id + "'";
                SqlCommand cmdBio = new SqlCommand(queryBio, sqlCon);
                SqlDataReader readerBio;
                readerBio = cmdBio.ExecuteReader();
                if (readerBio.Read())
                {
                    obj.bio.Text = readerBio["bio"].ToString();
                    obj.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Username or Password Inncorrect");
                }

                readerBio.Close();

                //Get favorite track
                string queryTrack = "Select favTrackId from UserInfo where username = '" + currentUser.Id + "'";
                SqlCommand cmdTrack = new SqlCommand(queryBio, sqlCon);
                SqlDataReader readerTrack;
                readerTrack = cmdTrack.ExecuteReader();
                if (readerTrack.Read())
                {


                    switch ((int)readerTrack["favTrackId"])
                    {
                        case 1:
                            string imageTrack =
                            break;

                        case 2:

                            break;

                        case 3:

                            break;

                        case 4:

                            break;

                        case 5:
                            break;

                        case 6:
                            break;

                        case 7:
                            break;

                        case 8:

                            break;

                        case 9:
                            break;

                        case 10:
                            break;

                        case 11:

                            break;
                        case 12:
                            break;

                        case 13:
                            break;

                        case 14:
                            break;

                        case 15:
                            break;

                        case 16:
                            break;

                        case 17:
                            break;

                        case 18:
                            break;

                        case 19:
                            break;

                        case 20:
                            break;





                    }

                }


                readerTrack.Close();

                //Get favorite driver
                string queryDriver = "Select favDriverId from UserInfo where username = '" + currentUser.Id + "'";
                SqlCommand cmdDriver = new SqlCommand(queryBio, sqlCon);
                SqlDataReader readerDriver;
                readerDriver = cmdDriver.ExecuteReader();
                if (readerDriver.Read())
                {
                    string imageDriver;
                    switch ((int)readerDriver["favDriverId"])
                    {
                        case 1:
                            imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Verstappen.jpg";
                            break;

                        case 2:
                            imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Seargent.png";
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
                            imageDriver = "pack://application:,,,/Resources(Images)\\Drivers\\Stroll.png";
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


                    readerDriver.Close();


                    //Get favorite team
                    string queryTeam = "Select favTeamId from UserInfo where username = '" + currentUser.Id + "'";
                    SqlCommand cmdTeam = new SqlCommand(queryBio, sqlCon);
                    SqlDataReader readerTeam;
                    readerTeam = cmdTeam.ExecuteReader();
                    if (readerTeam.Read())
                    {
                        obj.bio.Text = readerTeam["bio"].ToString();
                        obj.Show();
                        this.Close();

                    }


                    readerTeam.Close();


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
}