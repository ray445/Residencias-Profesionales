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
        Metodos AP = new Metodos();
        int dif=0;
        public Agregar_Proyectos()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            ttpAgregar.SetToolTip(button1, "Agregar Proyecto");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (dif <= 6 && dif >= 4)
            {
                if (string.IsNullOrWhiteSpace(txtnombreEmp.Text) || string.IsNullOrWhiteSpace(txt_nomProyecto.Text))
                    MessageBox.Show("Campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (cbxCveAsesor.Text == cbxCveRevisor1.Text || cbxCveAsesor.Text == cbxCveRevisor2.Text || cbxCveRevisor1.Text==cbxCveRevisor2.Text)
                        MessageBox.Show("El asesor y los revisores tienen que ser distintos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (MessageBox.Show("¿Desea relizar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            AP.insertarProyecto(cbxMatricula.SelectedValue.ToString(), txt_nomProyecto.Text, txtnombreEmp.Text, cbxCveAsesor.SelectedValue.ToString(), cbxCveRevisor1.SelectedValue.ToString(), cbxCveRevisor2.SelectedValue.ToString(), cbPeriodo.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), dtp_rev1.Value.ToShortDateString(), dtp_rev2.Value.ToShortDateString(), dtp_rev3.Value.ToShortDateString());
                            txt_nomProyecto.Clear(); txtnombreEmp.Clear();
                        }
                    }
                }
            }
            else
                MessageBox.Show("La fecha de finalizacion debe ser mayor a 4 meses y menor a 6", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Agregar_Proyectos_Load(object sender, EventArgs e)
        {

            AP.combos(cbxMatricula, "Exec comboAlumnos '"+Login.Carrera+"'", "Alumnos", "nom", "matricula");
            AP.combos(cbxCveAsesor, "Exec comboAsesores2 '" + Login.Carrera + "'", "Asesores", "nom", "cve");
            AP.combos(cbxCveRevisor1, "Exec comboAsesores2 '" + Login.Carrera + "'", "Asesores", "nom", "cve");
            AP.combos(cbxCveRevisor2, "Exec comboAsesores2 '" + Login.Carrera + "'", "Asesores", "nom", "cve");
            cbPeriodo.SelectedIndex = 0;           
            dateTimePicker1.MinDate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dif=difm(dateTimePicker2.Value,dateTimePicker1.Value);
        }

        public int difm(DateTime fechaDesde, DateTime fechaHasta)
        {
            return Math.Abs((fechaDesde.Month - fechaHasta.Month) + 12 * (fechaDesde.Year - fechaHasta.Year));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = new DateTime(DateTime.Now.Year, 1, 1, 6, 0, 0);
            dateTimePicker2.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
            dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year, 1, 1, 6, 0, 0);
            dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
            dtp_rev1.MinDate = new DateTime(DateTime.Now.Year, 1, 1, 6, 0, 0);
            dtp_rev1.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
            dtp_rev2.MinDate = new DateTime(DateTime.Now.Year, 1, 1, 6, 0, 0);
            dtp_rev2.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
            dtp_rev3.MinDate = new DateTime(DateTime.Now.Year, 1, 1, 6, 0, 0);
            dtp_rev3.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);

            if (cbPeriodo.Text=="Agosto-Diciembre")
            {
                dateTimePicker2.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, 12,30, 6, 0, 0);
                dateTimePicker2.MaxDate = new DateTime(DateTime.Now.Year, 12,30, 6, 0, 0);
                dtp_rev1.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dtp_rev1.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
                dtp_rev2.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dtp_rev2.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
                dtp_rev3.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dtp_rev3.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, 8, DateTime.Now.Day, 6, 0, 0);
                dateTimePicker2.Value=new DateTime(DateTime.Now.Year, 12, DateTime.Now.Day, 6, 0, 0);
            }
            if (cbPeriodo.Text == "Febrero-Junio")
            {
                dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year, 2, 1, 6, 0, 0);
                dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, 6, 30, 6, 0, 0);
                dateTimePicker2.MinDate = new DateTime(DateTime.Now.Year, 2, 1, 6, 0, 0);
                dateTimePicker2.MaxDate = new DateTime(DateTime.Now.Year, 6, 30, 6, 0, 0);
                dtp_rev1.MinDate = new DateTime(DateTime.Now.Year, 2, 1, 6, 0, 0);
                dtp_rev1.MaxDate = new DateTime(DateTime.Now.Year, 6, 30, 6, 0, 0);
                dtp_rev2.MinDate = new DateTime(DateTime.Now.Year, 2, 1, 6, 0, 0);
                dtp_rev2.MaxDate = new DateTime(DateTime.Now.Year, 6, 30, 6, 0, 0);
                dtp_rev3.MinDate = new DateTime(DateTime.Now.Year, 2, 1, 6, 0, 0);
                dtp_rev3.MaxDate = new DateTime(DateTime.Now.Year, 6, 30, 6, 0, 0);
                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, 2, DateTime.Now.Day, 6, 0, 0);
                dateTimePicker2.Value = new DateTime(DateTime.Now.Year, 6, DateTime.Now.Day, 6, 0, 0);
            }
        }

        private void cbxCveAsesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int c1 = -1, c2 = -1;
            AP.contador(lb1,cbxCveAsesor.SelectedValue.ToString(),false);

        }

        private void cbxCveRevisor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AP.contador(lb2,cbxCveRevisor1.SelectedValue.ToString(),true);
        }

        private void cbxCveRevisor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AP.contador(lb3,cbxCveRevisor2.SelectedValue.ToString(),true);
        }

        private void txtnombreEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nomProyecto_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_nomProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
