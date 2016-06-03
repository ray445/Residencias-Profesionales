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
            Agregar_Proyectos asd = new Agregar_Proyectos();
            this.Hide();
            asd.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Datos_Alumnos asd = new Datos_Alumnos();
            this.Hide();
            asd.ShowDialog();
            this.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Captura_de_Calificacion asd = new Captura_de_Calificacion();
            this.Hide();
            asd.ShowDialog();
            this.Show();
        }

        private void btnCoordinador_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_Asesor asd = new Agregar_Asesor();
            this.Hide();
            asd.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargaAlumnos asd = new CargaAlumnos();
            this.Hide();
            asd.ShowDialog();
            this.Show();
        }
    }
}
