using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSave.Helpers;
using WaterSave.Models.CloudMqtt;
using Xamarin.Forms;

namespace WaterSave.ViewModels
{
    class DevicesViewModel : BaseViewModel<Instance>
    {
        public ObservableRangeCollection<Instance> Instances { get; set; }
        public Command LoadItemsCommand { get; set; }

        public DevicesViewModel()
        {
            Title = "Dispositivos";
            Instances = new ObservableRangeCollection<Instance>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadInstancesCommand());           
        }

        async Task ExecuteLoadInstancesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Instances.Clear();
                var instances = await DataStore.GetItemsAsync(true);
                Instances.ReplaceRange(instances);
            }
            catch (Exception ex)
            {
                MessagingCenter.Send("Não é possível carregar os Dispositivos.", "messageDevice");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
