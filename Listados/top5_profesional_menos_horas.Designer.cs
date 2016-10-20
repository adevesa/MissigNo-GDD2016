namespace ClinicaFrba.Listados
{
    partial class top5_profesional_menos_horas
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
            this.Plan_profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad_cancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(197, 203);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(153, 52);
            this.botonVolver.TabIndex = 120;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plan_profesional,
            this.Especialidad_cancelacion,
            this.profesional,
            this.Numero_horas});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 186);
            this.dataGridView1.TabIndex = 119;
            // 
            // Plan_profesional
            // 
            this.Plan_profesional.HeaderText = "Plan";
            this.Plan_profesional.Name = "Plan_profesional";
            this.Plan_profesional.ReadOnly = true;
            // 
            // Especialidad_cancelacion
            // 
            this.Especialidad_cancelacion.HeaderText = "Especialidad";
            this.Especialidad_cancelacion.Name = "Especialidad_cancelacion";
            this.Especialidad_cancelacion.ReadOnly = true;
            this.Especialidad_cancelacion.Width = 200;
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
            // top5_profesional_menos_horas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 264);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "top5_profesional_menos_horas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica FRBA-Top 5 Profesionales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan_profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad_cancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_horas;
    }
}