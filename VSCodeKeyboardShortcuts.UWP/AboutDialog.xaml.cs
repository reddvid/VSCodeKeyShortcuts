using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace VSCodeKeyboardShortcuts.UWP
{
    public sealed partial class AboutDialog : ContentDialog
    {
        public AboutDialog()
        {
            this.InitializeComponent();

            GetAppVersion();
        }

        private void GetAppVersion()
        {
            Package package = Package.Current;
            PackageId packageId = package.Id;
            PackageVersion version = packageId.Version;

            DataTransferManager dataTransferManager = DataTransferManager.GetForCurrentView();
            dataTransferManager.DataRequested += new TypedEventHandler<DataTransferManager,
                DataRequestedEventArgs>(this.ShareTextHandler);

            VersionTextBlock.Text = string.Format("version {0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
        }

        private void ShareTextHandler(DataTransferManager sender, DataRequestedEventArgs e)
        {
            DataRequest request = e.Request;
            request.Data.Properties.Title = "VS Code Keyboard Shortcuts";
            request.Data.Properties.Description = "Share VS Code Keyboard Shortcuts";
            request.Data.Properties.ApplicationName = "VS Code Keyboard Shortcuts";

            request.Data.SetWebLink(new Uri("https://www.microsoft.com/store/apps/9NT6T77HJDWD"));
            request.Data.SetText("VS Code Keyboard Shortcuts for Windows 10. #Windows10 #UWP");
        }

        private async void btn_source_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://code.visualstudio.com/docs/getstarted/keybindings"));
        }

        private async void showmoreapps_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("ms-windows-store:Publisher?name=Red David"));
        }

        private async void hl_feedback_Click(object sender, RoutedEventArgs e)
        {
            if (Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.IsSupported())
            {
                // Launch feedback
                var launcher = Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.GetDefault();
                await launcher.LaunchAsync();
            }
            else
            {
                EmailMessage emailMessage = new EmailMessage();
                emailMessage.To.Add(new EmailRecipient("redappsupport@outlook.com"));
                emailMessage.Subject = "[FEEDBACK] VS Code Keyboard Shortcuts";
                await EmailManager.ShowComposeNewEmailAsync(emailMessage);
            }
        }

        private void btn_share_Click(object sender, RoutedEventArgs e)
        {
            DataTransferManager.ShowShareUI();
        }

        private async void btn_rate_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("ms-windows-store://review/?ProductId=9NT6T77HJDWD"));
        }

        private async void btn_fb_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("http://www.facebook.com/reddvidapps"));
        }

        private async void btn_twitter_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("http://www.twitter.com/reddvidapps"));
        }

        private void ContentDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            this.Hide();
        }

        private async void hl_donate_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://www.buymeacoffee.com/redDavid"));
            // PurchaseAddOn("9P650NF68J50");
        }
        
    }
}
