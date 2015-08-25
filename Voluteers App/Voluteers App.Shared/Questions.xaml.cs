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
    public sealed partial class Questions : Page
    {
        private int score = 0;
        public Questions()
        {
            this.InitializeComponent();
            btnnext.IsEnabled = false;
        }

        private void btnNQues_Click(object sender, RoutedEventArgs e)
        {
            if ((radYes1.IsChecked == true || radNo1.IsChecked == true) &&
                (radYes2.IsChecked == true || radNo2.IsChecked == true || radNo2_Copy.IsChecked == true || radDontKnow2.IsChecked == true)
                && (radYes3.IsChecked == true || radNo3_Copy1.IsChecked == true || radNo3.IsChecked == true || radDontKnow3.IsChecked == true)
                && (radYes4.IsChecked == true || radNo4_Cop.IsChecked == true) || (radDontKnow4.IsChecked == true) || (radNo4.IsChecked == true))
            {
                if (radYes1.IsChecked == true)
                {
                    score = score + 5;
                }
                if (radYes2.IsChecked == true)
                {
                    score = score + 5;
                }
                if (radYes3.IsChecked == true)
                {
                    score = score + 5;
                }
                if (radYes4.IsChecked == true)
                {
                    score = score + 5;
                }
                MessageBox("You total score is " + score);
                btnnext.IsEnabled = true;
                btnNQues.IsEnabled = false;
            }
            else {
                MessageBox("Please note that you have to answer all the questions");
            }
           
            
            
            
       
        }
        private async void MessageBox(string p)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(p);

            await msgDlg.ShowAsync();
        }


        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(OldLists));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void linkRevert_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Questions));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string toSend = score+"";
            this.Frame.Navigate(typeof(Results),toSend);
        }
    }
}
