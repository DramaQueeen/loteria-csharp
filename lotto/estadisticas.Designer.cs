/*
 * Creado por SharpDevelop.
 * Usuario: equipo
 * Fecha: 27/1/2021
 * Hora: 2:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace lotto
{
	partial class estadisticas
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ganacia_c = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Libre Baskerville", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(560, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Información";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(12, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(560, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Juegos realizados: 0";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new System.Drawing.Point(12, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(560, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Juegos de lotería: 0";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new System.Drawing.Point(12, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(560, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Juegos de bingo: 0";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Location = new System.Drawing.Point(12, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(560, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Total repartido bingo: 0";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.Location = new System.Drawing.Point(12, 203);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(560, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Total repartido lotería: 0";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ganacia_c
			// 
			this.ganacia_c.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ganacia_c.Location = new System.Drawing.Point(12, 305);
			this.ganacia_c.Name = "ganacia_c";
			this.ganacia_c.Size = new System.Drawing.Size(560, 23);
			this.ganacia_c.TabIndex = 6;
			this.ganacia_c.Text = "Ganacias del club: 0";
			this.ganacia_c.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Green;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(218, 394);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(134, 28);
			this.button3.TabIndex = 19;
			this.button3.Text = "Volver";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label7
			// 
			this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label7.Location = new System.Drawing.Point(12, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(560, 23);
			this.label7.TabIndex = 20;
			this.label7.Text = "Total repartido en ambos juegos: 0";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// estadisticas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(584, 451);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.ganacia_c);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Libre Baskerville", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "estadisticas";
			this.Text = "Información";
			this.Load += new System.EventHandler(this.EstadisticasLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label ganacia_c;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
