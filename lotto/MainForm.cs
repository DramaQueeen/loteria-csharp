/*
 * Creado por SharpDevelop.
 * Usuario: Mariangel
 * Fecha: 24/01/2021
 * Hora: 03:12 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lotto
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
		
		void Button1Click(object sender, EventArgs e)
		{
			//Validación para comprobar la contraseña.
			if(password.Text == "1234"){
				//Instancio el formulario registro_cartones y luego utilizo show para mostrarlo.
				menu menu_principal = new menu();
				menu_principal.Show();
				//Este es para cerrar el primer formulario.
				this.Close();
				
			}else{
				MessageBox.Show("La contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				password.Clear();
			}
		}
	}
}
