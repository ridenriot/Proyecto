using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace projecto_final{

	public partial class bebida : Form{
		
		private MySqlCommand myCmdQuery;
		private MySqlDataAdapter myDataAdapter;
		private BindingSource myBindingSource;
		private MySqlCommandBuilder myCommandBuilder;
		private DataSet myDataSet;
		private MySqlConnection myConnection;
		private string myStringCon;
		
		public bebida(){
			
			InitializeComponent();
					
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			
			this.myCmdQuery= new MySqlCommand();
			this.myDataAdapter=new MySqlDataAdapter();
			this.myBindingSource=new BindingSource();
			this.myCommandBuilder =new MySqlCommandBuilder();
			this.myDataSet=new DataSet();
			this.myStringCon=
				"Server=localhost;" +
				"Database=pandc;" +
				"User ID=root;" +
				"Password=angel666;" +
				"Pooling=false;";
	
		}
				
			private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		
		public void actualizarTabla(){
			try{
				this.myDataSet.Clear();
				this.myDataAdapter.Fill(this.myDataSet,"bebidas");
				this.myBindingSource.DataSource=this.myDataSet;
				this.myBindingSource.DataMember="bebidas";
				this.myDataGrid.DataSource=this.myBindingSource;
				this.myDataGrid.Update();
				this.myDataGrid.Refresh();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
		}


		
		void BebidaLoad(object sender, EventArgs e)
		{
						//create an instance of MySqlConnection class
			this.myConnection = new MySqlConnection(this.myStringCon);
			try{
				this.myConnection.Open();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
				System.Environment.Exit(1);
			}

			this.myCmdQuery.CommandText="SELECT * FROM bebidas";
			this.myCmdQuery.CommandType=CommandType.Text;
			this.myCmdQuery.Connection=this.myConnection;

			this.myDataAdapter.SelectCommand=this.myCmdQuery;
			this.myCommandBuilder.DataAdapter=this.myDataAdapter;

			//Llenar el dataset
			this.myDataAdapter.Fill(this.myDataSet,"bebidas");
			this.myBindingSource.DataSource=this.myDataSet;
			this.myBindingSource.DataMember="bebidas";
			this.myDataGrid.DataSource=this.myBindingSource;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
			Agregarbeb addbeb=new Agregarbeb(this);
			addbeb.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string seleccionado = myDataGrid.CurrentRow.Cells[0].Value.ToString();
			Editarbeb editbeb= new Editarbeb(this,seleccionado);
			editbeb.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string selectionar = myDataGrid.CurrentRow.Cells[0].Value.ToString();
			//label1.Text=selectionar;
			
			
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"¿Está seguro que desea eliminar?", "Eliminar",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				if(result == System.Windows.Forms.DialogResult.Yes){
				this.eliminar(selectionar);
				this.actualizarTabla();
				
			}
			
			
		}
		
		private void eliminar(String id){
			String sql ="DELETE FROM bebidas WHERE(`id`='" + id + "')";
			this.ejecutarComando(sql);
				
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.actualizarTabla();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			tablas t1=new tablas();
			t1.Show();
			this.Dispose();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			Application.Exit();

		}
	}
}
