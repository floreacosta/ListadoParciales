using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListadoParciales
{
	public partial class FormParcial : ContentPage
	{
		public FormParcial(Parcial p)
		{
			InitializeComponent();
		}

		//int id = 0;

		private void btn_agregar_parcial(object sender, EventArgs e)
		{
			//if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(institucion))
			//{
			//	DisplayAlert("Prueba", nombre, "Continuar");

			//	var misParciales = new ListadoParcial(new Estudiante { nombreEstudiante = "Florencia", nombreInstitucion = "Unlam" });

			//	this.Navigation.PushModalAsync(new NavigationPage(new ListadoParcial(estudianteActual)));
			//}
		}
	}

}
