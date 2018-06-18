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

using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace iTrackRecipes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Menu : Page
    {
        public Menu()
        {
            this.InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddRecipe));
        }

        private void btnAboutUs_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AboutUs));
        }

        private void btnContactUs_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ContactUs));
        }

        async private void btnLogOff_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
            var dialog = new MessageDialog("You logged out successfully!");
            await dialog.ShowAsync();
        }

        private void btnWebSearch_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WebSearch));
        }
    }
}
