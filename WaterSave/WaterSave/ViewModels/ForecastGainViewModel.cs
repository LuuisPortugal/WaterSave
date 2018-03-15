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

            /*MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Item;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });*/
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
                MessagingCenter.Send(new MessagingCenterAlert
                {
                    Title = "Erro",
                    Message = "Não é possível carregar as Previsões de Ganhos.",
                    Cancel = "OK"
                }, "message");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
