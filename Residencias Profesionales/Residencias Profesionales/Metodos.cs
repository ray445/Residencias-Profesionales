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

                conexion = new SqlConnection(cadena);
                conexion.Open();
                return conexion;
        }
        //metodo para cerrar conexion
        public void Desconcetar()
        {
                conexion.Close();
        }
    }
}
