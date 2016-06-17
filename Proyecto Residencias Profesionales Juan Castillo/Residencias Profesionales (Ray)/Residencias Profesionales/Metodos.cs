using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Residencias_Profesionales
{
    class Metodos
    {
        private string cadena = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        SqlConnection conexion;

        //metodo para abrir conexion
        private SqlConnection Conectar()
        {
            try
            {
                conexion = new SqlConnection(cadena);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        //metodo para cerrar conexion
        private void Desconcetar()
        {
            conexion.Close();
        }

        //metodo para permitir el acceso al programa,ademas permite obtener la carrera del usuario asi como su cargo
        public string login(string user, string pass)
        {
            string cargo = string.Empty;
            try
            {
                // 
                SqlDataReader read = null;
                SqlCommand cmd = new SqlCommand("exec sp_Acceso '" + user + "','" + Seguridad.encriptar(pass) + "'", Conectar());
                read = cmd.ExecuteReader();
                read.Read();

                if (read["Nombre"].ToString() == user && read["Contraseña"].ToString() == Seguridad.encriptar(pass))
                {
                    Login.Carrera = read["Carrera"].ToString();
                    cargo = read["Cargo"].ToString(); return cargo;
                }
                else
                    return cargo;
            }
            catch (Exception)
            {
                return cargo;
            }

        }

        //metodo implementado para realizar el registro de los alumnos al sistema
        public void insertarAlumno(string matricula, string nombre, string app, string apm, string tel, string correo, string carrera, string sexo)
        {
            try
            {
                string msj;
                //@matricula varchar(10),@nombre varchar(30),@apP varchar(30),@apM varchar(30),@telefono varchar(13),@correo varchar(100),@cve_carrera varchar(15),@sexo char(1)
                SqlCommand cmd = new SqlCommand("exec sp_insertarAlumnos '" + matricula + "','" + nombre + "','" + app + "','" + apm + "','" + tel + "','" + correo + "','" + carrera + "','" + sexo + "'", Conectar());
                msj = cmd.ExecuteNonQuery().ToString();
                if (msj == "1")
                {
                    MessageBox.Show("Datos Agregados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (msj == "0")
                {
                    MessageBox.Show("Error al Agregar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    return false;
            //}
            finally
            {
                Desconcetar();
            }
        }

        //Este metodo permite registrar nuevos asesores en el sistema
        public void insertaeAsesor(string cve, string nombre, string app, string apm, string correo, string tel, string carrera, string titulo)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarAsesores", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cveAsesor", cve));
            cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
            cmd.Parameters.Add(new SqlParameter("@apPaterno", app));
            cmd.Parameters.Add(new SqlParameter("@apMaterno", apm));
            cmd.Parameters.Add(new SqlParameter("@correo", correo));
            cmd.Parameters.Add(new SqlParameter("@telefono", tel));
            cmd.Parameters.Add(new SqlParameter("@cve_carrera", carrera));
            cmd.Parameters.Add(new SqlParameter("@titulo", titulo));
            SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 100);
            msj.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(msj);
            cmd.ExecuteNonQuery();
            string info = cmd.Parameters["@msj"].Value.ToString();
            MessageBox.Show(info);

        }

        //metodo utilizado para registrar nuevas carreras en el sistema(muy poco utilizado)
        public void insertarCarrera(string cve, string nombre, string jefe)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarCarreras", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cve", cve));
            cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
            cmd.Parameters.Add(new SqlParameter("@jefe", jefe));
            SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 50);
            msj.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(msj);
            cmd.ExecuteNonQuery();
            string info = cmd.Parameters["@msj"].Value.ToString();
            MessageBox.Show(info, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Se utiliza para registrar nuevos usuarios al sistema (solo utilizado por administradores)
        public void insertarUsuario(string user, string pass, string cargo, string cve)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@NombreUser", user));
            cmd.Parameters.Add(new SqlParameter("@Contraseña", pass));
            cmd.Parameters.Add(new SqlParameter("@Cargo", cargo));
            cmd.Parameters.Add(new SqlParameter("@cveAsesor", cve));
            SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 50);
            msj.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(msj);
            cmd.ExecuteNonQuery();
            string info = cmd.Parameters["@msj"].Value.ToString();
            MessageBox.Show(info);

        }

        //metodo que permite registrar nuevos proyectos de residencias en base a los alumnos registrados en el sistema
        public void insertarProyecto(string matricula, string nombre, string emp, string asesor, string revisor1,
            string revisor2, string periodo, string inicio, string fin, string fecha1, string fecha2, string fecha3)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarProyecto", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@matriculaAlumno", matricula));
                cmd.Parameters.Add(new SqlParameter("@nombreProyecto", nombre));
                cmd.Parameters.Add(new SqlParameter("@nombreEmpresa", emp));
                cmd.Parameters.Add(new SqlParameter("@cveAsesor", asesor));
                cmd.Parameters.Add(new SqlParameter("@cveRevisor1", revisor1));
                cmd.Parameters.Add(new SqlParameter("@cveRevisor2", revisor2));
                cmd.Parameters.Add(new SqlParameter("@periodo", periodo));
                cmd.Parameters.Add(new SqlParameter("@inicio", inicio));
                cmd.Parameters.Add(new SqlParameter("@fin", fin));
                cmd.Parameters.Add(new SqlParameter("@fecha1", fecha1));
                cmd.Parameters.Add(new SqlParameter("@fecha2", fecha2));
                cmd.Parameters.Add(new SqlParameter("@fecha3", fecha3));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos agregados con exito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operacion fallida" + ex, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconcetar();
            }
        }

        //metodo usado para capturar la calificacion final del proyecto
        public void CapturarCalificacion(string matricula, int calificacion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateCalifproyecto", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@calificacion", calificacion));
                cmd.Parameters.Add(new SqlParameter("@matricula", matricula));
                SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                msj.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(msj);
                cmd.ExecuteNonQuery();
                string info = cmd.Parameters["@msj"].Value.ToString();
                MessageBox.Show(info);
            }
            catch
            {

            }
            finally { Desconcetar(); }
        }

        /// <summary>
        /// Metodo para llenar los distintos combobox del sistema
        /// </summary>
        /// <param name="cb">Combobox que se llenara </param>
        /// <param name="cmd">Consulta sql a ejecutar</param>
        /// <param name="tabla">tabla de la bd que contiene los datos a usar en el cb</param>
        /// <param name="dsm">lo que se vusualiza en el combo</param>
        /// <param name="vm">el valor real de los items del combo</param>
        public void combos(ComboBox cb, string cmd, string tabla, string dsm, string vm)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd, Conectar());
                da.Fill(ds, tabla);
                cb.DataSource = ds.Tables[0].DefaultView;
                cb.DisplayMember = dsm;
                cb.ValueMember = vm;
            }
            catch (Exception ex)
            {

            }
        }

        //metodo para cargar la informacion del control datagrid en la ventana de Asesores, ademas permite ralizar busqueda por nombre y clave de asesor
        public DataSet buscarAsesor(string clave, string nombre, string carrera, string cargo)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Exec sp_BuscarAsesor '" + clave + "','" + nombre + "','" + carrera + "','" + cargo + "'", Conectar());
                DataSet ds = new DataSet();
                da.Fill(ds);
                Desconcetar();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //permite cargar la informacion del control datagrid en la ventana de busquedaAlumnos, ademas permite ralizar busqueda por nombre y matricula
        public DataSet Buscar_alumnos(string matricula, string nombre, string carrera, string cargo)
        {
            try
            {
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter("exec sp_BuscarAlumno '" + matricula + "','" + nombre + "','" + carrera + "','"+cargo+"'", Conectar());
                //SqlDataAdapter da1 = new SqlDataAdapter("exec sp_BuscarAlumno '" + matricula + "','" + nombre + "','" + carrera + "'", Conectar());
                da1.Fill(ds1, "Alumnos");
                return ds1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return null;
            }
            finally
            {
                Desconcetar();
            }
        }

        //metodo para cargar la informacion en el control datagrid de la ventana Control de Documentos, ademas de implementar busqueda por nombre y matricula del alumno
        public DataSet documentos(string nombre, string matricula, string carrera)
        {
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter("Exec sp_Documentos", Conectar());
                SqlDataAdapter da = new SqlDataAdapter("Exec sp_busquedaDocumentos '" + nombre + "','" + matricula + "','" + carrera + "'", Conectar());
                DataSet ds = new DataSet();
                da.Fill(ds);
                Desconcetar();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //este metodo permite actualizar la informacion de un registro de documentos asignado a cada proyecto
        public void actualizarDocs(string matricula, bool sr, bool ap, bool cp, bool d,
            bool aae, bool aai, bool s, bool ra, bool ct, bool srev, bool ar1, bool ar2, bool fe,
            bool ca, bool re, bool i, bool cac)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarDocumentos", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@matricula", matricula));
            cmd.Parameters.Add(new SqlParameter("@SolicitudResidencia", sr));
            cmd.Parameters.Add(new SqlParameter("@AnteProyecto", ap));
            cmd.Parameters.Add(new SqlParameter("@CartaPresentacion", cp));
            cmd.Parameters.Add(new SqlParameter("@Dictamen", d));
            cmd.Parameters.Add(new SqlParameter("@AsignacionExterno", aae));
            cmd.Parameters.Add(new SqlParameter("@AsignacionInterno", aai));
            cmd.Parameters.Add(new SqlParameter("@Seguimiento", s));
            cmd.Parameters.Add(new SqlParameter("@RegistrosAsesoria", ra));
            cmd.Parameters.Add(new SqlParameter("@CartaTerminacion", ct));
            cmd.Parameters.Add(new SqlParameter("@SolicitudRevisor", srev));
            cmd.Parameters.Add(new SqlParameter("@AsignacionRevisor1", ar1));
            cmd.Parameters.Add(new SqlParameter("@AsignacionRevisor2", ar2));
            cmd.Parameters.Add(new SqlParameter("@FormatoEvaluacion", fe));
            cmd.Parameters.Add(new SqlParameter("@CartaAgadecimiento", ca));
            cmd.Parameters.Add(new SqlParameter("@ResumenEjecutivo", re));
            cmd.Parameters.Add(new SqlParameter("@Informe", i));
            cmd.Parameters.Add(new SqlParameter("@CartaAceptacion", ca));
            SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 100);
            msj.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(msj);
            cmd.ExecuteNonQuery();
            string info = cmd.Parameters["@msj"].Value.ToString();
            //MessageBox.Show(info);
        }
        //permite actualizar la informacion registraada de cada alumno previamente registrado
        public void Actualizar_Alumnos(string matricula, string nom, string ApPaterno, string ApMaterno, string tele, string correo, string CveCarrera, string sexo)
        {
            SqlCommand cmd = new SqlCommand("sp_modificarAlumnos", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@matricula", matricula));
            cmd.Parameters.Add(new SqlParameter("@nombre", nom));
            cmd.Parameters.Add(new SqlParameter("@apPaterno", ApPaterno));
            cmd.Parameters.Add(new SqlParameter("@apMaterno", ApMaterno));
            cmd.Parameters.Add(new SqlParameter("@telefono", tele));
            cmd.Parameters.Add(new SqlParameter("@correo", correo));
            cmd.Parameters.Add(new SqlParameter("@cve_carrera", CveCarrera));
            cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
            SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 50);
            msj.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(msj);
            cmd.ExecuteNonQuery();
            string info = cmd.Parameters["@msj"].Value.ToString();
            MessageBox.Show(info);
        }

        //metodo implementado para llenar la informacion del control datagrid de la ventana proyectos, permitiendo ademas implementar una busqueda por nombre de alumno, o por nombre del proyecto
        public DataSet Buscar_Proyecto(string nombreA, string nombreP, string carrera)
        {
            try
            {
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter("exec sp_Busqueda_Proyecto '" + nombreA + "','" + nombreP + "','" + carrera + "'", Conectar());
                da1.Fill(ds1, "Proyectos");
                return ds1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return null;
            }
            finally
            {
                Desconcetar();
            }
        }

        //metodo que permite actualizar los datos de un proyecto previamente registrado en el sistema
        public void ActualizarProyecto(string matricula, string nombreP, string nombreE, string claveA,
            string claveR1, string claveR2, string periodo, string inicio, string fin, string fecha1, string fecha2, string fecha3)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarProyecto", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@matriculaAlumno", matricula));
                cmd.Parameters.Add(new SqlParameter("@nombreProyecto", nombreP));
                cmd.Parameters.Add(new SqlParameter("@nombreEmpresa", nombreE));
                cmd.Parameters.Add(new SqlParameter("@cveAsesor", claveA));
                cmd.Parameters.Add(new SqlParameter("@cveRevisor1", claveR1));
                cmd.Parameters.Add(new SqlParameter("@cveRevisor2", claveR2));
                cmd.Parameters.Add(new SqlParameter("@periodo", periodo));
                cmd.Parameters.Add(new SqlParameter("@inicio", inicio));
                cmd.Parameters.Add(new SqlParameter("@fin", fin));
                cmd.Parameters.Add(new SqlParameter("@fecha1", fecha1));
                cmd.Parameters.Add(new SqlParameter("@fecha2", fecha2));
                cmd.Parameters.Add(new SqlParameter("@fecha3", fecha3));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizacion exitosa", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Actualizacion erronea", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {

            }
        }
        //metodo utilizado para eliminar un proyecto del sistema
        public void EliminarProyecto(string matricula)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarProyecto", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@matricula", matricula));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proyecto Eliminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al eliminar el proyecto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { Desconcetar(); }

        }

        //metodo que se utiliza para validar que los correos tengan el formato correcto
        public bool ValidaCorreo(string texto, string patron)
        {
            Regex reg = new Regex(patron, RegexOptions.Compiled);
            if (reg.IsMatch(Convert.ToString(texto)) != true)
            {
                MessageBox.Show("Correo Invalido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        //metodo para eliminar un alumno de la base de datos 
        public void EliminarAlumno(string matricula)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarAlumno", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@matricula", matricula));
                SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                msj.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(msj);
                cmd.ExecuteNonQuery();
                string info = cmd.Parameters["@msj"].Value.ToString();
                MessageBox.Show(info, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al eliminar el proyecto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { Desconcetar(); }
        }

        //Metodo para realizar cambios sobre un asesor elegido 
        public void ActualizarAsesor(string cve, string nombre, string app, string apm, string correo, string tel, string carrera, string titulo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarAsesor", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cveAsesor", cve));
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@apPaterno", app));
                cmd.Parameters.Add(new SqlParameter("@apMaterno", apm));
                cmd.Parameters.Add(new SqlParameter("@correo", correo));
                cmd.Parameters.Add(new SqlParameter("@telefono", tel));
                cmd.Parameters.Add(new SqlParameter("@cve_carrera", carrera));
                cmd.Parameters.Add(new SqlParameter("@titulo", titulo));
                SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                msj.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(msj);
                cmd.ExecuteNonQuery();
                string info = cmd.Parameters["@msj"].Value.ToString();
                MessageBox.Show(info, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            { }
            finally
            { Desconcetar(); }

        }

        public void contador(Label c1,/* Label c2, Label c3,*/ string cve,bool rev)
        {
            try
            {
                SqlDataReader read = null;
                SqlCommand cmd = new SqlCommand("exec conteo '" + cve + "'" , Conectar());
                read = cmd.ExecuteReader();
                read.Read();
                if (rev)
                {
                    c1.Text = read["c2"].ToString();
                }
                else
                {
                    c1.Text = read["c1"].ToString();
                }
                
                
            }
            catch (Exception )
            {
                
            }
        }

        SmtpClient server = new SmtpClient("smtp.gmail.com", 587);
        private bool correo(string correo, string pass)
        {
            /*
             * Autenticacion en el Servidor
             * Utilizaremos nuestra cuenta de correo
             *
             * Direccion de Correo (Gmail o Hotmail)
             * y Contrasena correspondiente
             */
            server.Credentials = new System.Net.NetworkCredential(correo, pass);
            server.EnableSsl = true;
            return true;
        }
        private void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }

        //parametros:
        //correo,fecha,...y no se que mas...
        public void escribirCorreo(string correoR2, string correoR1, string fecha,string nombre)
        {
            DateTime f;
            f= Convert.ToDateTime(fecha);
            
            MailMessage mnsj = new MailMessage();
            try
            {
                correo("ray.hdz445@gmail.com", "patoganzo");

                mnsj.Subject = "Notificacion de Revision";                

                mnsj.To.Add(new MailAddress(correoR1));
                mnsj.To.Add(new MailAddress(correoR2));


                //mnsj.From = new MailAddress("desde donde se envia", "Departamento de Residensias del Instituto Tecnologico Superior de San Pedro");
                mnsj.From = new MailAddress("ray.hdz445@gmail.com", "Departamento de Residensias del Instituto Tecnologico Superior de San Pedro");

                mnsj.Body = "Se le notifica que el priximo "+f.ToShortDateString()+" tendra revision de proyecto de residencias del alumno "+nombre;

                MandarCorreo(mnsj);
                //MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //metodo para buscar una carrera 
        public DataSet BuscarCarrera(string nombre, string clave)
        {
            try
            {
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter("exec sp_BuscarCarrera '" + nombre + "','"+ clave + "'", Conectar());
                da1.Fill(ds1, "Carreras");
                return ds1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return null;
            }
            finally
            {
                Desconcetar();
            }
        }

        //metodo para eliminar el asesor seleccionado en el datagrid
        public void EliminarAsesor(string Clave)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarAsesor", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@clave", Clave));
                SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                msj.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(msj);
                cmd.ExecuteNonQuery();
                string info = cmd.Parameters["@msj"].Value.ToString();
                MessageBox.Show(info, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al eliminar el Asesor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { Desconcetar(); }
        }

        //metodo que actualiza una carrera seleccionada
        public void ActualizarCarrera(string clave, string nombre, string jefe)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarCarrera", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@clave", clave));
            cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
            cmd.Parameters.Add(new SqlParameter("@jefe", jefe));
            SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 50);
            msj.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(msj);
            cmd.ExecuteNonQuery();
            string info = cmd.Parameters["@msj"].Value.ToString();
            MessageBox.Show(info, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public DataSet mostrarNotificados()
        {
            try
            {
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter("exec infoCorreo", Conectar());
                da1.Fill(ds1);
                return ds1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return null;
            }
            finally
            {
                Desconcetar();
            }

        }

        public void consultarinfo(List<infoCorreo> asd,int folio)
        {
            try
            {
                SqlDataReader read = null;
                SqlCommand cmd = new SqlCommand("exec  datosmail '" + folio + "'", Conectar());
                read = cmd.ExecuteReader();
                read.Read();

                infoCorreo m = new infoCorreo();
                m.nombre = read["Nombre"].ToString();
                m.fecha = read["Fecha"].ToString();
                m.correo = read["correoR1"].ToString();
                m.correo2 = read["correor2"].ToString();
                asd.Add(m);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
