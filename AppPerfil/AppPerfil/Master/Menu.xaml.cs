using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPerfil.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void GoPaginaPerfil1(Object sender,EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Perfil1());
            IsPresented = false;
        }
        private void GoPaginaXamarin(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;

        }
    }
}