using app8.data;
using app8.vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app8
{
    public partial class App : Application
    {
        public  static database Contenido { get; set; }
        public App()
        {
            InitializeComponent();
            Initializatedatabase();

            MainPage = new NavigationPage(new principal());
        }

        private void Initializatedatabase()//inicializamos la base de datos 
        {
            var folderapp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbpath = System.IO.Path.Combine(folderapp, "app8.db3");//ruta de la bd
            Contenido = new database(dbpath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
