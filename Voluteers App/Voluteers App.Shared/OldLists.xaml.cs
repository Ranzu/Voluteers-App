using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        private string[] names = {"thapelo","mphumi","tsholo"};
        private string[] ageNames = { "", "", "", "", "" };
        public OldLists()
        {
            this.InitializeComponent();
            lstOldAges.ItemsSource = ageNames;
            lstOrphanage.ItemsSource = names;
        }

        private void btnNextAges_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Questions));
        }

    }
}
