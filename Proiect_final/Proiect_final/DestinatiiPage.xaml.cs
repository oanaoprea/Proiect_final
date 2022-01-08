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
    public partial class DestinatiiPage : ContentPage
    {
        public DestinatiiPage()
        {
            InitializeComponent();
        }


        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var dlist = (Destinatii)BindingContext;
            await App.DDatabase.SaveDestinatiiAsync(dlist);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var dlist = (Destinatii)BindingContext;
            await App.DDatabase.DeleteDestinatiiAsync(dlist);
            await Navigation.PopAsync();
        }
    }
}
