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
    public sealed partial class LoginPage : Page
    {
        private UserViewModel usermodel = null;
        private User user = null;
        private Register regis;
        public LoginPage()
        {
            this.InitializeComponent();
        }



        private  void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername2.Text;
            string pass = txtPassword2.Text;
            usermodel = new UserViewModel();
            user = usermodel.getUser(username,pass);
            try
            {
                if (user != null)
                {
                    this.Frame.Navigate(typeof(Choice));
                }
                else { 
                    MessageBox("Error, Invalid Login");
                }       
              
            }
            catch(Exception ex)
            {
                MessageBox(ex.Message+" or Error, Invalid Login");
            }
        }


        private async void MessageBox(string p)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(p);

            await msgDlg.ShowAsync();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

          

    }
}
