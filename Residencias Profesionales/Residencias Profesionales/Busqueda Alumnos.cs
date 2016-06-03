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
    public partial class Datos_Alumnos : Form
    {
        public Datos_Alumnos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Documentos asd = new Documentos(dataGridView1[0,e.RowIndex].Value.ToString());
            Documentos asd = new Documentos("ASD");
            this.Hide();
            asd.ShowDialog();
            this.Show();
            textBox1.Clear();
        }
    }
}
