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
		public FormParcial()
		{
			InitializeComponent();
		}

		private void btn_agregar_parcial(object sender, EventArgs e)
		{
			var idNuevo = Int32.Parse(id.Text);
			var materiaNuevo = materia.Text;
			var temasNuevo = temas.Text;
			var fechaNuevo = fecha.Text;

			var nuevoParcial = new Parcial() { id = idNuevo, materia = materiaNuevo, temas = temasNuevo, fecha = fechaNuevo };

			if (nuevoParcial != null)
			{
				// investigar sobre  INotifyPropertyChanged para pasar el mismo listado a todas las vistas
				// y poder borrarle o agregarle nuevos items de parciales
				((NavigationPage)this.Parent).PushAsync(new ListadoParcial(new Estudiante() { nombreEstudiante = "Florencia", nombreInstitucion = "Unlam" }));
			}
		}

		private void btn_cancelar_parcial(object sender, EventArgs e)
		{
		}
	}

}
