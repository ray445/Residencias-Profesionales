namespace Residencias_Profesionales
{
    partial class CargaAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaAlumnos));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apP = new System.Windows.Forms.TextBox();
            this.txt_apM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_matricula = new System.Windows.Forms.MaskedTextBox();
            this.rb_F = new System.Windows.Forms.RadioButton();
            this.rb_M = new System.Windows.Forms.RadioButton();
            this.ttpAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matricula";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(11, 102);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 20);
            this.txt_nombre.TabIndex = 3;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_apP
            // 
            this.txt_apP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_apP.Location = new System.Drawing.Point(11, 161);
            this.txt_apP.MaxLength = 30;
            this.txt_apP.Name = "txt_apP";
            this.txt_apP.Size = new System.Drawing.Size(150, 20);
            this.txt_apP.TabIndex = 5;
            this.txt_apP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apP_KeyPress);
            // 
            // txt_apM
            // 
            this.txt_apM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_apM.Location = new System.Drawing.Point(11, 219);
            this.txt_apM.MaxLength = 30;
            this.txt_apM.Name = "txt_apM";
            this.txt_apM.Size = new System.Drawing.Size(150, 20);
            this.txt_apM.TabIndex = 7;
            this.txt_apM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apM_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Carrera";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(210, 102);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(150, 20);
            this.txt_correo.TabIndex = 4;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(210, 45);
            this.txt_telefono.Mask = "999-999-99-99";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PromptChar = ' ';
            this.txt_telefono.Size = new System.Drawing.Size(150, 20);
            this.txt_telefono.TabIndex = 2;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(11, 45);
            this.txt_matricula.Mask = "999999999";
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.PromptChar = ' ';
            this.txt_matricula.Size = new System.Drawing.Size(150, 20);
            this.txt_matricula.TabIndex = 1;
            // 
            // rb_F
            // 
            this.rb_F.AutoSize = true;
            this.rb_F.Checked = true;
            this.rb_F.Location = new System.Drawing.Point(210, 220);
            this.rb_F.Name = "rb_F";
            this.rb_F.Size = new System.Drawing.Size(71, 17);
            this.rb_F.TabIndex = 8;
            this.rb_F.TabStop = true;
            this.rb_F.Text = "Femenino";
            this.rb_F.UseVisualStyleBackColor = true;
            this.rb_F.CheckedChanged += new System.EventHandler(this.rb_F_CheckedChanged);
            // 
            // rb_M
            // 
            this.rb_M.AutoSize = true;
            this.rb_M.Location = new System.Drawing.Point(287, 220);
            this.rb_M.Name = "rb_M";
            this.rb_M.Size = new System.Drawing.Size(73, 17);
            this.rb_M.TabIndex = 9;
            this.rb_M.TabStop = true;
            this.rb_M.Text = "Masculino";
            this.rb_M.UseVisualStyleBackColor = true;
            this.rb_M.CheckedChanged += new System.EventHandler(this.rb_M_CheckedChanged);
            // 
            // CargaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(246)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(373, 330);
            this.Controls.Add(this.rb_M);
            this.Controls.Add(this.rb_F);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_apM);
            this.Controls.Add(this.txt_apP);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 369);
            this.MinimumSize = new System.Drawing.Size(389, 369);
            this.Name = "CargaAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.Load += new System.EventHandler(this.CargaAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apP;
        private System.Windows.Forms.TextBox txt_apM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.MaskedTextBox txt_telefono;
        private System.Windows.Forms.MaskedTextBox txt_matricula;
        private System.Windows.Forms.RadioButton rb_F;
        private System.Windows.Forms.RadioButton rb_M;
        private System.Windows.Forms.ToolTip ttpAgregar;
    }
}