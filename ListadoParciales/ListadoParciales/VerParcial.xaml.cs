using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListadoParciales
{
	public partial class VerParcial : ContentPage
	{
		ObservableCollection<Parcial> listadoParciales;
		Parcial miParcial;
		public VerParcial(Parcial parcial, ObservableCollection<Parcial> parciales)
		{
			InitializeComponent();
			BindingContext = parcial;
			miParcial = parcial;
			listadoParciales = parciales;
		}

		private void btn_eliminar_parcial(object sender, EventArgs e)
		{
			listadoParciales.Remove(miParcial);
			Navigation.PushModalAsync(new NavigationPage(new ListadoParcial(new Estudiante() { nombreEstudiante = "Florencia", nombreInstitucion = "Unlam" }, listadoParciales)));
		}
	}
}
