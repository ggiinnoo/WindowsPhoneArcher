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
        int Score = 0;
        int TotalScore= 0;
        int ArrowCount = 0;
        private void ArrowScore(int ArrowPoint)
        {
            
            if (ArrowCount == 0)
            {
                tbArrow1.Text = ArrowPoint.ToString();
                ArrowCount++;
                TbArrowCount.Text = ArrowCount.ToString();
                TotalScore = ArrowPoint;
                tbTotaal.Text = TotalScore.ToString();
            }
            else if (ArrowCount == 1)
            {
                tbArrow2.Text = ArrowPoint.ToString();
                ArrowCount++;
                TbArrowCount.Text = ArrowCount.ToString();
                TotalScore += ArrowPoint;
                tbTotaal.Text = TotalScore.ToString();

            }
            else if (ArrowCount == 2)
            {
                tbArrow3.Text = ArrowPoint.ToString();
                ArrowCount++;
                TbArrowCount.Text = ArrowCount.ToString();
                tbTotaal.Text += ArrowPoint.ToString();
                TotalScore += ArrowPoint;
                tbTotaal.Text = TotalScore.ToString();
            }
            else if(ArrowCount >= 3)
            {
                MessageBox.Show("Maximaal aantal pijlen zijn al ingevoerd");
            }


        }

        //Go back to the menu
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void E1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("1");
            ArrowScore(1);
        }

        private void E2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("2");
            ArrowScore(2);
        }

        private void E3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("3");
            ArrowScore(3);
        }

        private void E4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("4");
            ArrowScore(4);
        }

        private void E5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("5");
            ArrowScore(5);
        }

        private void E6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("6");
            ArrowScore(6);
        }

        private void E7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("7");
            ArrowScore(7);
        }

        private void E8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("8");
            ArrowScore(8);
        }

        private void E9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("9");
            ArrowScore(9);
        }

        private void E10_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("10");
            ArrowScore(10);
        }

        private void btnCommit_Click(object sender, RoutedEventArgs e)
        {
            if (Count >= 0)
            {
                MessageBox.Show("Score is ingevoerd");
                TotalScore += Score;
                ////reset
                TotalScore = 0;
                ArrowCount = 0;
                tbArrow1.Text = "";
                tbArrow2.Text = "";
                tbArrow3.Text = "";
                Count--;
            }
            if (Count == 0)
            {
                MessageBox.Show("Score is opgeslagen in de database");
                DBo.commitScore(Score, Pijlpunten.MainPage.ArcherID);
            }

        }
    }
}