using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Voluteers_App.Classes;
using Windows.UI.Xaml;

namespace Voluteers_App.models
{
    class OldAgeViewModel
    {

        private App app = (Application.Current as App);
        private int id = 0;
        public int ID
        {
            get { return id; }
            set
            {
                if (id == value)
                {
                    return;
                }
                id = value;
            }
        }

        private string name = string.Empty;
        public string NAME
        {
            get { return name; }
            set
            {
                if (name == value)
                {
                    return;
                }
                name = value;
            }
        }
        private string address = string.Empty;
        public string Address
        {
            get { return address; }
            set
            {
                if (address == value)
                {
                    return;
                }
                address = value;
            }
        }
       public void addOldAgeManually(string name,string loc)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {
                    int data = db.Insert(new OldAge()
                    {
                        name = name,
                        location = loc
                    });
                }
                catch (Exception e)
                {

                }
            }

        }
       public OldAge getOldAges()
       {
           using (var db = new SQLite.SQLiteConnection(app.dbPath))
           {
               var query = db.Query<OldAge>("select * from OldAge").FirstOrDefault();
               return query;
           }
       }
    }
}
