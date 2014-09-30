using UnityEngine;
using System.Collections;

namespace ESCENARIOS
{
	public class Juego: MonoBehaviour  {
		//Propiedades
		Escena EscenaActual;

		//Eventos
		 void Start()
		{
			IniciarJuego();	
		}

		//Metodos

		/// <summary>
		/// Iniciars the juego.
		/// </summary>
		public void IniciarJuego()
		{
			EscenaActual = new Escena();
			EscenaActual.CargarEscena(1);
		}

		/// <summary>
		/// Cambiars the siguiente escena.
		/// </summary>
		/// <param name="pEscena">P escena.</param>
		public void CambiarSiguienteEscena(Escena pEscena)
		{
			EscenaActual.CargarEscena(EscenaActual.Número + 1);
		}
	}
}

