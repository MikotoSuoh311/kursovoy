﻿#pragma checksum "..\..\EnteryPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C877FB22D6A384F55FD4B6C7DA50B14B11A021E369AD41CB21927686EC9A67EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using curt;


namespace curt {
    
    
    /// <summary>
    /// EnteryPage
    /// </summary>
    public partial class EnteryPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\EnteryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSub;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\EnteryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGui;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\EnteryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStudy;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\EnteryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCurs;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\EnteryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSaveTheme;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\EnteryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExit;
        
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
            System.Uri resourceLocater = new System.Uri("/curt;component/enterypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EnteryPage.xaml"
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
            this.BtnSub = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\EnteryPage.xaml"
            this.BtnSub.Click += new System.Windows.RoutedEventHandler(this.BtnSub_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnGui = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\EnteryPage.xaml"
            this.BtnGui.Click += new System.Windows.RoutedEventHandler(this.BtnGui_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnStudy = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\EnteryPage.xaml"
            this.BtnStudy.Click += new System.Windows.RoutedEventHandler(this.BtnStudy_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnCurs = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\EnteryPage.xaml"
            this.BtnCurs.Click += new System.Windows.RoutedEventHandler(this.BtnCurs_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnSaveTheme = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\EnteryPage.xaml"
            this.BtnSaveTheme.Click += new System.Windows.RoutedEventHandler(this.BtnSaveTheme_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnExit = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\EnteryPage.xaml"
            this.BtnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
