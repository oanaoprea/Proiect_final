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
    public partial class CazarePage : ContentPage
    {
        public CazarePage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var clist = (Cazare)BindingContext;
            await App.CDatabase.SaveCazareAsync(clist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var clist = (Cazare)BindingContext;
            await App.CDatabase.DeleteCazareAsync(clist);
            await Navigation.PopAsync();
        }

    }
}
