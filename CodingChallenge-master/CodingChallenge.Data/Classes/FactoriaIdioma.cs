using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Classes.FormaGeometrica;

namespace CodingChallenge.Data.Classes
{
	public class FactoriaIdioma
	{ 
		public Idioma crearIdioma(int idioma)
		{
			
			if (idioma == (int)tipoIdioma.castellano)
			{
				Castellano c = new Castellano();
				c.id = idioma;
				return c;
			}
			if (idioma == (int) tipoIdioma.ingles)
			{
				return new Ingles();
			}

			return null;
		}
	}
}
