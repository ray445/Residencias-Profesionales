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
    public partial class CargaAlumnos : Form
    {
        string sexo="F";
        Metodos CA = new Metodos();
        public CargaAlumnos()
        {
            InitializeComponent();
            ttpAgregar.SetToolTip(button1, "Agregar Alumno");
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_matricula.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_correo.Text) || string.IsNullOrWhiteSpace(txt_apP.Text) || string.IsNullOrWhiteSpace(txt_apM.Text))
            {
                MessageBox.Show("Campos Vacios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (CA.ValidaCorreo(txt_correo.Text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*") == true)
                {
                    if (MessageBox.Show("¿Desea relizar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CA.insertarAlumno(txt_matricula.Text, txt_nombre.Text, txt_apP.Text, txt_apM.Text, txt_telefono.Text, txt_correo.Text, comboBox1.SelectedValue.ToString(), sexo);
                        txt_matricula.Clear(); txt_nombre.Clear(); txt_apP.Clear(); txt_apM.Clear(); txt_telefono.Clear(); txt_correo.Clear();
                    }
                }
            }                        
        }

        private void rb_F_CheckedChanged(object sender, EventArgs e)
        {   
            if(rb_F.Checked)
                sexo = "F";
        }

        private void rb_M_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_M.Checked)
                sexo = "M";
        }

        private void CargaAlumnos_Load(object sender, EventArgs e)
        {            
            CA.combos(comboBox1, "exec comboCarrera", "carreras", "nombre", "cve");
            if (Login.cargo == "Coordinador")
            {
                comboBox1.SelectedValue = Login.Carrera;
                comboBox1.Enabled = false;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_apP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_apM_KeyPress(object sender, KeyPressEventArgs e)
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
