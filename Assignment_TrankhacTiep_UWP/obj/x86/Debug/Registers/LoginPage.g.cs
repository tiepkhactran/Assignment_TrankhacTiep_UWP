﻿#pragma checksum "C:\Users\tiepb\source\repos\Assignment_TrankhacTiep_UWP\Assignment_TrankhacTiep_UWP\Registers\LoginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD8A46C08DE38A0C4EE087EB7B5BA9D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment_TrankhacTiep_UWP.Music
{
    partial class LoginPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Registers\LoginPage.xaml line 36
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Registers\LoginPage.xaml line 38
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 4: // Registers\LoginPage.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element4 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element4).Click += this.ButtonBase_OnClick;
                }
                break;
            case 5: // Registers\LoginPage.xaml line 40
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.ButtonLogin_OnClick;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
