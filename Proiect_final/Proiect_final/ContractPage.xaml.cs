using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proiect_final.Models;
using Proiect_final.Data;


namespace Proiect_final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContractPage : ContentPage
    {

        public ContractPage()
        {
            InitializeComponent();

        }


        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var rlist = (Contract)BindingContext;
            await App.RDatabase.SaveContractAsync(rlist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var rlist = (Contract)BindingContext;
            await App.RDatabase.DeleteContractAsync(rlist);
            await Navigation.PopAsync();
        }
    }
}

