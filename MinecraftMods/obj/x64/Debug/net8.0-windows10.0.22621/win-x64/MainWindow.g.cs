﻿#pragma checksum "C:\Users\15970\source\repos\MinecraftMods\MinecraftMods\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27471E8072881D532BD43634E36A95CE7E1F1847896811B6F612F43DCB509E5E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MinecraftMods
{
    partial class MainWindow : 
        global::WinUIEx.WindowEx, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBox_Text(global::Microsoft.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_MinecraftMods_Controls_IconButton_Command(global::MinecraftMods.Controls.IconButton obj, global::CommunityToolkit.Mvvm.Input.IRelayCommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::CommunityToolkit.Mvvm.Input.IRelayCommand) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::CommunityToolkit.Mvvm.Input.IRelayCommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_DevWinUI_ImageExBase_Source(global::DevWinUI.ImageExBase obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class MainWindow_obj7_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IMainWindow_Bindings
        {
            private global::MinecraftMods.Entries.ModItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj7;
            private global::DevWinUI.ImageEx obj8;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj9;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8SourceDisabled = false;
            private static bool isobj9TextDisabled = false;
            private static bool isobj10TextDisabled = false;

            public MainWindow_obj7_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 104 && columnNumber == 11)
                {
                    isobj8SourceDisabled = true;
                }
                else if (lineNumber == 107 && columnNumber == 22)
                {
                    isobj9TextDisabled = true;
                }
                else if (lineNumber == 108 && columnNumber == 22)
                {
                    isobj10TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // MainWindow.xaml line 97
                        this.obj7 = new global::System.WeakReference(global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target));
                        break;
                    case 8: // MainWindow.xaml line 101
                        this.obj8 = global::WinRT.CastExtensions.As<global::DevWinUI.ImageEx>(target);
                        break;
                    case 9: // MainWindow.xaml line 107
                        this.obj9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 10: // MainWindow.xaml line 108
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            public void DataContextChangedHandler(global::Microsoft.UI.Xaml.FrameworkElement sender, global::Microsoft.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Microsoft.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            var rootElement = (this.obj7.Target as global::Microsoft.UI.Xaml.Controls.StackPanel);
                            if (rootElement != null)
                            {
                                rootElement.DataContextChanged -= this.DataContextChangedHandler;
                            }
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_(global::WinRT.CastExtensions.As<global::MinecraftMods.Entries.ModItem>(item), 1 << phase);
            }

            public void Recycle()
            {
            }

            // IMainWindow_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::MinecraftMods.Entries.ModItem>(newDataRoot);
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MinecraftMods.Entries.ModItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Icon(obj.Icon, phase);
                        this.Update_Title(obj.Title, phase);
                        this.Update_Description(obj.Description, phase);
                    }
                }
            }
            private void Update_Icon(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainWindow.xaml line 101
                    if (!isobj8SourceDisabled)
                    {
                        XamlBindingSetters.Set_DevWinUI_ImageExBase_Source(this.obj8, obj, null);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainWindow.xaml line 107
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                    }
                }
            }
            private void Update_Description(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainWindow.xaml line 108
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private partial class MainWindow_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IMainWindow_Bindings
        {
            private global::MinecraftMods.MainWindow dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.ListView obj5;
            private global::Microsoft.UI.Xaml.Controls.TextBox obj11;
            private global::MinecraftMods.Controls.IconButton obj12;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5ItemsSourceDisabled = false;
            private static bool isobj11TextDisabled = false;
            private static bool isobj12CommandDisabled = false;

            private MainWindow_obj1_BindingsTracking bindingsTracking;

            public MainWindow_obj1_Bindings()
            {
                this.bindingsTracking = new MainWindow_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 91 && columnNumber == 29)
                {
                    isobj5ItemsSourceDisabled = true;
                }
                else if (lineNumber == 83 && columnNumber == 46)
                {
                    isobj11TextDisabled = true;
                }
                else if (lineNumber == 85 && columnNumber == 8)
                {
                    isobj12CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // MainWindow.xaml line 91
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                        break;
                    case 11: // MainWindow.xaml line 83
                        this.obj11 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                        this.bindingsTracking.RegisterTwoWayListener_11(this.obj11);
                        break;
                    case 12: // MainWindow.xaml line 84
                        this.obj12 = global::WinRT.CastExtensions.As<global::MinecraftMods.Controls.IconButton>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
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

            // IMainWindow_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::MinecraftMods.MainWindow>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MinecraftMods.MainWindow obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::MinecraftMods.ViewModels.MainViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ModItems(obj.ModItems, phase);
                        this.Update_ViewModel_KeyWord(obj.KeyWord, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_SearchCommand(obj.SearchCommand, phase);
                    }
                }
            }
            private void Update_ViewModel_ModItems(global::System.Collections.Generic.List<global::MinecraftMods.Entries.ModItem> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainWindow.xaml line 91
                    if (!isobj5ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ViewModel_KeyWord(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainWindow.xaml line 83
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBox_Text(this.obj11, obj, null);
                    }
                }
            }
            private void Update_ViewModel_SearchCommand(global::CommunityToolkit.Mvvm.Input.IRelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainWindow.xaml line 84
                    if (!isobj12CommandDisabled)
                    {
                        XamlBindingSetters.Set_MinecraftMods_Controls_IconButton_Command(this.obj12, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_11_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.KeyWord = this.obj11.Text;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainWindow_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainWindow_obj1_Bindings> weakRefToBindingObj; 

                public MainWindow_obj1_BindingsTracking(MainWindow_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainWindow_obj1_Bindings>(obj);
                }

                public MainWindow_obj1_Bindings TryGetBindingObject()
                {
                    MainWindow_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainWindow_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::MinecraftMods.ViewModels.MainViewModel obj = sender as global::MinecraftMods.ViewModels.MainViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_ModItems(obj.ModItems, DATA_CHANGED);
                                bindings.Update_ViewModel_KeyWord(obj.KeyWord, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "ModItems":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_ModItems(obj.ModItems, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "KeyWord":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_KeyWord(obj.KeyWord, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::MinecraftMods.ViewModels.MainViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::MinecraftMods.ViewModels.MainViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void RegisterTwoWayListener_11(global::Microsoft.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_11_Text();
                        }
                    };
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainWindow.xaml line 29
                {
                    this.ShowTransitions = global::WinRT.CastExtensions.As<global::CommunityToolkit.WinUI.Animations.ImplicitAnimationSet>(target);
                }
                break;
            case 3: // MainWindow.xaml line 41
                {
                    this.HideTransitions = global::WinRT.CastExtensions.As<global::CommunityToolkit.WinUI.Animations.ImplicitAnimationSet>(target);
                }
                break;
            case 4: // MainWindow.xaml line 58
                {
                    this.MyTitleBar = global::WinRT.CastExtensions.As<global::CommunityToolkit.WinUI.Controls.TitleBar>(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2411")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainWindow.xaml line 2
                {                    
                    global::WinUIEx.WindowEx element1 = (global::WinUIEx.WindowEx)target;
                    MainWindow_obj1_Bindings bindings = new MainWindow_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Activated += bindings.Activated;
                }
                break;
            case 7: // MainWindow.xaml line 97
                {                    
                    global::Microsoft.UI.Xaml.Controls.StackPanel element7 = (global::Microsoft.UI.Xaml.Controls.StackPanel)target;
                    MainWindow_obj7_Bindings bindings = new MainWindow_obj7_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element7.DataContext);
                    element7.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element7, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element7, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

