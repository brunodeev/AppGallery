using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            /*
            var pagina = new NavigationPage
                (
                    new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01()
                );
            */
            MainPage = new XamarinForms.Paginas.Modal.Conteudo01();
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
