﻿#pragma checksum "..\..\..\..\Views\Cylinder.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66003F21A3B6EDD5B0399F0EB55CEDE44469320E"
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
using WPF230319.Views;


namespace WPF230319.Views {
    
    
    /// <summary>
    /// Cylinder
    /// </summary>
    public partial class Cylinder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\..\..\Views\Cylinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbxHeight;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\Cylinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbxRadius;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Views\Cylinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgMaterial;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Views\Cylinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbxMaterial;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\Views\Cylinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbkArea;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\Views\Cylinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbkVolume;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\..\Views\Cylinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbkMass;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\..\Views\Cylinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\Views\Cylinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF230319;V1.0.0.0;component/views/cylinder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Cylinder.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txbxHeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbxRadius = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.imgMaterial = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.cmbxMaterial = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.txbkArea = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txbkVolume = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txbkMass = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

