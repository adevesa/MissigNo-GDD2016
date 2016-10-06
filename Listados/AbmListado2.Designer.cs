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
            this.semestre = new System.Windows.Forms.ComboBox();
            this.top5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.BotonFiltrar = new System.Windows.Forms.Button();
            this.AnioDeBaja = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_bonos_comprados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pertenece_grupo_familiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Tipo_afiliado_profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad_cancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_cancelaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_consultas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Plan_profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnioDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dataGridView5);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView4);
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
            // semestre
            // 
            this.semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestre.FormattingEnabled = true;
            this.semestre.Items.AddRange(new object[] {
            "Primer semestr",
            "Segundo semestre"});
            this.semestre.Location = new System.Drawing.Point(252, 182);
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
            this.top5.Location = new System.Drawing.Point(252, 89);
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
            this.label3.Location = new System.Drawing.Point(53, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 37);
            this.label3.TabIndex = 118;
            this.label3.Text = "Semestre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.AnioDeBaja.Location = new System.Drawing.Point(252, 132);
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
            this.label9.Location = new System.Drawing.Point(53, 83);
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
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 47);
            this.label1.TabIndex = 61;
            this.label1.Text = "Registros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.afiliado,
            this.cant_bonos_comprados,
            this.pertenece_grupo_familiar});
            this.dataGridView1.Location = new System.Drawing.Point(32, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 186);
            this.dataGridView1.TabIndex = 122;
            // 
            // afiliado
            // 
            this.afiliado.HeaderText = "Afiliado";
            this.afiliado.Name = "afiliado";
            this.afiliado.ReadOnly = true;
            // 
            // cant_bonos_comprados
            // 
            this.cant_bonos_comprados.HeaderText = "Cantidad Bonos";
            this.cant_bonos_comprados.Name = "cant_bonos_comprados";
            this.cant_bonos_comprados.ReadOnly = true;
            this.cant_bonos_comprados.Width = 200;
            // 
            // pertenece_grupo_familiar
            // 
            this.pertenece_grupo_familiar.HeaderText = "Pertenece a grupo familiar";
            this.pertenece_grupo_familiar.Name = "pertenece_grupo_familiar";
            this.pertenece_grupo_familiar.ReadOnly = true;
            this.pertenece_grupo_familiar.Width = 200;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_afiliado_profesional,
            this.Especialidad_cancelacion,
            this.Numero_cancelaciones});
            this.dataGridView2.Location = new System.Drawing.Point(32, 283);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(546, 186);
            this.dataGridView2.TabIndex = 123;
            // 
            // Tipo_afiliado_profesional
            // 
            this.Tipo_afiliado_profesional.HeaderText = "Tipo";
            this.Tipo_afiliado_profesional.Name = "Tipo_afiliado_profesional";
            this.Tipo_afiliado_profesional.ReadOnly = true;
            // 
            // Especialidad_cancelacion
            // 
            this.Especialidad_cancelacion.HeaderText = "Especialidad";
            this.Especialidad_cancelacion.Name = "Especialidad_cancelacion";
            this.Especialidad_cancelacion.ReadOnly = true;
            this.Especialidad_cancelacion.Width = 300;
            // 
            // Numero_cancelaciones
            // 
            this.Numero_cancelaciones.HeaderText = "Cancelaciones";
            this.Numero_cancelaciones.Name = "Numero_cancelaciones";
            this.Numero_cancelaciones.ReadOnly = true;
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
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView4.Location = new System.Drawing.Point(32, 283);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(546, 186);
            this.dataGridView4.TabIndex = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Especialidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Numero de consultas utilizados";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plan_profesional,
            this.dataGridViewTextBoxColumn4,
            this.profesional,
            this.Numero_horas});
            this.dataGridView5.Location = new System.Drawing.Point(32, 283);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(546, 186);
            this.dataGridView5.TabIndex = 126;
            // 
            // Plan_profesional
            // 
            this.Plan_profesional.HeaderText = "Plan";
            this.Plan_profesional.Name = "Plan_profesional";
            this.Plan_profesional.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Especialidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // profesional
            // 
            this.profesional.HeaderText = "Profesional";
            this.profesional.Name = "profesional";
            this.profesional.ReadOnly = true;
            // 
            // Numero_horas
            // 
            this.Numero_horas.HeaderText = "Horas";
            this.Numero_horas.Name = "Numero_horas";
            this.Numero_horas.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.AnioDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_bonos_comprados;
        private System.Windows.Forms.DataGridViewTextBoxColumn pertenece_grupo_familiar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_afiliado_profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad_cancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_cancelaciones;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_consultas;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan_profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_horas;


    }
}