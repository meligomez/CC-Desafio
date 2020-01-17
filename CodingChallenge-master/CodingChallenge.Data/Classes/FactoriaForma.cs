using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Classes.FormaGeometrica;

namespace CodingChallenge.Data.Classes
{
	class FactoriaForma
	{
		public Forma crearForma(int idForma)
		{

			if (idForma == (int)tipoForma.circulo)
			{
				Circulo c = new Circulo();
				c.incrementarCantidadPorForma();
				c.id = idForma;
				return c;
			}
			if (idForma == (int)tipoForma.cuadrado)
			{
				Cuadrado cu = new Cuadrado();
				cu.id = idForma;
				return cu;
			}
			if (idForma == (int)tipoForma.trianguloEquilatero)
			{
				TrianguloEquilatero t = new TrianguloEquilatero();
				t.id = idForma;
				return t;
			}
			return null;
		}
	}
}
