﻿#pragma checksum "..\..\..\..\Pages\GeneralPages\MyRequestGeneral.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2901FE4017AF0E12645E038DD6708C671E9C314FAAF46AC32E3550961D3055DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoSystemOfData.Pages.GeneralPages;
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


namespace AutoSystemOfData.Pages.GeneralPages {
    
    
    /// <summary>
    /// MyRequestGeneral
    /// </summary>
    public partial class MyRequestGeneral : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\Pages\GeneralPages\MyRequestGeneral.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock orgTextBlock;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Pages\GeneralPages\MyRequestGeneral.xaml"
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
            System.Uri resourceLocater = new System.Uri("/AutoSystemOfData;component/pages/generalpages/myrequestgeneral.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\GeneralPages\MyRequestGeneral.xaml"
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
            
            #line 28 "..\..\..\..\Pages\GeneralPages\MyRequestGeneral.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToMainGeneralPage);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 30 "..\..\..\..\Pages\GeneralPages\MyRequestGeneral.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToInfographicsGeneralPage);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 31 "..\..\..\..\Pages\GeneralPages\MyRequestGeneral.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToControlAndReportGeneralPage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.orgTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.DataGridRequestView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            
            #line 54 "..\..\..\..\Pages\GeneralPages\MyRequestGeneral.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Go_ToCreateRequestGeneralPage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

