﻿using System;
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
			Navigation.PushModalAsync(new NavigationPage(new ListadoParcial(listadoParciales)));
		}

		private void btn_editar_parcial(object sender, EventArgs e)
		{
			((NavigationPage)this.Parent).PushAsync(new FormParcial (listadoParciales, miParcial));
		}

		private void btn_email_profesor(object sender, EventArgs e)
		{

		}
	}
}
