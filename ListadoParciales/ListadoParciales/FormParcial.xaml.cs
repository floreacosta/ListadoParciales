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
		ObservableCollection<Parcial> listadoParciales;
		Parcial parcialEditar;
		public FormParcial(ObservableCollection<Parcial> parciales, Parcial parcial = null)
		{
			InitializeComponent();
			BindingContext = parcial;
			listadoParciales = parciales;

			parcialEditar = parcial;
		}

		private void btn_agregar_parcial(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(materia.Text) &&
					!string.IsNullOrEmpty(temas.Text) &&
					!string.IsNullOrEmpty(fecha.Text) &&
					!string.IsNullOrEmpty(nombreProfesor.Text) &&
					!string.IsNullOrEmpty(emailProfesor.Text)
				)
			{
				int idNumber = new Random().Next(0, 100);
				var idNuevo = idNumber;
				var materiaNuevo = materia.Text;
				var temasNuevo = temas.Text;
				var fechaNuevo = fecha.Text;
				var profesorNuevo = new Profesor() { nombre = nombreProfesor.Text, email = emailProfesor.Text };

				var nuevoParcial = new Parcial() { id = idNuevo, materia = materiaNuevo, temas = temasNuevo, fecha = fechaNuevo, profesor = profesorNuevo };

				listadoParciales.Add(nuevoParcial);
				((NavigationPage)this.Parent).PushAsync(new ListadoParcial(listadoParciales));
			}
		}

		private void btn_cancelar_parcial(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ListadoParcial(listadoParciales));
		}
	}

}
