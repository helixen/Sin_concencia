using UnityEngine;
using System.Collections;

namespace ESCENARIOS
{

	public class AreaInteractiva : MonoBehaviour {

		//Propiedades
		int alto;
		int ancho;
		int posicionX;
		int posicionY;
		string tipoHerramienta;
		Material materialArea;
		Material materialAlternativo;
				
		//Métodos

		/// <summary>
		/// Usars the heramienta en area.
		/// </summary>
		/// <returns><c>true</c>, if heramienta en area was usared, <c>false</c> otherwise.</returns>
		/// <param name="pHerramienta">P herramienta.</param>
		public bool UsarHeramientaEnArea(INTERFAZ.Herramienta pHerramienta)
		{
			if(pHerramienta.Tipo == this.tipoHerramienta)
			{
				new PERSONAJES.PersonajeJugador().CambiarSprite("recoger");

					//Al terminar:
				this.CambiarImagen();
					//Al teminar PersonajeJugador.CambiarSprite(“idle”)
			}
			else
			{ 
				INTERFAZ.CuadroDialogo cuadroDialogo = new INTERFAZ.CuadroDialogo();
				cuadroDialogo.Abrir();
				cuadroDialogo.MostrarDialogo("No puedo usar esto acá");
			}
		}

		/// <summary>
		/// Cambiars the imagen.
		/// </summary>
		public void CambiarImagen()
		{
			//AreaInteractiva.Imagen = ImagenAlternativa
		}

		//Eventos

		/// <summary>
		/// Eventos the click.
		/// </summary>
		public void EventoClick()
		{
			//PersonajeJugador.Desplazarse(Ubicación mouse X)
			//	Alterminar:
			//		Si InterfazGrafica.Herramienta.Resaltada = True
			//		AreaInteractiva.UsarHeramientaEnArea(InterfazGrafica.Herramienta)
		}
	}
}