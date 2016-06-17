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
    public partial class Control_de_Documentos : Form
    {
        Metodos D = new Metodos();
        public Control_de_Documentos()
        {
            InitializeComponent();
            ttpActualizar.SetToolTip(btn_actualizar, "Guardar Cambios");
        }

        private void Control_de_Documentos_Activated(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg_Documentos.RowCount; i++)
            {
                D.actualizarDocs(dg_Documentos.Rows[i].Cells[0].Value.ToString(),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[2].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[3].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[4].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[5].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[6].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[7].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[8].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[9].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[10].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[11].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[12].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[13].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[14].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[15].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[16].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[17].Value),
                                 Convert.ToBoolean(dg_Documentos.Rows[i].Cells[18].Value)
                                 );
            }
        }

        private void Control_de_Documentos_Load(object sender, EventArgs e)
        {
            DataSet docs = D.documentos("","",Login.Carrera);
            if (docs != null)
            {
                dg_Documentos.DataSource = docs.Tables[0];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbt_NombreA.Checked)
            {
                DataSet docs = D.documentos("",textBox1.Text,Login.Carrera);
                if (docs.Tables[0] != null)                
                    dg_Documentos.DataSource = docs.Tables[0];                
            }
            if (rdb_nomP.Checked)
            {
                DataSet docs = D.documentos(textBox1.Text, "", Login.Carrera);
                if (docs.Tables[0] != null)
                    dg_Documentos.DataSource = docs.Tables[0];
            }
            
        }
    }
}
