using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
	public abstract class Idioma
	{
		public int id { get; set; }
		public virtual string descripcion { get; set; }
		public string headerTitulo { get; set; }
		public string sinRegistros { get; set; }
		public virtual string mostrarHeader()
		{
			return this.headerTitulo;
		}
		public virtual string msjSinRegistros()
		{
			return this.sinRegistros;
		}
		public virtual string lineaSegunIdioma(Forma f)
		{
			return "";
		}
		public virtual string formaTraducido()
		{
			return "";
		}
		public virtual string perimetroTraducido()
		{
			return "";
		}
		public virtual string lineaSegunIdiomaPlural()
		{
			return "";
		}
		public virtual string traducirForma(Forma f)
		{
			return "";
		}
		public virtual string traducirFormaPlural(Forma f)
		{
			return "";
		}
	}
}
