﻿using System;
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
            this.Close();
        }

        private void Constructor_Standings_Click(object sender, RoutedEventArgs e)
        {
            Constructor_Standings obj = new Constructor_Standings();
            obj.Show();
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
            obj.Show();
            this.Close();
        }
    }
}
