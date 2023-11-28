using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app8.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class principal : ContentPage
    {
        public principal()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()//para regresar las paginas 
        {
            base.OnAppearing();
            CargarItems();
        }

        private async void CargarItems()
        {
            var items = await App.Contenido.GetItemsAsync();
            LISTADO.ItemsSource = items;//obtenemos la lista de nuestras ytareas 

        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new agregar());
        }
    }
}