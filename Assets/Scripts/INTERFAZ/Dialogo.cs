using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace INTERFAZ {

	public class Dialogo : MonoBehaviour {

		//Propiedades
		string PersonajeOrigen;
		string	PersonajeDestino;
		string	Texto;	
		string Accion;
		int IdDialogo;
		int IdDialogoOrigen;
		bool DialogoFinal;
				
		//Métodos
				
		/// <summary>
		/// Initializes a new instance of the <see cref="INTERFAZ.Dialogo"/> class.
		/// </summary>
		/// <param name="pPersonajeOrigen">P personaje origen.</param>
		/// <param name="pPersonajeDestino">P personaje destino.</param>
		/// <param name="pIdDialogoOrigen">P identifier dialogo origen.</param>
		/// <param name="pDialogoFinal">If set to <c>true</c> p dialogo final.</param>
		public List<Dialogo> ObtenerDialogos(string pPersonajeOrigen, string pPersonajeDestino, int pIdDialogoOrigen, bool pDialogoFinal)
		{
			//Filtrar Colección de Diálogos por personaje origen, personage destino, idDialogoOrigen, que puede ser nulo y si es un diálogo final.
						
			return null;
		}
	}	
}