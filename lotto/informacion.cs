using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lotto
{

	public class informacion
	{
		public struct ganadores_loteria{
			public Int64 numero_carton{get; set;}
			public Int16 numero_aciertos{get; set;}
		}
		
		public struct ganadores_bingo{
			
			public Int64 n1{get; set;}
			public Int64 n2{get; set;}
			public Int64 n3{get; set;}
			public Int64 n4{get; set;}
			public Int64 n5{get; set;}
			public Int64 n6{get; set;}
			public Int64 numero_cartonGanadorBingo{get; set;}
			public Int64 numero_aciertosBingo{get; set;}
		}
		
		//Lista para guardar todos los cartones
		
		public static List<registro_cartones_clase> r_cartones = new List<registro_cartones_clase>();
		 
		//Lista para guardar los ganadores de la lotería y bingo.
		public static List<ganadores_loteria> loteria = new List<ganadores_loteria>();
		public static List<ganadores_bingo> bingo = new List<ganadores_bingo>();
		
		
		
		//Array para guardar los número aleatorios de bingo y lotería (para que no se repitan).
		Int32[] numero_aleatorio_loteria = new Int32[6];
		Int64[] numero_aleatorio_bingo = new Int64[21];
		
		public static Int64 monto_total;
		public static Double total_club;
		public static Int64 pote_resto_loteria;
		public static Int64 pote_resto_bingo;
		public static Int64 juegos_loteria;
		public static Int64 juegos_bingo;
		public static Int64 repartido_loteria;
		public static Int64 repartido_bingo;
		
		//Este método es para solamente se ingrese números en el textbox y no letras.
		
		public static void solo_numeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
		
		//Método para guardar y comprobar los datos de los cartones en la lista.
		
		public Boolean guardar_datos(Int64 n_carton, Int32 n_1, Int32 n_2, Int32 n_3, Int32 n_4, Int32 n_5, Int32 n_6){
			
			//Este condicional es para verificar que la secuencia de números no sean iguales.
			
			if(n_1 == n_2 || n_1 == n_3 || n_1 == n_4 || n_1 == n_5 || n_1 == n_6){
				MessageBox.Show("La secuencia de números tiene que ser diferente entre ellos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}else if(n_2 == n_1 || n_2 == n_3 || n_2 == n_4 || n_2 == n_5 || n_2 == n_6){
				MessageBox.Show("La secuencia de números tiene que ser diferente entre ellos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}else if(n_3 == n_1 || n_3 == n_2 || n_3 == n_4 || n_3 == n_5 || n_3 == n_6){
				MessageBox.Show("La secuencia de números tiene que ser diferente entre ellos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}else if(n_4 == n_1 || n_4 == n_2 || n_4 == n_3 || n_4 == n_5 || n_4 == n_6){
				MessageBox.Show("La secuencia de números tiene que ser diferente entre ellos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}else if(n_5 == n_1 || n_5 == n_2 || n_5 == n_3 || n_5 == n_4 || n_5 == n_6){
				MessageBox.Show("La secuencia de números tiene que ser diferente entre ellos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}else if(n_6 == n_1 || n_6 == n_2 || n_6 == n_3 || n_6 == n_4 || n_6 == n_5){
				MessageBox.Show("La secuencia de números tiene que ser diferente entre ellos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}else{
				
				//Este condicional es para verificar que la secuencia de números sea entre 1 y 42
				
				if(n_1 < 1 || n_1 > 42){
					MessageBox.Show("La secuencia de números tiene que ser entre 1 y 42", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}else if(n_2 < 1 || n_2 > 42){
					MessageBox.Show("La secuencia de números tiene que ser entre 1 y 42", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}else if(n_3 < 1 || n_3 > 42){
					MessageBox.Show("La secuencia de números tiene que ser entre 1 y 42", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}else if(n_4 < 1 || n_4 > 42){
					MessageBox.Show("La secuencia de números tiene que ser entre 1 y 42", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}else if(n_5 < 1 || n_5 > 42){
					MessageBox.Show("La secuencia de números tiene que ser entre 1 y 42", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}else if(n_6 < 1 || n_6 > 42){
					MessageBox.Show("La secuencia de números tiene que ser entre 1 y 42", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}else{
					
					Boolean registrar = true;
			
					//Aquí comprobamos que el número del cartón y la secuencia de números no se repita en la lista.
					foreach(registro_cartones_clase lista in r_cartones){
						if(lista.numero_carton == n_carton){
							MessageBox.Show("El número de cartón ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							registrar = false;
							break;
						}else if(lista.primer_numero == n_1 && lista.segundo_numero == n_2 && lista.tercer_numero == n_3 && lista.cuarto_numero == n_4 && lista.quinto_numero == n_5 && lista.sexto_numero == n_6){
							MessageBox.Show("La secuencia de número ya está registrada. Intenta con otra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							registrar = false;
							break;
						}
					}
					
					//Si el booleano "registrar" no es falso (o sea, no entró en ningún condicional dentro del foreach)
					//entonces procederá a guardar los datos en la lista.
					
					if(registrar){
						r_cartones.Add(new registro_cartones_clase{numero_carton = n_carton, primer_numero = n_1, segundo_numero = n_2, tercer_numero = n_3, cuarto_numero = n_4, quinto_numero = n_5, sexto_numero = n_6});
						return true;
					}else{
						return false;
					}	
					
				}
				
			}
					
		}
		
		//Método para saber cuantos cartones tiene la lista.
		public Int64 total_cartones(){
			return r_cartones.Count;
			
		}
		
		//Método que obtiene el total del pote.
		//Se multiplica todos los cartones por 100
		public Int64 total_acumulado(){
			Int64 total = r_cartones.Count;
			monto_total = total * 100;
			return monto_total;
		}
		
		//Método para generar números aleatorios
		
		public Int32 generar_numero(string tipo){
			
			if(tipo == "loteria"){
				
				Random numero = new Random();
				Int32 numero2 = 0;
				
				var rand = numero.Next(1, 10);
			
				while(Array.Exists(numero_aleatorio_loteria, element => element == rand)){
					rand = numero.Next(1, 10);
				}
					
				if(Array.Exists(numero_aleatorio_loteria, element => element != rand)){
					numero2 = rand;
				}
				
				
				for(Int16 i = 0; i < numero_aleatorio_loteria.Length; i++){
					if(numero_aleatorio_loteria[i] == 0){
						numero_aleatorio_loteria[i] = numero2;
						break;
					}
				}
				
				return numero2;
			}else{
				
				Random numero = new Random();
				Int32 numero2 = 0;
				
				var rand = numero.Next(1, 7);
			
				while(Array.Exists(numero_aleatorio_bingo, element => element == rand)){
					rand = numero.Next(1, 7);
				}
					
				if(Array.Exists(numero_aleatorio_bingo, element => element != rand)){
					numero2 = rand;
				}
				
				
				for(Int16 i = 0; i < numero_aleatorio_bingo.Length; i++){
					if(numero_aleatorio_bingo[i] == 0){
						numero_aleatorio_bingo[i] = numero2;
						break;
					}
				}
				
				return numero2;
			}
		}
		
		
		public Int64 premios_loteria(Int16 numero){
			Int64 total = monto_total + pote_resto_loteria;
			Int64 premio;
			
			 if(numero == 6){
				premio = Convert.ToInt64(0.25*total);
				return premio;
				
			}else if(numero == 5){
				premio = Convert.ToInt64(0.20*total);
				return premio;
			
			}else if(numero == 4){
				premio = Convert.ToInt64(0.20*total);
				return premio;
			
			}else if(numero == 3){
				premio = Convert.ToInt64(0.25*total);
				return premio;
			
			}else{
				
				return 0;
			
			}
			
		}
		
		public void guardar_ganacias_loteria(){
			Double total;
			pote_resto_loteria = 0;
			
			total = monto_total/2;
			pote_resto_loteria = Convert.ToInt64(total);
			total_club = Convert.ToInt64(total_club + total);
			monto_total = 0;
			
		}
		
		
		
		public void buscar_ganador(){
			
			foreach(registro_cartones_clase lista in r_cartones){
				Int16 aciertos = 0;
				
				
				for (Int16 i = 0; i < numero_aleatorio_loteria.Length; i++){
					
					
					
					if(lista.primer_numero == numero_aleatorio_loteria[i] ||
					lista.segundo_numero == numero_aleatorio_loteria[i] ||
					lista.tercer_numero == numero_aleatorio_loteria[i] ||
					lista.cuarto_numero == numero_aleatorio_loteria[i] ||
					lista.quinto_numero == numero_aleatorio_loteria[i] ||
					lista.sexto_numero == numero_aleatorio_loteria[i]){
						aciertos++;
					}
				}
				
				if(aciertos == 6 || aciertos == 5 || aciertos == 4 || aciertos == 3){
					loteria.Add(new ganadores_loteria{numero_carton = lista.numero_carton, numero_aciertos = aciertos});
				}
			}
			
			
				
		}
		
		// metodos para el bingo
		public void buscar_ganadorBingo(){
			
			Int32 aciertosBingo = 0;
			
			
			foreach(registro_cartones_clase lista in r_cartones){
			      
				
				
			
			for (Int32 i = 0; i < numero_aleatorio_bingo.Length; i++){
					
					if(lista.primer_numero == numero_aleatorio_bingo[i] || // si pones 1,2,3,4,5 y 6 si funciona en ves de el arreglo
					lista.segundo_numero == numero_aleatorio_bingo[i] ||
					lista.tercer_numero == numero_aleatorio_bingo[i] ||
					lista.cuarto_numero == numero_aleatorio_bingo[i] ||
					lista.quinto_numero == numero_aleatorio_bingo[i] ||
					lista.sexto_numero == numero_aleatorio_bingo[i]){
					
					aciertosBingo++;
					
						
					}
				}
				
				if(aciertosBingo == 6){
					
					bingo.Add(new ganadores_bingo{numero_cartonGanadorBingo = lista.numero_carton, n1 = lista.primer_numero, n2 = lista.segundo_numero,
					          	                 n3 = lista.tercer_numero, n4 = lista.cuarto_numero, n5 = lista.quinto_numero,
					          		 n6 = lista.sexto_numero, numero_aciertosBingo = aciertosBingo});
					
		
				}
			}
			
			
		}
		
		public String lista_ganadoresBingo(){
		
			String datos = "";
			
			foreach(ganadores_bingo lista in bingo){
						
				if(lista.numero_aciertosBingo == 6){
							
					datos += "Número de cartón: "+ lista.numero_cartonGanadorBingo+"\nNúmeros ganadores: "+ lista.n1+", "
					+lista.n2+", "+lista.n3+", "+lista.n4+", "+lista.n5+", "+lista.n6 + "\n\n";
						
				}
			}
			
			if(datos == ""){
				return "No hay ganadores";
			}else{
				return datos;
			}
		}
	
		
		public Int64 lista_ganadores(Int16 aciertos){
			if(aciertos == 6){
				foreach(ganadores_loteria lista in loteria){
					if(lista.numero_aciertos == 6){
						return lista.numero_carton;
					}
				}
				return 0;
			}else if(aciertos == 5){
				foreach(ganadores_loteria lista in loteria){
					if(lista.numero_aciertos == 5){
						return lista.numero_carton;
						
					}
				}
				return 0;
			}else if(aciertos == 4){
				foreach(ganadores_loteria lista in loteria){
					if(lista.numero_aciertos == 4){
						return lista.numero_carton;
						
					}
				}
				return 0;
			}else if(aciertos == 3){
				foreach(ganadores_loteria lista in loteria){
					if(lista.numero_aciertos == 3){
						return lista.numero_carton;
						
					}
				}
				return 0;
			}else{
				return 0;
			}
		}
		
		
		public Int64 premios_bingo(){
			
			Int64 total = monto_total + pote_resto_bingo;
			Int64 premio = 0;
			
			premio = (total * 70) / 100;
				
			return premio;
				
		}
			
		
		
		public void guardar_ganancias_bingo(){
			Double total;
			pote_resto_bingo = 0;
			
			total = monto_total/2;
			pote_resto_bingo = Convert.ToInt64(total);
			total_club = Convert.ToInt64(total_club + total);
			monto_total = 0;
			
		}
	
	}
}

		
	
	
		
		
		
		
		
		

		 