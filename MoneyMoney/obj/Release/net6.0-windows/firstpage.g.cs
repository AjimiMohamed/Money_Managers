﻿#pragma checksum "..\..\..\firstpage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E7E2FEA15F6D8A18A6CB82877E1FE34F51571A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using MoneyMoney;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace MoneyMoney {
    
    
    /// <summary>
    /// firstpage
    /// </summary>
    public partial class firstpage : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 79 "..\..\..\firstpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome sal;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\firstpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textUser;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\firstpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUser;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\firstpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textAmount;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\firstpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAmount;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\..\firstpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textCategory;
        
        #line default
        #line hidden
        
        
        #line 256 "..\..\..\firstpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCategory;
        
        #line default
        #line hidden
        
        
        #line 327 "..\..\..\firstpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock balancetext;
        
        #line default
        #line hidden
        
        
        #line 335 "..\..\..\firstpage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid membersDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MoneyMoney;component/firstpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\firstpage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 38 "..\..\..\firstpage.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sal = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 3:
            
            #line 137 "..\..\..\firstpage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textUser = ((System.Windows.Controls.TextBlock)(target));
            
            #line 181 "..\..\..\firstpage.xaml"
            this.textUser.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.textUser_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtUser = ((System.Windows.Controls.TextBox)(target));
            
            #line 187 "..\..\..\firstpage.xaml"
            this.txtUser.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUser_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textAmount = ((System.Windows.Controls.TextBlock)(target));
            
            #line 223 "..\..\..\firstpage.xaml"
            this.textAmount.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.textAmount_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtAmount = ((System.Windows.Controls.TextBox)(target));
            
            #line 229 "..\..\..\firstpage.xaml"
            this.txtAmount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtAmount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textCategory = ((System.Windows.Controls.TextBlock)(target));
            
            #line 252 "..\..\..\firstpage.xaml"
            this.textCategory.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.textCategory_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtCategory = ((System.Windows.Controls.TextBox)(target));
            
            #line 258 "..\..\..\firstpage.xaml"
            this.txtCategory.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtCategory_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 264 "..\..\..\firstpage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.transaction_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.balancetext = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.membersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 13:
            
            #line 361 "..\..\..\firstpage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.delete_Button_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
