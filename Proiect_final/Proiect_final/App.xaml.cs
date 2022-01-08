using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using Proiect_final.Data;
using System.IO;

namespace Proiect_final
{
    public partial class App : Application
    {
        


        static TransportDatabase tdatabase;
        public static TransportDatabase TDatabase
        {
            get
            {
                if (tdatabase == null)
                {
                    tdatabase = new
                    TransportDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Transport.db3"));
                }
                return tdatabase;
            }
        }



        static CazareDatabase cdatabase;
        public static CazareDatabase CDatabase
        {
            get
            {
                if (cdatabase == null)
                {
                    cdatabase = new
                    CazareDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Cazare.db3"));
                }
                return cdatabase;
            }
        }



        static DestinatiiDatabase ddatabase;
        public static DestinatiiDatabase DDatabase
        {
            get
            {
                if (ddatabase == null)
                {
                    ddatabase = new
                    DestinatiiDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Destinatii.db3"));
                }
                return ddatabase;
            }
        }



        static ContractDatabase rdatabase;
        public static ContractDatabase RDatabase
        {
            get
            {
                if (rdatabase == null)
                {
                    rdatabase = new
                    ContractDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Contract.db3"));
                }
                return rdatabase;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EntryPage());

        }

    }
}