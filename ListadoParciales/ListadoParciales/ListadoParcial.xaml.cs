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
		public ObservableCollection<Parcial> listadoParciales = new ObservableCollection<Parcial>();

		public ListadoParcial(Estudiante estudianteActual)
		{
			InitializeComponent();
			BindingContext = estudianteActual;

			ParcialesList.ItemsSource = listadoParciales;

			//listadoParciales.Add(new Parcial { id = 1, materia = "Matemática", temas = "Muchos", fecha = "10/07/2017" });
			//listadoParciales.Add(new Parcial { id = 2, materia = "Física", temas = "Mas que antes", fecha = "04/07/2017" });
			//listadoParciales.Add(new Parcial { id = 3, materia = "Química", temas = "Todos", fecha = "22/06/2017" });
		}

		//	public ObservableCollection<Parcial> getListadoParcial()
		//	{
		//		return listadoParciales;
		//	}

		//	public void cargarListadoParciales(Parcial p)
		//	{
		//		listadoParciales.Add(p);
		//	}

		//	public Parcial conseguirParcialPorId (int id)
		//	{
		//		var parcialAconseguir = new Parcial();

		//		for (int i = 0; i < listadoParciales.Count; i++)
		//		{
		//			if (listadoParciales[i].id == id)
		//			{
		//				parcialAconseguir = listadoParciales[i];
		//			}
		//		}

		//		return parcialAconseguir;
		//	}

		//	public bool borrarParcial (int id)
		//	{
		//		var parcialAborrar = new Parcial();
		//		for (int i = 0; i < listadoParciales.Count; i++)
		//		{
		//			if(listadoParciales[i].id == id)
		//			{
		//				listadoParciales.Remove(conseguirParcialPorId(listadoParciales[i].id));
		//				return true;
		//			}
		//		}

		//		return false;
		//	}

		//	public bool modificarParcial(int id, Parcial pModificado)
		//	{
		//		var aBorrar = conseguirParcialPorId(id);

		//		if (borrarParcial(aBorrar.id) == true)
		//		{
		//			cargarListadoParciales(pModificado);
		//			return true;
		//		}

		//		return false;
		//	}

		//}
	}
}
