using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.ObjectModel;

namespace Practica8
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<_13090353> Items { get; set; }

        public static  MobileServiceClient cliente;
        public static IMobileServiceTable<_13090353> Table;
        //MobileServiceClient usuario;
        public MainPage()
        {
            InitializeComponent();
            cliente = new MobileServiceClient(AzureConnection.AzureUrl);
            Table = cliente.GetTable<_13090353>();
            LeerTabla();
        }

        private async void LeerTabla()
        {
            IEnumerable<_13090353> elementos = await Table.ToEnumerableAsync();
            Items = new ObservableCollection<_13090353>(elementos);
            BindingContext = this;
        }

        private void Insertar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new UpdatePage(e.SelectedItem as _13090353));
        }

        private void Eliminados_Clicked(object sender, EventArgs e)
        {
            LeerEliminados();
        }

        private async void LeerEliminados()
        {
            IEnumerable<_13090353> elementos = await Table.IncludeDeleted().ToEnumerableAsync();
            Items = new ObservableCollection<_13090353>(elementos);
            BindingContext = this;
            InitializeComponent();
        }
    }
}
