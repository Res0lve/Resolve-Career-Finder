using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnalystPage : ContentPage
    {
        public AnalystPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var analystName = (e.CurrentSelection.FirstOrDefault() as Career).Name;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"analystdetails?name={analystName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/domestic/dogs/dogdetails?name={dogName}");
        }
    }
}