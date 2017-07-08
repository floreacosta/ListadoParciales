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
		Estudiante est;
		public ListadoParcial(ObservableCollection<Parcial> parciales, Estudiante estudianteActual = null)
		{
			InitializeComponent();
			BindingContext = estudianteActual;
			listadoParciales = parciales;
			est = estudianteActual;

			ParcialesList.ItemsSource = listadoParciales;
			ParcialesList.ItemSelected += (sender, e) =>
				{
					if (e.SelectedItem != null) {
						((ListView)sender).SelectedItem = null;
					} else {
						return;
					};

					Parcial parcialAVer = (Parcial)e.SelectedItem;

					Navigation.PushModalAsync(new NavigationPage(new VerParcial(parcialAVer, listadoParciales, est)));
				};
		}

		private void btn_form_parcial(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new FormParcial(listadoParciales, null, est)));
		}
	}
}
