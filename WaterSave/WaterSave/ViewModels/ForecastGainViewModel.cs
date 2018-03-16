using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSave.Helpers;
using WaterSave.Models.Weather;
using Xamarin.Forms;

namespace WaterSave.ViewModels
{
    class ForecastGainViewModel : BaseViewModel<Date>
    {
        public ObservableRangeCollection<Date> Dates { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ForecastGainViewModel()
        {
            Title = "Previsão de Ganhos";
            Dates = new ObservableRangeCollection<Date>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadDatesCommand());
        }

        async Task ExecuteLoadDatesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Dates.Clear();
                var dates = await DataStore.GetItemsAsync(true);
                Dates.ReplaceRange(dates);
            }
            catch (Exception ex)
            {
                MessagingCenter.Send("Não é possível carregar as Previsões de Ganhos.", "messageForecastGain");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
