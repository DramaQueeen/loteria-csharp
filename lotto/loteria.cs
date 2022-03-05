/*
 * Creado por SharpDevelop.
 * Usuario: equipo
 * Fecha: 27/1/2021
 * Hora: 12:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
/*
 * Creado por SharpDevelop.
 * Usuario: equipo
 * Fecha: 27/1/2021
 * Hora: 12:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace lotto
{
	/// <summary>
	/// Description of loteria.
	/// </summary>
	public partial class loteria : Form
	{
		public loteria()
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
		
		void Button1Click(object sender, EventArgs e)
		{
			if(Convert.ToInt32(n1.Text) == 0){
				
				Int32 numero1 = Convert.ToInt32(n1.Text);
				numero1 = info.generar_numero("loteria");
				n1.Text = Convert.ToString(numero1);
				button3.Hide();
				
			}else if(Convert.ToInt32(n2.Text) == 0){
				
				Int32 numero2 = Convert.ToInt32(n2.Text);
				numero2 = info.generar_numero("loteria");
				n2.Text = Convert.ToString(numero2);
				
			}else if(Convert.ToInt32(n3.Text) == 0){
				
				Int32 numero3 = Convert.ToInt32(n3.Text);
				numero3 = info.generar_numero("loteria");
				n3.Text = Convert.ToString(numero3);
				
			}else if(Convert.ToInt32(n4.Text) == 0){
				
				Int32 numero4 = Convert.ToInt32(n4.Text);
				numero4 = info.generar_numero("loteria");
				n4.Text = Convert.ToString(numero4);
				
			}else if(Convert.ToInt32(n5.Text) == 0){
				
				Int32 numero5 = Convert.ToInt32(n5.Text);
				numero5 = info.generar_numero("loteria");
				n5.Text = Convert.ToString(numero5);
				
			}else if(Convert.ToInt32(n6.Text) == 0){
				
				Int32 numero6 = Convert.ToInt32(n6.Text);
				numero6 = info.generar_numero("loteria");
				n6.Text = Convert.ToString(numero6);
				button1.Hide();
				button2.Show();
				
			}
			
		}
		
		void LoteriaLoad(object sender, EventArgs e)
		{
			button2.Hide();
			ganador6.Text = "Ganador con 6 números: " + Convert.ToString(info.premios_loteria(6) + "$");
			ganador5.Text = "Ganador con 5 números: " + Convert.ToString(info.premios_loteria(5) + "$");
			ganador4.Text = "Ganador con 4 números: " + Convert.ToString(info.premios_loteria(4) + "$");
			ganador3.Text = "Ganador con 3 números: " + Convert.ToString(info.premios_loteria(3) + "$");
			
			cartones_registrados.Text = "Cartones registrados: " + info.total_cartones();
			Int64 total = informacion.monto_total + informacion.pote_resto_loteria;
			total_pote.Text = "Total del pote: " + Convert.ToString(total) + "$";
		}
		
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
			
			info.buscar_ganador();
			GanadoresLoteria Ganadores = new GanadoresLoteria();
			Ganadores.Show();
			this.Close();
			
		}
	}
}
