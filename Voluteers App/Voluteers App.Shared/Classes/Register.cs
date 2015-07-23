using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voluteers_App.Classes
{
[Table("Register")]
    class Register
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name {get; set;}
      
        public string surname{get; set;}
        public int age{get; set;}
        public string idNumber{get; set;}
        public string contactNum{get; set;}
        public string emailAddress{get; set;}

        public string username { get; set; }

        public string password { get; set; }
    }
}
