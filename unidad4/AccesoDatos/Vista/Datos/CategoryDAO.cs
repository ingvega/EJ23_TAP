using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class CategoryDAO
    {
        public DataTable obtenerTodas() {
            //Conectarme
            if (new Conexion().Conectar())
            {
                //Crear la sentencia a ejecutar (SELECT)
                String select = "SELECT CATEGORYID, CATEGORYNAME,DESCRIPTION FROM CATEGORIES;";
                //Definir un datatable para que sea llenado
                DataTable dt = new DataTable();
                //Crear el dataadapter
                MySqlCommand sentencia=new MySqlCommand();
                sentencia.CommandText=select;
                sentencia.Connection = Conexion.conexion;
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sentencia;
                //Llenar el datatable
                da.Fill(dt);
                return dt;
            }
            else {
                return null;
            }

        }
    }
}
