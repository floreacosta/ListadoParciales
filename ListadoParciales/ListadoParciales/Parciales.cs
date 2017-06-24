using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoParciales
{
	public class Parciales
	{

		public ObservableCollection<Parcial> listadoParciales = new ObservableCollection<Parcial>();

		public ObservableCollection<Parcial> getListadoParcial()
		{
			return listadoParciales;
		}

		public ObservableCollection<Parcial> cargarListadoParciales(Parcial p)
		{
			listadoParciales.Add(p);
			return listadoParciales;
		}

		public Parcial conseguirParcialPorId(int id)
		{
			Parcial parcialAconseguir = new Parcial();

			for (int i = 0; i < listadoParciales.Count; i++)
			{
				if (listadoParciales[i].id == id)
				{
					parcialAconseguir = listadoParciales[i];
				}
			}

			return parcialAconseguir;
		}

		public bool borrarParcial(int id)
		{
			var parcialAborrar = new Parcial();
			for (int i = 0; i < listadoParciales.Count; i++)
			{
				if (listadoParciales[i].id == id)
				{
					listadoParciales.Remove(conseguirParcialPorId(listadoParciales[i].id));
					return true;
				}
			}

			return false;
		}

		public bool modificarParcial(int id, Parcial pModificado)
		{
			var aBorrar = conseguirParcialPorId(id);

			if (borrarParcial(aBorrar.id) == true)
			{
				cargarListadoParciales(pModificado);
				return true;
			}

			return false;
		}
	}
}
