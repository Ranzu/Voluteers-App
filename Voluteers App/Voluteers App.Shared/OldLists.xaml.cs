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
    public sealed partial class OldLists : Page
    {
        private OldAgesViewModel model = null;
        private OrphanagesViewModel modelOrph = null;
        ObservableCollection<OldAgeViewModel> oldAges = null;
        ObservableCollection<OrphanageViewModel> orphs = null;
        string myItem = string.Empty;
        string jobUrl = string.Empty;
        string orUrl = string.Empty;
        public OldLists()
        {
            this.InitializeComponent();
           
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            model = new OldAgesViewModel();
            oldAges = model.getOldAges();
           

            foreach (var old in oldAges)
            {
                lstOldAges.Items.Add(old.NAME +":"+old.Address);
            } 

            modelOrph = new OrphanagesViewModel();
            orphs = modelOrph.getOrphanages();
            foreach (var o in orphs)
            {
                lstOrphanage.Items.Add(o.NAME+":"+o.Address);
            }
            base.OnNavigatedTo(e);
        }
        private void btnNextAges_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Questions));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Choice));
        }

        private void lstOrphanage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = lstOrphanage.SelectedItems.ToArray();
            string oldAgeUrl = string.Empty;

            if (selectedItems != null)
            {
                foreach (var item in selectedItems)
                {
                    myItem = item.ToString();
                }
                orUrl = myItem.Substring(myItem.IndexOf(':') + 1);
            }
        }
        private async void MessageBox(string p)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(p);

            await msgDlg.ShowAsync();
        }
        private void lstOldAges_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = lstOldAges.SelectedItems.ToArray();
            string oldAgeUrl = string.Empty;

            if (selectedItems != null)
            {
                foreach (var item in selectedItems)
                {
                    myItem = item.ToString();
                }
                jobUrl = myItem.Substring(myItem.IndexOf(':') + 1);
            }
        }

        private void linkVisitOrphanage_Click(object sender, RoutedEventArgs e)
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
