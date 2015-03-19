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
                Archer_Name.Text = DBpijl.Tbl_Archer.ToString();
                Archer_Guild.Text = DBpijl.Tbl_Archer.ToString();
            }
        }
    }
}