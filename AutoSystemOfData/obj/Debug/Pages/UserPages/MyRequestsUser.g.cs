﻿#pragma checksum "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "376433ED5AC88D540C61250ED708EAD3E167E146083ED586D7259F928E04FD48"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoSystemOfData.Pages.UserPages;
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


namespace AutoSystemOfData.Pages.UserPages {
    
    
    /// <summary>
    /// MyRequestsUser
    /// </summary>
    public partial class MyRequestsUser : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock orgTextBlock;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridRequestView;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoSystemOfData;component/pages/userpages/myrequestsuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
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
            
            #line 28 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToMainUserPage);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 30 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToPlanUserPage);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 31 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToSittingUserPage);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 32 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToFeedingUserPage);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 33 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToChemicalRegimentUserPage);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 34 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToHarvestingUserPage);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 35 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToFilledDataUserPage);
            
            #line default
            #line hidden
            return;
            case 8:
            this.orgTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.DataGridRequestView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            
            #line 58 "..\..\..\..\Pages\UserPages\MyRequestsUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToCreateRequestPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

