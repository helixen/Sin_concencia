using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ESCENARIOS
{
	public class Pantalla {

		//Propiedades
		Material Fondo;
		List<AreaInteractiva> AreasInteractivas;
		List<PERSONAJES.PersonajeNoJugador> PNJs;
		List<INTERFAZ.Herramienta> HerramientasExpuestas;
		Limite LímiteDerecho;
		Limite LímiteIzquierda;
		int numero;

		//Metodos

		/// <summary>
		/// Cargars the pantalla.
		/// </summary>
		/// <param name="NumeroPantalla">Numero pantalla.</param>
		public void CargarPantalla(Pantalla NumeroPantalla)
		{
			//CrearImagenFondo
			//CrearAreasInteractivas
			//Crear PJ
			//Crear PNJs
			//Crear Herramientas
			//Crear Límites

		}		
				
		/// <summary>
		/// Eventos the click.
		/// </summary>
		public void EventoClick()
		{
			int PosX;
			new PERSONAJES.PersonajeJugador().Desplazarse(PosX);
		}
	}
}