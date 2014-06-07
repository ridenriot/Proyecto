
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace projecto_final
{
	/// <summary>
	/// Description of ensaladas.
	/// </summary>
	public partial class ensaladas : Form
	{
		private MySqlCommand myCmdQuery;
		private MySqlDataAdapter myDataAdapter;
		private BindingSource myBindingSource;
		private MySqlCommandBuilder myCommandBuilder;
		private DataSet myDataSet;
		private MySqlConnection myConnection;
		private string myStringCon;
		
		public ensaladas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
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
		
		void EnsaladasLoad(object sender, EventArgs e)
		{
//create an instance of MySqlConnection class
			this.myConnection = new MySqlConnection(this.myStringCon);
			try{
				this.myConnection.Open();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
				System.Environment.Exit(1);
			}

			this.myCmdQuery.CommandText="SELECT * FROM ensalada";
			this.myCmdQuery.CommandType=CommandType.Text;
			this.myCmdQuery.Connection=this.myConnection;

			this.myDataAdapter.SelectCommand=this.myCmdQuery;
			this.myCommandBuilder.DataAdapter=this.myDataAdapter;

			//Llenar el dataset
			this.myDataAdapter.Fill(this.myDataSet,"ensalada");
			this.myBindingSource.DataSource=this.myDataSet;
			this.myBindingSource.DataMember="ensalada";
			this.myDataGrid.DataSource=this.myBindingSource;
			
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
				this.myDataAdapter.Fill(this.myDataSet,"ensalada");
				this.myBindingSource.DataSource=this.myDataSet;
				this.myBindingSource.DataMember="ensalada";
				this.myDataGrid.DataSource=this.myBindingSource;
				this.myDataGrid.Update();
				this.myDataGrid.Refresh();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			guarda save=new guarda(this);
			save.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Eliminar delete=new Eliminar(this);
			delete.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Editar edit=new Editar(this);
			edit.Show();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.actualizarTabla();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			tablas t1=new tablas();
			t1.Show();
			this.Hide();
		}
	}
}
