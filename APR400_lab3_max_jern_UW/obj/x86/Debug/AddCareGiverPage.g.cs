﻿#pragma checksum "C:\Users\Max Jern\source\repos\APR400_lab3_max_jern_UW\APR400_lab3_max_jern_UW\AddCareGiverPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F1AB1868E29A926CA35FD4EF51F8C9CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APR400_lab3_max_jern_UW
{
    partial class AddCareGiverPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // AddCareGiverPage.xaml line 12
                {
                    this.navCareGiving = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                }
                break;
            case 3: // AddCareGiverPage.xaml line 14
                {
                    this.mnuCareGive = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)this.mnuCareGive).Tapped += this.MnuCareGive_Tapped;
                }
                break;
            case 4: // AddCareGiverPage.xaml line 15
                {
                    this.mnuCareTake = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)this.mnuCareTake).Tapped += this.MnuCareTake_Tapped;
                }
                break;
            case 5: // AddCareGiverPage.xaml line 16
                {
                    this.mnuAddGive = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)this.mnuAddGive).Tapped += this.MnuAddGive_Tapped;
                }
                break;
            case 6: // AddCareGiverPage.xaml line 17
                {
                    this.mnuAddTake = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)this.mnuAddTake).Tapped += this.MnuAddTake_Tapped;
                }
                break;
            case 7: // AddCareGiverPage.xaml line 19
                {
                    this.contentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 8: // AddCareGiverPage.xaml line 43
                {
                    this.btnSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSave).Click += this.BtnSave_Click;
                }
                break;
            case 9: // AddCareGiverPage.xaml line 35
                {
                    this.cmbCenter = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 11: // AddCareGiverPage.xaml line 31
                {
                    this.txtRole = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // AddCareGiverPage.xaml line 27
                {
                    this.txtLastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // AddCareGiverPage.xaml line 23
                {
                    this.txtFirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
