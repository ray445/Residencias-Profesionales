using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residencias_Profesionales
{
    public partial class Modificar_Datos_de_Asesor : Form
    {//
        Metodos ma = new Metodos();
        public Modificar_Datos_de_Asesor(string clave, string nombre, string app, string apm, string correo, string telefono, string carrera)
        {
            InitializeComponent();
            txtapMaterno.Text = apm;
            txtapPaterno.Text = app;
            txtCorreo.Text = correo;
            txtCveAsesor.Text = clave;
            txtNombre.Text = nombre;
            mstxTelefono.Text = telefono;
            cbxCveCarrera.Text = carrera;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ma.modificarAsesor(txtCveAsesor.Text, txtNombre.Text, txtapPaterno.Text, txtapMaterno.Text, txtCorreo.Text, mstxTelefono.Text, cbxCveCarrera.SelectedValue.ToString());  
        }

        private void Modificar_Datos_de_Asesor_Load(object sender, EventArgs e)
        {
            ma.combos(cbxCveCarrera, "exec comboCarrera", "carreras", "nombre", "cve");
        }
    }
}
