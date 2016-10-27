namespace ClinicaFrba.Listados
{
    partial class AbmListado2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_consultas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestre = new System.Windows.Forms.ComboBox();
            this.top5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.BotonFiltrar = new System.Windows.Forms.Button();
            this.AnioDeBaja = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnioDeBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.semestre);
            this.panel1.Controls.Add(this.top5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.botonVolver);
            this.panel1.Controls.Add(this.BotonFiltrar);
            this.panel1.Controls.Add(this.AnioDeBaja);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 547);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plan,
            this.dataGridViewTextBoxColumn1,
            this.Numero_consultas});
            this.dataGridView3.Location = new System.Drawing.Point(32, 283);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(546, 186);
            this.dataGridView3.TabIndex = 124;
            // 
            // plan
            // 
            this.plan.HeaderText = "Plan";
            this.plan.Name = "plan";
            this.plan.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Especialidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // Numero_consultas
            // 
            this.Numero_consultas.HeaderText = "Consultas";
            this.Numero_consultas.Name = "Numero_consultas";
            this.Numero_consultas.ReadOnly = true;
            // 
            // semestre
            // 
            this.semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestre.FormattingEnabled = true;
            this.semestre.Items.AddRange(new object[] {
            "Primer semestr",
            "Segundo semestre"});
            this.semestre.Location = new System.Drawing.Point(252, 179);
            this.semestre.Margin = new System.Windows.Forms.Padding(2);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(326, 40);
            this.semestre.TabIndex = 120;
            this.semestre.Text = "Elija uno";
            // 
            // top5
            // 
            this.top5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top5.FormattingEnabled = true;
            this.top5.Items.AddRange(new object[] {
            "Especialidades con mas cancelaciones",
            "Profesionales más consultados",
            "Profesionales más perezosos",
            "Afiliado con màs bonos comprados",
            "Especialidades con mas consultas"});
            this.top5.Location = new System.Drawing.Point(252, 83);
            this.top5.Margin = new System.Windows.Forms.Padding(2);
            this.top5.Name = "top5";
            this.top5.Size = new System.Drawing.Size(326, 33);
            this.top5.TabIndex = 119;
            this.top5.Text = "Elija uno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 21.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 37);
            this.label3.TabIndex = 118;
            this.label3.Text = "Semestre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 21.75F);
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(425, 493);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(153, 52);
            this.botonVolver.TabIndex = 117;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // BotonFiltrar
            // 
            this.BotonFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonFiltrar.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F);
            this.BotonFiltrar.ForeColor = System.Drawing.Color.Black;
            this.BotonFiltrar.Location = new System.Drawing.Point(444, 236);
            this.BotonFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonFiltrar.Name = "BotonFiltrar";
            this.BotonFiltrar.Size = new System.Drawing.Size(134, 42);
            this.BotonFiltrar.TabIndex = 116;
            this.BotonFiltrar.Text = "Filtrar";
            this.BotonFiltrar.UseVisualStyleBackColor = true;
            // 
            // AnioDeBaja
            // 
            this.AnioDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnioDeBaja.Location = new System.Drawing.Point(252, 130);
            this.AnioDeBaja.Margin = new System.Windows.Forms.Padding(2);
            this.AnioDeBaja.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.AnioDeBaja.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.AnioDeBaja.Name = "AnioDeBaja";
            this.AnioDeBaja.Size = new System.Drawing.Size(158, 38);
            this.AnioDeBaja.TabIndex = 71;
            this.AnioDeBaja.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 21.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 37);
            this.label2.TabIndex = 65;
            this.label2.Text = "Año";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(54, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 37);
            this.label9.TabIndex = 62;
            this.label9.Text = "Elegir Top 5";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 47);
            this.label1.TabIndex = 61;
            this.label1.Text = "Registros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbmListado2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 569);
            this.Controls.Add(this.panel1);
            this.Name = "AbmListado2";
            this.Text = "Clinica FRBA-Listados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnioDeBaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox semestre;
        private System.Windows.Forms.ComboBox top5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button BotonFiltrar;
        private System.Windows.Forms.NumericUpDown AnioDeBaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_consultas;


    }
}