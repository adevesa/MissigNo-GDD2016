namespace ClinicaFrba.Abm_Afiliado
{
    partial class HistorialAfiliado
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
            this.botonVolver = new System.Windows.Forms.Button();
            this.eleccionSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAfiliadoHistorial = new System.Windows.Forms.DataGridView();
            this.botonFiltrar = new System.Windows.Forms.Button();
            this.textoUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliadoHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(653, 444);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(109, 46);
            this.botonVolver.TabIndex = 94;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // eleccionSexo
            // 
            this.eleccionSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eleccionSexo.FormattingEnabled = true;
            this.eleccionSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.eleccionSexo.Location = new System.Drawing.Point(491, -41);
            this.eleccionSexo.Name = "eleccionSexo";
            this.eleccionSexo.Size = new System.Drawing.Size(226, 28);
            this.eleccionSexo.TabIndex = 97;
            this.eleccionSexo.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 37);
            this.label4.TabIndex = 95;
            this.label4.Text = "Historial de Afiliado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textoUsername);
            this.panel1.Controls.Add(this.botonFiltrar);
            this.panel1.Controls.Add(this.dgvAfiliadoHistorial);
            this.panel1.Controls.Add(this.botonVolver);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(48, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 542);
            this.panel1.TabIndex = 98;
            // 
            // dgvAfiliadoHistorial
            // 
            this.dgvAfiliadoHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfiliadoHistorial.Location = new System.Drawing.Point(10, 218);
            this.dgvAfiliadoHistorial.MultiSelect = false;
            this.dgvAfiliadoHistorial.Name = "dgvAfiliadoHistorial";
            this.dgvAfiliadoHistorial.ReadOnly = true;
            this.dgvAfiliadoHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAfiliadoHistorial.Size = new System.Drawing.Size(557, 272);
            this.dgvAfiliadoHistorial.TabIndex = 96;
            // 
            // botonFiltrar
            // 
            this.botonFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.botonFiltrar.ForeColor = System.Drawing.Color.Black;
            this.botonFiltrar.Location = new System.Drawing.Point(595, 87);
            this.botonFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.botonFiltrar.Name = "botonFiltrar";
            this.botonFiltrar.Size = new System.Drawing.Size(109, 46);
            this.botonFiltrar.TabIndex = 97;
            this.botonFiltrar.Text = "Filtrar";
            this.botonFiltrar.UseVisualStyleBackColor = true;
            this.botonFiltrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // textoUsername
            // 
            this.textoUsername.BackColor = System.Drawing.Color.White;
            this.textoUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoUsername.Location = new System.Drawing.Point(10, 87);
            this.textoUsername.Name = "textoUsername";
            this.textoUsername.Size = new System.Drawing.Size(557, 44);
            this.textoUsername.TabIndex = 98;
            this.textoUsername.Text = "ingrese username";
            this.textoUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoUsername.TextChanged += new System.EventHandler(this.textoUsername_TextChanged);
            // 
            // HistorialAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 509);
            this.Controls.Add(this.eleccionSexo);
            this.Controls.Add(this.panel1);
            this.Name = "HistorialAfiliado";
            this.Text = "Clinica FRBA- Historial de Afiliado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliadoHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.ComboBox eleccionSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvAfiliadoHistorial;
        private System.Windows.Forms.Button botonFiltrar;
        private System.Windows.Forms.TextBox textoUsername;
    }
}