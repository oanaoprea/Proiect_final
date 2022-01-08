using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proiect_final.Models;

namespace Proiect_final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContractShowPage : ContentPage
    {
        public ContractShowPage()
        {
            InitializeComponent();
        }


        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ContractPage
                {
                    BindingContext = e.SelectedItem as Contract
                });
            }
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.RDatabase.GetContractAsync();


        }
    }
}
