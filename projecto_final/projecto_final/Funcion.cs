using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

	
namespace projecto_final
{ 

	public class Funcion:MySQL
	{
		public Funcion()
		{
		}
	
		//muestra los registros de la base de datos
		public void mostrarTodosp(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id_ens"].ToString();
	            string nombre = myReader["nombre"].ToString();
	            string precio = myReader["precio"].ToString();
	           
	       }

            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}

		
	public void insertarRegistroNuevop(string nombre,string precio){
			
			
			this.abrirConexion();
			string sql = "INSERT INTO `ensalada` (`nombre`, `precio`) VALUES ('" + nombre + "', '" + precio + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		
			//elimina registro por id
		public void eliminarRegistroPorIdp(string id){
			
			this.abrirConexion();
			string sql = "DELETE FROM `ensalada` WHERE (`id_ens`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
			
			
		}

	/*	
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
*/
		
		//edita nombre por id
		public void editarNombreRegistrop(string id, string nombre,string precio){
			
		
			//update ensalada set nombre=" eduardo",precio=20 where id_ens=7;
			this.abrirConexion();
			string sql = "UPDATE `ensalada` SET `nombre`='" + nombre + "' , `precio`='" + precio + "'  WHERE (`id_ens`='" + id + "')";
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
