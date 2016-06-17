namespace Residencias_Profesionales
{
    partial class Actualizar_Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Alumnos));
            this.button1 = new System.Windows.Forms.Button();
            this.rb_M = new System.Windows.Forms.RadioButton();
            this.rb_F = new System.Windows.Forms.RadioButton();
            this.txt_matricula = new System.Windows.Forms.MaskedTextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apM = new System.Windows.Forms.TextBox();
            this.txt_apP = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_carrera = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ttpActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_M
            // 
            this.rb_M.AutoSize = true;
            this.rb_M.Location = new System.Drawing.Point(288, 207);
            this.rb_M.Name = "rb_M";
            this.rb_M.Size = new System.Drawing.Size(73, 17);
            this.rb_M.TabIndex = 9;
            this.rb_M.TabStop = true;
            this.rb_M.Text = "Masculino";
            this.rb_M.UseVisualStyleBackColor = true;
            // 
            // rb_F
            // 
            this.rb_F.AutoSize = true;
            this.rb_F.Checked = true;
            this.rb_F.Location = new System.Drawing.Point(203, 207);
            this.rb_F.Name = "rb_F";
            this.rb_F.Size = new System.Drawing.Size(71, 17);
            this.rb_F.TabIndex = 8;
            this.rb_F.TabStop = true;
            this.rb_F.Text = "Femenino";
            this.rb_F.UseVisualStyleBackColor = true;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Enabled = false;
            this.txt_matricula.Location = new System.Drawing.Point(12, 44);
            this.txt_matricula.Mask = "999999999";
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.PromptChar = ' ';
            this.txt_matricula.Size = new System.Drawing.Size(150, 20);
            this.txt_matricula.TabIndex = 1;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(211, 101);
            this.txt_correo.MaxLength = 100;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(150, 20);
            this.txt_correo.TabIndex = 4;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(211, 44);
            this.txt_telefono.Mask = "999-999-99-99";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PromptChar = ' ';
            this.txt_telefono.Size = new System.Drawing.Size(150, 20);
            this.txt_telefono.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 85;
            this.label8.Text = "Carrera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 84;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 83;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 81;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nombre";
            // 
            // txt_apM
            // 
            this.txt_apM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_apM.Location = new System.Drawing.Point(12, 207);
            this.txt_apM.MaxLength = 30;
            this.txt_apM.Name = "txt_apM";
            this.txt_apM.Size = new System.Drawing.Size(150, 20);
            this.txt_apM.TabIndex = 7;
            this.txt_apM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apM_KeyPress);
            // 
            // txt_apP
            // 
            this.txt_apP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_apP.Location = new System.Drawing.Point(12, 151);
            this.txt_apP.MaxLength = 30;
            this.txt_apP.Name = "txt_apP";
            this.txt_apP.Size = new System.Drawing.Size(150, 20);
            this.txt_apP.TabIndex = 5;
            this.txt_apP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apP_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(12, 101);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 20);
            this.txt_nombre.TabIndex = 3;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // cmb_carrera
            // 
            this.cmb_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_carrera.FormattingEnabled = true;
            this.cmb_carrera.Location = new System.Drawing.Point(211, 151);
            this.cmb_carrera.Name = "cmb_carrera";
            this.cmb_carrera.Size = new System.Drawing.Size(150, 21);
            this.cmb_carrera.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 72;
            this.label7.Text = "Matricula";
            // 
            // Actualizar_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(246)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(372, 308);
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
            this.Controls.Add(this.cmb_carrera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 347);
            this.MinimumSize = new System.Drawing.Size(388, 347);
            this.Name = "Actualizar_Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_M;
        private System.Windows.Forms.RadioButton rb_F;
        private System.Windows.Forms.MaskedTextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.MaskedTextBox txt_telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apM;
        private System.Windows.Forms.TextBox txt_apP;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_carrera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip ttpActualizar;
    }
}