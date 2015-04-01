using System;
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
        //Make the connection to the database.
        DBpijlpuntenContext DBCon = new DBpijlpuntenContext(DBpijlpuntenContext.ConnectionString);


        public void initializeDatabase()
        {
            //Create the database if it does not exists yet.
            DBCon.CreateIfNotExists();
            // For debugging if it crashes
            DBCon.LogDebug = true;
        }

        //Get archers from database
        public List<Tbl_Archer> GetArcher()
        {
            List<Tbl_Archer> Archer_table = new List<Tbl_Archer>();
            var tmp = from s in DBCon.Tbl_Archer select s;
            Archer_table = tmp.ToList();

            return Archer_table;
        }

        //Push score into database
        public void commitScore(int Scoretocommit, int archerid, string currentdate)
        {
                Tbl_Score tblScore = new Tbl_Score();
                tblScore.Score_Totaal = Scoretocommit;
                tblScore.Archer_ID = archerid;
                tblScore.Date = currentdate;
                DBCon.Tbl_Score.InsertOnSubmit(tblScore);
                DBCon.SubmitChanges();

        }

        //Get the data for the selected user in the main menu
        public List<Tbl_Archer> SelectedArcher(string selecteduser)
        {
            List<Tbl_Archer> tblArcher = new List<Tbl_Archer>();
            var tmp = from s in DBCon.Tbl_Archer where s.Archer_Name == selecteduser select s;
            tblArcher = tmp.ToList();

            return tblArcher;
        }

        //Gets the scores for the selected Archer
        public List<Tbl_Score> GetScoreDate(int archerid)
        {
            List<Tbl_Score> tblScore = new List<Tbl_Score>();

            var tmp = from s in DBCon.Tbl_Score where s.Archer_ID == archerid select s;
            tblScore = tmp.ToList();

            return tblScore;
        }

        //Create Archer into database
        public void createArcher(string ArcherName, string Guild)
        {

            Tbl_Archer addArcher = new Tbl_Archer();
            addArcher.Archer_Name = ArcherName;
            addArcher.Archer_Guild = Guild;
            DBCon.Tbl_Archer.InsertOnSubmit(addArcher);
            DBCon.SubmitChanges();

        }

       
        public void deleteArcherScore(int archerid)
        {
            var tmp = from s in DBCon.Tbl_Score where s.Archer_ID == archerid select s;
            Tbl_Score delarcherscore = tmp.FirstOrDefault();
            DBCon.Tbl_Score.DeleteOnSubmit(delarcherscore);
            DBCon.SubmitChanges();
        }
        //Delete the archer and his/hers information
        public void deleteArcher(int archerid)
        {
            var tmp = from s in DBCon.Tbl_Archer where s.Archer_Id == archerid select s;
            Tbl_Archer delArcher = tmp.FirstOrDefault();
            DBCon.Tbl_Archer.DeleteOnSubmit(delArcher);
            DBCon.SubmitChanges();

        }
    }
}