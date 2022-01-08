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
    public partial class EntryPage : ContentPage
    {
        public EntryPage()
        {
            InitializeComponent();
        }


        async void OnTransportAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransportPage
            {
                BindingContext = new Transport()
            });
        }


        async void OnCazareAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CazarePage
            {
                BindingContext = new Cazare()
            });
        }


        async void OnTransporturiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransportShowPage
            {
                BindingContext = new Transport()
            });
        }


        async void OnCazariClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CazariShowPage
            {
                BindingContext = new Cazare()
            });
        }


        async void OnDestinatiiAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DestinatiiPage
            {
                BindingContext = new Destinatii()
            });
        }


        async void OnDestinatiiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DestinatiiShowPage
            {
                BindingContext = new Destinatii()
            });
        }


        async void OnContractAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContractPage
            {
                BindingContext = new Contract()
            });
        }


        async void OnContracteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContractShowPage
            {
                BindingContext = new Contract()
            });
        }

    }
}
