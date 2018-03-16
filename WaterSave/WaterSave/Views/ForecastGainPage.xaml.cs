using System;
using WaterSave.Helpers;
using WaterSave.Models;
using WaterSave.ViewModels;

using Xamarin.Forms;

namespace WaterSave.Views
{
    public partial class ForecastGainPage : ContentPage
    {
        ForecastGainViewModel viewModel;

        public ForecastGainPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ForecastGainViewModel();

            MessagingCenter.Subscribe<string>(this, "messageForecastGain", (string message) =>
            {
                DisplayAlert(viewModel.Title, message, "Ok");
            });
        }

        protected void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            DatesListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Dates.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
