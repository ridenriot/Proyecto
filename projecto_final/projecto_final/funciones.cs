using System;
//using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

//cambiar el namespace por namespace mysqlConnect
	
namespace projecto_final
{ 

	public class funciones:MySQL
	{

		
		public funciones()
		{
		}
	
		//muestra los registros de la base de datos
		public void mostrarTodosp(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id"].ToString();
	            string nombre = myReader["nombre"].ToString();
	            string precio = myReader["precio"].ToString();
	            Console.WriteLine("ID:" + id +
				                  "  Nombre:" + nombre + 
				                  "  Precio:" + precio);
	       }

            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}

		public void agregarbebida(string nombre,string precio){
			this.abrirConexion();
			string sql = "INSERT INTO `bebidas` (`nombre` , `precio`) values ('"+ nombre +"','"+precio+"')";
			this.ejecutarComando(sql);
			this.cerrarConexion();			
		}
		public void eliminarbebida(string selecionar){
			this.abrirConexion();
			string sql = "DELETE FROM bebidas WHERE(`id`='" + selecionar + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		public void editarbebida(string selecionado,string nombre,string precio){
			this.abrirConexion();
			string sql ="UPDATE bebidas SET `nombre`='"+nombre+"',`precio`='"+precio+"' WHERE (`id`='"+selecionado+"')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		/*public Hashtable obtenerPorId(string id){
			Hashtable registro = new Hashtable();
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM alumno WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	registro["id"] = myReader["id"].ToString();
	            registro["nombre"] = myReader["codigo"].ToString();
	            registro["precio"] = myReader["nombre"].ToString();
	       }
          
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			return registro;
		}
		*/
		
		public void insertarRegistroNuevop(){
			string nombre,precio;
			
			Console.WriteLine("Ingresa el nombre :");
			nombre=Console.ReadLine();
			
			Console.WriteLine("Ingresa el precio :");
			precio=Console.ReadLine();
			
			
			this.abrirConexion();
			string sql = "INSERT INTO `ensalada` (`nombre` , `precio`) VALUES ('" + nombre + "', '" + precio + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		
		//edita codigo por nombre
		public void editarCodigoRegistrop(){
			
			string id,codigo;
			Console.WriteLine("Ingresa id del profesor a editar;");
			id=Console.ReadLine();
			Console.WriteLine("Ingresa el nuevo codigo:");
			codigo=Console.ReadLine();
			
			this.abrirConexion();
			string sql = "UPDATE `ensalada` SET `codigo`='" + codigo + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		
		//edita nombre por id
		public void editarNombreRegistrop(){
			string id,nombre;
			Console.WriteLine("Ingresa ID del profesor a editar;");
			id=Console.ReadLine();
			Console.WriteLine("Ingresa el nuevo nombre:");
			nombre=Console.ReadLine();
			
			this.abrirConexion();
			string sql = "UPDATE `ensalada` SET `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		
		
		 
		
		
		//elimina registro por id
		public void eliminarRegistroPorIdp(){
			string id;
			Console.WriteLine("Ingresa el ID del profesor a eliminar :");
			id=Console.ReadLine();
		
				
			this.abrirConexion();
			string sql = "DELETE FROM `ensalada` WHERE (`id`='" + id + "')";
			Console.WriteLine("Se ha eliminado el profesor");
			this.ejecutarComando(sql);
			this.cerrarConexion();
			
			
		}
		
		
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}

		private string querySelect(){
			return "SELECT * " +
	           	"FROM ensalada";
		}
		
		
		
	}
}
