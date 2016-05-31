using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

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
        public void Desconcetar()
        {
                conexion.Close();
        }


        public bool login(string user, string pass)
        {
            try
            {
                SqlDataReader read = null;
                SqlCommand cmd = new SqlCommand("exec sp_Acceso '" + user + "','" + pass + "'", Conectar());
                read = cmd.ExecuteReader();
                read.Read();

                if (read["Nombre"].ToString() == user && read["Contraseña"].ToString() == pass)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;                
            }
            
        }

        public void insertarAlumno(string matricula,string nombre, string app, string apm, string tel, string correo, string carrera, string sexo)
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
                if(msj=="0")
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
                
        public void insertaeAsesor(string cve, string nombre, string app, string apm,  string correo, string tel, string carrera)
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
            SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 100);
            msj.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(msj);
            cmd.ExecuteNonQuery();
            string info = cmd.Parameters["@msj"].Value.ToString();
            MessageBox.Show(info);

        }

        public void insertarCarrera(string cve, string nombre)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarCarreras", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cve", cve));
            cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
            SqlParameter msj = new SqlParameter("@msj", SqlDbType.VarChar, 50);
            msj.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(msj);
            cmd.ExecuteNonQuery();
            string info = cmd.Parameters["@msj"].Value.ToString();            
            MessageBox.Show(info);
        }

        public void insertarUsuario(string user, string pass, string cargo, string cve)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarUsuario",Conectar());
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
    }
}
