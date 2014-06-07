/*
 * Created by SharpDevelop.
 * User: ChristianArias
 * Date: 23/may./2014
 * Time: 10:25 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projecto_final
{

	public partial class Eliminarbeb : Form
	{
		private bebida bebs;
		
		
		public Eliminarbeb(bebida bebs)
		{

			InitializeComponent();
			this.bebs=bebs;
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			bebida bebid=new bebida();
			bebid.Show();
			this.Dispose();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void EliminarbebLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e){
			if(this.textBox1.Text.Trim()==""){
				System.Windows.Forms.DialogResult advertencia = MessageBox.Show(
					"Debes ingresar el ID a eliminar");
			}else{

		System.Windows.Forms.DialogResult result = MessageBox.Show(
					"Enserio deseas eliminar?", "Eliminar bebida",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1);
			
				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
					this.bebs.actualizarTabla();
				}
			else{
	funciones funci = new funciones();
	funci.eliminarbebida(this.textBox1.Text.Trim());
	this.bebs.actualizarTabla();
	this.Close();
				}
		}
		
		}
	}
}
