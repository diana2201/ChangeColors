﻿#pragma checksum "E:\DOCUMENTOS\Aplicaciones Moviles\ChangeColor\ChangeColor\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1F48BC526DA68521A5EB3C86AB17454D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ChangeColor {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel Title;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.Pivot pestanas;
        
        internal Microsoft.Phone.Controls.PivotItem radio;
        
        internal System.Windows.Shapes.Rectangle RecRad;
        
        internal Microsoft.Phone.Controls.PivotItem check;
        
        internal System.Windows.Shapes.Rectangle RecCheck;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ChangeColor;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Title = ((System.Windows.Controls.StackPanel)(this.FindName("Title")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.pestanas = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pestanas")));
            this.radio = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("radio")));
            this.RecRad = ((System.Windows.Shapes.Rectangle)(this.FindName("RecRad")));
            this.check = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("check")));
            this.RecCheck = ((System.Windows.Shapes.Rectangle)(this.FindName("RecCheck")));
        }
    }
}

