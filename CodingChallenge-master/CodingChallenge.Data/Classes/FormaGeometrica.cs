/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. 
 * Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. 
 * La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Formas

        //public const int Cuadrado = 1;
        //public const int TrianguloEquilatero = 2;
        //public const int Circulo = 3;
        //public const int Trapecio = 4;
		public enum tipoForma
		{
			cuadrado=1,
			trianguloEquilatero=2,
			circulo=3,
			trapecio=4
		}

		#endregion

		#region Idiomas

		//public const int Castellano = 1;
		//public const int Ingles = 2;
		public enum tipoIdioma
		{
			castellano=1,
			ingles=2,
			frances=3,
			aleman=4
		}

        #endregion

        public decimal _lado { get; set; }

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
			var sb = new StringBuilder();
			//Instancié factoria de idioma
			FactoriaIdioma factoriaI = new FactoriaIdioma();
            //Ejecuto el método crear idioma, que según el parámetro de la funcion me busca a que
			//valor del enum pertenece
			Idioma idiomaFinal= factoriaI.crearIdioma(idioma);

			if (!formas.Any())
			{
				sb.Append("<h1>" + idiomaFinal.msjSinRegistros() + "</h1>");
			}
			else
			{
				
				sb.Append("<h1>" + idiomaFinal.mostrarHeader() + "</h1>");
		

				FactoriaForma factoriaF = new FactoriaForma();
				List<Forma> listaDeFormas = new List<Forma>();
				Forma unaForma;
				//Agrupo las formas para después poder ir concatenando POR forma.
				var formasAgrupadas = formas.GroupBy(x => x.Tipo).Where(g => g.Count() > 0).Select(y => y).ToList();
				for (var i = 0; i < formasAgrupadas.Count; i++)
				{
					//Uso el metodo de la factoria para instanciar el objeto que sea según la Key
					unaForma = factoriaF.crearForma(formasAgrupadas[i].Key);
					unaForma.incrementarCantidad();
					unaForma.cantidadForma = formasAgrupadas[i].Count();
					//Sumo todas las areas adentro de cada listado agrupado
					unaForma.areaTotal = formasAgrupadas[i].Sum(unElem => unaForma.area(unElem._lado));
					//Sumo todas los perímetros adentro de cada listado agrupado
					unaForma.perimetroTotal = formasAgrupadas[i].Sum(unElem => unaForma.perimetro(unElem._lado));
					listaDeFormas.Add(unaForma);
					sb.Append(ObtenerLinea(unaForma, idiomaFinal));
			

				}
				
				


				// FOOTER
				sb.Append("TOTAL:<br/>");
                sb.Append(listaDeFormas.Sum(unaF=>unaF.cantidadForma)+ " " + (idiomaFinal.formaTraducido()) + " ");
                sb.Append((idiomaFinal.perimetroTraducido()) + (listaDeFormas.Sum(unaF => unaF.perimetroTotal)).ToString("#.##") + " ");
                sb.Append("Area " + (listaDeFormas.Sum(unaF => unaF.areaTotal)).ToString("#.##"));
            }

            return sb.ToString();
        }

		private static string ObtenerLinea(Forma f, Idioma idiomaFinal)
		{
			if (f.cantidadForma > 0)
			{
				return idiomaFinal.lineaSegunIdioma(f);
			}
			return string.Empty;
		}

    }
}
