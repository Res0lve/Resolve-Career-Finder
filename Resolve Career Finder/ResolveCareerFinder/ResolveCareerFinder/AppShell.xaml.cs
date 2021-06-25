using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ResolveCareerFinder.Data;
using ResolveCareerFinder.Views;

namespace ResolveCareerFinder
{
    public partial class AppShell : Shell
    {
        readonly Random rand = new Random();
        readonly Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand RandomPageCommand => new Command(async () => await NavigateToRandomPageAsync());

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        void RegisterRoutes()
        {
            routes.Add("networkdetails", typeof(NetworkDetailPage));
            routes.Add("supportdetails", typeof(SupportDetailPage));
            routes.Add("careersdetails", typeof(CareersDetailPage));
            routes.Add("desktopdetails", typeof(DesktopDetailPage));
            routes.Add("webdetails", typeof(WebDetailPage));
            routes.Add("mobiledetails", typeof(MobileDetailPage));
            routes.Add("systemsdetails", typeof(SystemsDetailPage));
            routes.Add("clouddetails", typeof(CloudDetailPage));
            routes.Add("databasedetails", typeof(DatabaseDetailPage));
            routes.Add("analystdetails", typeof(AnalystDetailPage));
            routes.Add("leadershipdetails", typeof(LeadershipDetailPage));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        async Task NavigateToRandomPageAsync()
        {
            string destinationRoute = routes.ElementAt(rand.Next(0, routes.Count)).Key;
            string careerName = null;

            switch (destinationRoute)
            {
                case "networkdetails":
                    careerName = NetworkData.Network.ElementAt(rand.Next(0, NetworkData.Network.Count)).Name;
                    break;
                case "supportdetails":
                    careerName = SupportData.Support.ElementAt(rand.Next(0, SupportData.Support.Count)).Name;
                    break;
                case "careersdetails":
                    careerName = CareersData.Careers.ElementAt(rand.Next(0, CareersData.Careers.Count)).Name;
                    break;
                case "desktopdetails":
                    careerName = DesktopData.Desktop.ElementAt(rand.Next(0, DesktopData.Desktop.Count)).Name;
                    break;
                case "webdetails":
                    careerName = WebData.Web.ElementAt(rand.Next(0, WebData.Web.Count)).Name;
                    break;
                case "mobiledetails":
                    careerName = MobileData.Mobile.ElementAt(rand.Next(0, MobileData.Mobile.Count)).Name;
                    break;
                case "systemsdetails":
                    careerName = SystemsData.Systems.ElementAt(rand.Next(0, SystemsData.Systems.Count)).Name;
                    break;
                case "clouddetails":
                    careerName = CloudData.Cloud.ElementAt(rand.Next(0, CloudData.Cloud.Count)).Name;
                    break;
                case "databasedetails":
                    careerName = DatabaseData.Database.ElementAt(rand.Next(0, DatabaseData.Database.Count)).Name;
                    break;
                case "analystdetails":
                    careerName = AnalystData.Analyst.ElementAt(rand.Next(0, AnalystData.Analyst.Count)).Name;
                    break;
                case "leadershipdetails":
                    careerName = LeadershipData.Leadership.ElementAt(rand.Next(0, LeadershipData.Leadership.Count)).Name;
                    break;
            }

            ShellNavigationState state = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{state.Location}/{destinationRoute}?name={careerName}");
            Shell.Current.FlyoutIsPresented = false;
        }

        void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
            // Cancel any back navigation
            //if (e.Source == ShellNavigationSource.Pop)
            //{
            //    e.Cancel();
            //}
        }

        void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {
        }
    }
}
