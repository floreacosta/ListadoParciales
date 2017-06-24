using System;
using System.Collections.Generic;
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
		public string fecha { get; set; }
		public Profesor profesor { get; set; }
	}
}
