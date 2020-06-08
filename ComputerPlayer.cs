
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace TP_Arguello
{
	public class ComputerPlayer: Jugador
	{
		
		public ComputerPlayer()
		{
		}
		
		
		
		
		
		public override void  incializar(List<int> cartasPropias, List<int> cartasOponente, int limite)
		{
			if (cartasOponente.Count > 0)
			{
				ArbolGeneral<Tuple<int, int>> primernodo = new ArbolGeneral<Tuple<int, int>>(new Tuple<int, int>(0, 0));
				for (int i = 0; i < cartasOponente.Count; i++)
				{
					ArbolGeneral<Tuple<int, int>> segundonodo = new ArbolGeneral<Tuple<int, int>>(new Tuple<int, int>(cartasOponente[i], limite - cartasOponente[i]));
					primernodo.agregarHijo(segundonodo);
					List<int> copy = new List<int>(cartasOponente);
					copy.RemoveAt(i);
					Console.WriteLine("cartas oponente" + segundonodo.getDatoRaiz());
					if (limite - cartasOponente[i] < 0)
					{
						Console.WriteLine("Perdio el oponente");

					}
					else 
					{
						incializar(copy, cartasPropias, limite - cartasOponente[i]);
						Console.WriteLine("cartas propias" + segundonodo.getDatoRaiz());
					}
				
					/*Console.WriteLine("lista removida"+ copy[i].ToString());*/
				}
			
			}
				
		}
		
		
		public override int descartarUnaCarta()
		{
			//Implementar
			return 0;
		}
		
		public override void cartaDelOponente(int carta)
		{
			//implementar
			
		}

    }
}
