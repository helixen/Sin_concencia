using UnityEngine;
using System.Collections;

namespace PERSONAJES
{
	
	public class PersonajeJugador : MonoBehaviour {

		//Propiedades
		int PosicionX;
		int Ancho;
		Material RetratoDialogo;
				
		//Métodos

		/// <summary>
		/// Desplazarse the specified pCoordenadaX.
		/// </summary>
		/// <param name="pCoordenadaX">P coordenada x.</param>
		public void Desplazarse(int pCoordenadaX)
		{
			//Si coordenadaX > PersonajeJugador.PosicionX + Ancho
			//	CambiarSprite(“caminar derecha”)
			//		Mover PersonajeJugador(pCoordenadaX - Ancho/2)
			//		Si coordenadaX < PersonajeJugador.PosicionX
			//		CambiarSprite(“caminar izquierda”)
			//		Mover PersonajeJugador(pCoordenadaX - Ancho/2)
					
			//		Al terminar CambiarSprite(“idle”)
		}

		/// <summary>
		/// Cambiars the sprite.
		/// </summary>
		/// <param name="pNombreSprite">P nombre sprite.</param>
		public void CambiarSprite(string pNombreSprite)
		{
			//PJ.Imagen = imagen(pNombreSprite)
		}
	}
}
