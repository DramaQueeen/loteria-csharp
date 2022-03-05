/*
 * Creado por SharpDevelop.
 * Usuario: equipo
 * Fecha: 27/1/2021
 * Hora: 2:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lotto
{
	/// <summary>
	/// Description of estadisticas.
	/// </summary>
	public partial class estadisticas : Form
	{
		public estadisticas()
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
		
		void Button3Click(object sender, EventArgs e)
		{
			//Instancio el formulario registro_cartones y luego utilizo show para mostrarlo.
			menu menu_principal = new menu();
			menu_principal.Show();
			//Este es para cerrar el primer formulario.
			this.Close();
		}
		
		void EstadisticasLoad(object sender, EventArgs e)
		{	
			label2.Text = "Juegos realizados: " + (informacion.juegos_loteria+informacion.juegos_bingo);
			label3.Text = "Juegos de lotería: " + informacion.juegos_loteria;
			label4.Text = "Juegos de bingo: " + informacion.juegos_bingo;
			label6.Text = "Total repartido lotería: " + informacion.repartido_loteria + "$";
			label5.Text = "Total repartido bingo: " + informacion.repartido_bingo + "$";
			label7.Text = "Total repartido en ambos juegos: " + (informacion.repartido_bingo+informacion.repartido_loteria) + "$";
			ganacia_c.Text = "Ganancias del club: " + Convert.ToString(informacion.total_club) + "$";
		}
	}
}
