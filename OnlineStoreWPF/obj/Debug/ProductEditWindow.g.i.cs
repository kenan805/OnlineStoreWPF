﻿#pragma checksum "..\..\ProductEditWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9C891518D1C51A2DED2FE7EBFAC05D5C8E0A18384C8D2193559C5D1387439E94"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OnlineStoreWPF;
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


namespace OnlineStoreWPF {
    
    
    /// <summary>
    /// ProductEditWindow
    /// </summary>
    public partial class ProductEditWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ProductEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridEditMain;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ProductEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgSelectedProduct;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ProductEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbProdName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ProductEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbProdPrice;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ProductEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnImgChnOrAdd;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\ProductEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddOrDeleteProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/OnlineStoreWPF;component/producteditwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductEditWindow.xaml"
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
            this.gridEditMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.imgSelectedProduct = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.txbProdName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txbProdPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnImgChnOrAdd = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\ProductEditWindow.xaml"
            this.btnImgChnOrAdd.Click += new System.Windows.RoutedEventHandler(this.Button_ImageChange_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddOrDeleteProduct = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\ProductEditWindow.xaml"
            this.btnAddOrDeleteProduct.Click += new System.Windows.RoutedEventHandler(this.Button_AddOrDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

