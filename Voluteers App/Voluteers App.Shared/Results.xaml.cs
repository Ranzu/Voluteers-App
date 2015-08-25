using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Results : Page
    {
        private int score = 0;
        private string strScore = string.Empty;
        public Results()
        {
            this.InitializeComponent();
            btnFailed.IsEnabled = false;
            btnNResults.IsEnabled = false;
        }

        private void btnNResults_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LogoutPage));
        }
        private void Commandhandler(IUICommand cmd)
        {
            var lable = cmd.Label;

            switch (lable)
            {
                case "Yes":

                    try
                    {
                        this.Frame.Navigate(typeof(Questions));
                    }
                    catch (Exception ex)
                    {
                        //messageBox("error " + ex.Message);
                    }
                    break;
                case "Quit Application":
                    this.Frame.Navigate(typeof(Choice));
                    break;

            }
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("You failed the would you like to try again?");
            dialog.Commands.Add(new UICommand("Yes", new UICommandInvokedHandler(Commandhandler)));
            dialog.Commands.Add(new UICommand("Quit Application", new UICommandInvokedHandler(Commandhandler)));
            await dialog.ShowAsync();
            //this.Frame.Navigate(typeof(Questions));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            strScore = e.Parameter as string;
            score = Int32.Parse(strScore);
            lblScore.Text = strScore+" Points";
             
             if (score > 9)
             {
                 btnNResults.IsEnabled = true;
             }
             else { btnFailed.IsEnabled = true; }
       
            base.OnNavigatedTo(e);
        }
        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
             
        }

        private void btntryagain_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Questions));
        }
    }
}
