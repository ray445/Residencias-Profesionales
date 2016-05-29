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
            Agregar_Usuario asd = new Agregar_Usuario();
            asd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_Asesor  asd = new Agregar_Asesor();
            asd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargaAlumnos CA = new CargaAlumnos();
            CA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregar_Carrera NC = new Agregar_Carrera();
            NC.ShowDialog();
        }
    }
}
