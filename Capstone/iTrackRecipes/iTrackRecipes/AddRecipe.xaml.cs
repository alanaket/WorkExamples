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

using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace iTrackRecipes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddRecipe : Page
    {
        public AddRecipe()
        {
            this.InitializeComponent();
        }

        IMobileServiceTable<Recipe> recipeTable = App.capstoneAppServiceClient.GetTable<Recipe>();
        MobileServiceCollection<Recipe, Recipe> recipes;

        public class Recipe
        {
            public string Id { get; set; }
            public string Category { get; set; }
            public string RecipeName { get; set; }
            public string Process { get; set; }
            public Boolean Complete { get; set; }
            public DateTime CreateDate { get; set; }

        }


        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Menu));
        }

        async private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Recipe recipes = new Recipe
                {
                    Process = txtBoxRecipe.Text,
                    RecipeName = txtBoxRecipeName.Text,
                    Category = txtBoxCategory.Text,
                    Complete = false
                };
                await App.capstoneAppServiceClient.GetTable<Recipe>().InsertAsync(recipes);
                var dialog = new MessageDialog("Recipe Saved!");
                await dialog.ShowAsync();

            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog("An Error Occurred: " + ex.Message);
                await dialog.ShowAsync();
            }
        }

        async private void btnLogOff_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
            var dialog = new MessageDialog("You logged out successfully!");
            await dialog.ShowAsync();
        }
    }
}
