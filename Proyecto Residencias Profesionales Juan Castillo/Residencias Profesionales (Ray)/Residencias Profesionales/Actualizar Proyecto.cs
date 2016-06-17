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
    public partial class Actualizar_Proyecto : Form
    {
        //instanciamos un objeto de la clase metodos
        Metodos AP = new Metodos();
        //declaramos unas variables que nos serviran para saber la diferencia de tiempo de las fechas
        int dif = 0;
        string mat;

        //sobrecargamos el metod para que pueda recibir parametros y vaciarlos en contenedores
        public Actualizar_Proyecto(string matricula,string empresa, string nombrep, string revisor1,string asesor, string revisor2, string alumno, string periodo, string inicio, string fin, string rev1, string rev2, string rev3 )
        {
            InitializeComponent();
            ttpActualizar.SetToolTip(button1, "Actualizar Datos");
            mat = matricula;
            txtnombreEmp.Text = empresa;
            txt_nomProyecto.Text = nombrep;
            AP.combos(cbxCveAsesor, "Exec comboAsesores2 '" + Login.Carrera + "'", "Asesores", "nom", "cve");
            AP.combos(cbxCveRevisor1, "Exec comboAsesores2 '" + Login.Carrera + "'", "Asesores", "nom", "cve");
            AP.combos(cbxCveRevisor2, "Exec comboAsesores2 '" + Login.Carrera + "'", "Asesores", "nom", "cve");
            //cbPeriodo.SelectedIndex = 0;
            txt_alumno.Text = alumno;
            cbxCveRevisor1.SelectedValue = revisor1;
            cbxCveAsesor.SelectedValue = asesor;
            cbxCveRevisor2.SelectedValue = revisor2;
            dateTimePicker1.Value = Convert.ToDateTime(inicio);
            dateTimePicker2.Value = Convert.ToDateTime(fin);
            dtp_rev1.Value = Convert.ToDateTime(rev1);
            dtp_rev2.Value = Convert.ToDateTime(rev2);
            dtp_rev3.Value = Convert.ToDateTime(rev3);
            cbPeriodo.Text = periodo;
            txt_alumno.Text = alumno;

        }

        private void Actualizar_Proyecto_Load(object sender, EventArgs e)
        {
        }
        public int difm(DateTime fechaDesde, DateTime fechaHasta)
        {
            return Math.Abs((fechaDesde.Month - fechaHasta.Month) + 12 * (fechaDesde.Year - fechaHasta.Year));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dif = difm(dateTimePicker2.Value, dateTimePicker1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dif <= 6 && dif >= 4)
            {
                if (string.IsNullOrWhiteSpace(txtnombreEmp.Text) || string.IsNullOrWhiteSpace(txt_nomProyecto.Text)|| string.IsNullOrWhiteSpace(cbPeriodo.Text)|| string.IsNullOrWhiteSpace(cbxCveAsesor.Text)|| string.IsNullOrWhiteSpace(cbxCveRevisor1.Text)|| string.IsNullOrWhiteSpace(cbxCveRevisor2.Text))
                    MessageBox.Show("Campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (cbxCveAsesor.Text == cbxCveRevisor1.Text || cbxCveAsesor.Text == cbxCveRevisor2.Text || cbxCveRevisor1.Text == cbxCveRevisor2.Text)
                        MessageBox.Show("El asesor y los revisores tienen que ser distintos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (MessageBox.Show("¿Desea relizar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            AP.ActualizarProyecto(mat, txt_nomProyecto.Text, txtnombreEmp.Text, cbxCveAsesor.SelectedValue.ToString(), cbxCveRevisor1.SelectedValue.ToString(), cbxCveRevisor2.SelectedValue.ToString(), cbPeriodo.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), dtp_rev1.Value.ToShortDateString(), dtp_rev2.Value.ToShortDateString(), dtp_rev3.Value.ToShortDateString());
                        }
                    }
                }
            }
            else
                MessageBox.Show("La fecha de finalizacion debe ser mayor a 4 meses y menor a 6", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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

            if (cbPeriodo.Text == "Agosto-Diciembre")
            {
                dateTimePicker2.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
                dateTimePicker2.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
                dtp_rev1.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dtp_rev1.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
                dtp_rev2.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dtp_rev2.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
                dtp_rev3.MinDate = new DateTime(DateTime.Now.Year, 8, 1, 6, 0, 0);
                dtp_rev3.MaxDate = new DateTime(DateTime.Now.Year, 12, 30, 6, 0, 0);
                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, 8, DateTime.Now.Day, 6, 0, 0);
                dateTimePicker2.Value = new DateTime(DateTime.Now.Year, 12, DateTime.Now.Day, 6, 0, 0);
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

        private void txtnombreEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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
