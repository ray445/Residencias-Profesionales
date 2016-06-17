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
    public partial class Docs : Form
    {
        string mat;
        public Docs(string matricula)
        {
            InitializeComponent();
            mat = matricula;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            reporte RA = new reporte();
            RA.SetParameterValue("@matricula", mat);    
            rep_Asesor.ReportSource = RA;

            Revisor_Doc R1 = new Revisor_Doc();
            R1.SetParameterValue("@matricula", mat);
            R1.SetParameterValue("@numfecha", comboBox1.SelectedIndex+1);
            rep_R1.ReportSource = R1;

            Revisor2_Doc R2 = new Revisor2_Doc();
            R2.SetParameterValue("@matricula", mat);
            R2.SetParameterValue("@numfecha", comboBox2.SelectedIndex+1);
            rep_R2.ReportSource = R2;

            Proyecto p = new Proyecto();
            p.SetParameterValue("@matricula", mat);
            rep_Proyecto.ReportSource = p;
            
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Revisor_Doc R1 = new Revisor_Doc();
            R1.SetParameterValue("@matricula", mat);
            R1.SetParameterValue("@numfecha", comboBox1.SelectedIndex+1);
            rep_R1.ReportSource = R1;
        }

        private void rep_R2_Load(object sender, EventArgs e)
        {
            Revisor2_Doc R2 = new Revisor2_Doc();
            R2.SetParameterValue("@matricula", mat);
            R2.SetParameterValue("@numfecha", comboBox2.SelectedIndex+1);
            rep_R2.ReportSource = R2;
        }
    }
}
