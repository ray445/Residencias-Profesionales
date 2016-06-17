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
        Metodos m = new Metodos();
        string matricula, nom, ApPaterno, ApMaterno, tele, correo, CveCarrera, sexo, carg;
        public Datos_Alumnos(string a)
        {
            InitializeComponent();
            carg = a;
            ttpAgregar.SetToolTip(button1, "Agregar Nuevo Alumno");
            ttpActualizar.SetToolTip(button2, "Actualizar Alumno Seleccionado");
            ttpEliminar.SetToolTip(button3, "Eliminar Alumno Seleccionado");
            ttpControl.SetToolTip(button4, "Mostrar Documentos Recibidos");
            ttpAgregarP.SetToolTip(button5, "Agregar Proyecto");
            ttpProyectos.SetToolTip(button6, "Mostrar Proyectos");
            if (a=="a")
            {
                button4.Enabled = false;button4.Visible = false;
                button5.Enabled = false; button5.Visible = false;
                button6.Enabled = false; button6.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            Metodos obj = new Metodos();
            DataSet ds;
            if (rdb_nombre.Checked==true)
            {
                ds= obj.Buscar_alumnos("", textBox1.Text, Login.Carrera,carg);
                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            if (rdb_matricula.Checked == true)
            {
                ds = obj.Buscar_alumnos(textBox1.Text, "", Login.Carrera,carg);
                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void Datos_Alumnos_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargaAlumnos asd = new CargaAlumnos();
            this.Hide();
            asd.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Agregar_Proyectos asd = new Agregar_Proyectos();
            this.Hide();
            asd.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Proyectos p = new Proyectos();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                Actualizar_Alumnos a = new Actualizar_Alumnos(matricula, nom, ApPaterno, ApMaterno, tele, correo, CveCarrera, sexo);
                this.Hide();
                a.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No existen registros", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                string mat = matricula;
                if (MessageBox.Show("¿Esta seguro que desea eliminar al alumno?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    m.EliminarAlumno(mat);
                }
            }
            else
            {
                MessageBox.Show("No existen registros", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Control_de_Documentos cd = new Control_de_Documentos();
            Hide();
            cd.ShowDialog();
            Show();
        }

        private void Datos_Alumnos_Activated(object sender, EventArgs e)
        {
            Metodos obj = new Metodos();
            DataSet ds;
            ds = obj.Buscar_alumnos("", "", Login.Carrera,carg);
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            matricula = dataGridView1[0, e.RowIndex].Value.ToString();
            nom = dataGridView1[1, e.RowIndex].Value.ToString();
            ApPaterno = dataGridView1[2, e.RowIndex].Value.ToString();
            ApMaterno = dataGridView1[3, e.RowIndex].Value.ToString();
            tele = dataGridView1[4, e.RowIndex].Value.ToString();
            correo = dataGridView1[5, e.RowIndex].Value.ToString();
            CveCarrera = dataGridView1[6, e.RowIndex].Value.ToString();
            sexo = dataGridView1[7, e.RowIndex].Value.ToString();
        }
    }
}
