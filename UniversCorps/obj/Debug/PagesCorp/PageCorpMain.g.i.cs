﻿#pragma checksum "..\..\..\PagesCorp\PageCorpMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A846FFBE5FECC56827851968C3CBBBD155A8CA7154B493E9452BB79124F6ACA8"
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
using UniversCorps.PagesCorp;


namespace UniversCorps.PagesCorp {
    
    
    /// <summary>
    /// PageCorpMain
    /// </summary>
    public partial class PageCorpMain : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\PagesCorp\PageCorpMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGCorps;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\PagesCorp\PageCorpMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddCorp;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\PagesCorp\PageCorpMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnChangeCorp;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\PagesCorp\PageCorpMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteCorp;
        
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
            System.Uri resourceLocater = new System.Uri("/UniversCorps;component/pagescorp/pagecorpmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PagesCorp\PageCorpMain.xaml"
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
            this.DGCorps = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BtnAddCorp = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\PagesCorp\PageCorpMain.xaml"
            this.BtnAddCorp.Click += new System.Windows.RoutedEventHandler(this.BtnAddCorp_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnChangeCorp = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\PagesCorp\PageCorpMain.xaml"
            this.BtnChangeCorp.Click += new System.Windows.RoutedEventHandler(this.BtnChangeCorp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnDeleteCorp = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\PagesCorp\PageCorpMain.xaml"
            this.BtnDeleteCorp.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteCorp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

