﻿/*
 * Created by SharpDevelop.
 * User: ChristianArias
 * Date: 23/may./2014
 * Time: 10:25 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projecto_final
{
	partial class Editarbeb
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
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ingresa el Nuevo Nombre:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(13, 35);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(186, 20);
			this.textBox2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ingresa el Nuevo Precio:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(13, 84);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(187, 20);
			this.textBox3.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(125, 110);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Editar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Editarbeb
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(211, 151);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Name = "Editarbeb";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editarbeb";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
	}
}
