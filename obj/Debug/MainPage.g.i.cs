﻿#pragma checksum "..\..\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "897232F768371574798B9E0819BFFF7C53954498F8C9967936ABE22205ACBA9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KQClicker;
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


namespace KQClicker {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock display_cps_left;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider leftClicker_slider;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button on_off_leftClicker_button;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button left_toggle_button;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bind_left_button;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock display_cps_right;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider rightClicker_slider;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button on_off_rightClicker_button;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button right_toggle_button;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bind_right_button;
        
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
            System.Uri resourceLocater = new System.Uri("/KQClicker;component/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainPage.xaml"
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
            this.display_cps_left = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.leftClicker_slider = ((System.Windows.Controls.Slider)(target));
            
            #line 66 "..\..\MainPage.xaml"
            this.leftClicker_slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.left_cps_slider_scroll);
            
            #line default
            #line hidden
            return;
            case 3:
            this.on_off_leftClicker_button = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\MainPage.xaml"
            this.on_off_leftClicker_button.Click += new System.Windows.RoutedEventHandler(this.on_off_leftClicker);
            
            #line default
            #line hidden
            return;
            case 4:
            this.left_toggle_button = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\MainPage.xaml"
            this.left_toggle_button.Click += new System.Windows.RoutedEventHandler(this.left_toggle_hold_switch);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bind_left_button = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\MainPage.xaml"
            this.bind_left_button.KeyDown += new System.Windows.Input.KeyEventHandler(this.bind_left_KeyDown);
            
            #line default
            #line hidden
            
            #line 103 "..\..\MainPage.xaml"
            this.bind_left_button.Click += new System.Windows.RoutedEventHandler(this.bind_left);
            
            #line default
            #line hidden
            return;
            case 6:
            this.display_cps_right = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.rightClicker_slider = ((System.Windows.Controls.Slider)(target));
            
            #line 161 "..\..\MainPage.xaml"
            this.rightClicker_slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.right_cps_slider_scroll);
            
            #line default
            #line hidden
            return;
            case 8:
            this.on_off_rightClicker_button = ((System.Windows.Controls.Button)(target));
            
            #line 172 "..\..\MainPage.xaml"
            this.on_off_rightClicker_button.Click += new System.Windows.RoutedEventHandler(this.on_off_rightClicker);
            
            #line default
            #line hidden
            return;
            case 9:
            this.right_toggle_button = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\MainPage.xaml"
            this.right_toggle_button.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.bind_right_button = ((System.Windows.Controls.Button)(target));
            
            #line 198 "..\..\MainPage.xaml"
            this.bind_right_button.KeyDown += new System.Windows.Input.KeyEventHandler(this.bind_right_KeyDown);
            
            #line default
            #line hidden
            
            #line 199 "..\..\MainPage.xaml"
            this.bind_right_button.Click += new System.Windows.RoutedEventHandler(this.bind_right);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 212 "..\..\MainPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Settings_button);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
