using System;
using System.Linq;
using Xamarin.Forms;
using ResolveCareerFinder.Data;

namespace ResolveCareerFinder.Views
{
    [QueryProperty("Name", "name")]
    public partial class WebDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = WebData.Web.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public WebDetailPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
