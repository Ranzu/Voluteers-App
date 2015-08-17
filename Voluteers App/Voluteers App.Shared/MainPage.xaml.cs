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

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //string name;
            //string surname;
            //int age;
            //string idNumber;
            //string homeLanguage;
            //string contactNum;
            //string emailAddress;
            //string username;
            //string password;

            try
            {
                Register newUser = new Register()
                {

                    name = txtName.Text,
                    surname = txtSurname.Text,
                    age = Convert.ToInt32(txtAge.Text),
                    idNumber = txtId.Text,
                    homeLanguage = txtHomeLan.Text,
                    contactNum = txtNum.Text,
                    emailAddress = txtEmail.Text,
                    username = txtUsernames.Text,
                    password = txtPassword.Text

                };

                
                     SQLiteAsyncConnection conn = new SQLiteAsyncConnection("Register.db");
                    await conn.InsertAsync(newUser);

                   
              

            }
            catch(Exception exc)
            {
 
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


        /*private async void AddUserAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a random user
            User newUser = new User()
            {
                // the Id will be set by SQlite
                Name = string.Format("User X (created at {0})", DateTime.Now),
                City = "Rome, Italy"
            };

            // Add row to the User Table
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection("people.db");
            await conn.InsertAsync(newUser);

            // Add to the user list
            users.Add(newUser);

            // Refresh user list
            UserList.ItemsSource = null;
            UserList.ItemsSource = users;
        }*/
    }
}
