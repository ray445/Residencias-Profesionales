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
    public partial class Agregar_Proyectos : Form
    {
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            
        }
        Metodos AP = new Metodos();
        public Agregar_Proyectos()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-mm-dddd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-mm-dddd";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombreEmp.Text) || string.IsNullOrWhiteSpace(txt_nomProyecto.Text))
                MessageBox.Show("Campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (cbxCveAsesor.Text == cbxCveRevisor1.Text && cbxCveAsesor.Text == cbxCveRevisor2.Text)
                    MessageBox.Show("Un mismo docente no puede ocupar los tres puestos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (MessageBox.Show("¿Desea relizar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (AP.insertarProyecto(cbxMatricula.SelectedValue.ToString(), txt_nomProyecto.Text, txtnombreEmp.Text, cbxCveAsesor.SelectedValue.ToString(), cbxCveRevisor1.SelectedValue.ToString(), cbxCveRevisor2.SelectedValue.ToString(), cbPeriodo.Text, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date))
                        {
                            MessageBox.Show("Datos Agregados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_nomProyecto.Clear(); txtnombreEmp.Clear();
                        }
                        else
                            MessageBox.Show("Error al Agregar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Agregar_Proyectos_Load(object sender, EventArgs e)
        {
            AP.combos(cbxMatricula, "Exec comboAlumnos", "Alumnos", "nom", "matricula");
            AP.combos(cbxCveAsesor, "Exec comboAsesores", "Asesores", "nom", "cve");
            AP.combos(cbxCveRevisor1, "Exec comboAsesores", "Asesores", "nom", "cve");
            AP.combos(cbxCveRevisor2, "Exec comboAsesores", "Asesores", "nom", "cve");
            cbPeriodo.SelectedIndex = 0;

            dateTimePicker1.MinDate = dateTimePicker1.Value;
        }
    }
}
