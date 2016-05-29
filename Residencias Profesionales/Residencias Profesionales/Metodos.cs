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

     public bool insertarAlumno(string matricula,string nombre, string app, string apm, string tel, string correo, string carrera, string sexo)
        {
            try
            {
          //@matricula varchar(10),@nombre varchar(30),@apP varchar(30),@apM varchar(30),@telefono varchar(13),@correo varchar(100),@cve_carrera varchar(15),@sexo char(1)
                SqlCommand cmd = new SqlCommand("exec sp_insertarAlumnos '"+matricula+"','"+nombre+"','"+app+"','"+apm+"','"+tel+"','"+correo+"','"+carrera+"','"+sexo+"'", Conectar());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                Desconcetar();
            }
        }
                
        public bool insertaeAsesor(string cve, string nombre, string app, string apm,  string correo, string tel, string carrera)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand("Exec sp_insertarAsesores '"+cve+"','"+nombre+"','"+app+"','"+apm+"','"+correo+"','"+tel+"','"+carrera+"'", Conectar());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                Desconcetar();
            }
        }


        public bool insertarUsuario(string user,string pass, string cargo,string cve)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Exec sp_InsertarUsuario '" + user + "','" + Seguridad.encriptar( pass) + "','" + cargo + "','" + cve + "'", Conectar());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                Desconcetar();
            }
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
