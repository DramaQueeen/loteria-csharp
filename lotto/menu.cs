/*
 * Creado por SharpDevelop.
 * Usuario: equipo
 * Fecha: 27/1/2021
 * Hora: 11:42 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lotto
{
	/// <summary>
	/// Description of menu.
	/// </summary>
	public partial class menu : Form
	{
		public menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		informacion info = new informacion();
		
		void Button1Click(object sender, EventArgs e)
		{
			//Instancio el formulario registro_cartones y luego utilizo show para mostrarlo.
			registro_cartones registro = new registro_cartones();
			registro.Show();
			//Este es para cerrar el primer formulario.
			this.Close();
		}
		
		void MenuLoad(object sender, EventArgs e)
		{
			cartones_registrados.Text = "Cartones registrados: " + info.total_cartones();
			total_pote.Text = "Total del pote: " + info.total_acumulado() + "$";
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if(info.total_cartones() > 0){
				loteria loteria_juego = new loteria();
				loteria_juego.Show();
				this.Close();
			}else{
				MessageBox.Show("Compra primero un cartón", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void Button3Click(object sender, EventArgs e){
			
			if(info.total_cartones() > 0){
				
				Bingo bingo = new Bingo();
			 	bingo.Show();
				this.Close();
			}else{
				MessageBox.Show("Compra primero un cartón", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			estadisticas infor = new estadisticas();
			infor.Show();
			this.Close();
		}
	}
}
