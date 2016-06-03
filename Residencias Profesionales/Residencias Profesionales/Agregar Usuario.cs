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
    public partial class Agregar_Usuario : Form
    {
        Metodos AU = new Metodos();
        public Agregar_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomUsuario.Text)||string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Campos Vacios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(cbxCveAsesor.SelectedValue.ToString());
                if(MessageBox.Show("¿Desea relizar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AU.insertarUsuario(txtNomUsuario.Text, Seguridad.encriptar( txtContraseña.Text), cbxCargo.Text, cbxCveAsesor.SelectedValue.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {
            cbxCargo.Text = "Administrador";
            AU.combos(cbxCveAsesor, "exec comboAsesores","Asesores", "nom", "cveAsesor");
        }
    }
}
