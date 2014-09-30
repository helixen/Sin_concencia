using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace INTERFAZ {

	public class Maleta : MonoBehaviour {

		//Propiedades
		string Estado; //[Abierta, cerrada]
			List<Herramienta> Herramientas;
				
		//Métodos

		/// <summary>
		/// Abrirs the maleta.
		/// </summary>
		public void AbrirMaleta() 
		{
			//Maleta.visibilidad = true;
		}
			
		/// <summary>
		/// Abrirs the maleta.
		/// </summary>
		/// <param name="pHerramienta">P herramienta.</param>
		public void AbrirMaleta(Herramienta pHerramienta) 
		{
			//Maleta.Herramientas.Agregar(pHerramienta)
			//Maleta.IncluirImagen(pHerramienta)
		}
			
		/// <summary>
		/// Cerrar this instance.
		/// </summary>
		public void  Cerrar()
		{
			//Maleta.visibilidad = false;
		}
			
		//Eventos

		/// <summary>
		/// Eventos the click.
		/// </summary>
		public void EventoClick()
		{
			Maleta.AbrirMaleta();
		}
	}	
}