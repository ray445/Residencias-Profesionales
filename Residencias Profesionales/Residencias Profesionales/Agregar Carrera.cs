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
    public partial class Agregar_Carrera : Form
    {
        private Metodos AC = new Metodos();
        public Agregar_Carrera()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCveCarrera.Text)||string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Campos vacios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Desea relizar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AC.insertarCarrera(txtCveCarrera.Text, txtNombre.Text);
                }
                    //{
                //    MessageBox.Show("Datos Agregados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtCveCarrera.Clear();txtNombre.Clear();
                //}
                //else
                //    MessageBox.Show("Error al Agregar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
}
