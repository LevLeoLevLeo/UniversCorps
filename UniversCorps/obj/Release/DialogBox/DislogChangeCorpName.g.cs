﻿#pragma checksum "..\..\..\DialogBox\DislogChangeCorpName.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5A5AFF7A1DF20218E6E976A7155AB1EE11B67B107FE2ABA307EBB1DA7FDF7082"
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
using UniversCorps.DialogBox;


namespace UniversCorps.DialogBox {
    
    
    /// <summary>
    /// DislogChangeCorpName
    /// </summary>
    public partial class DislogChangeCorpName : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\DialogBox\DislogChangeCorpName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\DialogBox\DislogChangeCorpName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbCorrectName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\DialogBox\DislogChangeCorpName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbNewName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\DialogBox\DislogChangeCorpName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnChange;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\DialogBox\DislogChangeCorpName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/UniversCorps;component/dialogbox/dislogchangecorpname.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DialogBox\DislogChangeCorpName.xaml"
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
            
            #line 21 "..\..\..\DialogBox\DislogChangeCorpName.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxbCorrectName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxbNewName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnChange = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\DialogBox\DislogChangeCorpName.xaml"
            this.BtnChange.Click += new System.Windows.RoutedEventHandler(this.BtnChange_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\DialogBox\DislogChangeCorpName.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

