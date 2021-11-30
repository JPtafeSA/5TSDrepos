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
using SQLite;
using StartFinance.Models;
using Windows.UI.Popups;
using SQLite.Net;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StartFinance.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContactDetailsPage : Page
    {
        SQLiteConnection conn; // adding an SQLite connection
        string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "Findata.sqlite");

        public ContactDetailsPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            /// Initializing a database
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            // Creating table
            Results();
        }

        public void Results()
        { // Creating table
            conn.CreateTable<ContactDetail>();
            /// Refresh Data
            var query1 = conn.Table<ContactDetail>();

            ContactDetailsView.ItemsSource = query1.ToList();
        }

        private async void AddContact_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if (_FirstName.Text.ToString() == "")
                {
                    MessageDialog dialog = new MessageDialog("No value entered", "Oops..!");
                    await dialog.ShowAsync();
                }
                else
                {

                    conn.CreateTable<ContactDetail>();
                    conn.Insert(new ContactDetail
                    {
                        FirstName = _FirstName.Text.ToString(),
                        LastName = _LastName.Text.ToString(),
                        CompanyName = _CompanyName.Text.ToString(),
                        MobilePhone = _MobilePhone.Text.ToString(),
                    });
                    // Creating table
                    Results();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageDialog dialog = new MessageDialog("You forgot to enter the Name", "Oops..!");
                    await dialog.ShowAsync();
                }
                else if (ex is SQLiteException)
                {
                    MessageDialog dialog = new MessageDialog("Contact already exist, Try Different Name", "Try Again!");
                    await dialog.ShowAsync();
                }
                else
                {
                    MessageDialog dialog = new MessageDialog("Unknown Error", "Try Again!");
                    await dialog.ShowAsync();
                }
            }
        }

        private async void DeleteContact_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string AccSelection = ((ContactDetail)ContactDetailsView.SelectedItem).FirstName;
                //  string AccSelection = "";
                if (AccSelection == "")
                {
                    MessageDialog dialog = new MessageDialog("No selected Item", "Oops..!");
                    await dialog.ShowAsync();
                }

                else
                {
                    conn.CreateTable<ContactDetail>();
                    var query1 = conn.Table<ContactDetail>();
                    var query3 = conn.Query<ContactDetail>("DELETE FROM ContactDetail WHERE FirstName ='" + AccSelection + "'");
                    ContactDetailsView.ItemsSource = query1.ToList();
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException)
                {
                    MessageDialog dialog = new MessageDialog("No item selected", "Try Again!");
                    await dialog.ShowAsync();
                }
            }
        }


        private async void UpdateContact_Click(object sender, RoutedEventArgs e)
        {
            try

            {
                int Appid = ((ContactDetail)ContactDetailsView.SelectedItem).ContactID;           

                // var setFirstName = conn.Query<ContactDetail>("SELECT FirstName FROM ContactDetail WHERE ContactID =" + Appid + "");

       //         _FirstName.Text = setFirstName.ToString();

                if (_FirstName.Text.ToString() == "")
                {
                    MessageDialog dialog = new MessageDialog("No value entered", "Try Again..!");
                    await dialog.ShowAsync();
                }
                else
                {

                    // conn.CreateTable<Appointments>();
                    var query1 = conn.Query<ContactDetail>("UPDATE ContactDetail set FirstName ='" + _FirstName.Text.ToString() + "' WHERE ContactID =" + Appid + "");
                    var query2 = conn.Query<ContactDetail>("UPDATE ContactDetail set LastName = '" + _LastName.Text.ToString() + "' WHERE ContactID ='" + Appid + "'");
                    var query3 = conn.Query<ContactDetail>("UPDATE ContactDetail set CompanyName = '" + _CompanyName.Text.ToString() + "' WHERE ContactID ='" + Appid + "'");
                    var query4 = conn.Query<ContactDetail>("UPDATE ContactDetail set MobilePhone = '" + _MobilePhone.Text.ToString() + "' WHERE ContactID ='" + Appid + "'");

                    Results();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageDialog dialog = new MessageDialog("You forgot the name", "Try Again..!");
                    await dialog.ShowAsync();
                }
                else if (ex is SQLiteException)
                {
                    MessageDialog dialog = new MessageDialog("Contact already exist, Try Different Name", "Try Again!");
                    await dialog.ShowAsync();
                }
                else if (ex is NullReferenceException)
                {
                    MessageDialog dialog = new MessageDialog("Try Different Name", "Try Again!");
                    await dialog.ShowAsync();
                }
                else
                {
                    MessageDialog dialog = new MessageDialog("Unknown Error", "Try Again!");
                    await dialog.ShowAsync();
                }
            }
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Results();
        }
    }
}

