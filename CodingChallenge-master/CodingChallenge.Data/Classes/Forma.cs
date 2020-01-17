using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
	public abstract class Forma
	{
		public int id { get; set; }
		public int cantidadForma=0;
		public int cantidadPorForma = 0;
		public decimal areaTotal;
		public decimal perimetroTotal { get; set; }
		public int incrementarCantidad()
		{
			return cantidadForma++;
		}
		public virtual int incrementarCantidadPorForma()
		{
			return cantidadPorForma++;
		}
		public virtual decimal area(decimal lado)
		{
			return 0;
		}
		public virtual decimal perimetro(decimal lado)
		{
			return 0;
		}


	}
}
