using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Conexion
{
    public class Conexion
    {
        readonly string cadena_conexion = "Server=localhost; Port=3306; DataBase=usuario_ejerccio3; Uid=root; Pwd=gerson11";
        MySqlConnection conexion;
        MySqlCommand comand;

        public Usuario user(String usuario, String contra)
        {
            Usuario user_login = null;
            try
            {
                String sql = "SELECT * FROM Usuario_tabla  WHERE Codigo_Usuario = @usuario AND Contraseña= @contra; ";
                conexion = new MySqlConnection(cadena_conexion); 
                conexion.Open();    

                comand =  new MySqlCommand(sql, conexion);
                comand.Parameters.AddWithValue("@usuario", usuario);
                comand.Parameters.AddWithValue("@contra", contra);

                MySqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    user_login = new Usuario();
                    user_login.Codigo_Usuario = reader[0].ToString();
                    user_login.Contraseña = reader[1].ToString();
                    user_login.Nombre_usuario = reader[2].ToString();
                    user_login.edad = Convert.ToInt32(reader[3]);

                }
                reader.Close();
                conexion.Close();


            }
            catch (Exception ex)
            {

                throw;
            }

            return user_login;


        }

        public DataTable lista_regis()
        {
            DataTable lista_registros= new DataTable();

            try
            {
                String sql = "SELECT * FROM Usuario_tabla ";

                conexion = new MySqlConnection(cadena_conexion);
                conexion.Open();

                comand = new MySqlCommand(sql, conexion);

                MySqlDataReader reader = comand.ExecuteReader();
                lista_registros.Load(reader);   
                reader.Close();
                conexion.Close();



            }
            catch (Exception ex)
            {

                throw;
            }


            return lista_registros;

        }
    }
}
