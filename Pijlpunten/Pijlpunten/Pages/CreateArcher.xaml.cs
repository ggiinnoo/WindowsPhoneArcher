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
    public partial class CreateArcher : PhoneApplicationPage
    {
        DatabaseOperations DBo = new DatabaseOperations();

        //Variables
        string ArcherName;
        string ArcherGuild;

        public CreateArcher()
        {
            InitializeComponent();
        }

        //Go back to the menu
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Add archer to database
        private void btnCommit_Click(object sender, RoutedEventArgs e)
        {
            //Put the info into strings
            tbArcherName.Text = ArcherName;
            tbArcherGuild.Text = ArcherGuild;

            //Check to see if the textboxes are emty, if they are not, the data will will be inserted
            if (tbArcherName == null && tbArcherGuild == null)
            {
                MessageBox.Show("Vul een goede gebruikersnaam in.");
            }
            else
            {
                DBo.createArcher(ArcherName, ArcherGuild);
                MessageBox.Show("Schutter aangemaakt.");
            }
        }
    }
}