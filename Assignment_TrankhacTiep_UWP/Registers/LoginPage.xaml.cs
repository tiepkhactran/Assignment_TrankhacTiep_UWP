﻿using Assignment_TrankhacTiep_UWP.Entity;
using Assignment_TrankhacTiep_UWP.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_TrankhacTiep_UWP.Music
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {

        private IMemberService _memberService;
        private IFileService _fileService;

        public LoginPage()
        {
            this.InitializeComponent();
            this._memberService = new MemberService();
            this._fileService = new LocalFileService();
        }



        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegisterPage));
        }

        private void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
        {
            var memberlogin = new Memberlogin
            {
                email = Email.Text,
                password = Password.Password
            };
            var memberCredential = this._memberService.Login(memberlogin);
            this._fileService.SaveMemberCredentialToFile(memberCredential);
        }

    }
}
