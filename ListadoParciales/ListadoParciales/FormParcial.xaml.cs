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
		public FormParcial(ObservableCollection<Parcial> parciales)
		{
			InitializeComponent();
			BindingContext = parciales;
			listadoParciales = parciales;
		}

		private void btn_agregar_parcial(object sender, EventArgs e)
		{
			int idNumber = new Random().Next(0, 100);
			var idNuevo = idNumber;
			var materiaNuevo = materia.Text;
			var temasNuevo = temas.Text;
			var fechaNuevo = fecha.Text;

			var nuevoParcial = new Parcial() { id = idNuevo, materia = materiaNuevo, temas = temasNuevo, fecha = fechaNuevo };

			if (nuevoParcial != null)
			{
				listadoParciales.Add(nuevoParcial);
				((NavigationPage)this.Parent).PushAsync(
					new ListadoParcial(new Estudiante() { nombreEstudiante = "Florencia", nombreInstitucion = "Unlam" }, listadoParciales
				));
			}
		}

		private void btn_cancelar_parcial(object sender, EventArgs e)
		{
		}
	}

}
