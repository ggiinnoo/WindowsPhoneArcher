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
        public ScoreBekijken()
        {
            InitializeComponent();
            lbpunt1.Items.Add("2");
            lbpunt1.Items.Add("3");
            lbpunt1.Items.Add("9");
            lbpunt1.Items.Add("8");
        }

        //Go back to main menu
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}