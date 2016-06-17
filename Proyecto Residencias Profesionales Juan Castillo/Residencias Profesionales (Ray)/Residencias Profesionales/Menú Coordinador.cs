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
    public partial class Menú_Coordinador : Form
    {
        public Menú_Coordinador()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            Datos_Alumnos da = new Datos_Alumnos("c");
            this.Hide();
            da.ShowDialog();
            this.Show();
        }

        private void btnCoordinador_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar_Asesor ba = new Buscar_Asesor("c");
            this.Hide();
            ba.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
