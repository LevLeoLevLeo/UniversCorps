﻿#pragma checksum "..\..\..\DialogBox\WinDeleteQ.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18FB91136460081C7F4BCB7DC3FE1D4F9059DFC34FEFE12275A99E8214992B50"
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
using UniversCorps.WindowsCorp;


namespace UniversCorps.WindowsCorp {
    
    
    /// <summary>
    /// WinDeleteQ
    /// </summary>
    public partial class WinDeleteQ : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\DialogBox\WinDeleteQ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\DialogBox\WinDeleteQ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxbDeleteText;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\DialogBox\WinDeleteQ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnYes;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\DialogBox\WinDeleteQ.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNo;
        
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
            System.Uri resourceLocater = new System.Uri("/UniversCorps;component/dialogbox/windeleteq.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DialogBox\WinDeleteQ.xaml"
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
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\DialogBox\WinDeleteQ.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxbDeleteText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BtnYes = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\DialogBox\WinDeleteQ.xaml"
            this.BtnYes.Click += new System.Windows.RoutedEventHandler(this.BtnYes_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnNo = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\DialogBox\WinDeleteQ.xaml"
            this.BtnNo.Click += new System.Windows.RoutedEventHandler(this.BtnNo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

