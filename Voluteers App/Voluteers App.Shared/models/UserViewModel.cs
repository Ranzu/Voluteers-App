using System;
using System.Collections.Generic;
using System.Text;
using ElectricityApp;
using System.Linq;
using Windows.UI.Xaml;
using Voluteers_App;
using Voluteers_App.Classes;
namespace ElectricityApp.model
{
    class UserViewModel
    {

        private int Id = 0;
        public int ID
        {
            get { return Id; }

            set
            {
                if (Id == value)
                { return; }
                Id = value;
            }
        }
       
        private string fname = string.Empty;
        public string NAME
        {
            get { return fname; }

            set
            {
                if (fname == value)
                { return; }
                fname = value;
            }
        }
        private string lname = string.Empty;
        public string LNAME
        {
            get { return lname; }

            set
            {
                if (lname == value)
                { return; }
                lname = value;
            }
        }
        private string Age = string.Empty;
        public string AGE
        {
            get { return Age; }

            set
            {
                if (Age == value)
                { return; }
                Age = value;
            }
        }
        private string IdNumber = string.Empty;
        public string IDNUMBER
        {
            get { return IdNumber; }

            set
            {
                if (IdNumber == value)
                { return; }
                IdNumber = value;
            }
        }
        private string lang = string.Empty;
        public string LANGUAGE
        {
            get { return lang; }

            set
            {
                if (lang == value)
                { return; }
                lang = value;
            }
        }
        private string Contact = string.Empty;
        public string CONTACT
        {
            get { return Contact; }

            set
            {
                if (Contact == value)
                { return; }
                Contact = value;
            }
        }
        private string Email = string.Empty;
        public string EMAIL
        {
            get { return Email; }

            set
            {
                if (Email == value)
                { return; }
                Email = value;
            }
        }
        private string Username = string.Empty;
        public string USERNAME
        {
            get { return Username; }

            set
            {
                if (Username == value)
                { return; }
                Username = value;
            }
        }
        private App app = (Application.Current as App);
        private string Password = string.Empty;
        public string PASSWORD 
        {
            get { return Password; }

            set
            {
                if (Password == value)
                { return; }
                Password = value;
            }
        }
        public void addUser(string name, string surname, int age, string idNumber, string language, string contact, string email, string username, string password)
        {
            string result = string.Empty;
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            try {
                int success = db.Insert(new User() 
                {
                     name = name,
                     surname = surname,
                     age = age,
                     idNumber = idNumber,
                     homeLanguage = language,
                     contactNum = contact,
                     emailAddress = email,
                     username = username,
                     password = password
                });
            }
            catch (Exception e)
            {
                
            }
            //return "Success";
        }
        public User getUser(string username,string password)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var existingUser = db.Query<User>("select * from User where username = '" + username + "' and password = '" + password+"'").FirstOrDefault();
                return existingUser;
            }
        }
        public User verify(string username)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var existingUser = db.Query<User>("select * from User where username = '" + username + "'").Single();
                return existingUser;
            }
        }
        public User getPassowrd(string username)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var existingUser = db.Query<User>("select * from User where USER_EMAIL = '" + username + "'").FirstOrDefault();
                return existingUser;
            }
        }
        public User removeUser(string username)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var existingUser = db.Query<User>("delete from User where USER_EMAIL = '" + username + "'").FirstOrDefault();
                return existingUser;
            }
        }
        public void removeAllUsers(string username)
        {
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var existingUser = db.Query<User>("delete from User");
            }
        }
    }
}
