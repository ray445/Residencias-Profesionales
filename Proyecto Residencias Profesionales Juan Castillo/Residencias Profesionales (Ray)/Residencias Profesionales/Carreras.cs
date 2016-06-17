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
    public partial class Carreras : Form
    {
        string cve, nombre, encargado;
        public Carreras()
        {
            InitializeComponent();
            ttpActualizar.SetToolTip(BntBuscar, "Actualizar la carrera seleccionada");
            ttpAgregar.SetToolTip(button2, "Agregar nueva carrera");
        }

        private void Carreras_Activated(object sender, EventArgs e)
        {
            Metodos C = new Metodos();
            DataSet ds;
            ds = C.BuscarCarrera("", "");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Metodos C = new Metodos();
            DataSet ds;
            if (rdb_carrera.Checked==true)
            {
                ds = C.BuscarCarrera(textBox1.Text, "");
                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            if (rdb_cveCarrera.Checked == true)
            {
                ds = C.BuscarCarrera("", textBox1.Text);
                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar_Carrera AC = new Agregar_Carrera();
            Hide();
            AC.ShowDialog();
            Show();
        }

        private void BntBuscar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                Actualizar_Carrera AC = new Actualizar_Carrera(cve, nombre, encargado);
                Hide();
                AC.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("No existen registros", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cve = dataGridView1[0, e.RowIndex].Value.ToString();
            nombre= dataGridView1[1, e.RowIndex].Value.ToString();
            encargado= dataGridView1[2, e.RowIndex].Value.ToString();
        }
    }
}
