﻿#pragma checksum "C:\New folder\StarFinanceMaster\InstaRichie\Views\DebtPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4B71657E936618667B468A1E1075E8FC"
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
    partial class DebtPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class DebtPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IDebtPage_Bindings
        {
            private global::StartFinance.Views.DebtPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.AppBarButton obj27;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj28;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj29;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj27Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj28Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj29Click;

            // Static fields for each binding's enabled/disabled state

            public DebtPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 101 && columnNumber == 31)
                {
                    this.obj27.Click -= obj27Click;
                }
                else if (lineNumber == 102 && columnNumber == 31)
                {
                    this.obj28.Click -= obj28Click;
                }
                else if (lineNumber == 103 && columnNumber == 31)
                {
                    this.obj29.Click -= obj29Click;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 27: // Views\DebtPage.xaml line 101
                        this.obj27 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj27Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoSettings();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj27Click;
                        break;
                    case 28: // Views\DebtPage.xaml line 102
                        this.obj28 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj28Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoPrivacy();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj28Click;
                        break;
                    case 29: // Views\DebtPage.xaml line 103
                        this.obj29 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        this.obj29Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.GotoAbout();
                        };
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += obj29Click;
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

            // IDebtPage_Bindings

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
                    this.dataRoot = (global::StartFinance.Views.DebtPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::StartFinance.Views.DebtPage obj, int phase)
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
            case 1: // Views\DebtPage.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 4: // Views\DebtPage.xaml line 55
                {
                    this.ViewModel = (global::StartFinance.ViewModels.MainPageViewModel)(target);
                }
                break;
            case 5: // Views\DebtPage.xaml line 61
                {
                    this.AdaptiveVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 6: // Views\DebtPage.xaml line 62
                {
                    this.VisualStateNarrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7: // Views\DebtPage.xaml line 72
                {
                    this.VisualStateNormal = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 8: // Views\DebtPage.xaml line 82
                {
                    this.VisualStateWide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 9: // Views\DebtPage.xaml line 95
                {
                    this.pageHeader = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 10: // Views\DebtPage.xaml line 108
                {
                    this.AddDebtFooter = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 11: // Views\DebtPage.xaml line 118
                {
                    this.PayDebtFooter = (global::Template10.Controls.PageHeader)(target);
                }
                break;
            case 12: // Views\DebtPage.xaml line 132
                {
                    this.DebtPivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    ((global::Windows.UI.Xaml.Controls.Pivot)this.DebtPivot).SelectionChanged += this.DebtPivot_SelectionChanged;
                }
                break;
            case 13: // Views\DebtPage.xaml line 134
                {
                    this.AddDebt = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                }
                break;
            case 14: // Views\DebtPage.xaml line 165
                {
                    this.pageStart1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 15: // Views\DebtPage.xaml line 173
                {
                    this.DebtList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 16: // Views\DebtPage.xaml line 167
                {
                    this.AccountSelct = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 17: // Views\DebtPage.xaml line 170
                {
                    this.MoneyIn1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 18: // Views\DebtPage.xaml line 171
                {
                    this.Desc1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 19: // Views\DebtPage.xaml line 141
                {
                    this.pageStart = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 20: // Views\DebtPage.xaml line 147
                {
                    this.DebtList1 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 21: // Views\DebtPage.xaml line 144
                {
                    this.MoneyIn = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 22: // Views\DebtPage.xaml line 145
                {
                    this.Desc = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 23: // Views\DebtPage.xaml line 124
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element23 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element23).Click += this.PayDebt_Click;
                }
                break;
            case 24: // Views\DebtPage.xaml line 125
                {
                    this.DeleteItem = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.DeleteItem).Click += this.DeleteItem_Click;
                }
                break;
            case 25: // Views\DebtPage.xaml line 113
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element25 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element25).Click += this.AddData;
                }
                break;
            case 26: // Views\DebtPage.xaml line 114
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element26 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element26).Click += this.ClearFileds_Click;
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
            case 1: // Views\DebtPage.xaml line 17
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    DebtPage_obj1_Bindings bindings = new DebtPage_obj1_Bindings();
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

