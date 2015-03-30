﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Navigation;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Data.Linq.Mapping;
using Microsoft.Phone.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Pijlpunten
{
    public class DatabaseOperations : PhoneApplicationPage
    {
        DBpijlpuntenContext DBCon = new DBpijlpuntenContext(DBpijlpuntenContext.ConnectionString);

        //Get archers from database
        public List<Tbl_Archer> GetArcher()
        {
            List<Tbl_Archer> Archer_table = new List<Tbl_Archer>();
            if (DBCon.CreateIfNotExists() == false)
            {
                MessageBox.Show("There is no database, it has now been created.");
                DBCon.CreateIfNotExists();
            }
            DBCon.LogDebug = true;

            var tmp = from s in DBCon.Tbl_Archer select s;
            Archer_table = tmp.ToList();

            return Archer_table;
        }

        
        public void commitScore(int Scoretocommit, int archerid)
        {

                Tbl_Score tblScore = new Tbl_Score();
                tblScore.Score_Totaal = Scoretocommit;
                tblScore.Archer_ID = archerid;
                DBCon.Tbl_Score.InsertOnSubmit(tblScore);
                DBCon.SubmitChanges();
        }

        public List<Tbl_Archer> SelectedArcher(string selecteduser)
        {
            List<Tbl_Archer> tblArcher = new List<Tbl_Archer>();
            var tmp = from s in DBCon.Tbl_Archer where s.Archer_Name == selecteduser select s;
            tblArcher = tmp.ToList();

            return tblArcher;
        }
    }
}