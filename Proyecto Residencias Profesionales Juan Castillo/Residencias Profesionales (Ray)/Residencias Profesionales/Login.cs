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
    public partial class Login : Form
    {
        //private const int CS_DROPSHADOW = 0x20000;
        private const int CS_DROPSHADOW = 0x30000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        public static  string Carrera;
        public static string cargo;
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Log();
        }

        private void Log()
        {
            Menu_Opciones menu = new Menu_Opciones();
            Menú_Coordinador mc = new Menú_Coordinador();
            Metodos log = new Metodos();
            if (string.IsNullOrWhiteSpace(textBox1.Text) == false && string.IsNullOrWhiteSpace(textBox2.Text) == false)
            {
                if (log.login(textBox1.Text, textBox2.Text) == "Administrador")
                {
                    cargo = "Administrador";
                    this.Hide();
                    menu.ShowDialog();
                    textBox1.Clear();
                    textBox2.Clear();
                    this.Show();
                    textBox1.Focus();
                    
                }
            }
            else
            {
                MessageBox.Show("Espacios Vacios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) == false && string.IsNullOrWhiteSpace(textBox2.Text) == false)
            {
                if (log.login(textBox1.Text, textBox2.Text) == "Coordinador")
                {
                    cargo = "Coordinador";
                    this.Hide();
                    mc.ShowDialog();
                    textBox1.Clear();
                    textBox2.Clear();
                    this.Show();
                    textBox1.Focus();
                    
                }
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) == false && string.IsNullOrWhiteSpace(textBox2.Text) == false)
            {
                if (log.login(textBox1.Text, textBox2.Text) == string.Empty)
                {
                    MessageBox.Show("Datos incorrectos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar( Keys.Enter))
                Log();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Log();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
