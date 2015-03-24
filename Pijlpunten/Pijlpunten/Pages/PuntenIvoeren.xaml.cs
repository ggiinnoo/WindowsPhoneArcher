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
    public partial class PuntenIvoeren : PhoneApplicationPage
    {
        string currentDate;

        public PuntenIvoeren()
        {
            InitializeComponent();

            //Set date to string and to screen
            currentDate = DateTime.UtcNow.Date.ToString("dd-MM-yyyy");
            TbDatum.Text = currentDate;
        }

        //Go back to menu
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}