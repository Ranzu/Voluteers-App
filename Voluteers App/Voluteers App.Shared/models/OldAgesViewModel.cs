using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Voluteers_App.Classes;
using Windows.UI.Xaml;

namespace Voluteers_App.models
{
    class OldAgesViewModel
    {
        private App app = (Application.Current as App);
        private ObservableCollection<OldAgeViewModel> oldAge;
        public ObservableCollection<OldAgeViewModel> OldAge
        {
            get { return oldAge; }

            set
            {
                if (oldAge == value)
                {
                    return;
                }
                oldAge = value;

            }
        }
        public ObservableCollection<OldAgeViewModel> getOldAges()
        {
            oldAge = new ObservableCollection<OldAgeViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var query = db.Table<OldAge>();

                foreach (var j in query)
                {
                    var jo = new OldAgeViewModel()
                    {
                        ID = j.Id,
                        NAME = j.name,
                        Address = j.location
                    };
                    oldAge.Add(jo);
                }
            }
            return oldAge;
        }
    }
}
