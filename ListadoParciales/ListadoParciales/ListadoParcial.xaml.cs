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
		ObservableCollection<Parcial> listadoParciales;
		public ListadoParcial(Estudiante estudianteActual, ObservableCollection<Parcial> parciales)
		{
			InitializeComponent();
			BindingContext = estudianteActual;
			listadoParciales = parciales;

			ParcialesList.ItemsSource = listadoParciales;
		}

		private void btn_form_parcial(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new FormParcial(listadoParciales)));
		}

		private void btn_eliminar_parcial(object sender, EventArgs e)
		{

		}
	}
}
