namespace Residencias_Profesionales
{
    partial class Actualizar_Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Proyecto));
            this.label3 = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomProyecto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxCveRevisor2 = new System.Windows.Forms.ComboBox();
            this.cbxCveRevisor1 = new System.Windows.Forms.ComboBox();
            this.cbxCveAsesor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreEmp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_alumno = new System.Windows.Forms.TextBox();
            this.dtp_rev1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_rev2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_rev3 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ttpActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Periodo";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Agosto-Diciembre",
            "Febrero-Junio"});
            this.cbPeriodo.Location = new System.Drawing.Point(12, 189);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cbPeriodo.TabIndex = 7;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbPeriodo_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 245);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Nombre Proyecto";
            // 
            // txt_nomProyecto
            // 
            this.txt_nomProyecto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nomProyecto.Location = new System.Drawing.Point(177, 40);
            this.txt_nomProyecto.MaxLength = 50;
            this.txt_nomProyecto.Name = "txt_nomProyecto";
            this.txt_nomProyecto.Size = new System.Drawing.Size(120, 20);
            this.txt_nomProyecto.TabIndex = 2;
            this.txt_nomProyecto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomProyecto_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "Fecha finalizacion";
            // 
            // cbxCveRevisor2
            // 
            this.cbxCveRevisor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCveRevisor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCveRevisor2.FormattingEnabled = true;
            this.cbxCveRevisor2.Location = new System.Drawing.Point(12, 139);
            this.cbxCveRevisor2.Name = "cbxCveRevisor2";
            this.cbxCveRevisor2.Size = new System.Drawing.Size(121, 21);
            this.cbxCveRevisor2.TabIndex = 5;
            // 
            // cbxCveRevisor1
            // 
            this.cbxCveRevisor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCveRevisor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCveRevisor1.FormattingEnabled = true;
            this.cbxCveRevisor1.Location = new System.Drawing.Point(176, 93);
            this.cbxCveRevisor1.Name = "cbxCveRevisor1";
            this.cbxCveRevisor1.Size = new System.Drawing.Size(121, 21);
            this.cbxCveRevisor1.TabIndex = 4;
            // 
            // cbxCveAsesor
            // 
            this.cbxCveAsesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCveAsesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCveAsesor.FormattingEnabled = true;
            this.cbxCveAsesor.Location = new System.Drawing.Point(12, 93);
            this.cbxCveAsesor.Name = "cbxCveAsesor";
            this.cbxCveAsesor.Size = new System.Drawing.Size(121, 21);
            this.cbxCveAsesor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Fecha de inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Alumno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Revisor2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Revisor1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Asesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Empresa";
            // 
            // txtnombreEmp
            // 
            this.txtnombreEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombreEmp.Location = new System.Drawing.Point(12, 40);
            this.txtnombreEmp.MaxLength = 50;
            this.txtnombreEmp.Name = "txtnombreEmp";
            this.txtnombreEmp.Size = new System.Drawing.Size(120, 20);
            this.txtnombreEmp.TabIndex = 1;
            this.txtnombreEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreEmp_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_alumno
            // 
            this.txt_alumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_alumno.Enabled = false;
            this.txt_alumno.Location = new System.Drawing.Point(177, 140);
            this.txt_alumno.MaxLength = 6;
            this.txt_alumno.Name = "txt_alumno";
            this.txt_alumno.Size = new System.Drawing.Size(120, 20);
            this.txt_alumno.TabIndex = 95;
            // 
            // dtp_rev1
            // 
            this.dtp_rev1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_rev1.Location = new System.Drawing.Point(176, 245);
            this.dtp_rev1.Name = "dtp_rev1";
            this.dtp_rev1.Size = new System.Drawing.Size(121, 20);
            this.dtp_rev1.TabIndex = 10;
            // 
            // dtp_rev2
            // 
            this.dtp_rev2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_rev2.Location = new System.Drawing.Point(12, 302);
            this.dtp_rev2.Name = "dtp_rev2";
            this.dtp_rev2.Size = new System.Drawing.Size(121, 20);
            this.dtp_rev2.TabIndex = 11;
            // 
            // dtp_rev3
            // 
            this.dtp_rev3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_rev3.Location = new System.Drawing.Point(177, 302);
            this.dtp_rev3.Name = "dtp_rev3";
            this.dtp_rev3.Size = new System.Drawing.Size(121, 20);
            this.dtp_rev3.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "Fecha Revision 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 100;
            this.label11.Text = "Fecha Revision 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 101;
            this.label12.Text = "Fecha Revision 3";
            // 
            // Actualizar_Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(246)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(310, 407);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtp_rev3);
            this.Controls.Add(this.dtp_rev2);
            this.Controls.Add(this.dtp_rev1);
            this.Controls.Add(this.txt_alumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomProyecto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxCveRevisor2);
            this.Controls.Add(this.cbxCveRevisor1);
            this.Controls.Add(this.cbxCveAsesor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombreEmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 446);
            this.MinimumSize = new System.Drawing.Size(326, 446);
            this.Name = "Actualizar_Proyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Proyecto";
            this.Load += new System.EventHandler(this.Actualizar_Proyecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomProyecto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxCveRevisor2;
        private System.Windows.Forms.ComboBox cbxCveRevisor1;
        private System.Windows.Forms.ComboBox cbxCveAsesor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombreEmp;
        private System.Windows.Forms.TextBox txt_alumno;
        private System.Windows.Forms.DateTimePicker dtp_rev1;
        private System.Windows.Forms.DateTimePicker dtp_rev2;
        private System.Windows.Forms.DateTimePicker dtp_rev3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip ttpActualizar;
    }
}