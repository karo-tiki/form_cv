using app8.mode;
using SQLitePCL;
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
    public partial class agregar : ContentPage
    {
        public agregar()
        {
            InitializeComponent();
        }

        private async  void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                var item = new tocv
                {
                    name = nombreEditor.Text,
                    apellido = apellidoEditor.Text,
                    perfil = perfilEditor.Text,
                    contacto = contactoEntry.Text,
                    idiomas = idiomasEditor.Text,
                    habilidades = habilidadesEditor.Text

                };
                var resultado =await App.Contenido.InsertItemAsyn(item);
                if (resultado == 1)
                {
                    await Navigation.PopAsync();//eliminamos la pantalla 
                }
                else
                {
                    await DisplayAlert("ERROR", "NO SE GUARDO", "ACEPTAR");
                }
            }
            catch (Exception ex)//por si algo falla
            {
                await DisplayAlert("error", ex.Message, "aceptar");

            }
        }
    }
}