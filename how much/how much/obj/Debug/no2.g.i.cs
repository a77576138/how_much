﻿#pragma checksum "..\..\no2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BB6F7BF74B51F05B3217CEC0FBBD4B3E15498425"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using how_much;


namespace how_much {
    
    
    /// <summary>
    /// no2
    /// </summary>
    public partial class no2 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\no2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid HoleItem;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\no2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Day;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\no2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\no2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemPrice;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/how much;component/no2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\no2.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HoleItem = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Day = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\no2.xaml"
            this.Day.GotFocus += new System.Windows.RoutedEventHandler(this.Day_GotFocus);
            
            #line default
            #line hidden
            
            #line 20 "..\..\no2.xaml"
            this.Day.LostFocus += new System.Windows.RoutedEventHandler(this.Day_LostFocus);
            
            #line default
            #line hidden
            
            #line 20 "..\..\no2.xaml"
            this.Day.Loaded += new System.Windows.RoutedEventHandler(this.Day_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ItemName = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\no2.xaml"
            this.ItemName.GotFocus += new System.Windows.RoutedEventHandler(this.ItemName_GotFocus);
            
            #line default
            #line hidden
            
            #line 24 "..\..\no2.xaml"
            this.ItemName.LostFocus += new System.Windows.RoutedEventHandler(this.ItemName_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ItemPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\no2.xaml"
            this.ItemPrice.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.itemPrice_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 27 "..\..\no2.xaml"
            this.ItemPrice.GotFocus += new System.Windows.RoutedEventHandler(this.ItemPrice_GotFocus);
            
            #line default
            #line hidden
            
            #line 27 "..\..\no2.xaml"
            this.ItemPrice.LostFocus += new System.Windows.RoutedEventHandler(this.ItemPrice_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

