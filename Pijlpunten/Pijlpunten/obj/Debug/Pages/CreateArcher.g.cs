﻿#pragma checksum "C:\Users\Jorrit\Documents\GitHub\WindowsPhoneArcher\Pijlpunten\Pijlpunten\Pages\CreateArcher.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9BEA2E72CB7DBB44F25492560BB4BC81"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Pijlpunten.Pages {
    
    
    public partial class CreateArcher : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button btnCommit;
        
        internal System.Windows.Controls.Button btnBack;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBox tbArcherName;
        
        internal System.Windows.Controls.TextBox tbArcherGuild;
        
        internal System.Windows.Controls.Button button1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Pijlpunten;component/Pages/CreateArcher.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnCommit = ((System.Windows.Controls.Button)(this.FindName("btnCommit")));
            this.btnBack = ((System.Windows.Controls.Button)(this.FindName("btnBack")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.tbArcherName = ((System.Windows.Controls.TextBox)(this.FindName("tbArcherName")));
            this.tbArcherGuild = ((System.Windows.Controls.TextBox)(this.FindName("tbArcherGuild")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
        }
    }
}

