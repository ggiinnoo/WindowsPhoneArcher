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

        DBpijlpuntenContext DBCon = new DBpijlpuntenContext(DBpijlpuntenContext.ConnectionString);

        //Get archers from database
        
    }
}