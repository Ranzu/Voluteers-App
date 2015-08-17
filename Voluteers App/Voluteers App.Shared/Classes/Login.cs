using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace Voluteers_App.Classes
{
    [Table("Logins")]
    class Login
    {
        
        public string username { get; set; }

        public string password { get; set; }

    }
}
