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
    public partial class Actualizar_Alumnos : Form
    {
        //instanciamos un objeto global de la clase metodos
        Metodos obj = new Metodos();
        //private string Mat;

        //le asignamos parametrso al form para despues cargarlos en los diferentes contenedores de texto
        public Actualizar_Alumnos(string matricula,string nom,string ApPaterno,string ApMaterno,string tele,string correo,string CveCarrera,string sexo)
        {
            InitializeComponent();
            txt_matricula.Text = matricula;
            txt_nombre.Text = nom;
            txt_apP.Text = ApPaterno;
            txt_apM.Text = ApMaterno;
            txt_telefono.Text = tele;
            txt_correo.Text = correo;
            ttpActualizar.SetToolTip(button1, "Actualizar Datos");
            
            obj.combos(cmb_carrera, "exec comboCarrera", "carreras", "nombre", "cve");
            if (Login.cargo == "Coordinador")
            {
                cmb_carrera.SelectedValue = Login.Carrera;
                cmb_carrera.Enabled = false;
            }
            //cmb_carrera.Text = CveCarrera;

            if(sexo=="M")
            { rb_M.Checked = true; }
            else { rb_F.Checked = true; }

        }
        string x;

        //en el evento clic revisamos que todo en los contenedores este de la forma correcta para poder seguir
        //si no es asi no podemos avanzar
        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_F.Checked)
            { x = "F"; }
            else
            { x = "M"; }           
            if (string.IsNullOrWhiteSpace(txt_matricula.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_correo.Text) || string.IsNullOrWhiteSpace(txt_apP.Text) || string.IsNullOrWhiteSpace(txt_apM.Text)||string.IsNullOrWhiteSpace(cmb_carrera.Text))
            {
                MessageBox.Show("Campos Vacios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (obj.ValidaCorreo(txt_correo.Text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*") == true)
                {
                    if (MessageBox.Show("¿Desea relizar la actualización?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        obj.Actualizar_Alumnos(txt_matricula.Text, txt_nombre.Text, txt_apP.Text, txt_apM.Text, txt_telefono.Text, txt_correo.Text, cmb_carrera.SelectedValue.ToString(), x);
                    }
                }
            }

        }
        //en el evento keypress verificamos que solo se puedan escribir letras en las cajas de texto
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
