﻿#pragma checksum "G:\5TSDrepos\StarFinanceMaster\InstaRichie\Views\AppointmentsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "700C2D9560009332F6DDDD895A4644EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartFinance.Views
{
    partial class AppointmentsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AppointmentsPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAppointmentsPage_Bindings
        {
            private global::StartFinance.Views.AppointmentsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.AppBarButton obj26;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj27;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj28;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj26Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj27Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj28Click;

            // Static fields for each binding's enabled/disabled state

            public AppointmentsPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 80 && columnNumber == 31)
                {
                    this.obj26.Click -= obj26Click;
                }
                else if (lineNumber == 81 && columnNumber == 31)
                {
                    this.obj27.Click -= obj27Click;
                }
                else if (lineNumber == 82 && columnNumber == 31)
                {
                    this.obj28.Click -= obj28Click;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 26: // Views\AppointmentsPage.xaml line 80
                        this.obj26 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj26Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoSettings();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj26Click;
                        break;
                    case 27: // Views\AppointmentsPage.xaml line 81
                        this.obj27 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj27Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoPrivacy();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj27Click;
                        break;
                    case 28: // Views\AppointmentsPage.xaml line 82
                        this.obj28 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj28Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoAbout();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj28Click;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IAppointmentsPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::StartFinance.Views.AppointmentsPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::StartFinance.Views.AppointmentsPage obj, int phase)
            {
                if (obj != null)
                {
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\AppointmentsPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // Views\AppointmentsPage.xaml line 18
                {
                    this.ViewModel = (global::StartFinance.ViewModels.MainPageViewModel)(target);
                }
                break;
            case 4: // Views\AppointmentsPage.xaml line 40
                {
                    this.AdaptiveVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 5: // Views\AppointmentsPage.xaml line 41
                {
                    this.VisualStateNarrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // Views\AppointmentsPage.xaml line 51
                {
                    this.VisualStateNormal = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7: // Views\AppointmentsPage.xaml line 61
                {
                    this.VisualStateWide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 8: // Views\AppointmentsPage.xaml line 74
                {
                    this.pageHeader = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 9: // Views\AppointmentsPage.xaml line 87
                {
                    this.pageFooter = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 10: // Views\AppointmentsPage.xaml line 128
                {
                    this.AppointmentsView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 11: // Views\AppointmentsPage.xaml line 120
                {
                    this.AppIdHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\AppointmentsPage.xaml line 121
                {
                    this.EventNameHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\AppointmentsPage.xaml line 122
                {
                    this.LocationHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Views\AppointmentsPage.xaml line 123
                {
                    this.eventdateHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Views\AppointmentsPage.xaml line 124
                {
                    this.StartTimeHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Views\AppointmentsPage.xaml line 125
                {
                    this.EndTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\AppointmentsPage.xaml line 112
                {
                    this._EventName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 18: // Views\AppointmentsPage.xaml line 113
                {
                    this._Location = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 19: // Views\AppointmentsPage.xaml line 114
                {
                    this._EventDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 20: // Views\AppointmentsPage.xaml line 115
                {
                    this._StartTime = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 21: // Views\AppointmentsPage.xaml line 116
                {
                    this._EndTime = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 22: // Views\AppointmentsPage.xaml line 117
                {
                    this.Note = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23: // Views\AppointmentsPage.xaml line 92
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element23 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element23).Click += this.AddAppointments_Click;
                }
                break;
            case 24: // Views\AppointmentsPage.xaml line 93
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element24 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element24).Click += this.DeleteAppointments_Click;
                }
                break;
            case 25: // Views\AppointmentsPage.xaml line 94
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element25 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element25).Click += this.UpdateAppointments_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\AppointmentsPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    AppointmentsPage_obj1_Bindings bindings = new AppointmentsPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
