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
        public string selectedUser;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            //DBo.GetArcher();
            var temp = DBo.GetArcher();

            foreach (Tbl_Archer item in temp)
            {
                UserSelection.Items.Add(item.Archer_Name);
                tbUserClub.Text = item.Archer_Guild;
            }
            UserSelection.SelectionChanged +=new SelectionChangedEventHandler(UserSelection_SelectionChanged);

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
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
            MessageBox.Show("Not availeble in this version");
        }

        private void UserSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedUser = UserSelection.SelectedItem.ToString();
            tbSelectedUser.Text = selectedUser.ToString();
        }
    }
}