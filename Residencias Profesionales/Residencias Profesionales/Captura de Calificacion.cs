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
        public Captura_de_Calificacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CC.CapturarCalificacion(Convert.ToInt32( comboBox1.SelectedValue),Convert.ToInt32( txtCali.Text));
            txtCali.Value=0;
            CC.combos(comboBox1, "Exec comboProyectos", "Proyectos", "proyecto", "folio");
        }

        private void Captura_de_Calificacion_Load(object sender, EventArgs e)
        {
            CC.combos(comboBox1, "Exec comboProyectos", "Proyectos", "proyecto", "folio"); 
        }
    }
}
