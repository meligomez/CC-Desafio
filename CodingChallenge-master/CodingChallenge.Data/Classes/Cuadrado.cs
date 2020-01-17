using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
	public class Cuadrado:Forma
	{
		public override decimal area(decimal lado)
		{
			this.areaTotal = lado * lado;
			return areaTotal;
		}
		public override decimal perimetro(decimal lado)
		{
			perimetroTotal= lado * 4;
			return perimetroTotal;
		}
		public override int incrementarCantidadPorForma()
		{
			return cantidadPorForma++;
		}

	}
}
