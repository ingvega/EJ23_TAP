using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EmployeeDAO
    {
        public Employee login(String usuario, String password)
        {
            Employee emp=null;
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                {
                    //Crear la sentencia a ejecutar (SELECT)
                    //SENTENCIA VULNERABLE A ATAQUE POR INYECCIÓN SQL
                    //EVITAR A TODA COSTA CONCATENAR VALORES STRING
                    //String select = @"SELECT EmployeeId, FirstName, LastName, Title
                    //    FROM Employees
                    //    WHERE UserName='"+usuario+"' AND Password='"+password+"'";

                    String select = @"SELECT EmployeeId, FirstName, LastName, Title
                        FROM Employees
                        WHERE UserName=@usuario AND Password=@password";


                    //Definir un datatable para que sea llenado
                    DataTable dt = new DataTable();
                    //Crear el dataadapter
                    MySqlCommand sentencia = new MySqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@usuario", usuario);
                    sentencia.Parameters.AddWithValue("@password", password);

                    sentencia.Connection = Conexion.conexion;
                    
                    MySqlDataAdapter da = new MySqlDataAdapter(sentencia);
                    
                    //Llenar el datatable
                    da.Fill(dt);
                    //Revisar si hubo resultados
                    if(dt.Rows.Count > 0) { 
                        DataRow fila = dt.Rows[0];
                        emp = new Employee()
                        {
                            EmployeeId = Convert.ToInt32(fila["EmployeeId"]),
                            FirstName = fila["FirstName"].ToString(),
                            LastName = fila["LastName"].ToString(),
                            Title = fila["Title"].ToString()
                        };
                        
                    }

                    return emp;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                return null;
            }

        }
    }
}
