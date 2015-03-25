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
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           using (DBpijlpuntenContext DBpijl = new DBpijlpuntenContext(DBpijlpuntenContext.ConnectionString))
            {
                DBpijl.CreateIfNotExists();
                DBpijl.LogDebug = true;
                UserSelection.ItemsSource = DBpijl.Tbl_Archer.ToList();

                //List<DBpijlpuntenContext> Archers = new List<DBpijlpuntenContext>();
                //var getArcher = from DBpijlpunten in DBpijl.Tbl_Archer select Archer_Name;
                //foreach (var DBpijlpunten in getArcher)
                //{
                //    Archers.Add();
                //}
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
            MessageBox.Show("Not availeble in this version");
        }
    }
}