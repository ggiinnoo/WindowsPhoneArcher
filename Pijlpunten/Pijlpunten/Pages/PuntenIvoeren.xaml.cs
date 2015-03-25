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

        private void E1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void E2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("2");
        }

        private void E3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("3");
        }

        private void E4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("4");
        }

        private void E5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("5");
        }

        private void E6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("6");
        }

        private void E7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("7");
        }

        private void E8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("8");
        }

        private void E9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("9");
        }

        private void E10_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("10");
        }
    }
}