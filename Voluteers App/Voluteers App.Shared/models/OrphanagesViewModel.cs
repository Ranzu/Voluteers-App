using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Voluteers_App.Classes;
using Windows.UI.Xaml;

namespace Voluteers_App.models
{
    class OrphanagesViewModel
    {
        private App app = (Application.Current as App);
        private ObservableCollection<OrphanageViewModel> o;
        public ObservableCollection<OrphanageViewModel> O
        {
            get { return o; }

            set
            {
                if (o == value)
                {
                    return;
                }
                o = value;

            }
        }
        public ObservableCollection<OrphanageViewModel> getOrphanages()
        {
            o = new ObservableCollection<OrphanageViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var query = db.Table<Orphanage>();

                foreach (var j in query)
                {
                    var jo = new OrphanageViewModel()
                    {
                        ID = j.Id,
                        NAME = j.name,
                    };
                    o.Add(jo);
                }
            }
            return o;
        }
    }
}
