using System;
using System.Collections.Generic;
using System.Text;
using Voluteers_App.Classes;
using Windows.UI.Xaml;
using System.Linq;
namespace Voluteers_App.models
{
    class JobViewModel
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

        private string jobName = string.Empty;
        public string JOB_NAME
        {
            get { return jobName; }
            set
            {
                if (jobName == value)
                {
                    return;
                }
                jobName = value;
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
        public void update(string name,string address)
        {          
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {//db.Execute("update meterbox set currentUnits = currentUnits -" + used);
                    var existing = db.Query<Job>("select * from Job").First();

                    if (existing != null)
                    {
                        existing.name = name;
                        existing.address = address;
                        db.RunInTransaction(() =>
                        {
                            db.Update(existing);
                        });
                    }
                }

                catch (Exception e)
                {

                }
            }
        }
        public void addJobManually(string name, string address)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                try
                {
                    int data = db.Insert(new Job()
                    {
                        Id =0,
                        name = name,
                        address = address
                    });
                }
                catch (Exception e)
                {
                    
                }
            }

        }
        public Job getJobs()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var query = db.Query<Job>("select * from Job").FirstOrDefault();
                return query;
            }
        }
        /*
        public void deleteAllAppliances()
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                //db.CreateTable<Appliance>();
                //db.DropTable<Appliance>();
                var data = db.Table<Appliance>();
                var delete = db.Query<Appliance>("delete from appliance");
                if (db.Delete(delete) > 0)
                {

                }
                else
                {

                }

            }
        }
        public void deleteAllUsers()
        {
            using (var db = new SQLite.SQLiteConnection(app.DBPath))
            {
                var data = db.Table<User>();
                if (db.Delete(data) > 0)
                {

                }

            }

        }
        public void deleteAllUsersVersion2()
        {
            using (var db = new SQLite.SQLiteConnection(app.DBPath))
            {
                var data = db.Query<User>("delete from Appliance");
                if (db.Delete(data) > 0)
                {

                }

            }

        }

        public List<Appliance> getAppliance(string name)
        {
            using (var db = new SQLite.SQLiteConnection(app.DBPath))
            {
                var existingUser = db.Query<Appliance>("select * from Appliance where applianceName = '" + name + "'");
                return existingUser;
            }
        }*/
    }
}
