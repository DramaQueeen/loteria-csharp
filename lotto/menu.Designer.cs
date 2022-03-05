/*
 * Creado por SharpDevelop.
 * Usuario: equipo
 * Fecha: 27/1/2021
 * Hora: 11:42 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace lotto
{
	partial class menu
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.cartones_registrados = new System.Windows.Forms.Label();
			this.total_pote = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Libre Baskerville", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(560, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menú";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Green;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(216, 126);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Comprar cartón";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Green;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(216, 176);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 32);
			this.button2.TabIndex = 2;
			this.button2.Text = "Lotería";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Green;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(216, 228);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(152, 32);
			this.button3.TabIndex = 3;
			this.button3.Text = "Bingo";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Green;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(216, 279);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(152, 32);
			this.button4.TabIndex = 4;
			this.button4.Text = "Información";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// cartones_registrados
			// 
			this.cartones_registrados.BackColor = System.Drawing.Color.Transparent;
			this.cartones_registrados.ForeColor = System.Drawing.Color.Green;
			this.cartones_registrados.Location = new System.Drawing.Point(12, 419);
			this.cartones_registrados.Name = "cartones_registrados";
			this.cartones_registrados.Size = new System.Drawing.Size(184, 23);
			this.cartones_registrados.TabIndex = 13;
			this.cartones_registrados.Text = "Cartones registrados: 0";
			this.cartones_registrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// total_pote
			// 
			this.total_pote.BackColor = System.Drawing.Color.Transparent;
			this.total_pote.ForeColor = System.Drawing.Color.Green;
			this.total_pote.Location = new System.Drawing.Point(424, 419);
			this.total_pote.Name = "total_pote";
			this.total_pote.Size = new System.Drawing.Size(148, 23);
			this.total_pote.TabIndex = 16;
			this.total_pote.Text = "Total del pote: 0";
			this.total_pote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(584, 451);
			this.Controls.Add(this.total_pote);
			this.Controls.Add(this.cartones_registrados);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Libre Baskerville", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "menu";
			this.Text = "Menú";
			this.Load += new System.EventHandler(this.MenuLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label total_pote;
		private System.Windows.Forms.Label cartones_registrados;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
