/*
 * Creado por SharpDevelop.
 * Usuario: Mariangel
 * Fecha: 24/01/2021
 * Hora: 03:12 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;

namespace lotto
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Instancio el formulario princial fuera de Aplication.Run().
			//Esto es para que no se cierre el programa al usar this.Close() en el formulario principal.			
			MainForm main = new MainForm();
			//Llamo a la función FormClosed.
			main.FormClosed += new FormClosedEventHandler(FormClosed);
			//Se muestra el formulario.
    		main.Show();
    		Application.Run(); 
		}
		
		/*Debido a los pasos de arriba, al cerrar una ventana la aplicación seguirá ejecutanse a pesar de no verse.
		 * Esta función es para cerrarla automáticamente cuando no haya una ventana abierta*/
		
		static void FormClosed(object sender, FormClosedEventArgs e) 
		{
        	((Form)sender).FormClosed -= FormClosed;
        	if (Application.OpenForms.Count == 0) Application.ExitThread();
        	else Application.OpenForms[0].FormClosed += FormClosed;
    	}
		
	}
}
