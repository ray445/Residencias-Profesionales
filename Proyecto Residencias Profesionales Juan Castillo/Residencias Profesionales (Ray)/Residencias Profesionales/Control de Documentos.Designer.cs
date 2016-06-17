namespace Residencias_Profesionales
{
    partial class Control_de_Documentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_de_Documentos));
            this.dg_Documentos = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbt_NombreA = new System.Windows.Forms.RadioButton();
            this.rdb_nomP = new System.Windows.Forms.RadioButton();
            this.ttpActualizar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Documentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Documentos
            // 
            this.dg_Documentos.AllowUserToAddRows = false;
            this.dg_Documentos.AllowUserToDeleteRows = false;
            this.dg_Documentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Documentos.BackgroundColor = System.Drawing.Color.White;
            this.dg_Documentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Documentos.Location = new System.Drawing.Point(12, 78);
            this.dg_Documentos.Name = "dg_Documentos";
            this.dg_Documentos.Size = new System.Drawing.Size(717, 279);
            this.dg_Documentos.TabIndex = 0;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_actualizar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.BackgroundImage")));
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Location = new System.Drawing.Point(668, 11);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(61, 61);
            this.btn_actualizar.TabIndex = 1;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(55, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar:";
            // 
            // rbt_NombreA
            // 
            this.rbt_NombreA.AutoSize = true;
            this.rbt_NombreA.Checked = true;
            this.rbt_NombreA.Location = new System.Drawing.Point(237, 37);
            this.rbt_NombreA.Name = "rbt_NombreA";
            this.rbt_NombreA.Size = new System.Drawing.Size(117, 17);
            this.rbt_NombreA.TabIndex = 4;
            this.rbt_NombreA.TabStop = true;
            this.rbt_NombreA.Text = "Nombre del Alumno";
            this.rbt_NombreA.UseVisualStyleBackColor = true;
            // 
            // rdb_nomP
            // 
            this.rdb_nomP.AutoSize = true;
            this.rdb_nomP.Location = new System.Drawing.Point(360, 37);
            this.rdb_nomP.Name = "rdb_nomP";
            this.rdb_nomP.Size = new System.Drawing.Size(68, 17);
            this.rdb_nomP.TabIndex = 5;
            this.rdb_nomP.Text = "Matricula";
            this.rdb_nomP.UseVisualStyleBackColor = true;
            // 
            // Control_de_Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(246)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(741, 369);
            this.Controls.Add(this.rdb_nomP);
            this.Controls.Add(this.rbt_NombreA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.dg_Documentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Control_de_Documentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docuemntos Recibidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Control_de_Documentos_Activated);
            this.Load += new System.EventHandler(this.Control_de_Documentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Documentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Documentos;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbt_NombreA;
        private System.Windows.Forms.RadioButton rdb_nomP;
        private System.Windows.Forms.ToolTip ttpActualizar;
    }
}