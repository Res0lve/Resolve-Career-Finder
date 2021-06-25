using System;
using System.Linq;
using Xamarin.Forms;
using ResolveCareerFinder.Data;

namespace ResolveCareerFinder.Views
{
    [QueryProperty("Name", "name")]
    public partial class AnalystDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = AnalystData.Analyst.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public AnalystDetailPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
