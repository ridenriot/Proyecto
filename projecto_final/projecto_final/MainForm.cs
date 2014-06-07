/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 16/05/2014
 * Time: 10:55 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projecto_final
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		    
			
			if(this.textBox1.Text == "eduardo" && this.textBox2.Text == "123"){
			this.Hide();
			tablas t1=new tablas();
		    t1.Show();
		    System.Windows.Forms.DialogResult advertencia = MessageBox.Show("\t"+"Bienvenido Borja");
			}else if (this.textBox1.Text == "arias" && this.textBox2.Text == "12345"){
			this.Hide();
			tablas t1=new tablas();
		    t1.Show();
		    System.Windows.Forms.DialogResult advertencia = MessageBox.Show("\t"+"Bienvenido Arias");
			}
			else{System.Windows.Forms.DialogResult advertencia = MessageBox.Show("\t"+"Contraseña Erronea Intenta de nuevo");}
			
		}
	}
}
