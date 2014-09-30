using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ESCENARIOS
{
	public class Escena {

		//Propiedades
		string Estado; //[Activo, inactivo]
		List<Pantalla> Pantallas;
		public int Número;

		//Metodos

		/// <summary>
		/// Cargars the escena.
		/// </summary>
		/// <param name="NúmeroEscena">Número escena.</param>
		public void CargarEscena(int NúmeroEscena)
		{
			Pantalla PantallaActual = Pantallas[0];
			PantallaActual.CargarPantalla();
		}

		/// <summary>
		/// Cambiars the pantalla.
		/// </summary>
		/// <param name="pPantallaActual">P pantalla actual.</param>
		/// <param name="pDireccion">P direccion.</param>
		public void CambiarPantalla(Pantalla pPantallaActual, int pDireccion)
		{
			int pantallaDestino;

			if(pDireccion > 0)
					pantallaDestino++;
			else
				pantallaDestino--;

			new Pantalla().CargarPantalla(pantallaDestino);
		}

		/// <summary>
		/// Vers the fin de escena.
		/// </summary>
		public void VerFinDeEscena()
		{


		}

	}
}
