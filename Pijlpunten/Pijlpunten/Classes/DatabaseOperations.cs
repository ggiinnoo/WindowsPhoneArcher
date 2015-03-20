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

namespace Pijlpunten.Classes
{
    public class DatabaseOperations : PhoneApplicationPage
    {

        DBpijlpuntenContext DBCon = new DBpijlpuntenContext(DBpijlpuntenContext.ConnectionString);
        //public void getarchers()
        //{
        //    list<string> archers = new list<string>();
        //    try
        //    {
        //        var tmp = from s in DBCon.tbl_archer
        //                  select s;
        //        foreach (tbl_archer item in tmp)
        //        {
        //            archers.add(item);
        //        }

        //    }
        //    catch
        //    {
        //    }
        //}
        
    }
}
