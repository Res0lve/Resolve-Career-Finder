using System;
using System.Linq;
using Xamarin.Forms;
using ResolveCareerFinder.Data;

namespace ResolveCareerFinder.Views
{
    [QueryProperty("Name", "name")]
    public partial class SystemsDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = SystemsData.Systems.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public SystemsDetailPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
