using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoParciales
{
	public class Parcial
	{
		public int id { get; set; }
		public string materia { get; set; }
		public string temas { get; set; }
		public DateTime fecha { get; set; }
		public Profesor profesor { get; set; }

		public bool existeParcialEnListado(ObservableCollection<Parcial> listadoParciales, int id)
		{
			foreach (Parcial p in listadoParciales)
			{
				if (p.id == id)
				{
					return true;
				}
			}
			return false;
		}
	}
}
