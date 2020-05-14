using System;
using System.Collections.Generic;

namespace TrabajoFinalComplejidad
{
	public class ArbolGeneral<T>
	{
		
		private NodoGeneral<T> raiz;

		public ArbolGeneral(T dato) {
			this.raiz = new NodoGeneral<T>(dato);
		}
	
		private ArbolGeneral(NodoGeneral<T> nodo) {
			this.raiz = nodo;
		}
	
		private NodoGeneral<T> getRaiz() {
			return raiz;
		}
	
		public T getDatoRaiz() {
			return this.getRaiz().getDato();
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			List<ArbolGeneral<T>> temp= new List<ArbolGeneral<T>>();
			foreach (var element in this.raiz.getHijos()) {
				temp.Add(new ArbolGeneral<T>(element));
			}
			return temp;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Add(hijo.getRaiz());
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Remove(hijo.getRaiz());
		}
	
		public bool esVacio() {
			return this.raiz == null;
		}
	
		public bool esHoja() {
			return this.raiz != null && this.getHijos().Count == 0;
		}

		public int altura()
		{
			int contador_altura = 0;
			int contador_altura_provisorio = 0;
			if (this.esHoja() == true)
			{
				return  0;
			}
			else

			{
				List<ArbolGeneral<T>> lista_hijos = new List<ArbolGeneral<T>>();
				lista_hijos = this.getHijos();
				if (lista_hijos.Count > 0)
				{
					foreach (ArbolGeneral<T> hijo  in  lista_hijos )
                    {
						int altura_hijo = hijo.altura();
						Console.WriteLine("  " + " \n ");
						Console.WriteLine(" Nodo: " + hijo.getDatoRaiz() + " \n ");
						Console.WriteLine(" Altura Hijo: " + altura_hijo + " \n ");
						if (altura_hijo > contador_altura_provisorio)
						{
							contador_altura_provisorio = altura_hijo;
						}
					}
				}
				if (contador_altura_provisorio > contador_altura)
				{
					contador_altura = contador_altura_provisorio;
					Console.WriteLine(" Contador de Altura Provisorio actualizado al valor: " + contador_altura_provisorio);
				}
			}
			return contador_altura  +1;
		}


		public int nivel(T dato)
		{
			int contador_nivel = 0;

			if (Equals(dato, this.getDatoRaiz()) && this.raiz == null)
			{
				return 0;
			}
			else
			{
				List<ArbolGeneral<T>> lista_hijos = new List<ArbolGeneral<T>>();
				lista_hijos = this.getHijos();
				if (lista_hijos.Count > 0)
				{
					foreach (var hijo in lista_hijos)
					{
						int nivel_hijo = hijo.nivel(dato);
						if (Equals(hijo.getDatoRaiz(), dato) && nivel_hijo == 0)
						{
							return 1;
						}
						if (nivel_hijo > 0)
						{
							nivel_hijo++;
						}
						if (nivel_hijo > 0 && contador_nivel == 0)
						{
							contador_nivel = nivel_hijo;
						}
					}
				}
			}
			return contador_nivel++;
		}

	}
}
