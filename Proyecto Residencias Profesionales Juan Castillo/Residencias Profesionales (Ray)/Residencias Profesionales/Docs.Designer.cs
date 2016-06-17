namespace Residencias_Profesionales
{
    partial class Docs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docs));
            this.tab_Docs = new System.Windows.Forms.TabControl();
            this.tab_Asesor = new System.Windows.Forms.TabPage();
            this.rep_Asesor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tab_R1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rep_R1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tab_R2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rep_R2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rep_Proyecto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tab_Docs.SuspendLayout();
            this.tab_Asesor.SuspendLayout();
            this.tab_R1.SuspendLayout();
            this.tab_R2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Docs
            // 
            this.tab_Docs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Docs.Controls.Add(this.tab_Asesor);
            this.tab_Docs.Controls.Add(this.tab_R1);
            this.tab_Docs.Controls.Add(this.tab_R2);
            this.tab_Docs.Controls.Add(this.tabPage4);
            this.tab_Docs.Location = new System.Drawing.Point(0, 0);
            this.tab_Docs.Name = "tab_Docs";
            this.tab_Docs.SelectedIndex = 0;
            this.tab_Docs.Size = new System.Drawing.Size(588, 260);
            this.tab_Docs.TabIndex = 0;
            // 
            // tab_Asesor
            // 
            this.tab_Asesor.Controls.Add(this.rep_Asesor);
            this.tab_Asesor.Location = new System.Drawing.Point(4, 22);
            this.tab_Asesor.Name = "tab_Asesor";
            this.tab_Asesor.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Asesor.Size = new System.Drawing.Size(580, 234);
            this.tab_Asesor.TabIndex = 0;
            this.tab_Asesor.Text = "Asignacion de Asesor";
            this.tab_Asesor.UseVisualStyleBackColor = true;
            // 
            // rep_Asesor
            // 
            this.rep_Asesor.ActiveViewIndex = -1;
            this.rep_Asesor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rep_Asesor.Cursor = System.Windows.Forms.Cursors.Default;
            this.rep_Asesor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rep_Asesor.Location = new System.Drawing.Point(3, 3);
            this.rep_Asesor.Name = "rep_Asesor";
            this.rep_Asesor.Size = new System.Drawing.Size(574, 228);
            this.rep_Asesor.TabIndex = 0;
            // 
            // tab_R1
            // 
            this.tab_R1.Controls.Add(this.label1);
            this.tab_R1.Controls.Add(this.comboBox1);
            this.tab_R1.Controls.Add(this.rep_R1);
            this.tab_R1.Location = new System.Drawing.Point(4, 22);
            this.tab_R1.Name = "tab_R1";
            this.tab_R1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_R1.Size = new System.Drawing.Size(580, 234);
            this.tab_R1.TabIndex = 1;
            this.tab_R1.Text = "Asignacion de Revisor 1";
            this.tab_R1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(475, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imprimir para:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fecha de revision 1",
            "Fecha de revision 2",
            "Fecha de revision 3"});
            this.comboBox1.Location = new System.Drawing.Point(544, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rep_R1
            // 
            this.rep_R1.ActiveViewIndex = -1;
            this.rep_R1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rep_R1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rep_R1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rep_R1.Location = new System.Drawing.Point(3, 3);
            this.rep_R1.Name = "rep_R1";
            this.rep_R1.Size = new System.Drawing.Size(574, 228);
            this.rep_R1.TabIndex = 0;
            // 
            // tab_R2
            // 
            this.tab_R2.Controls.Add(this.label2);
            this.tab_R2.Controls.Add(this.comboBox2);
            this.tab_R2.Controls.Add(this.rep_R2);
            this.tab_R2.Location = new System.Drawing.Point(4, 22);
            this.tab_R2.Name = "tab_R2";
            this.tab_R2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_R2.Size = new System.Drawing.Size(580, 234);
            this.tab_R2.TabIndex = 2;
            this.tab_R2.Text = "Asignacion de Revisor 2";
            this.tab_R2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(478, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imprimir para:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Fecha de revision 1",
            "Fecha de revision 2",
            "Fecha de revision 3"});
            this.comboBox2.Location = new System.Drawing.Point(547, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // rep_R2
            // 
            this.rep_R2.ActiveViewIndex = -1;
            this.rep_R2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rep_R2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rep_R2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rep_R2.Location = new System.Drawing.Point(3, 3);
            this.rep_R2.Name = "rep_R2";
            this.rep_R2.Size = new System.Drawing.Size(574, 228);
            this.rep_R2.TabIndex = 0;
            this.rep_R2.Load += new System.EventHandler(this.rep_R2_Load);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rep_Proyecto);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(580, 234);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rep_Proyecto
            // 
            this.rep_Proyecto.ActiveViewIndex = -1;
            this.rep_Proyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rep_Proyecto.Cursor = System.Windows.Forms.Cursors.Default;
            this.rep_Proyecto.Location = new System.Drawing.Point(3, 3);
            this.rep_Proyecto.Name = "rep_Proyecto";
            this.rep_Proyecto.Size = new System.Drawing.Size(424, 143);
            this.rep_Proyecto.TabIndex = 0;
            // 
            // Docs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 260);
            this.Controls.Add(this.tab_Docs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Docs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_Docs.ResumeLayout(false);
            this.tab_Asesor.ResumeLayout(false);
            this.tab_R1.ResumeLayout(false);
            this.tab_R1.PerformLayout();
            this.tab_R2.ResumeLayout(false);
            this.tab_R2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Docs;
        private System.Windows.Forms.TabPage tab_Asesor;
        private System.Windows.Forms.TabPage tab_R1;
        private System.Windows.Forms.TabPage tab_R2;
        private System.Windows.Forms.TabPage tabPage4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rep_Asesor;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rep_R1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rep_R2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rep_Proyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}