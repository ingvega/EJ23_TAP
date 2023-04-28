using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class CategoryDAO
    {
        public List<Category> obtenerTodas() {
            List<Category> lista = new List<Category>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {

                
                //Crear la sentencia a ejecutar (SELECT)
                String select = "SELECT CATEGORYID Clave, CATEGORYNAME,DESCRIPTION FROM CATEGORIES;";
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
                //Crear un objeto categoría por cada fila de la tabla y añadirlo a la lista
                foreach (DataRow fila in dt.Rows)
                {
                    Category categoria = new Category(
                        //int.Parse(fila["Clave"].ToString())
                        Convert.ToInt32(fila["Clave"]),
                        fila["CATEGORYNAME"].ToString(),
                        fila["DESCRIPTION"].ToString()
                        );
                    lista.Add(categoria);
                }

                return lista;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else {
                return null;
            }

        }

        public int agregar(Category categoria) {
            
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (INSERT)
                    String select = "INSERT INTO (CATEGORYNAME,DESCRIPTION) VALUES(@nombre,@descripcion); select last_insert_id();";
                    
                    
                    MySqlCommand sentencia = new MySqlCommand();
                    sentencia.CommandText = select;
                    sentencia.Connection = Conexion.conexion;

                    //Ejercutar el comando 
                    //Cuando nos interesa obtener un valor adicional en el comando (como en el ejemplo de arriba que obtiene el último id generado por autoincrement podemos usar ExecuteScalar
                    int claveNuevaCategoria=Convert.ToInt32(sentencia.ExecuteScalar());

                    //O de lo contrario podríamos usar ExecuteNonQuery que simplemente ejecuta la sentencia y nos permite recuperar (solo si nos interesa) el número de filas afectadas (si es un insert nos regresa cuantas filas agregó, en un update cuantas filas editó y en un delete igual cuantas filas eliminó, por ejemplo:
                    //int filasAfectadas = Convert.ToInt32(sentencia.ExecuteNonQuery());


                    return claveNuevaCategoria;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                //Devolvemos un cero indicando que no se insertó nada
                return 0;
            }
        }
    }
}
