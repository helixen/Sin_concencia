using UnityEngine;
using System.Collections;


namespace ESCENARIOS {

	public class Limite : MonoBehaviour {

		//Propiedades
		int ancho;
		string tipoLímite; //[Izquierdo, Derecho];

		//Eventos

		/// <summary>
		/// Eventos the click.
		/// </summary>
		public void EventoClick()
		{
			//PersonajeJugador.Desplazarse(Ubicación mouse X)
			//	Alterminar: 
			//		int dirección
			//		si Límite.TipoLímite = derecho
			//		dirección= +1
			//		Sino 
			//		dirección -1
			//		Escena.CambiarPantalla(PantallaActual, +1)
		}
	}	
}