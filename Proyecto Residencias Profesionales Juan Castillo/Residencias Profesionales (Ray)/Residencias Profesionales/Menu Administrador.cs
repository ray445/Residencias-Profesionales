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
            Buscar_Asesor asd = new Buscar_Asesor("a");
            this.Hide();
            asd.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos_Alumnos CA = new Datos_Alumnos("a");
            this.Hide();
            CA.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Carreras C = new Carreras();
            this.Hide();
            C.ShowDialog();
            this.Show();
        }
    }
}
