namespace Residencias_Profesionales
{
    partial class Actualizar_Carrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Carrera));
            this.label4 = new System.Windows.Forms.Label();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCveCarrera = new System.Windows.Forms.TextBox();
            this.ttpActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Jefe de Carrera";
            // 
            // txtJefe
            // 
            this.txtJefe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJefe.Location = new System.Drawing.Point(12, 88);
            this.txtJefe.MaxLength = 100;
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(100, 20);
            this.txtJefe.TabIndex = 3;
            this.txtJefe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJefe_KeyPress);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar.BackgroundImage")));
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.Location = new System.Drawing.Point(64, 134);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(129, 50);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Clave Carrera";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(154, 28);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCveCarrera
            // 
            this.txtCveCarrera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCveCarrera.Enabled = false;
            this.txtCveCarrera.Location = new System.Drawing.Point(12, 28);
            this.txtCveCarrera.MaxLength = 15;
            this.txtCveCarrera.Name = "txtCveCarrera";
            this.txtCveCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtCveCarrera.TabIndex = 1;
            // 
            // Actualizar_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(246)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(272, 196);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJefe);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCveCarrera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(288, 235);
            this.MinimumSize = new System.Drawing.Size(288, 235);
            this.Name = "Actualizar_Carrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Carrera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCveCarrera;
        private System.Windows.Forms.ToolTip ttpActualizar;
    }
}