
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projecto_final
{
	
	public partial class Eliminar : Form
	{
			private ensaladas ensa;
			
		public Eliminar(ensaladas ensa)
		{this.FormBorderStyle = FormBorderStyle.FixedSingle;
			
			InitializeComponent();
			//this.main=main;
			this.ensa=ensa;
		}
		
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
			
			
			if(this.txtId2.Text.Trim()!="" ){
				Funcion funci = new Funcion();
				funci.eliminarRegistroPorIdp(this.txtId2.Text.Trim());
				
				
				
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"la ensalada se eliminó con exito ¿Deseas eliminar  otra ensalada?", "Nuevo ensalada",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);

				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
					this.ensa.actualizarTabla();
				}else{
					this.txtId2.Clear();
					this.ensa.actualizarTabla();
					
				}
			}
		}
	}
}
