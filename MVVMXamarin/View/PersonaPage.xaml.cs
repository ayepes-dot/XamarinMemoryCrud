using MVVMXamarin.Model;
using MVVMXamarin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaPage : ContentPage
    {
        PersonaViewModel context = new PersonaViewModel();
        public PersonaPage()
        {
            InitializeComponent();
            BindingContext = context;
            LvPersonas.ItemSelected += LvPersonas_ItemSelected;
        }

        private void LvPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                PersonaModel modelo = (PersonaModel)e.SelectedItem;
                context.Nombre = modelo.Nombre;
                context.Apellido = modelo.Apellido;
                context.Edad = modelo.Edad;
                context.Id = modelo.Id;
            }
        }
    }
}