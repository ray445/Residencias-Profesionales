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
    public partial class Proyectos : Form
    {
        private string matricula, empresa, nombrep, revisor1, asesor, revisor2, alumno, periodo, inicio, fin, rev1, rev2, rev3,calif;

        private void button4_Click(object sender, EventArgs e)
        {
            Pruebacorreo pc = new Pruebacorreo();
            Hide();
            pc.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                this.Hide();
                Docs VD = new Docs(matricula);
                VD.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existen proyectos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                string mat = matricula;
                if (MessageBox.Show("¿Esta seguro de eliminar el siguiente proyecto: " + matricula + "?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Metodos el = new Metodos();
                    el.EliminarProyecto(mat);
                }
            }
            else
            {
                MessageBox.Show("No existen proyectos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                Actualizar_Proyecto ap = new Actualizar_Proyecto(matricula, empresa, nombrep, revisor1, asesor, revisor2, alumno, periodo, inicio, fin, rev1, rev2, rev3);
                this.Hide();
                ap.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existen proyectos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Proyectos()
        {
            InitializeComponent();
            ttpActualizar.SetToolTip(button2, "Actualizar Proyecto Seleccionado");
            ttpEliminar.SetToolTip(button3, "Eliminar Proyecto Seleccionado");
            ttpImprimir.SetToolTip(button1, "Generar Documentos del Proyecto Seleccionado");
            ttpCalificaion.SetToolTip(button5, "Capturar Calificacion del Proyecto Seleccionado");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                Captura_de_Calificacion asd = new Captura_de_Calificacion(matricula, calif, nombrep);
                this.Hide();
                asd.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existen proyectos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Metodos obj = new Metodos();
            DataSet ds;
            if (rdb_alumno.Checked == true)
            {
                ds = obj.Buscar_Proyecto(textBox1.Text, "",Login.Carrera);
                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            if (rdb_proyecto.Checked == true)
            {
                ds = obj.Buscar_Proyecto("", textBox1.Text, Login.Carrera);
                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void Proyectos_Activated(object sender, EventArgs e)
        {
            Metodos obj = new Metodos();
            DataSet ds;
            ds = obj.Buscar_Proyecto("", "", Login.Carrera);
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            matricula = dataGridView1[0, e.RowIndex].Value.ToString();
            alumno = dataGridView1[1, e.RowIndex].Value.ToString();
            nombrep = dataGridView1[2, e.RowIndex].Value.ToString();
            empresa= dataGridView1[3, e.RowIndex].Value.ToString();
            calif = dataGridView1[4, e.RowIndex].Value.ToString();
            asesor = dataGridView1[5, e.RowIndex].Value.ToString();
            revisor1= dataGridView1[6, e.RowIndex].Value.ToString();
            revisor2= dataGridView1[7, e.RowIndex].Value.ToString();
            periodo= dataGridView1[8, e.RowIndex].Value.ToString();
            inicio= dataGridView1[9, e.RowIndex].Value.ToString();
            fin= dataGridView1[10, e.RowIndex].Value.ToString();
            rev1= dataGridView1[11, e.RowIndex].Value.ToString();
            rev2= dataGridView1[12, e.RowIndex].Value.ToString();
            rev3= dataGridView1[13, e.RowIndex].Value.ToString();
        }
    }
}
