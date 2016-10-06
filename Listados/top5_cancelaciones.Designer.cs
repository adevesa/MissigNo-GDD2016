namespace ClinicaFrba.Listados
{
    partial class top5_cancelaciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tipo_afiliado_profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad_cancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_cancelaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_afiliado_profesional,
            this.Especialidad_cancelacion,
            this.Numero_cancelaciones});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 186);
            this.dataGridView1.TabIndex = 0;
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
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 21.75F);
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(212, 203);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(153, 52);
            this.botonVolver.TabIndex = 118;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // top5_cancelaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 273);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.dataGridView1);
            this.Name = "top5_cancelaciones";
            this.Text = "Clinica FRBA-TOP 5 Cancelaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_afiliado_profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad_cancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_cancelaciones;
        private System.Windows.Forms.Button botonVolver;
    }
}