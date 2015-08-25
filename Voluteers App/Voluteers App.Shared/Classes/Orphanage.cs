using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Voluteers_App.Classes
{
    class Orphanage
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }
        public string location { get; set; }

    }
}
