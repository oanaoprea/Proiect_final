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
    public partial class DestinatiiShowPage : ContentPage
    {
        public DestinatiiShowPage()
        {
            InitializeComponent();
        }


        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DestinatiiPage
                {
                    BindingContext = e.SelectedItem as Destinatii
                });
            }
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.DDatabase.GetDestinatiiAsync();


        }
    }
}
