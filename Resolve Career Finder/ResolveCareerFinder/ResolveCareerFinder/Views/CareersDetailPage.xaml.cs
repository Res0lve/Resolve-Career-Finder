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
    public partial class CareersDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = CareersData.Careers.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public CareersDetailPage()
        {
            InitializeComponent();
        }
    }
}