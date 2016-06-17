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
    public partial class Buscar_Asesor : Form
    {
        Metodos BA = new Metodos();
        string clave, nombre, app, apm, correo, telefono, carrera, titulo, carg;
        

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cargar(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                string cve = clave;
                if (MessageBox.Show("¿Esta seguro de querer eliminar el asesor?","Sistema",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                {
                    BA.EliminarAsesor(cve);
                }
            }
            else
            {
                MessageBox.Show("No existen registros", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                Agregar_Asesor asd = new Agregar_Asesor();
                this.Hide();
                asd.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existen registros", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargar(DataGridViewCellEventArgs e)
        {
            clave = dataGridView1[0, e.RowIndex].Value.ToString();
            nombre = dataGridView1[1, e.RowIndex].Value.ToString();
            app = dataGridView1[2, e.RowIndex].Value.ToString();
            apm = dataGridView1[3, e.RowIndex].Value.ToString();
            correo = dataGridView1[4, e.RowIndex].Value.ToString();
            telefono = dataGridView1[5, e.RowIndex].Value.ToString();
            carrera = dataGridView1[6, e.RowIndex].Value.ToString();
            titulo = dataGridView1[7, e.RowIndex].Value.ToString();
        }


        public Buscar_Asesor(string cargo)
        {
            InitializeComponent();
            carg = cargo;
            ttpActualizar.SetToolTip(BntBuscar, "Actualizar Asesor Seleccionado");
            ttpAgregar.SetToolTip(button2, "Agregar un nuevo Asesor");
            ttpEliminar.SetToolTip(button1, "Eliminar Asesor Seleccionado");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds;
            if (radioButton1.Checked)
            {
                ds= BA.buscarAsesor(textBox1.Text, "",Login.Carrera,carg);
                if (ds != null)
                    dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton2.Checked)
            {
                ds = BA.buscarAsesor("", textBox1.Text,Login.Carrera,carg);
                if (ds != null)
                    dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Buscar_Asesor_Activated(object sender, EventArgs e)
        {
            DataSet ds=BA.buscarAsesor(textBox1.Text, "",Login.Carrera,carg);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntBuscar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                Modificar_Datos_de_Asesor MA = new Modificar_Datos_de_Asesor(clave, nombre, app, apm, correo, telefono, carrera, titulo);
                Hide();
                MA.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("No existen registros", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
