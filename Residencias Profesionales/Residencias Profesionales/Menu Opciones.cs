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
    public partial class Menu_Opciones : Form
    {
        
        public Menu_Opciones()
        {
            InitializeComponent();
        }

        private void Menu_Opciones_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCoordinador_Click(object sender, EventArgs e)
        {
            Agregar_Usuario au = new Agregar_Usuario();
            this.Hide();
            au.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_Asesor  asd = new Agregar_Asesor();
            this.Hide();
            asd.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargaAlumnos CA = new CargaAlumnos();
            this.Hide();
            CA.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregar_Carrera NC = new Agregar_Carrera();
            this.Hide();
            NC.ShowDialog();
            this.Show();
        }
    }
}
