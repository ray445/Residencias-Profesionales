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
        string clave, nombre, app, apm, correo, telefono, carrera;
        

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cargar(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar este registro?","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                BA.eliminarAsesor(clave);
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
        }


        public Buscar_Asesor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds;
            if (radioButton1.Checked)
            {
                ds= BA.buscarAsesor(textBox1.Text, "");
                if (ds != null)
                    dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton2.Checked)
            {
                ds = BA.buscarAsesor("", textBox1.Text);
                if (ds != null)
                    dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Buscar_Asesor_Activated(object sender, EventArgs e)
        {
            DataSet ds=BA.buscarAsesor(textBox1.Text, "");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntBuscar_Click(object sender, EventArgs e)
        {
            Modificar_Datos_de_Asesor MA = new Modificar_Datos_de_Asesor(clave, nombre,app,apm,correo,telefono,carrera);
            MA.Show();
        }
    }
}
