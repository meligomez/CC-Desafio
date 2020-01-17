using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
	public class Circulo:Forma
	{
		public override decimal area(decimal _lado)
		{
			this.areaTotal = (decimal)Math.PI * (_lado / 2) * (_lado / 2);
			return areaTotal;
		}
		public override decimal perimetro(decimal _lado)
		{
			perimetroTotal= (decimal)Math.PI * _lado;
			return perimetroTotal;
		}
		public override int incrementarCantidadPorForma()
		{
			return cantidadPorForma++;
		}
		
	}
}
