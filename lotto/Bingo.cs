/*
 * Creado por SharpDevelop.
 * Usuario: Daniel
 * Fecha: 28/01/2021
 * Hora: 09:11 p.m.
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
	/// Description of Bingo.
	/// </summary>
	public partial class Bingo : Form
	{
		public Bingo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		informacion info2 = new informacion();
		ListaNumeros cantados = new ListaNumeros();
		String[] guardar_EnLista = new String[1];
		Int32 numerito;
		
		
		int contador = 1;
		
		
		void Button3Click(object sender, EventArgs e){
			
			menu menusito = new menu();
			menusito.Show();
			this.Close();
			
			//inicializando el evento de click para el metodo volver
			//aqui le estamos diciendo que cuando se presione el boton de volver
			//muestre el menu principal
			
		}
		
		public void Button1Click(object sender, EventArgs e)
		{
			info2.buscar_ganadorBingo();
			button3.Hide();
			
			if(contador == 21){
				
				button1.Hide();
				button2.Show();
			}
			
			if (contador >= 6){
				if(informacion.bingo.Count >= 1){
					button1.Hide();
					button2.Show();
				}
			}
			
			if(cantado.Text == Convert.ToString(0)){
				
				numerito = Convert.ToInt32(cantado.Text);
			}
			    
				numerito = info2.generar_numero("bingo");
				
				if(numerito >= 1 && numerito <= 9){
					
					cantado.Text = "B"+Convert.ToString(numerito);
					
				} else if(numerito >= 10 && numerito <= 18){
					
					cantado.Text = "I"+Convert.ToString(numerito);
					
				} else if(numerito >= 19 && numerito <= 26){
					
					cantado.Text = "N"+Convert.ToString(numerito);
					
				} else if(numerito >= 27 && numerito <= 34){
					
					cantado.Text = "G"+Convert.ToString(numerito);
					
				}else if(numerito >= 35 && numerito <= 42){
					
					cantado.Text = "O"+Convert.ToString(numerito);
				}
	
				CambiarColores(numerito);
			    guardar_EnLista[0] = cantado.Text; // no le paren bola a esto, era para hcer uan lista y mostrar los numeros
				cantados.VerLista(guardar_EnLista[0]); //pero taba arrecho
				contador++; //este si importa
				
					/*button4.Text = Convert.ToString(info2.generar_numero_bingo("bingo"));
					
					if(button5.Text == Convert.ToString(0) || button5.Text > Convert.ToString(){
						
					button5.Text = Convert.ToString(info2.generar_numero_bingo("bingo");
					}
					
					button6.Text = Convert.ToString(numerito);
					button7.Text = Convert.ToString(numerito);*/
				
				
					if(ultimajugada1.Text == Convert.ToString(0)){
					
					ultimajugada1.Text = Convert.ToString(numerito);
					
					
				} else if(ultimajugada2.Text == Convert.ToString(0)){
					
					ultimajugada2.Text = Convert.ToString(numerito);
					
					                                	                                
				} else if(ultimajugada3.Text == Convert.ToString(0)){
				
					ultimajugada3.Text = Convert.ToString(numerito);
					
					
				} else if(ultimajugada4.Text == Convert.ToString(0)){
							
					ultimajugada4.Text = Convert.ToString(numerito);
					
							
				} else if(Convert.ToInt32(ultimajugada1.Text) > 0){
				
					ultimajugada1.Text = Convert.ToString(numerito);
					
					
				} else if(Convert.ToInt32(ultimajugada2.Text) > 0){
				
					ultimajugada2.Text = Convert.ToString(numerito);
					
					
				} else if(Convert.ToInt32(ultimajugada3.Text) > 0){
					
					ultimajugada3.Text = Convert.ToString(numerito);
					
					
				} else if(Convert.ToInt32(ultimajugada4.Text) > 0){
							
					ultimajugada4.Text = Convert.ToString(numerito);
					
						}
					
					
					/*else if(Convert.ToInt32(button4.Text) > 0){
				
					button4.Text = Convert.ToString(numerito);
					
				}  else if(Convert.ToInt32(button5.Text) > 0){
				
					button5.Text = Convert.ToString(numerito);
					
				}  else if(Convert.ToInt32(button6.Text) > 0){
					
					button6.Text = Convert.ToString(numerito);
					
				}  else if(Convert.ToInt32(button7.Text) > 0){
							
					button7.Text = Convert.ToString(numerito);
						}*/
				
				
						                                                 	
				
				
				
			/*if(Convert.ToInt32(n1.Text) == 0){
				
				Int32 numero1 = Convert.ToInt32(n1.Text);
				numero1 = info2.generar_numero_bingo("bingo");
				n1.Text = Convert.ToString(numero1);
				CambiarColores(numero1);
				
				
				
			}else if(Convert.ToInt32(n2.Text) == 0){
				
				n1.Text = <<>>;
				Int32 numero2 = Convert.ToInt32(n2.Text);
				numero2 = info2.generar_numero_bingo("bingo");
				n2.Text = Convert.ToString(numero2);
				CambiarColores(numero2);
				
				
			}else if(Convert.ToInt32(n3.Text) == 0){
				
				Int32 numero3 = Convert.ToInt32(n3.Text);
				numero3 = info2.generar_numero_bingo("bingo");
				n3.Text = Convert.ToString(numero3);
				CambiarColores(numero3);
				
			}else if(Convert.ToInt32(n4.Text) == 0){
				
				Int32 numero4 = Convert.ToInt32(n4.Text);
				numero4 = info2.generar_numero_bingo("bingo");
				n4.Text = Convert.ToString(numero4);
				CambiarColores(numero4);
				
			}else if(Convert.ToInt32(n5.Text) == 0){
				
				Int32 numero5 = Convert.ToInt32(n5.Text);
				numero5 = info2.generar_numero_bingo("bingo");
				n5.Text = Convert.ToString(numero5);
				CambiarColores(numero5);
				
			}else if(Convert.ToInt32(n6.Text) == 0){
				
				Int32 numero6 = Convert.ToInt32(n6.Text);
				numero6 = info2.generar_numero_bingo("bingo");
				n6.Text = Convert.ToString(numero6);
				CambiarColores(numero6);
				
				button1.Hide();
			}*/
			
			
		}
		
		
			
			
		
		 public void CambiarColores(int RN){
						
			switch(RN){
						
						
					case 1: num1.BackColor = System.Drawing.Color.Red; break;
					case 2: num2.BackColor = System.Drawing.Color.Red; break;
					case 3: num3.BackColor = System.Drawing.Color.Red; break;
					case 4: num4.BackColor = System.Drawing.Color.Red; break;
					case 5: num5.BackColor = System.Drawing.Color.Red; break;
					case 6: num6.BackColor = System.Drawing.Color.Red; break;
					case 7: num7.BackColor = System.Drawing.Color.Red; break;
					case 8: num8.BackColor = System.Drawing.Color.Red; break;
					case 9: num9.BackColor = System.Drawing.Color.Red; break;
					case 10: num10.BackColor = System.Drawing.Color.Red; break;
					case 11: num11.BackColor = System.Drawing.Color.Red; break;
					case 12: num12.BackColor = System.Drawing.Color.Red; break;
					case 13: num13.BackColor = System.Drawing.Color.Red; break;
					case 14: num14.BackColor = System.Drawing.Color.Red; break;
					case 15: num15.BackColor = System.Drawing.Color.Red; break;
					case 16: num16.BackColor = System.Drawing.Color.Red; break;
					case 17: num17.BackColor = System.Drawing.Color.Red; break;
					case 18: num18.BackColor = System.Drawing.Color.Red; break;
					case 19: num19.BackColor = System.Drawing.Color.Red; break;
					case 20: num20.BackColor = System.Drawing.Color.Red; break;
					case 21: num21.BackColor = System.Drawing.Color.Red; break;
					case 22: num22.BackColor = System.Drawing.Color.Red; break;
					case 23: num23.BackColor = System.Drawing.Color.Red; break;
					case 24: num.BackColor = System.Drawing.Color.Red; break;
					case 25: num25.BackColor = System.Drawing.Color.Red; break;
					case 26: num26.BackColor = System.Drawing.Color.Red; break;
					case 27: num27.BackColor = System.Drawing.Color.Red; break;
					case 28: num28.BackColor = System.Drawing.Color.Red; break;
					case 29: num29.BackColor = System.Drawing.Color.Red; break;
					case 30: num30.BackColor = System.Drawing.Color.Red; break;
					case 31: num31.BackColor = System.Drawing.Color.Red; break;
					case 32: num32.BackColor = System.Drawing.Color.Red; break;
					case 33: num33.BackColor = System.Drawing.Color.Red; break;
					case 34: num34.BackColor = System.Drawing.Color.Red; break;
					case 35: num35.BackColor = System.Drawing.Color.Red; break;
					case 36: num36.BackColor = System.Drawing.Color.Red; break;
					case 37: num37.BackColor = System.Drawing.Color.Red; break;
					case 38: num38.BackColor = System.Drawing.Color.Red; break;
					case 39: num39.BackColor = System.Drawing.Color.Red; break;
					case 40: num40.BackColor = System.Drawing.Color.Red; break;
					case 41: num41.BackColor = System.Drawing.Color.Red; break;
					case 42: num42.BackColor = System.Drawing.Color.Red; break;
				default: break;
			}
			   	
		}
		
		
				
			
			   
			
			//inicializando el evento de click para el metodo volver
			//aqui le estamso diciendo que cuando se presione elboton de volver
			//muestre el menu principal
			
		
		
		
			
			
			
			
		//necesito crear un metodo de si el numero aleatorio generado es = texto un de los label
			
			
			
			
			void Button8Click(object sender, EventArgs e)
			{
				
				cantados.Show();
				
			}
		
			
			
			void BingoLoad(object sender, EventArgs e)
			{
				button2.Hide();
				dineroGanador.Text = "Ganador del bingo: " + Convert.ToString(info2.premios_bingo() + "$");
				cartones_registrados.Text = "Cartones registrados: " + info2.total_cartones();
				Int64 total = informacion.monto_total + informacion.pote_resto_bingo;
			    total_pote.Text = "Total del pote: " + total + "$";
			}
			
			void Button2Click(object sender, EventArgs e)
			{
				
				//mostrar ganador del bingo
				info2.buscar_ganadorBingo();
				GanadorBingo bingoGanador = new GanadorBingo();
				bingoGanador.Show();
				this.Close();
				
			}
	}
}
