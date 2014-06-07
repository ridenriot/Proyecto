/*
 * Created by SharpDevelop.
 * User: a
 * Date: 16/05/2014
 * Time: 15:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projecto_final
{
	/// <summary>
	/// Description of tablas.
	/// </summary>
	public partial class tablas : Form
	{
		public tablas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm m1=new MainForm();
			m1.Show();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
		
			Application.Exit();

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			bebida bebid=new bebida();
			bebid.Show();
			this.Dispose();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Dispose();
			ensaladas ensa= new ensaladas();
			ensa.Show();
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{

				System.Windows.Forms.DialogResult advertencia = MessageBox.Show(
					"\t"+"Bebidas :"+"\n"+"Christian Saúl Rojas Arias."
					+"\n"+
					"\t"+"Ensaladas :"+"\n"+"Eduardo Trujillo Borja."
				);
				
		}
	}
}
