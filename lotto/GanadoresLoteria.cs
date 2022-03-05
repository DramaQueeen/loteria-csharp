using System;
using System.Drawing;
using System.Windows.Forms;

namespace lotto
{
	/// <summary>
	/// Description of GanadoresLoteria.
	/// </summary>
	public partial class GanadoresLoteria : Form
	{
		public GanadoresLoteria()
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
		
	
		Int16 cont = 0;
		
		void GanadoresLoteriaLoad(object sender, EventArgs e)
		{
			
			
			if(info.lista_ganadores(6) != 0){
				label4.Text = Convert.ToString(info.lista_ganadores(6));
				label8.Text = "6";
				label12.Text = Convert.ToString(info.premios_loteria(6) + "$");
				informacion.repartido_loteria = informacion.repartido_loteria + info.premios_loteria(6);
				informacion.monto_total = informacion.monto_total - info.premios_loteria(6);
			}
			
			if(info.lista_ganadores(5) != 0){
				label5.Text = Convert.ToString(info.lista_ganadores(5));
				label9.Text = "5";
				label13.Text = Convert.ToString(info.premios_loteria(5) + "$");
				informacion.repartido_loteria = informacion.repartido_loteria + info.premios_loteria(5);
				informacion.monto_total = informacion.monto_total - info.premios_loteria(5);
			}
			
			if(info.lista_ganadores(4) != 0){
				label6.Text = Convert.ToString(info.lista_ganadores(4));
				label10.Text = "4";
				label14.Text = Convert.ToString(info.premios_loteria(4) + "$");
				informacion.repartido_loteria = informacion.repartido_loteria + info.premios_loteria(4);
				informacion.monto_total = informacion.monto_total - info.premios_loteria(4);
			}
			if(info.lista_ganadores(3) != 0){
				label7.Text = Convert.ToString(info.lista_ganadores(3));
				label11.Text = "3";
				label15.Text = Convert.ToString(info.premios_loteria(3) + "$");
				informacion.repartido_loteria = informacion.repartido_loteria + info.premios_loteria(3);
				informacion.monto_total = informacion.monto_total - info.premios_loteria(3);
			}
			
			if(Convert.ToInt16(label4.Text) == 0){
				label4.Hide();
				label8.Hide();
				label12.Hide();	
				cont++;				
			}
			if(Convert.ToInt16(label5.Text) == 0){
				label5.Hide();
				label9.Hide();
				label13.Hide();	
				cont++;				
			}
			if(Convert.ToInt16(label6.Text) == 0){
				label6.Hide();
				label10.Hide();
				label14.Hide();
				cont++;				
			}
			if(Convert.ToInt16(label7.Text) == 0){
				label7.Hide();
				label11.Hide();
				label15.Hide();	
				cont++;				
			}
			
			if(cont == 4){
				MessageBox.Show("En esta ocasión no hay ganadores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{	
			informacion.juegos_loteria++;
			if(cont == 4){
				informacion.pote_resto_loteria = 0;
				informacion.pote_resto_loteria = informacion.monto_total;
				informacion.monto_total = 0;
			}else{
				info.guardar_ganacias_loteria();
			}
			
			informacion.r_cartones.Clear();
			informacion.loteria.Clear();
			//Instancio el formulario registro_cartones y luego utilizo show para mostrarlo.
			menu menu_principal = new menu();
			menu_principal.Show();
			//Este es para cerrar el primer formulario.
			this.Close();
		}
	}
}
