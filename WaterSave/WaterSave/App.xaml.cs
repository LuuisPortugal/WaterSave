using WaterSave.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WaterSave
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Tempo Real",
                        Icon = Device.OnPlatform("icons8-conectado.png", null, null)
                    },
                    new NavigationPage(new DevicesPage())
                    {
                        Title = "Dispositivos",
                        Icon = Device.OnPlatform("icons8-varios-dispositivos.png", null, null)
                    },
                    new NavigationPage(new ForecastGainPage())
                    {
                        Title = "Previsão de Ganhos",
                        Icon = Device.OnPlatform("icons8-inspecao.png", null, null)
                    }
                }
            };
        }
    }
}
