using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Voluteers_App.Classes;
using Windows.UI.Xaml;

namespace Voluteers_App.models
{
    class OrphanageViewModel
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
        public Orphanage getOrphanages()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var query = db.Query<Orphanage>("select * from Orphanage").FirstOrDefault();
                return query;
            }
        }
        public void addOphenagebManually(string name)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {
                    int data = db.Insert(new Orphanage()
                    {
                        Id = 0,
                        name = name,
                      
                    });
                }
                catch (Exception e)
                {

                }
            }

        }

        internal void addOphenagebManually(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public string Address { get; set; }
    }
}
