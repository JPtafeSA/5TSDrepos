﻿#pragma checksum "G:\5TSDrepos\StarFinanceMaster\InstaRichie\Views\Busy.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C18BC87229AA862FF40F0BB621E405BC"
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
    partial class Busy : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(global::Windows.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Busy_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IBusy_Bindings
        {
            private global::StartFinance.Views.Busy dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ProgressRing obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2IsActiveDisabled = false;
            private static bool isobj3TextDisabled = false;

            private Busy_obj1_BindingsTracking bindingsTracking;

            public Busy_obj1_Bindings()
            {
                this.bindingsTracking = new Busy_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 18 && columnNumber == 46)
                {
                    isobj2IsActiveDisabled = true;
                }
                else if (lineNumber == 21 && columnNumber == 24)
                {
                    isobj3TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\Busy.xaml line 17
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ProgressRing)target;
                        break;
                    case 3: // Views\Busy.xaml line 19
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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

            // IBusy_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::StartFinance.Views.Busy)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::StartFinance.Views.Busy obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_IsBusy(obj.IsBusy, phase);
                        this.Update_BusyText(obj.BusyText, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_BusyText(phase);
                    }
                }
            }
            private void Update_IsBusy(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Busy.xaml line 17
                    if (!isobj2IsActiveDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(this.obj2, obj);
                    }
                }
            }
            private void Update_BusyText(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Busy.xaml line 19
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                    }
                }
            }

            private void UpdateFallback_BusyText(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Busy.xaml line 19
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, "BusyText", null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class Busy_obj1_BindingsTracking
            {
                private global::System.WeakReference<Busy_obj1_Bindings> weakRefToBindingObj; 

                public Busy_obj1_BindingsTracking(Busy_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<Busy_obj1_Bindings>(obj);
                }

                public Busy_obj1_Bindings TryGetBindingObject()
                {
                    Busy_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_IsBusy(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    Busy_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::StartFinance.Views.Busy obj = sender as global::StartFinance.Views.Busy;
                        if (obj != null)
                        {
                            bindings.Update_IsBusy(obj.IsBusy, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_BusyText(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    Busy_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::StartFinance.Views.Busy obj = sender as global::StartFinance.Views.Busy;
                        if (obj != null)
                        {
                            bindings.Update_BusyText(obj.BusyText, DATA_CHANGED);
                        }
                        else
                        {
                            bindings.UpdateFallback_BusyText(DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_IsBusy = 0;
                private long tokenDPC_BusyText = 0;
                public void UpdateChildListeners_(global::StartFinance.Views.Busy obj)
                {
                    Busy_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::StartFinance.Views.Busy.IsBusyProperty, tokenDPC_IsBusy);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::StartFinance.Views.Busy.BusyTextProperty, tokenDPC_BusyText);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_IsBusy = obj.RegisterPropertyChangedCallback(global::StartFinance.Views.Busy.IsBusyProperty, DependencyPropertyChanged_IsBusy);
                            tokenDPC_BusyText = obj.RegisterPropertyChangedCallback(global::StartFinance.Views.Busy.BusyTextProperty, DependencyPropertyChanged_BusyText);
                        }
                    }
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
            case 1: // Views\Busy.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    Busy_obj1_Bindings bindings = new Busy_obj1_Bindings();
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

