using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListadoParciales
{
	public partial class Bienvenido : ContentPage
	{
		public Bienvenido()
		{
			InitializeComponent();
		}

		private void btn_guardar_usuario (object sender, EventArgs e)
		{
			var nombre = nombreAlumno.Text;
			var institucion = nombreInstitucion.Text;

			if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(institucion))
			{
				// DisplayAlert("Prueba", nombre, "Continuar");

				var estudianteActual = new Estudiante ()
				{
					nombreEstudiante = nombre,
					nombreInstitucion = institucion
				};

				this.Navigation.PushModalAsync(new NavigationPage(new ListadoParcial(estudianteActual)));
			}
		}
	}
}
