namespace ClinicaFrba.Listados
{
    partial class top5_afiliados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_bonos_comprados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pertenece_grupo_familiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 21.75F);
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(204, 203);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(153, 52);
            this.botonVolver.TabIndex = 122;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 186);
            this.dataGridView1.TabIndex = 121;
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
            // top5_afiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 268);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.dataGridView1);
            this.Name = "top5_afiliados";
            this.Text = "Clinica FRBA-Top 5 Afiliados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_bonos_comprados;
        private System.Windows.Forms.DataGridViewTextBoxColumn pertenece_grupo_familiar;
    }
}