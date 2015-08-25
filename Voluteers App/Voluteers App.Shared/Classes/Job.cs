using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voluteers_App.Classes
{
    class Job
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }

        public string address { get; set; }

    }
}
