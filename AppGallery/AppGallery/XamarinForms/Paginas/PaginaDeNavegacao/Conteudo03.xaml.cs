using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo03 : ContentPage
    {
        public Conteudo03()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void VoltarParaPaginaAnterior(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void VoltarParaInicio(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void AdicionarPagina(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore
            (
                new PaginaInserida(),
                Navigation.NavigationStack[0]
            );
        }

        private void ExcluirPagina(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }
    }
}