using ElectricityApp.model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Voluteers_App.Classes;
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
    /// 
    

    public sealed partial class MainPage : Page
    {
        private UserViewModel usermodel = null;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            usermodel = new UserViewModel();
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string idNumber = txtId.Text;
            string homeLanguage = txtHomeLan.Text;
            string contactNum = txtNum.Text;
            string  emailAddress = txtEmail.Text;
            string  username = txtUsernames.Text;
            string password = txtPassword.Text;

            try
            {
                usermodel.addUser(name,surname,age,idNumber,homeLanguage,contactNum,emailAddress,username,password);
            }
            catch(Exception exc)
            {
                MessageBox(exc.Message);
            }


            MessageBox("You are successful registered");

            
        }

        private async void MessageBox(string p)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(p);

            await msgDlg.ShowAsync();
        }

        private void btnLoginnn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginPage));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }


    }
}
