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

                            contacto = dr["contacto"].ToString(),
                            identificacion = dr["identificacion"].ToString(),
                            primerNombre = dr["primerNombre"].ToString()
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


        //Solicitud para obtener el reporte de actividad economica
        public static List<ActividadEconomica> ListarActividad()
        {
            Conexion con = new Conexion();
            List<ActividadEconomica> oListaUsuario = new List<ActividadEconomica>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("consulta.ActividadEconomica", oConexion);
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

        //Solicitud para obtener el reporte de pagos por transferencia
        public static List<ReportePagosTransferencia> ListarReporte()
        {
            Conexion con = new Conexion();
            List<ReportePagosTransferencia> oListaUsuario = new List<ReportePagosTransferencia>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("consulta.ReportePagoTransferencia", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                //try
                //{
                oConexion.Open();
                //cmd.ExecuteNonQuery();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oListaUsuario.Add(new ReportePagosTransferencia()
                        {
                            identificacion = dr["identificacion"].ToString(),
                            primerNombre = dr["primerNombre"].ToString(),
                            segundoNombre = dr["segundoNombre"].ToString(),
                            primerApellido = dr["primerApellido"].ToString(),
                            segundoApellido = dr["segundoApellido"].ToString(),
                            TipoDePago = dr["TipoDePago"].ToString(),
                            Banco = dr["Banco"].ToString(),
                            valor = Convert.ToInt32(dr["valor"]),
                            fecha = dr["fecha"].ToString(),
                            numeroTransaccion = dr["numeroTransaccion"].ToString(),
                            numeroFactura = dr["numeroFactura"].ToString()
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

        //Solicitud para obtener el reporte de tickets
        public static List<Tickets> ListarTicket()
        {
            Conexion con = new Conexion();
            List<Tickets> oListaUsuario = new List<Tickets>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("consulta.Tickets", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                //try
                //{
                oConexion.Open();
                //cmd.ExecuteNonQuery();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oListaUsuario.Add(new Tickets()
                        {
                            idTicket = Convert.ToInt32(dr["idTicket"]),
                            identificacion = dr["identificacion"].ToString(),
                            nombre = dr["nombre"].ToString(),
                            fechaIngreso = dr["fechaIngreso"].ToString(),
                            detalle = dr["detalle"].ToString(),
                            estadoTicket = dr["estadoTicket"].ToString(),
                            tipoTicket = dr["tipoTicket"].ToString(),
                            fechaCierre = dr["fechaCierre"].ToString(),
                            rol = dr["rol"].ToString()
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

        //Solicitud para obtener el reporte de certificados vendidos
        public static int ListarCertificadosVendidos(DateTime tiempo)
        {
            int contador = 0;
            Conexion con = new Conexion();
            List<CertificadoVendido> oListaUsuario = new List<CertificadoVendido>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("consulta.CertificadosVendidos", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", tiempo);
                //cmd.Parameters.AddWithValue("@mes", mes);
                //cmd.Parameters.AddWithValue("@dia", dia);
                //Console.WriteLine(cmd.CommandText.ToString());

                //try
                //{
                oConexion.Open();
                //cmd.ExecuteNonQuery();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        contador++;
                        oListaUsuario.Add(new CertificadoVendido()
                        {
                            idPago = Convert.ToInt32(dr["idPago"]),
                            numeroFactura = dr["numeroFactura"].ToString(),
                            fecha = dr["fecha"].ToString()
                        });
                    }

                }
                return contador;
                //oConexion.Close();
                //}
                //catch (Exception ex)
                //{
                //  return oListaUsuario;
                //}

            }

        }

        //consultar sin fotos
        public static List<ConsultaSinFotos> ListarConsultaSinFotos()
        {
            Conexion con = new Conexion();
            List<ConsultaSinFotos> oListaUsuario = new List<ConsultaSinFotos>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("consulta.tablaSinFotos", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                //try
                //{
                oConexion.Open();
                //cmd.ExecuteNonQuery();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oListaUsuario.Add(new ConsultaSinFotos()
                        {
                            /*IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            DocumentoIdentidad = dr["DocumentoIdentidad"].ToString(),
                            Nombres = dr["Nombres"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            Ciudad = dr["Ciudad"].ToString(),
                            FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])*/

                            ci = dr["ci"].ToString(),
                            nombre = dr["nombre"].ToString(),
                            segundoNombre = dr["segundoNombre"].ToString(),
                            apellido = dr["apellido"].ToString(),
                            segundoApellido = dr["segundoApellido"].ToString(),
                            numeroSolicitud = dr["numeroSolicitud"].ToString(),
                            fechaEmision = dr["fechaEmision"].ToString(),
                            fechaVencimiento = dr["fechaVencimiento"].ToString(),
                            correo = dr["correo"].ToString(),
                            celular = dr["celular"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            ciudad = dr["ciudad"].ToString(),
                            sector = dr["sector"].ToString(),
                            direccionPersonal= dr["direccionPersonal"].ToString(),
                            direccionOficina = dr["direccionOficina"].ToString(),
                            ip = dr["ip"].ToString(),
                            idSolicitudCertificado = Convert.ToInt32(dr["idSolicitudCertificado"]),
                            actividadEconomica = dr["actividadEconomica"].ToString(),
                            ruc = dr["ruc"].ToString()
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
