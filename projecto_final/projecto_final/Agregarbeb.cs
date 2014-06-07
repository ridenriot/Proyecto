/*
 * Created by SharpDevelop.
 * User: ChristianArias
 * Date: 23/may./2014
 * Time: 10:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projecto_final
{


	public partial class Agregarbeb : Form
	{
		public bebida bebs;
		
		public Agregarbeb(bebida bebs)
		{
			
			InitializeComponent();
			this.bebs=bebs;
		}
		
		void AgregarbebLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{

			bebida bebid=new bebida();
			bebid.Show();
			this.Dispose();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if(this.textBox2.Text.Trim()=="" && this.textBox3.Text.Trim()==""){
				System.Windows.Forms.DialogResult advertencia = MessageBox.Show(
					"Los campos no pueden ir vacios"
				);
					
			}else{
					
funciones funci = new funciones();
funci.agregarbebida(this.textBox2.Text.Trim(),this.textBox3.Text.Trim());
		
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"Se agrego correctamente ¿Desea agregar otra bebida?", "agregar bebida",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
					this.bebs.actualizarTabla();
				}else{
	this.bebs.actualizarTabla();
	this.textBox2.Clear();
	this.textBox3.Clear();
				}
		}
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
