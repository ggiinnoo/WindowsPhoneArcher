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

namespace Pijlpunten.Pages
{
    public partial class ScoreBekijken : PhoneApplicationPage
    {
        DatabaseOperations DBo = new DatabaseOperations();
        public ScoreBekijken()
        {
            InitializeComponent();

            
            var temp = DBo.GetScoreDate(Pijlpunten.MainPage.ArcherID);
            foreach (Tbl_Score item in temp)
            {
                lbDate.Items.Add(item.Date.ToString());
                lbScore.Items.Add(item.Score_Totaal.ToString());
            }

        }

        //Go back to main menu
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}