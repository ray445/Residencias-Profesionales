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
    public partial class Pruebacorreo : Form
    {
        List<infoCorreo> mar = new List<infoCorreo>();
        Metodos asd = new Metodos();
        public Pruebacorreo()
        {
            InitializeComponent();
        }


        private void Pruebacorreo_Load(object sender, EventArgs e)
        {
            
            DataSet ds= asd.mostrarNotificados();
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
            
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                asd.consultarinfo(mar, int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < mar.Count; i++)
                {
                    asd.escribirCorreo(mar[i].correo, mar[i].correo2, mar[i].fecha, mar[i].nombre);
                }

            }
            catch (Exception)
            {
                
            }
        }
    }
}
