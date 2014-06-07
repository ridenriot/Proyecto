
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projecto_final
{
	/// <summary>
	/// Description of Editar.
	/// </summary>
	public partial class Editar : Form
	{
		private ensaladas ensa;
		
		public Editar(ensaladas ensa)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			InitializeComponent();
			this.ensa=ensa;
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
				
			
			if(this.txtId.Text.Trim()!="" && this.txtNombre.Text.Trim()!="" && this.txtPrecio.Text.Trim()!=""){
				Funcion funci = new Funcion();
				funci.editarNombreRegistrop(this.txtId.Text.Trim(),this.txtNombre.Text.Trim(), this.txtPrecio.Text.Trim());
				
				
				
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"la ensalada se editó con exito ¿Desea editar otra ensalada?", "Nuevo ensalada",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);

				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
					this.ensa.actualizarTabla();
				}else{
					this.txtId.Clear();
					this.txtNombre.Clear();
					this.txtPrecio.Clear();
					this.ensa.actualizarTabla();
				}
				}
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
