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
            conexion.ConnectionString = "server=localhost;uid=root;pwd=root;database=northwind";

            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                return false;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public void Desconectar() { 
        
        }
    }
}
