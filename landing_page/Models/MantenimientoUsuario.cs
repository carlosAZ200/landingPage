using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace landing_page.Models
{
    public class MantenimientoUsuario
    {
        private SqlConnection con;

        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["administracion"].ToString();
            con = new SqlConnection(constr);
        }

        public int Alta(Usuario usu)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("insert into es_usuarios (USU_nombre,USU_email,USU_fecharegistro,USU_ciudad) values (@nombre, @email, GETDATE(), @ciudad )", con);

            comando.Parameters.Add("@nombre", SqlDbType.VarChar);
            comando.Parameters.Add("@email", SqlDbType.VarChar);
            comando.Parameters.Add("@ciudad", SqlDbType.VarChar);
            
            comando.Parameters["@nombre"].Value = usu.Nombre;
            comando.Parameters["@email"].Value = usu.Email;
            comando.Parameters["@ciudad"].Value = usu.Ciudad;
            

            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public List<Usuario> RecuperarTodos()
        {
            Conectar();
            List<Usuario> usuarios = new List<Usuario>();

            SqlCommand com = new SqlCommand("select USU_id,USU_nombre,USU_email,USU_fecharegistro,USU_ciudad from es_usuarios", con);

            con.Open();
            SqlDataReader registros = com.ExecuteReader();
            while (registros.Read())
            {
                Usuario usu = new Usuario
                {
                    Id = Convert.ToInt32(registros["USU_id"]),
                    Nombre = registros["USU_nombre"].ToString(),
                    Email = registros["USU_email"].ToString(),
                    FechaRegistro = DateTime.Parse(registros["USU_fecharegistro"].ToString()),
                    Ciudad = registros["USU_ciudad"].ToString()
                };
                usuarios.Add(usu);
            }
            con.Close();
            return usuarios;
        }
    }
}