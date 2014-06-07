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
	/// <summary>
	/// Description of Editarbeb.
	/// </summary>
	public partial class Editarbeb : Form
	{
		private bebida bebs;
		private string seleccionado;
		
		public Editarbeb(bebida bebs,string seleccionado)
		{
			
			this.bebs=bebs;
			this.seleccionado=seleccionado;
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			bebida bebid=new bebida();
			bebid.Show();
			this.Dispose();			
		}
		
		void Button2Click(object sender, EventArgs e)
		{

					
			if (this.textBox2.Text.Trim()=="" || this.textBox3.Text.Trim()==""){
				
				System.Windows.Forms.DialogResult advertencia = MessageBox.Show(
					"Debes ingresar los nuevos datos");
			}else{	
				
funciones funci=new funciones();
funci.editarbebida(this.seleccionado,this.textBox2.Text.Trim(),this.textBox3.Text.Trim());
			
System.Windows.Forms.DialogResult result = MessageBox.Show(
					"Se edito correctamente ¿Desea editar otra bebida?", "editar bebida",
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
		/*void cargareditar(object sender, EventArgs e){
			System.Collections.Hashtable registro = new System.Collections.Hashtable();
			funciones funci=new funciones();
			registro=funci.
		}*/
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
