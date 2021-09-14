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
    /// Appointments Features Page 
    /// Created by Joshua Pang
    /// 
    public sealed partial class AppointmentsPage : Page
    {
        SQLiteConnection conn; // adding an SQLite connection
        string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "Findata.sqlite");

        public AppointmentsPage()
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
            conn.CreateTable<Appointments>();
            /// Refresh Data
            var query1 = conn.Table<Appointments>();
     
            AppointmentsView.ItemsSource = query1.ToList();
        }

        private async void AddAppointments_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string CDay = _EventDate.Date.Value.Day.ToString();
                string CMonth = _EventDate.Date.Value.Month.ToString();
                string CYear = _EventDate.Date.Value.Year.ToString();
                string FinalDate = "" + CMonth + "/" + CDay + "/" + CYear;

                string StimeHour = _StartTime.Time.Hours.ToString();
                string StimeMin = _StartTime.Time.Minutes.ToString();
                string SFinalTime = "" + StimeHour + ":" + StimeMin;

                string EtimeHour = _EndTime.Time.Hours.ToString();
                string EtimeMin = _EndTime.Time.Minutes.ToString();
                string EFinalTime = "" + EtimeHour + ":" + EtimeMin;

                if (_EventName.Text.ToString() == "")
                {
                    MessageDialog dialog = new MessageDialog("No value entered", "Oops..!");
                    await dialog.ShowAsync();
                }
                else
                {
                
                    conn.CreateTable<Appointments>();
                    conn.Insert(new Appointments
                    {
                        EventName = _EventName.Text.ToString(),
                        Location = _Location.Text.ToString(),
                        EventDate = FinalDate,
                        StartTime = SFinalTime,
                        EndTime = EFinalTime,
                    }) ;
                    // Creating table
                    Results();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageDialog dialog = new MessageDialog("You forgot to enter the Amount or entered an invalid Amount", "Oops..!");
                    await dialog.ShowAsync();
                }
                else if (ex is SQLiteException)
                {
                    MessageDialog dialog = new MessageDialog("Appointment already exist, Try Different Name", "Try Again!");
                    await dialog.ShowAsync();
                }
                else
                {
                    MessageDialog dialog = new MessageDialog("Unknown Error", "Try Again!");
                    await dialog.ShowAsync();
                }
            }
        }

        private async void DeleteAppointments_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string AccSelection = ((Appointments)AppointmentsView.SelectedItem).EventName;
                //  string AccSelection = "";
                if (AccSelection == "")
                {
                    MessageDialog dialog = new MessageDialog("No selected Item", "Oops..!");
                    await dialog.ShowAsync();
                }

                else
                {
                    conn.CreateTable<Appointments>();
                    var query1 = conn.Table<Appointments>();
                    var query3 = conn.Query<Appointments>("DELETE FROM Appointments WHERE EventName ='" + AccSelection + "'");
                    AppointmentsView.ItemsSource = query1.ToList();
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
        

        private async void UpdateAppointments_Click(object sender, RoutedEventArgs e)
        {
            try
     
            {
                int Appid = ((Appointments)AppointmentsView.SelectedItem).AppointmentID;

                string CDay = _EventDate.Date.Value.Day.ToString();
                string CMonth = _EventDate.Date.Value.Month.ToString();
                string CYear = _EventDate.Date.Value.Year.ToString();
                string FinalDate = "" + CMonth + "/" + CDay + "/" + CYear;

                string StimeHour = _StartTime.Time.Hours.ToString();
                string StimeMin = _StartTime.Time.Minutes.ToString();
                string SFinalTime = "" + StimeHour + ":" + StimeMin;

                string EtimeHour = _EndTime.Time.Hours.ToString();
                string EtimeMin = _EndTime.Time.Minutes.ToString();
                string EFinalTime = "" + EtimeHour + ":" + EtimeMin;

                if (_EventName.Text.ToString() == "")
                {
                    MessageDialog dialog = new MessageDialog("No value entered", "Try Again..!");
                    await dialog.ShowAsync();
                }
                else
                {

                    // conn.CreateTable<Appointments>();
                     var query1 = conn.Query<Appointments>("UPDATE Appointments set EventName='" + _EventName.Text.ToString() +"' WHERE AppointmentID =" + Appid + "");
                    var query2 = conn.Query<Appointments>("UPDATE Appointments set Location = '" + _Location.Text.ToString() + "' WHERE AppointmentID ='" + Appid + "'");
                    var query3 = conn.Query<Appointments>("UPDATE Appointments set EventDate = '"+ FinalDate + "' WHERE AppointmentID ='" + Appid + "'");
                    var query4 = conn.Query<Appointments>("UPDATE Appointments set StartTime = '" + SFinalTime + "' WHERE AppointmentID ='" + Appid + "'");
                    var query5 = conn.Query<Appointments>("UPDATE Appointments set EndTime = '" + EFinalTime + "' WHERE AppointmentID ='" + Appid + "'");

                    Results();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageDialog dialog = new MessageDialog("You forgot to enter the Amount or entered an invalid Amount", "Try Again..!");
                    await dialog.ShowAsync();
                }
                else if (ex is SQLiteException)
                {
                    MessageDialog dialog = new MessageDialog("Appointment already exist, Try Different Name", "Try Again!");
                    await dialog.ShowAsync();
                }
                else if (ex is NullReferenceException)
                {
                    MessageDialog dialog = new MessageDialog("Event Name must be unique, Try Different Name", "Try Again!");
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

