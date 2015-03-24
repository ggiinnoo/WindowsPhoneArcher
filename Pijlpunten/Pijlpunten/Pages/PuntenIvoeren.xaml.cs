﻿using System;
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
        public PuntenIvoeren()
        {
            InitializeComponent();
            TbDatum.Text = DateTime.UtcNow.Date.ToString("dd-MM-yyyy");
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}