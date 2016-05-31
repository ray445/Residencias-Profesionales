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
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea relizar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                CA.insertarAlumno(txt_matricula.Text, txt_nombre.Text, txt_apP.Text, txt_apM.Text, txt_telefono.Text, txt_correo.Text, comboBox1.SelectedValue.ToString(), sexo);

                    //MessageBox.Show("Datos Agregados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_matricula.Clear(); txt_nombre.Clear(); txt_apP.Clear(); txt_apM.Clear(); txt_telefono.Clear(); txt_correo.Clear();

                //else
                  //  MessageBox.Show("Error al Agregar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
