
namespace lotto
{
	partial class GanadorBingo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.carton_Ganador = new System.Windows.Forms.Label();
			this.numeros_ganadores = new System.Windows.Forms.Label();
			this.monto_ganado = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// carton_Ganador
			// 
			this.carton_Ganador.Font = new System.Drawing.Font("Libre Baskerville", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carton_Ganador.ForeColor = System.Drawing.SystemColors.Window;
			this.carton_Ganador.Location = new System.Drawing.Point(20, 99);
			this.carton_Ganador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.carton_Ganador.Name = "carton_Ganador";
			this.carton_Ganador.Size = new System.Drawing.Size(633, 178);
			this.carton_Ganador.TabIndex = 1;
			// 
			// numeros_ganadores
			// 
			this.numeros_ganadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.numeros_ganadores.ForeColor = System.Drawing.SystemColors.Window;
			this.numeros_ganadores.Location = new System.Drawing.Point(20, 357);
			this.numeros_ganadores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.numeros_ganadores.Name = "numeros_ganadores";
			this.numeros_ganadores.Size = new System.Drawing.Size(438, 35);
			this.numeros_ganadores.TabIndex = 2;
			// 
			// monto_ganado
			// 
			this.monto_ganado.Font = new System.Drawing.Font("Libre Baskerville", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monto_ganado.ForeColor = System.Drawing.SystemColors.Window;
			this.monto_ganado.Location = new System.Drawing.Point(20, 324);
			this.monto_ganado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.monto_ganado.Name = "monto_ganado";
			this.monto_ganado.Size = new System.Drawing.Size(356, 34);
			this.monto_ganado.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Green;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.SystemColors.Window;
			this.button2.Location = new System.Drawing.Point(250, 506);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(201, 43);
			this.button2.TabIndex = 16;
			this.button2.Text = "Menú Principal";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Libre Baskerville", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(20, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(646, 49);
			this.label1.TabIndex = 17;
			this.label1.Text = "Ganadores del Bingo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Green;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Libre Baskerville", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(266, 412);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 28);
			this.button1.TabIndex = 18;
			this.button1.Text = "Menú Principal";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// GanadorBingo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(684, 452);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.monto_ganado);
			this.Controls.Add(this.numeros_ganadores);
			this.Controls.Add(this.carton_Ganador);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "GanadorBingo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "GanadorBingo";
			this.Load += new System.EventHandler(this.GanadorBingoLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label monto_ganado;
		private System.Windows.Forms.Label numeros_ganadores;
		private System.Windows.Forms.Label carton_Ganador;
	}
}
