using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Voluteers_App.Classes;
using Voluteers_App.models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Voluteers_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Choice : Page
    {
        private JobViewModel jobModel = null;
        private Job job = null;
        OldAgeViewModel oldModel;
        OldAge oldAge = null;
        OrphanageViewModel orphanageModel;
        Orphanage orphanage;

        public Choice()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            try
            {
                job = new Job();
                jobModel = new JobViewModel();
                job = jobModel.getJobs();
                oldAge = new OldAge();
                oldModel = new OldAgeViewModel();
                oldAge = oldModel.getOldAges();
                orphanage = new Orphanage();
                orphanageModel = new OrphanageViewModel();
                orphanage = orphanageModel.getOrphanages();
                if (job == null)
                {
                    //populate jobs table if empty
                    jobModel.addJobManually("TUT Jobs", "http://www.tut.ac.za");
                    jobModel.addJobManually("Carees 24", "http://www.carees24.com");
                    jobModel.addJobManually("Goverment Jobs", "http://www.goverment.ac.za");
                    jobModel.addJobManually("Indeed Jobs", "http://www.indeed.com");  
                }
                //now populate old ages table if empty
                if (oldAge != null)
                {
                    oldModel.addOldAgeManually("Overall Search", "https://www.google.co.za/?gfe_rd=cr&ei=M13pVZSSGYKp8weova_IDw&gws_rd=ssl#q=oldAge");
                    oldModel.addOldAgeManually("Vermount Old Age", "http://community-services.blaauwberg.net/old-age-homes/old-age-homes-western-cape/Vermont-Old-Aged-Home-Hornlee");
                    oldModel.addOldAgeManually("SeniorServices Old Age", "https://www.google.co.za/?gfe_rd=cr&ei=M13pVZSSGYKp8weova_IDw&gws_rd=ssl#q=seniorservice");
                    oldModel.addOldAgeManually("Mothwa Haven Old Age", "http://www.yellowpages.co.za/business/SA_5878392_BUS");
                }
               
                //now populate orphanages table if empty
                if (orphanage != null)
                {
                    orphanageModel.addOphenagebManually("Tshwaraganang", "http://www.tshwaraganang.org.za/index.php/component/content/?view=featured");
                    orphanageModel.addOphenagebManually("Arcadia Home", "http://www.jhbchev.co.za/pages/default.aspx");
                    orphanageModel.addOphenagebManually("Sunnyside Orphanage Home", "http://www.soh.org.za/");
                    orphanageModel.addOphenagebManually("Overall Search", "https://www.google.co.za/?gfe_rd=cr&ei=M13pVZSSGYKp8weova_IDw&gws_rd=ssl#q=orphanage+");
                }
                             
            }
            catch (Exception ex)
            { 
                
            }
            base.OnNavigatedTo(e);
        }
        private void btnNChoice_Click(object sender, RoutedEventArgs e)
        {
            if (chbVolunteer.IsChecked == true)
            {
                this.Frame.Navigate(typeof(OldLists));
            }
           if (chbJob.IsChecked == true)
            {
                this.Frame.Navigate(typeof(JobPage));
            }
            //this.Frame.Navigate(typeof(OldLists));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginPage));
        }
    }
}
