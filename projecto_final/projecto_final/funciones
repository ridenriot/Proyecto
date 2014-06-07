using MySql.Data.MySqlClient;
using System;
//cambiar el namespace por namespace mysqlConnect
	
namespace mysqlConnect
{ 

	public class profesor : MySQL
	{
		public profesor()
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
	            string codigo = myReader["codigo"].ToString();
	            string nombre = myReader["nombre"].ToString();
	            Console.WriteLine("ID:" + id +
				                  "  Código:" + codigo + 
				                  "  Nombre:" + nombre);
	       }

            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}

		
		public void insertarRegistroNuevop(){
			string  codigo, nombre;
			
			Console.WriteLine("Ingresa el Codigo :");
			codigo=Console.ReadLine();
			
			Console.WriteLine("Ingresa el Nombre :");
			nombre=Console.ReadLine();
			
			
			this.abrirConexion();
			string sql = "INSERT INTO `profesor` (`codigo` , `nombre`) VALUES ('" + codigo + "', '" + nombre + "')";
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
			string sql = "UPDATE `profesor` SET `codigo`='" + codigo + "' WHERE (`id`='" + id + "')";
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
			string sql = "UPDATE `profesor` SET `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		
		
		 
		
		
		//elimina registro por id
		public void eliminarRegistroPorIdp(){
			string id,s;
			Console.WriteLine("Ingresa el ID del profesor a eliminar :");
			id=Console.ReadLine();
			Console.WriteLine("Estas seguro de eliminar el profesor?(s/n)");
			s=Console.ReadLine();
			
			if(s=="s"){
				
			this.abrirConexion();
			string sql = "DELETE FROM `profesor` WHERE (`id`='" + id + "')";
			Console.WriteLine("Se ha eliminado el profesor");
			this.ejecutarComando(sql);
			this.cerrarConexion();
			
			}else{Console.WriteLine("No se eliminó el profesor");}
			
			
			
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
	           	"FROM profesor";
		}
		
		
		
	}
}
