/*
 * Creado por SharpDevelop.
 * Usuario: Mariangel
 * Fecha: 25/01/2021
 * Hora: 12:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace lotto
{
	public class registro_cartones_clase
	{
		private Int64 Numero_Carton;
		private Int32 Primer_Numero;
		private Int32 Segundo_Numero;
		private Int32 Tercer_Numero;
		private Int32 Cuarto_Numero;
		private Int32 Quinto_Numero;
		private Int32 Sexto_Numero;
			
		public Int64 numero_carton{
			get{return Numero_Carton;} set{Numero_Carton = value;}
		}
		public Int32 primer_numero{
			get{return Primer_Numero;} set{Primer_Numero = value;}
		}
		public Int32 segundo_numero{
			get{return Segundo_Numero;} set{Segundo_Numero = value;}
		}
		public Int32 tercer_numero{
			get{return Tercer_Numero;} set{Tercer_Numero = value;}
		}
		public Int32 cuarto_numero{
			get{return Cuarto_Numero;} set{Cuarto_Numero = value;}
		}
		public Int32 quinto_numero{
			get{return Quinto_Numero;} set{Quinto_Numero = value;}
		}
		public Int32 sexto_numero{
			get{return Sexto_Numero;} set{Sexto_Numero = value;}
		}
		
		public registro_cartones_clase()
		{
			Numero_Carton = 0;
			Primer_Numero = 0;
			Segundo_Numero = 0;
			Tercer_Numero = 0;
			Cuarto_Numero = 0;
			Quinto_Numero = 0;
			Sexto_Numero = 0;
		}
	}
}
