using UnityEngine;
using System.Collections;

namespace INTERFAZ {

	public class Herramienta : MonoBehaviour {

		//Propiedades
		public string Tipo;
		bool VisibleEnEscenario;
				
		//Métodos

		/// <summary>
		/// Resaltar this instance.
		/// </summary>
		public void Resaltar()
		{
			//InterfazGrafica.HerramientaSeleccionada.CambiarSprite(“Resaltada”)
		}

		/// <summary>
		/// Ocultar this instance.
		/// </summary>
		public void Ocultar()
		{
			Herramienta.VisibleEnEscenario = false;
		}

		/// <summary>
		/// Usar this instance.
		/// </summary>
		public void Usar()
		{

		}

		/// <summary>
		/// Eventos the click.
		/// </summary>
		public void  EventoClick()
		{
			//Si padre = Pantalla
			//	PersonajeJugador.Desplazarse(Ubicación mouse X)
			//		Alterminar:
			//		Maleta.AbrirMaleta(pHerramienta)
			//		si Padre = Maleta
			//		InterfazGrafica.HerramientaSeleccionada = herramienta

		}
	}
} 