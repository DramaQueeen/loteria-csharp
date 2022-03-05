/*
 * Creado por SharpDevelop.
 * Usuario: Mariangel
 * Fecha: 24/01/2021
 * Hora: 03:57 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lotto
{
	public partial class registro_cartones : Form
	{
		public registro_cartones()
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
		void N_cartonKeyPress(object sender, KeyPressEventArgs e)
		{
			informacion.solo_numeros(e);
		}
		
		void Numero1KeyPress(object sender, KeyPressEventArgs e)
		{
			informacion.solo_numeros(e);
		}
		
		void Numero2KeyPress(object sender, KeyPressEventArgs e)
		{
			informacion.solo_numeros(e);
		}
		
		void Numero3KeyPress(object sender, KeyPressEventArgs e)
		{
			informacion.solo_numeros(e);
		}
		
		void Numero4KeyPress(object sender, KeyPressEventArgs e)
		{
			informacion.solo_numeros(e);
		}
		
		void Numero5KeyPress(object sender, KeyPressEventArgs e)
		{
			informacion.solo_numeros(e);
		}
		
		void Numero6KeyPress(object sender, KeyPressEventArgs e)
		{
			informacion.solo_numeros(e);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(n_carton.Text == "" || numero1.Text == "" || numero2.Text == "" || numero3.Text == "" || numero4.Text == "" || numero5.Text == "" || numero6.Text == ""){
				MessageBox.Show("Ningún campo debe estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}else{
			
				Int64 nCarton = Convert.ToInt64(n_carton.Text);
				Int32 n_1 = Convert.ToInt32(numero1.Text);
				Int32 n_2 = Convert.ToInt32(numero2.Text);
				Int32 n_3 = Convert.ToInt32(numero3.Text);
				Int32 n_4 = Convert.ToInt32(numero4.Text);
				Int32 n_5 = Convert.ToInt32(numero5.Text);
				Int32 n_6 = Convert.ToInt32(numero6.Text);
			
				
				Boolean comprobar = info.guardar_datos(nCarton, n_1, n_2, n_3, n_4, n_5, n_6);
				
				if(comprobar){
					MessageBox.Show("El cartón ha sido registrado con éxito", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					n_carton.Text = "";
					numero1.Text = "";
					numero2.Text = "";
					numero3.Text = "";
					numero4.Text = "";
					numero5.Text = "";
					numero6.Text = "";
					
					cartones_registrados.Text = "Cartones registrados: " + info.total_cartones();
					total_pote.Text = "Total del pote: " + info.total_acumulado() + "$";
				}
				
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//Instancio el formulario registro_cartones y luego utilizo show para mostrarlo.
			menu menu_principal = new menu();
			menu_principal.Show();
			//Este es para cerrar el primer formulario.
			this.Close();
		}
		
		void Registro_cartonesLoad(object sender, EventArgs e)
		{
			cartones_registrados.Text = "Cartones registrados: " + info.total_cartones();
			total_pote.Text = "Total del pote: " + info.total_acumulado() + "$";
		}
	}
}
