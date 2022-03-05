/*
 * Creado por SharpDevelop.
 * Usuario: Daniel
 * Fecha: 29/01/2021
 * Hora: 11:42 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace lotto
{
	/// <summary>
	/// Description of Lista_numeros.
	/// </summary>
	public partial class ListaNumeros : Form
	{
		public ListaNumeros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		public void VerLista(string lista){
			
			lista2.Text = lista;
			lista3.Text = lista;
			lista4.Text = lista;
			lista5.Text = lista;
			lista6.Text = lista;
			lista7.Text = lista;
		}
		
		
		
	}
}
