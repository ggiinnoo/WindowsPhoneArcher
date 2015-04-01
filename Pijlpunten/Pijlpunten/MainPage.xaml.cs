using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

//Own added library's
using System.Windows.Navigation;

namespace Pijlpunten
{
    public partial class MainPage : PhoneApplicationPage
    {
        DatabaseOperations DBo = new DatabaseOperations();

        //Variables
        public string selectedUser;
        public static int ArcherID;

        public MainPage()
        {
            InitializeComponent();

            //If needed it creates the database
            DBo.initializeDatabase();
            var temp = DBo.GetArcher();

            foreach (Tbl_Archer item in temp)
            {
                UserSelection.Items.Add(item.Archer_Name);
                tbUserClub.Text = item.Archer_Guild;
            }
        }

        //Go to Add score view screen
        private void btnPinvoer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/PuntenIvoeren.xaml", UriKind.Relative));
        }

        //Go to score view screen
        private void btnScore_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/ScoreBekijken.xaml", UriKind.Relative));
        }

        //The options button
        private void btnOpties_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not available in this version");
        }

        //Go to Nieuw screen
        private void btnCreateArcher_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/CreateArcher.xaml", UriKind.Relative));
        }

        //When a other user is selected, it gets it information
        private void UserSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedUser = UserSelection.SelectedItem.ToString();
            tbSelectedUser.Text = selectedUser.ToString();
            var temp = DBo.SelectedArcher(selectedUser);
            foreach (Tbl_Archer item in temp)
            {
                ArcherID = item.Archer_Id;
                tbUserClub.Text = item.Archer_Guild;
            }
        }

        //Puts all of the archers in the list picker.
        private void UserSelection_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var temp = DBo.GetArcher();

            foreach (Tbl_Archer item in temp)
            {
                UserSelection.Items.Add(item.Archer_Name);
                tbUserClub.Text = item.Archer_Guild;
            }
        }

        //Deletes the current selected archer
        private void btnDeleteArcher_Click(object sender, RoutedEventArgs e)
        {
            //DBo.deleteArcherScore(ArcherID, selectedUser);
            DBo.deleteArcher(ArcherID);
        }
    }
}