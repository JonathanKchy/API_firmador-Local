using API2.Data;
using API2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API2.Controllers
{
    public class PruebaController : ApiController
    {
        [HttpGet]
        [Route("api/funciones/Suma")]
        public String GetSuma(int idUsuario)
        {
           /* List < Usuario > oUsuarios=new List<Usuario>();
            Usuario usuario = new Usuario();
            usuario.Correo = "hola.com";
            usuario.Nombres = "Andres";
            oUsuarios.Add(usuario);
            Usuario usuario2 = new Usuario();
            usuario2.Correo = "chao.com";
            usuario2.Nombres = "Eve";
            oUsuarios.Add(usuario2);
            

           //Conexion con = new Conexion();
            string ruta = Conexion.rutaConexion;
            //SqlConnection oConexion = new SqlConnection(ruta);
            //return ruta;
            SqlConnection oConexion = new SqlConnection(ruta);
            SqlCommand cmd = new SqlCommand("usp_obtener", oConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idusuario", idUsuario);
            oConexion.Open();
            cmd.ExecuteNonQuery();
            using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            usuario = new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                DocumentoIdentidad = dr["DocumentoIdentidad"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Ciudad = dr["Ciudad"].ToString(),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])
                            };
                        }
                    }*/
            return "hola";
                         
        }
    }
}
