
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projecto_final
{
	
	public partial class guarda :Form
	{
private ensaladas ensa;
		public guarda(ensaladas ensa)
		{
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
			InitializeComponent();
			this.ensa=ensa;
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			 if(this.txtNombre.Text.Trim()!="" && this.txtPrecio.Text.Trim()!=""){
				Funcion funci = new Funcion();
				funci.insertarRegistroNuevop(this.txtNombre.Text.Trim(), this.txtPrecio.Text.Trim());
				
				
				
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"la ensalada se agregó con exito ¿Desea agregar otro ensalada?", "Nuevo ensalada",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);

				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
					this.ensa.actualizarTabla();
				}else{
					
					this.txtNombre.Clear();
					this.txtPrecio.Clear();
					this.ensa.actualizarTabla();
				}
			}
		}
		
		void TxtIdTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
