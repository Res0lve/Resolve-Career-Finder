using System;
using System.Linq;
using Xamarin.Forms;
using ResolveCareerFinder.Data;

namespace ResolveCareerFinder.Views
{
    [QueryProperty("Name", "name")]
    public partial class DatabaseDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = DatabaseData.Database.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public DatabaseDetailPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
