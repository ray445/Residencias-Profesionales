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
    public partial class Captura_de_Calificacion : Form
    {
        Metodos CC = new Metodos();
        private string mat;
        public Captura_de_Calificacion(string matricula, string calificacion, string proyecto)
        {
            InitializeComponent();
            mat = matricula;
            txt_nombreP.Text = proyecto;
            ttpAgregar.SetToolTip(button1, "Agregar Calificacion");
            if(string.IsNullOrWhiteSpace(calificacion)==false)
                txtCali.Value = Convert.ToDecimal(calificacion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CC.CapturarCalificacion(mat,Convert.ToInt32( txtCali.Text));
        }

        private void Captura_de_Calificacion_Load(object sender, EventArgs e)
        {
            //CC.combos(comboBox1, "Exec comboProyectos", "Proyectos", "proyecto", "folio"); 
        }

        private void txtCali_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
