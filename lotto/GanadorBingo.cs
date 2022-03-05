
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lotto
{
	/// <summary>
	/// Description of GamadorBingo.
	/// </summary>
	public partial class GanadorBingo : Form
	{
		public GanadorBingo()
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
		
		Int64 premio2; 
		
		void GanadorBingoLoad(object sender, EventArgs e)
		{
			
			carton_Ganador.Text = Convert.ToString(info.lista_ganadoresBingo());
			Int64 premio = (info.premios_bingo() / informacion.bingo.Count);
			monto_ganado.Text = "Premio ganado para cada ganador: " + Convert.ToString(premio) + "$";
			
		
			if(info.lista_ganadoresBingo() != "No hay ganadores"){
				premio2 = info.premios_bingo();
				informacion.monto_total = informacion.monto_total - info.premios_bingo();
			}
			
			
			//RECORDAR tengo un fallo que no me muestra cuanto es el premio del bingo
			//numeros_ganadores.Text= "Numeros ganadores: "+ Convert.ToString(
			
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{	
			informacion.juegos_bingo++;
			if(info.lista_ganadoresBingo() == "No hay ganadores"){
				informacion.pote_resto_bingo = 0;
				informacion.pote_resto_bingo = informacion.monto_total;
				informacion.monto_total = 0;
			}else{
				informacion.repartido_bingo = informacion.repartido_bingo + premio2;
				info.guardar_ganancias_bingo();
			}
			
			informacion.r_cartones.Clear();
			informacion.bingo.Clear();
			//Instancio el formulario registro_cartones y luego utilizo show para mostrarlo.
			menu menu_principal = new menu();
			menu_principal.Show();
			//Este es para cerrar el primer formulario.
			this.Close();
		}
	}
}
