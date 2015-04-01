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
        DatabaseOperations DBo = new DatabaseOperations();
        public PuntenIvoeren()
        {
            InitializeComponent();

            //Set date to string and to screen
            currentDate = DateTime.UtcNow.Date.ToString("dd-MM-yyyy");
            TbDatum.Text = currentDate;
        }
        int Count = 10; //aantal invoeringen
        int TotaalScore;
        int ScoreOpgeteld= 0;
        int ArrowCount = 0;
        private void ArrowScore(int ArrowPoint)
        {
            
            if (ArrowCount == 0)
            {
                tbArrow1.Text = ArrowPoint.ToString();
                ArrowCount++;
                TbArrowCount.Text = ArrowCount.ToString();
                ScoreOpgeteld = ArrowPoint;
                tbTotaal.Text = ScoreOpgeteld.ToString();
            }
            else if (ArrowCount == 1)
            {
                tbArrow2.Text = ArrowPoint.ToString();
                ArrowCount++;
                TbArrowCount.Text = ArrowCount.ToString();
                ScoreOpgeteld += ArrowPoint;
                tbTotaal.Text = ScoreOpgeteld.ToString();

            }
            else if (ArrowCount == 2)
            {
                tbArrow3.Text = ArrowPoint.ToString();
                ArrowCount++;
                TbArrowCount.Text = ArrowCount.ToString();
                tbTotaal.Text += ArrowPoint.ToString();
                ScoreOpgeteld += ArrowPoint;
                tbTotaal.Text = ScoreOpgeteld.ToString();
            }
            else if(ArrowCount >= 3)
            {
                MessageBox.Show("Maximaal aantal pijlen zijn al ingevoerd");
            }

        }
        private void yesnodialog(int arrow)
        {
            MessageBoxResult yesno = MessageBox.Show(arrow.ToString(), "weet je het zeker?", MessageBoxButton.OKCancel);

            if (yesno == MessageBoxResult.OK)
            {
                ArrowScore(arrow);
            }

            else if (yesno == MessageBoxResult.Cancel)
            {

            }
        }

        //Go back to the menu
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


        private void R0_Tap(object sender, System.Windows.Input.GestureEventArgs e){yesnodialog(0);}
        private void E1_Tap(object sender, System.Windows.Input.GestureEventArgs e){yesnodialog(1);} 
        private void E2_Tap(object sender, System.Windows.Input.GestureEventArgs e){ yesnodialog(2);}
        private void E3_Tap(object sender, System.Windows.Input.GestureEventArgs e){ yesnodialog(3);}
        private void E4_Tap(object sender, System.Windows.Input.GestureEventArgs e){ yesnodialog(4);}
        private void E5_Tap(object sender, System.Windows.Input.GestureEventArgs e){yesnodialog(5);}
        private void E6_Tap(object sender, System.Windows.Input.GestureEventArgs e){ yesnodialog(6);}
        private void E7_Tap(object sender, System.Windows.Input.GestureEventArgs e){yesnodialog(7);}
        private void E8_Tap(object sender, System.Windows.Input.GestureEventArgs e){ yesnodialog(8);}
        private void E9_Tap(object sender, System.Windows.Input.GestureEventArgs e){yesnodialog(9);}
        private void E10_Tap(object sender, System.Windows.Input.GestureEventArgs e){yesnodialog(10);}

        private void btnCommit_Click(object sender, RoutedEventArgs e)
        {
            if ((Count >= 0) && (tbArrow1.Text != "") && (tbArrow2.Text != "") && (tbArrow3.Text != ""))
            {
                MessageBox.Show("Score is ingevoerd");
                TotaalScore += ScoreOpgeteld;
                tbTotaalScore.Text = TotaalScore.ToString();
                ////reset
                tbTotaal.Text = "";
                ScoreOpgeteld = 0;
                ArrowCount = 0;
                tbArrow1.Text = "";
                tbArrow2.Text = "";
                tbArrow3.Text = "";
                Count--;
            }
            else
            {
                MessageBox.Show("Voer alle pijlen in");
            }
            if (Count == 0)
            {
                MessageBox.Show("Score is opgeslagen in de database");
                DBo.commitScore(TotaalScore, Pijlpunten.MainPage.ArcherID, currentDate);
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }

        }
    }
}