using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace PERSONAJES {

	public class PersonajeNoJugador : MonoBehaviour {

		//Propiedades
		List<INTERFAZ.Dialogo> Dialogos;
		Material RetratoDialogo;
		bool Visibilidad;
				
		//Métodos

		/// <summary>
		/// Desplazarse the specified pCoordenadaX.
		/// </summary>
		public void Desplazarse(int pCoordenadaX)
		{
			//CambiarSprite(“caminar derecha”)
			//	Mover PersonajeNoJugador(pCoordenadaX - Ancho/2)
			//		Al terminar CambiarSprite(“idle”)

		}

		/// <summary>
		/// Cambiars the sprite.
		/// </summary>
		/// <param name="pNombreSprite">P nombre sprite.</param>
		public void CambiarSprite(string pNombreSprite)
		{
			//PNJ.Imagen = imagen(pNombreSprite)
		}

		//Eventos

		/// <summary>
		/// Eventos the click.
		/// </summary>
		public void EventoClick()
		{
			//PersonajeJugador.Desplazarse(Ubicación mouse X)
			//	Alterminar:
			//		InterfazGráfica.CuadroDialogo.AbrirCuadroDialogo(PersonajeNoJugador)
		}
	}	
}