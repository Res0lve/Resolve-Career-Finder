using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ResolveCareerFinder.Data;

namespace ResolveCareerFinder.Views
{
    [QueryProperty("Name", "name")]
    public partial class DesktopDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = DesktopData.Desktop.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public DesktopDetailPage()
        {
            InitializeComponent();
        }
    }
}