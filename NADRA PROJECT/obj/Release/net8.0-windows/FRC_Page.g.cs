﻿#pragma checksum "..\..\..\FRC_Page.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "955B7437E7948EE52A6A9A13BD9D6E04364EBB0E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NADRA_PROJECT;
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


namespace NADRA_PROJECT {
    
    
    /// <summary>
    /// FRC_Page
    /// </summary>
    public partial class FRC_Page : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\..\FRC_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyNowButton;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\FRC_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ByBirthLabel;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\FRC_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ByMarriageLabel;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\FRC_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ByAdoptionLabel;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\FRC_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ByBirthText;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\FRC_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ByAdoptionText;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\FRC_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ByMarriageText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NADRA PROJECT;component/frc_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FRC_Page.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ApplyNowButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\FRC_Page.xaml"
            this.ApplyNowButton.Click += new System.Windows.RoutedEventHandler(this.ApplyNowButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ByBirthLabel = ((System.Windows.Controls.Label)(target));
            
            #line 101 "..\..\..\FRC_Page.xaml"
            this.ByBirthLabel.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ByBirthLabel_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ByMarriageLabel = ((System.Windows.Controls.Label)(target));
            
            #line 108 "..\..\..\FRC_Page.xaml"
            this.ByMarriageLabel.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ByMarriageLabel_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ByAdoptionLabel = ((System.Windows.Controls.Label)(target));
            
            #line 115 "..\..\..\FRC_Page.xaml"
            this.ByAdoptionLabel.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ByAdoptionLabel_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ByBirthText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ByAdoptionText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ByMarriageText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

