using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {
        public static MySqlConnection conexion;
        public bool Conectar() { 
            conexion = new MySqlConnection();
            conexion.ConnectionString = "sever=localhost;uid=root;pwd=123;database=northwind";
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public void Desconectar() { 
        
        }
    }
}
