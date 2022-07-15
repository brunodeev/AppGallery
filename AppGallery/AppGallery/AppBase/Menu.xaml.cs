using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : FlyoutPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContentPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.Conteudo01();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarouselPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlyoutPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirModalPage(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Conteudo01();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirStackLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.Stack_Layout.Stack();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirGrid(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.Grid.Grid();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirAbsoluteLayout(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new XamarinForms.Layouts.AbsoluteLayout.Absolute();
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }
    }
}