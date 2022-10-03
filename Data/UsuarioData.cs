using API2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Diagnostics.Contracts;

namespace API2.Data
{
    public class UsuarioData
    {

        //registrar
        /*public static bool Registrar(Usuario oUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_registrar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documentoidentidad", oUsuario.DocumentoIdentidad);
                cmd.Parameters.AddWithValue("@nombres", oUsuario.Nombres);
                cmd.Parameters.AddWithValue("@telefono", oUsuario.Telefono);
                cmd.Parameters.AddWithValue("@correo", oUsuario.Correo);
                cmd.Parameters.AddWithValue("@ciudad", oUsuario.Ciudad);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }
        //modificar
        public static bool Modificar(Usuario oUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_modificar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", oUsuario.IdUsuario);
                cmd.Parameters.AddWithValue("@documentoidentidad", oUsuario.DocumentoIdentidad);
                cmd.Parameters.AddWithValue("@nombres", oUsuario.Nombres);
                cmd.Parameters.AddWithValue("@telefono", oUsuario.Telefono);
                cmd.Parameters.AddWithValue("@correo", oUsuario.Correo);
                cmd.Parameters.AddWithValue("@ciudad", oUsuario.Ciudad);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }*/

        //listar

        public static List<Usuario> Listar()
        {
            Conexion con = new Conexion();
            List<Usuario> oListaUsuario = new List<Usuario>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("cliente.consultaSofy", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                //try
                //{
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaUsuario.Add(new Usuario()
                            {
                                /*IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                DocumentoIdentidad = dr["DocumentoIdentidad"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Ciudad = dr["Ciudad"].ToString(),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])*/

                                contacto= dr["contacto"].ToString(),
                                identificacion= dr["identificacion"].ToString(),
                                primerNombre= dr["primerNombre"].ToString()
                            });
                        }
                    }
                    return oListaUsuario;
                //}
                //catch (Exception ex)
                //{
                  //  return oListaUsuario;
                //}

            }

        }

        //obtener usuario
        /*public static Usuario Obtener(int idusuario)
        {
            Usuario oUsuario = new Usuario();
            using (SqlConnection oConexion = new SqlConnection("Data Source=.;Initial Catalog = DBPRUEBAS; Integrated Security = True"))
            {
                SqlCommand cmd = new SqlCommand("usp_obtener", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", idusuario);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oUsuario = new Usuario()
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
                    }
                    return oUsuario;
                }
                catch (Exception ex)
                {
                    Usuario u = new Usuario();
                    u.Nombres = "mal Nombre";
                    return u;
                }

            }

        }

        //eliminar
        public static bool Eliminar(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_eliminar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", id);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }*/


        ///segunda conexion
        public static List<ActividadEconomica> ListarActividad()
        {
            ConexionSodig con = new ConexionSodig();
            List<ActividadEconomica> oListaUsuario = new List<ActividadEconomica>();
            using (SqlConnection oConexion = new SqlConnection(ConexionSodig.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("cliente.consultaActividadSodig", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                //try
                //{
                oConexion.Open();
                //cmd.ExecuteNonQuery();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oListaUsuario.Add(new ActividadEconomica()
                        {
                            /*IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            DocumentoIdentidad = dr["DocumentoIdentidad"].ToString(),
                            Nombres = dr["Nombres"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            Ciudad = dr["Ciudad"].ToString(),
                            FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])*/

                            fecha = dr["fecha"].ToString(),
                            hora = dr["hora"].ToString(),
                            ciudad = dr["ciudad"].ToString(),
                            contacto = dr["contacto"].ToString(),
                            identificacion = dr["identificacion"].ToString(),
                            primerNombre = dr["primerNombre"].ToString(),
                            segundoNombre = dr["segundoNombre"].ToString(),
                            primerApellido = dr["primerApellido"].ToString(),
                            segundoApellido = dr["segundoApellido"].ToString(),
                            actividadEconomica = dr["actividadEconomica"].ToString()
                        });
                    }
                }
                return oListaUsuario;
                //}
                //catch (Exception ex)
                //{
                //  return oListaUsuario;
                //}

            }

        }
    }
}
