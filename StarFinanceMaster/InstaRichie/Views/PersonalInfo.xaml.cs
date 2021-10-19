using SQLite.Net;
using StartFinance.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StartFinance.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PersonalInfo : Page
    {
        SQLiteConnection conn; // adding an SQLite connection
        string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "Findata.sqlite");

        public PersonalInfo()
        {
            this.InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            Results();
        }

        public void Results()
        {
            conn.CreateTable<Personal>();

            //Refresh Data
            var query = conn.Table<Personal>();
            PersonalInfoView.ItemsSource = query.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Results();
        }

        private async void AddPersonalInfo_Click(object sender, RoutedEventArgs e)
        {
            string Day = _DOB.Date.Day.ToString();
            string Month = _DOB.Date.Month.ToString();
            string Year = _DOB.Date.Year.ToString();
            string ChosenDate = "" + Day + "/" + Month + "/" + Year;

            try
            {
                if (_firstName.Text.ToString() == "" || _surname.Text.ToString() == "")
                {
                    MessageDialog dialog = new MessageDialog("You must enter all fields", "Oops..!");
                    await dialog.ShowAsync();
                }
                else if (_DOB.SelectedDate == null)
                {
                    MessageDialog dialog = new MessageDialog("You must enter all fields", "Oops..!");
                    await dialog.ShowAsync();
                }
                else if (_email.Text.ToString() == "")
                {
                    MessageDialog dialog = new MessageDialog("You must enter all fields", "Oops..!");
                    await dialog.ShowAsync();
                }
                else
                {
                    string gender;
                    if (Male.IsChecked == true)
                    {
                        gender = Male.Content.ToString();
                    }
                    else if (Female.IsChecked == true)
                    {
                        gender = Female.Content.ToString();
                    }
                    else
                    {
                        gender = Other.Content.ToString();
                    }
                    conn.Insert(new Personal()
                    {
                        FirstName = _firstName.Text,
                        Surname = _surname.Text,
                        DOB = ChosenDate,
                        Gender = gender,
                        Email = _email.Text,

                    }); ;
                    Results();
                }
            }

            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageDialog dialog = new MessageDialog("You forgot to enter the Value or entered an invalid Data", "Oops..!");
                    await dialog.ShowAsync();
                }
                else if (ex is SQLiteException)
                {
                    MessageDialog dialog = new MessageDialog("Personal Info already exist, Try Different Name", "Oops..!");
                    await dialog.ShowAsync();
                }
                else
                {
                    /// no idea
                }
            }
        }

        private async void DeletePersonalInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog ShowConf = new MessageDialog("Deleting this Account will delete all transactions of this account", "Important");
            ShowConf.Commands.Add(new UICommand("Yes, Delete")
            {
                Id = 0
            });
            ShowConf.Commands.Add(new UICommand("Cancel")
            {
                Id = 1
            });
            ShowConf.DefaultCommandIndex = 0;
            ShowConf.CancelCommandIndex = 1;

            var result = await ShowConf.ShowAsync();
            if ((int)result.Id == 0)
            {
                try
                {
                    string AccSelection = ((Personal)PersonalInfoView.SelectedItem).FirstName;
                    if (AccSelection == "")
                    {
                        MessageDialog dialog = new MessageDialog("Not selected the Item", "Oops..!");
                        await dialog.ShowAsync();
                    }
                    else
                    {
                        conn.CreateTable<Personal>();
                        var query1 = conn.Table<Personal>();
                        var query3 = conn.Query<Personal>("DELETE FROM Personal WHERE FirstName ='" + AccSelection + "'");
                        PersonalInfoView.ItemsSource = query1.ToList();
                    }
                }
                catch (NullReferenceException)
                {
                    MessageDialog dialog = new MessageDialog("Not selected the Item", "Oops..!");
                    await dialog.ShowAsync();
                }
            }

        }

        private async void EditPersonalInfo_Click(object sender, RoutedEventArgs e)
        {
            string Day = _DOB.Date.Day.ToString();
            string Month = _DOB.Date.Month.ToString();
            string Year = _DOB.Date.Year.ToString();
            string ChosenDate = "" + Day + "/" + Month + "/" + Year;

            string gender;
            if (Male.IsChecked == true)
            {
                gender = Male.Content.ToString();
            }
            else if (Female.IsChecked == true)
            {
                gender = Female.Content.ToString();
            }
            else
            {
                gender = Other.Content.ToString();
            }

            try
            {
                string AccSelection = ((Personal)PersonalInfoView.SelectedItem).FirstName;
                if (AccSelection == "")
                {
                    MessageDialog dialog = new MessageDialog("Please Select which one should be edited", "Oops..!");
                    await dialog.ShowAsync();
                }
                else
                {

                    string FirstName1 = _firstName.Text;
                    string Surname1 = _surname.Text;
                    string DOB1 = ChosenDate;
                    string Gender1 = gender;
                    string Email1 = _email.Text;

                    conn.CreateTable<Personal>();
                    var query = conn.Table<Personal>();
                    var queryEdit = conn.Query<Personal>("UPDATE Personal SET FirstName ='" + FirstName1 + "', Surname ='" + Surname1 + "', DOB ='" + DOB1 + "', Gender ='" + Gender1 + "', Email ='" + Email1 + "' WHERE FirstName ='" + AccSelection + "'");
                    Results();
                }

            }
            catch (NullReferenceException)
            {
                MessageDialog dialog = new MessageDialog("Please select record to edit ", "Error !!");
                await dialog.ShowAsync();

            }
        }

        private void Personalinfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Day = _DOB.Date.Day.ToString();
            string Month = _DOB.Date.Month.ToString();
            string Year = _DOB.Date.Year.ToString();
            string ChosenDate = "" + Day + "/" + Month + "/" + Year;

            string gender;
            if (Male.IsChecked == true)
            {
                gender = Male.Content.ToString();
            }
            else if (Female.IsChecked == true)
            {
                gender = Female.Content.ToString();
            }
            else
            {
                gender = Other.Content.ToString();
            }
            try
            {
                string selectFirstName = ((Personal)PersonalInfoView.SelectedItem).FirstName;
                string selectSurname = ((Personal)PersonalInfoView.SelectedItem).Surname;
                string selectDOB = ((Personal)PersonalInfoView.SelectedItem).DOB;
                string selectGender = ((Personal)PersonalInfoView.SelectedItem).Gender;
                string selectEmail = ((Personal)PersonalInfoView.SelectedItem).Email;



                _firstName.Text = selectFirstName;
                _surname.Text = selectSurname;
                ChosenDate = selectDOB;
                gender = selectGender;
                _email.Text = selectEmail;


            }
            catch (NullReferenceException)
            {
                NoFunction();
            }
        }

        private void NoFunction()
        {
            throw new NotImplementedException();
        }
    }
}
