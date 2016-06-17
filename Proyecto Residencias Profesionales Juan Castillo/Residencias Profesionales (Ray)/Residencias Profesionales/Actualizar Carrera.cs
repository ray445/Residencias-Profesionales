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
    public partial class Actualizar_Carrera : Form
    {
        //instanciamoos un objeto de la classe metodos
        Metodos UC = new Metodos();

        //sobrecargamos el metodo de atualizar carrera para poder recibir parametros y poder asignarlos 
        //a diferentes contenedores
        public Actualizar_Carrera(string cve, string nombre, string encargado)
        {
            InitializeComponent();
            txtCveCarrera.Text = cve;
            txtNombre.Text = nombre;
            txtJefe.Text = encargado;
            ttpActualizar.SetToolTip(btn_agregar, "Actualizar Datos");
        }

        //en el boton de agregar en el evento clic verificamos que no existan campos vacio y que no existan espacios en blanco
        //si todo esta en orden ejecutamos el metodo de actualizar carrera
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCveCarrera.Text)||string.IsNullOrWhiteSpace(txtNombre.Text)||string.IsNullOrWhiteSpace(txtJefe.Text))
            {
                MessageBox.Show("No pueden existir campos vacios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Desea realizar el registro?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                { UC.ActualizarCarrera(txtCveCarrera.Text, txtNombre.Text, txtJefe.Text); }
            }
        }
        //en el evento key press verificamos que no se puedan escribir nad ams que letras
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtJefe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
