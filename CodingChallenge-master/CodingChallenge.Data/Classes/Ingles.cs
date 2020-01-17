using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
	class Ingles:Idioma
	{
		public override string mostrarHeader()
		{
			return "Shapes report";
		}
		public override string msjSinRegistros()
		{
			return "Empty list of shapes!";
		}
		public override string lineaSegunIdioma(Forma f)
		{
			return (f.cantidadForma == 1) ?
					$"{f.cantidadForma} {this.traducirForma(f)} | Area {f.areaTotal:#.##} | Perimeter {f.perimetroTotal:#.##} <br/>" :
					$"{f.cantidadForma} {this.traducirFormaPlural(f)} | Area {f.areaTotal:#.##} | Perimeter {f.perimetroTotal:#.##} <br/>";
		}
		public override string formaTraducido()
		{
			return "shapes";
		}
		public override string perimetroTraducido()
		{
			return "Perimeter ";
		}
		public override string traducirForma(Forma f)
		{
			if (f.id == (int)FormaGeometrica.tipoForma.cuadrado)
			{
				return "Square";
			}
			if (f.id == (int)FormaGeometrica.tipoForma.circulo)
			{
				return "Circle";
			}
			if (f.id == (int)FormaGeometrica.tipoForma.trianguloEquilatero)
			{
				return "Triangle";
			}
			return "";
		}
		public override string traducirFormaPlural(Forma f)
		{
			if (f.id == (int)FormaGeometrica.tipoForma.cuadrado)
			{
				return "Squares";
			}
			if (f.id == (int)FormaGeometrica.tipoForma.circulo)
			{
				return "Circles";
			}
			if (f.id == (int)FormaGeometrica.tipoForma.trianguloEquilatero)
			{
				return "Triangles";
			}
			return "";
		}
	}
}
