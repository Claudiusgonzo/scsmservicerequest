﻿#pragma checksum "..\..\Microsoft.Demo.ServiceRequest.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E8E3F72F504320986202AFCB11BFCA11"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Demo.ServiceRequest;
using Microsoft.EnterpriseManagement.UI.FormsInfra;
using Microsoft.EnterpriseManagement.UI.WpfControls;
using Microsoft.EnterpriseManagement.UI.WpfToolbox;
using Microsoft.Windows.Controls;
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


namespace Microsoft.Demo.ServiceRequest {
    
    
    /// <summary>
    /// ServiceRequest
    /// </summary>
    public partial class ServiceRequest : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 86 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblTitle;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.TextBox txtTitle;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblID;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblDescription;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblAssgignedToUser;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal Microsoft.EnterpriseManagement.UI.WpfControls.UserPicker upAssignedTo;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblClassification;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal Microsoft.EnterpriseManagement.UI.WpfControls.ListPicker lpClassification;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblAffectedUser;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal Microsoft.EnterpriseManagement.UI.WpfControls.UserPicker upAffectedUser;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblAlternateContactInfo;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.TextBox txtAlternateContactInfo;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblScheduledStartDate;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal Microsoft.Windows.Controls.DatePicker dtScheduledStartDate;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblScheduledEndDate;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal Microsoft.Windows.Controls.DatePicker dtScheduledEndDate;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblActualStartDate;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal Microsoft.Windows.Controls.DatePicker dtActualStartDate;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblActualEndDate;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal Microsoft.Windows.Controls.DatePicker dtActualEndDate;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Label lblAffectedCIs;
        
        #line default
        #line hidden
        
        
        #line 217 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.ListView lvAffectedCIs;
        
        #line default
        #line hidden
        
        
        #line 228 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\Microsoft.Demo.ServiceRequest.xaml"
        internal System.Windows.Controls.Button btnRemove;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/Microsoft.Demo.ServiceRequest;component/microsoft.demo.servicerequest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Microsoft.Demo.ServiceRequest.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 31 "..\..\Microsoft.Demo.ServiceRequest.xaml"
            ((Microsoft.Demo.ServiceRequest.ServiceRequest)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lblID = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lblDescription = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.lblAssgignedToUser = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.upAssignedTo = ((Microsoft.EnterpriseManagement.UI.WpfControls.UserPicker)(target));
            return;
            case 10:
            this.lblClassification = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.lpClassification = ((Microsoft.EnterpriseManagement.UI.WpfControls.ListPicker)(target));
            return;
            case 12:
            this.lblAffectedUser = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.upAffectedUser = ((Microsoft.EnterpriseManagement.UI.WpfControls.UserPicker)(target));
            return;
            case 14:
            this.lblAlternateContactInfo = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.txtAlternateContactInfo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.lblScheduledStartDate = ((System.Windows.Controls.Label)(target));
            return;
            case 17:
            this.dtScheduledStartDate = ((Microsoft.Windows.Controls.DatePicker)(target));
            return;
            case 18:
            this.lblScheduledEndDate = ((System.Windows.Controls.Label)(target));
            return;
            case 19:
            this.dtScheduledEndDate = ((Microsoft.Windows.Controls.DatePicker)(target));
            return;
            case 20:
            this.lblActualStartDate = ((System.Windows.Controls.Label)(target));
            return;
            case 21:
            this.dtActualStartDate = ((Microsoft.Windows.Controls.DatePicker)(target));
            return;
            case 22:
            this.lblActualEndDate = ((System.Windows.Controls.Label)(target));
            return;
            case 23:
            this.dtActualEndDate = ((Microsoft.Windows.Controls.DatePicker)(target));
            return;
            case 24:
            this.lblAffectedCIs = ((System.Windows.Controls.Label)(target));
            return;
            case 25:
            this.lvAffectedCIs = ((System.Windows.Controls.ListView)(target));
            
            #line 217 "..\..\Microsoft.Demo.ServiceRequest.xaml"
            this.lvAffectedCIs.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lvAffectedCIs_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 26:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 228 "..\..\Microsoft.Demo.ServiceRequest.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            this.btnRemove = ((System.Windows.Controls.Button)(target));
            
            #line 237 "..\..\Microsoft.Demo.ServiceRequest.xaml"
            this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
