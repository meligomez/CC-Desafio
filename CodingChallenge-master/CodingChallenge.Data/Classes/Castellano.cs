using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
	public class Castellano:Idioma
	{	
		public override string mostrarHeader()
		{
			return "Reporte de Formas";
		}
		public override string msjSinRegistros()
		{
			return "Lista vacía de formas!";
		}
		public override string lineaSegunIdioma(Forma f)
		{
			
			return (f.cantidadForma==1)? 
					$"{f.cantidadForma} {this.traducirForma(f)} | Area {f.areaTotal:#.##} | Perimetro {f.perimetroTotal:#.##} <br/>" :
					$"{f.cantidadForma} {this.traducirFormaPlural(f)} | Area {f.areaTotal:#.##} | Perimetro {f.perimetroTotal:#.##} <br/>";
		}
		public override string formaTraducido()
		{
			return "formas";
		}
		public override string perimetroTraducido()
		{
			return "Perimetro ";
		}
		public override string traducirForma(Forma f)
		{
			 if(f.id== (int)FormaGeometrica.tipoForma.cuadrado)
			{
				return "Cuadrado";
			}
			 if(f.id == (int) FormaGeometrica.tipoForma.circulo)
			{
				return "Círculo";
			}
			if (f.id == (int)FormaGeometrica.tipoForma.trianguloEquilatero)
			{
				return "Triángulo";
			}
			return "";
		}
		public override string traducirFormaPlural(Forma f)
		{
			if (f.id == (int)FormaGeometrica.tipoForma.cuadrado)
			{
				return "Cuadrados";
			}
			if (f.id == (int)FormaGeometrica.tipoForma.circulo)
			{
				return "Círculos";
			}
			if (f.id == (int)FormaGeometrica.tipoForma.trianguloEquilatero)
			{
				return "Triángulos";
			}
			return "";
		}

	}
}
