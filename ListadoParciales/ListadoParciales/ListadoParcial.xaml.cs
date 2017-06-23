using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace ListadoParciales
{
	public partial class ListadoParcial : ContentPage
	{

		public ListadoParcial(Estudiante estudianteActual)
		{
			InitializeComponent();
			BindingContext = estudianteActual;

			Parcial miParcial = new Parcial { id = 1, materia = "Matemática", temas = "Muchos", fecha = "10/07/2017" };
			ObservableCollection<Parcial> listadoParciales = new ObservableCollection<Parcial>(new Parciales().cargarListadoParciales(miParcial));

			ParcialesList.ItemsSource = listadoParciales;
		}

		private void btn_form_parcial(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new FormParcial()));
		}
	}
}
