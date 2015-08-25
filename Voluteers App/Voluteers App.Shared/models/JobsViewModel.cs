using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Voluteers_App.Classes;
using Windows.UI.Xaml;

namespace Voluteers_App.models
{
    class JobsViewModel
    {
        private App app = (Application.Current as App);
        private ObservableCollection<JobViewModel> job;
        public ObservableCollection<JobViewModel> Job
        {
            get { return job; }

            set
            {
                if (job == value)
                {
                    return;
                }
                job = value;

            }
        }
        public ObservableCollection<JobViewModel> getAllJobs()
        {
            job = new ObservableCollection<JobViewModel>();
            using (var db = new SQLite.SQLiteConnection(app.dbPath))
            {
                var query = db.Table<Job>();

                foreach (var j in query)
                {
                    var jo = new JobViewModel()
                    {
                       ID = j.Id,
                       JOB_NAME = j.name,
                       Address = j.address
                    };
                    job.Add(jo);
                }
            }
            return job;
        }
    }
}
