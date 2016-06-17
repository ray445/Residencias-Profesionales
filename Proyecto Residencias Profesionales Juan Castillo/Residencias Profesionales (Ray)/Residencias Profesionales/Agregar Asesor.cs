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
    public partial class Agregar_Asesor : Form
    {
        Metodos AA = new Metodos();
        public Agregar_Asesor()
        {
            InitializeComponent();
            ttpAgregar.SetToolTip(button1, "Agregar Asesor");
        }

        private void Agregar_Asesor_Load(object sender, EventArgs e)
        {
            AA.combos(cbxCveCarrera, "exec comboCarrera", "carreras", "nombre", "cve");
            if (Login.cargo == "Coordinador")
            {
                cbxCveCarrera.SelectedValue = Login.Carrera;
                cbxCveCarrera.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCveAsesor.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtapPaterno.Text) || string.IsNullOrWhiteSpace(txtapMaterno.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text)||string.IsNullOrWhiteSpace(txtTitulo.Text)||string.IsNullOrWhiteSpace(cbxCveCarrera.Text))/*&& string.IsNullOrWhiteSpace(mstxTelefono.Text)*/
            {
                MessageBox.Show("Campos vacios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (AA.ValidaCorreo(txtCorreo.Text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")==true)
                {
                    if (MessageBox.Show("¿Desea relizar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AA.insertaeAsesor(txtCveAsesor.Text, txtNombre.Text, txtapPaterno.Text, txtapMaterno.Text, txtCorreo.Text, mstxTelefono.Text, cbxCveCarrera.SelectedValue.ToString(),txtTitulo.Text);
                        // MessageBox.Show("Datos Agregados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)&&(e.KeyChar!=(char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
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
