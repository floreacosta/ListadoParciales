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
				int idCheck;
				if (parcialEditar == null)
				{
					idCheck = new Random().Next(0, 100);
				} else
				{
					idCheck = parcialEditar.id;
				}

				int idNumber = idCheck;
				var idNuevo = idNumber;
				var materiaNuevo = materia.Text;
				var temasNuevo = temas.Text;
				var fechaNuevo = fecha.Text;
				var profesorNuevo = new Profesor() { nombre = nombreProfesor.Text, email = emailProfesor.Text };

				var nuevoParcial = new Parcial() { id = idNuevo, materia = materiaNuevo, temas = temasNuevo, fecha = fechaNuevo, profesor = profesorNuevo };

				bool existeParcial = nuevoParcial.existeParcialEnListado(listadoParciales, nuevoParcial.id);
				if (existeParcial)
				{
					listadoParciales.Remove(parcialEditar);
				}

				listadoParciales.Add(nuevoParcial);
				Navigation.PushModalAsync(new ListadoParcial(listadoParciales));
			}
		}

		private void btn_cancelar_parcial(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ListadoParcial(listadoParciales));
		}
	}

}
