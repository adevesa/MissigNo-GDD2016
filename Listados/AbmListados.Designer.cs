namespace ClinicaFrba.Listados
{
    partial class AbmListados
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
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.AnioDeBaja = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnioDeBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.semestre);
            this.panel1.Controls.Add(this.top5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.botonVolver);
            this.panel1.Controls.Add(this.BotonBuscar);
            this.panel1.Controls.Add(this.AnioDeBaja);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 553);
            this.panel1.TabIndex = 1;
            // 
            // semestre
            // 
            this.semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestre.FormattingEnabled = true;
            this.semestre.Items.AddRange(new object[] {
            "Primer semestr",
            "Segundo semestre"});
            this.semestre.Location = new System.Drawing.Point(60, 345);
            this.semestre.Margin = new System.Windows.Forms.Padding(2);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(159, 40);
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
            this.top5.Location = new System.Drawing.Point(60, 159);
            this.top5.Margin = new System.Windows.Forms.Padding(2);
            this.top5.Name = "top5";
            this.top5.Size = new System.Drawing.Size(316, 33);
            this.top5.TabIndex = 119;
            this.top5.Text = "Elija uno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 21.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 306);
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
            this.botonVolver.Location = new System.Drawing.Point(252, 436);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(153, 52);
            this.botonVolver.TabIndex = 117;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonBuscar.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 21.75F);
            this.BotonBuscar.ForeColor = System.Drawing.Color.Black;
            this.BotonBuscar.Location = new System.Drawing.Point(60, 436);
            this.BotonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(153, 52);
            this.BotonBuscar.TabIndex = 116;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // AnioDeBaja
            // 
            this.AnioDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnioDeBaja.Location = new System.Drawing.Point(61, 250);
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
            this.label2.Location = new System.Drawing.Point(54, 211);
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
            this.label9.Location = new System.Drawing.Point(53, 120);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 42);
            this.label1.TabIndex = 61;
            this.label1.Text = "Registros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbmListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 562);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmListados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica FRBA-Listados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AbmListados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnioDeBaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.NumericUpDown AnioDeBaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox top5;
        private System.Windows.Forms.ComboBox semestre;
    }
}