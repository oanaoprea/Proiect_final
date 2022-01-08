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
    public partial class TransportPage : ContentPage
    {
        public TransportPage()
        {
            InitializeComponent();
        }


        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var tlist = (Transport)BindingContext;
            await App.TDatabase.SaveTransportAsync(tlist);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var tlist = (Transport)BindingContext;
            await App.TDatabase.DeleteTransportAsync(tlist);
            await Navigation.PopAsync();
        }





    }
}
