﻿

#pragma checksum "D:\Voluteers App\Voluteers App\Voluteers App.Shared\LoginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4674773A51E163CE12DF92EC37BB5F17"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voluteers_App
{
    partial class LoginPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 20 "..\..\..\LoginPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.txtUsername_TextChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 21 "..\..\..\LoginPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.txtPassword_TextChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 22 "..\..\..\LoginPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnLogin_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


