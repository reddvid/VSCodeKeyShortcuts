using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using VSCodeKeyboardShortcuts.UWP.Classes;
using VSCodeKeyboardShortcuts.UWP.Data;
using Windows.ApplicationModel.UserActivities;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VSCodeKeyboardShortcuts.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<CommandItem> keyBindsList = new ObservableCollection<CommandItem>();

        public MainPage()
        {
            this.InitializeComponent();

            Window.Current.SetTitleBar(CustomTitleBar);

            GetItems();

            // Get CTRL+F
            Window.Current.CoreWindow.Dispatcher.AcceleratorKeyActivated += Dispatcher_AcceleratorKeyActivated;

            GenerateActivityAsync();
        }

        UserActivitySession _currentActivity;
        private async Task GenerateActivityAsync()
        {
            // Get the default UserActivityChannel and query it for our UserActivity. If the activity doesn't exist, one is created.
            UserActivityChannel channel = UserActivityChannel.GetDefault();
            UserActivity userActivity = await channel.GetOrCreateUserActivityAsync("MainPage");

            // Populate required properties
            userActivity.VisualElements.DisplayText = "VS Code Keyboard Shortcuts";
            userActivity.ActivationUri = new Uri("vscodeks://");
            userActivity.VisualElements.Description = "View keyboard shortcuts";

            // Save
            await userActivity.SaveAsync(); //save the new metadata

            // Dispose of any current UserActivitySession, and create a new one.
            _currentActivity?.Dispose();
            _currentActivity = userActivity.CreateSession();

            Debug.WriteLine("Created user session");
        }             

        private void Dispatcher_AcceleratorKeyActivated(CoreDispatcher sender, AcceleratorKeyEventArgs args)
        {
            if (args.EventType.ToString().Contains("Down"))
            {
                var ctrl = Window.Current.CoreWindow.GetKeyState(VirtualKey.Control);
                if (ctrl.HasFlag(CoreVirtualKeyStates.Down))
                {
                   
                    switch (args.VirtualKey)
                    {
                        case VirtualKey.F:
                            searchBox.Focus(FocusState.Programmatic);
                            break;
                    }
                }
            }
        }       

        private void GetItems()
        {
            var keys = new KeyboardShortcuts();
            keyBindsList = keys.KeyboardShortcutsData;
            ItemsGridView.ItemsSource = keyBindsList;

            CountIcons();
        }

        private void searchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                if (sender.Text.Length > 1)
                {
                    string inputText = sender.Text.ToLower();

                    ItemsGridView.ItemsSource = keyBindsList.Where(i =>
                    i.Description.ToLower().Contains(inputText) || 
                    i.KeyBinding.ToLower().Contains(inputText) ||
                    i.KeyType.ToLower().Contains(inputText));
                }
                else
                {
                    ItemsGridView.ItemsSource = keyBindsList;
                }
            }

            CountIcons();
        }

        private void CountIcons()
        {
            if (ItemsGridView.Items.Count != 0)
            {
                ItemsGridView.Visibility = Visibility.Visible;
                NoResultsTxt.Visibility = Visibility.Collapsed;
            }
            else
            {
                ItemsGridView.Visibility = Visibility.Collapsed;
                NoResultsTxt.Visibility = Visibility.Visible;
            }
        }              

        private async void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            // Show About Content/User Dialog
            AboutDialog aboutDialog = new AboutDialog();
            await aboutDialog.ShowAsync();
        }

    }
}
