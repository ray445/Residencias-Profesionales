﻿namespace Residencias_Profesionales
{
    partial class Carreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carreras));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_cveCarrera = new System.Windows.Forms.RadioButton();
            this.rdb_carrera = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BntBuscar = new System.Windows.Forms.Button();
            this.ttpActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttpAgregar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(497, 238);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Buscar:";
            // 
            // rdb_cveCarrera
            // 
            this.rdb_cveCarrera.AutoSize = true;
            this.rdb_cveCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_cveCarrera.Location = new System.Drawing.Point(391, 29);
            this.rdb_cveCarrera.Name = "rdb_cveCarrera";
            this.rdb_cveCarrera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdb_cveCarrera.Size = new System.Drawing.Size(123, 24);
            this.rdb_cveCarrera.TabIndex = 3;
            this.rdb_cveCarrera.Text = "Clave Carrera";
            this.rdb_cveCarrera.UseVisualStyleBackColor = true;
            // 
            // rdb_carrera
            // 
            this.rdb_carrera.AutoSize = true;
            this.rdb_carrera.Checked = true;
            this.rdb_carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_carrera.Location = new System.Drawing.Point(227, 28);
            this.rdb_carrera.Name = "rdb_carrera";
            this.rdb_carrera.Size = new System.Drawing.Size(135, 24);
            this.rdb_carrera.TabIndex = 2;
            this.rdb_carrera.TabStop = true;
            this.rdb_carrera.Text = "Nombre Carera";
            this.rdb_carrera.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(518, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 61);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BntBuscar
            // 
            this.BntBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BntBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.BntBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BntBuscar.BackgroundImage")));
            this.BntBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BntBuscar.FlatAppearance.BorderSize = 0;
            this.BntBuscar.Location = new System.Drawing.Point(518, 59);
            this.BntBuscar.Name = "BntBuscar";
            this.BntBuscar.Size = new System.Drawing.Size(61, 61);
            this.BntBuscar.TabIndex = 5;
            this.BntBuscar.UseVisualStyleBackColor = false;
            this.BntBuscar.Click += new System.EventHandler(this.BntBuscar_Click);
            // 
            // Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(246)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(591, 309);
            this.Controls.Add(this.BntBuscar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdb_cveCarrera);
            this.Controls.Add(this.rdb_carrera);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Carreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            this.Activated += new System.EventHandler(this.Carreras_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_cveCarrera;
        private System.Windows.Forms.RadioButton rdb_carrera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BntBuscar;
        private System.Windows.Forms.ToolTip ttpActualizar;
        private System.Windows.Forms.ToolTip ttpAgregar;
    }
}