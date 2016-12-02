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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace App1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private async void but1_click(object sender, RoutedEventArgs e)
        {
            if (tb1.Text == "太阳之神" & p1.Password == "2016211832")
            {
                ContentDialog Dialog1 = new ContentDialog()
                {
                    Title = "恭喜您！",
                    Content = "成功输入测试的用户名及密码，然而名没有什么用。",
                    PrimaryButtonText = "确定"
                };

                ContentDialogResult result = await Dialog1.ShowAsync();
            }
            else
            {
                ContentDialog Dialog11 = new ContentDialog()
                {
                    Title = "错误",
                    Content = "请检查用户名以及密码是否正确。",
                    PrimaryButtonText = "确定"
                };

                ContentDialogResult result = await Dialog11.ShowAsync();
            }
        }

        private async void but3_click(object sender, RoutedEventArgs e)
        {
            ContentDialog Dialog3 = new ContentDialog()
            {
                Title = "忘记了密码怎么办？",
                Content = "十分抱歉，我们也不记得您的密码。",
                PrimaryButtonText = "确定"
            };

            ContentDialogResult result = await Dialog3.ShowAsync();
        }

        private async void but2_click(object sender, RoutedEventArgs e)
        {
            ContentDialog Dialog2 = new ContentDialog()
            {
                Title = "注册新用户",
                Content = "十分抱歉，我们暂时无法注册。",
                PrimaryButtonText = "确定"
            };

            ContentDialogResult result = await Dialog2.ShowAsync();
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void p1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (p1.Password != "2016211832")
            {
                t3.Text = "密码错误，请重新输入";
            }
            else
            {
                t3.Text = string.Empty;
            }
        }
    }
}
