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
			ParcialesList.ItemSelected += (sender, e) =>
				{
					if (e.SelectedItem == null) return; // don't do anything if we just de-selected the row
					Parcial parcialAVer = (Parcial)e.SelectedItem;
					Navigation.PushModalAsync(new NavigationPage(new VerParcial(parcialAVer, listadoParciales)));
					//listadoParciales.RemoveAt(aBorrar.id);
					//await DisplayAlert(e.SelectedItem, e.SelectedItem + " row was selected", "OK");
					//((ListView)sender).SelectedItem = null; // de-select the row
				};
		}

		private void btn_form_parcial(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new FormParcial(listadoParciales)));
		}
	}
}
