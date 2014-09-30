using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace INTERFAZ {

	public class CuadroDialogo : MonoBehaviour {

		//Propiedades
		int PosiciónX;
		int PosiciónY;
		List<Dialogo> DialogosPJ;
		List<Dialogo> DialogosPNJ;
				
		//Métodos

		/// <summary>
		/// Elegirs the dialogo P.
		/// </summary>
		public void ElegirDialogoPJ()
		{
			//Si Dialogo.Final = true
			//	CuadroDialogo.Cerrar()
			//		Si Dialogo.Acción != “”	
			//		Switch (Dialogo.acción)	
			//		Sino
			//		Dialogo.ObtenerDialogos(pJugador, PNJ, pIdDialogoElegido, False)	
			//		AsignarTextos DialogosListados
		}

		/// <summary>
		/// Abrir the specified .
		/// </summary>
		/// <param name="">.</param>
		public  void Abrir(PERSONAJES.PersonajeNoJugador PNJ)
		{
			//CuadroDialogo.Visibilidad = true;
		}

		/// <summary>
		/// Cerrar this instance.
		/// </summary>
		public void Cerrar()
		{
			//CuadroDialogo.Visibilidad = false;
		}

		/// <summary>
		/// Mostrars the dialogo.
		/// </summary>
		public void  MostrarDialogo()
		{}
	}
}