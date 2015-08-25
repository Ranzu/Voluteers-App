using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class JobPage : Page
    {
        private ObservableCollection<JobViewModel> jobs = null;
        private JobsViewModel job = null;
        string myItem = string.Empty;
        string jobUrl = string.Empty;
        public JobPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            job = new JobsViewModel();
            jobs = job.getAllJobs();
            foreach (var j in jobs)
            { 
                listView.Items.Add(j.JOB_NAME+" Website :"+j.Address);
            }
            
            base.OnNavigatedTo(e);
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = listView.SelectedItems.ToArray();
            
            if (selectedItems != null)
            {
                foreach (var item in selectedItems)
                {
                    myItem = item.ToString();
                }
                jobUrl = myItem.Substring(myItem.IndexOf(':') + 1);
               // 
                
                //MessageBox("You selected " + jobUrl);
            }
        }
        private async void MessageBox(string p)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(p);

            await msgDlg.ShowAsync();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Choice));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void linkVisit_Click(object sender, RoutedEventArgs e)
        {
            if (jobUrl.Equals(""))
            {
                MessageBox("You must select at least one item");
            }
            else
            {
                linkVisit.NavigateUri = new Uri(jobUrl);

            }
            
        }
    }
}
