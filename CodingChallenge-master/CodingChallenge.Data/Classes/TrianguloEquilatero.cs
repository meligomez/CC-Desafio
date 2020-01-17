using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
	class TrianguloEquilatero:Forma
	{
		public override decimal area(decimal lado)
		{
			areaTotal= ((decimal)Math.Sqrt(3) / 4) * lado * lado;
			return areaTotal;
		}
		public override decimal perimetro(decimal lado)
		{
			perimetroTotal= lado * 3;
			return perimetroTotal;
		}
		public override int incrementarCantidadPorForma()
		{
			return cantidadPorForma++;
		}
	
	}
}
