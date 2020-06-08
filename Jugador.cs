using System;
using System.Collections.Generic;
using System.Linq;


namespace TP_Arguello
{
	public abstract class Jugador
	{
		public  abstract void incializar(List<int> cartasPropias, List<int> cartasOponente, int limite);
		public  abstract int descartarUnaCarta();
		public abstract void cartaDelOponente(int carta);
	}
}
