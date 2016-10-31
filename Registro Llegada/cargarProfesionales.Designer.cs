namespace ClinicaFrba.Registro_Llegada
{
    partial class cargarProfesionales
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
            this.label2 = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.dgvProfesionales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 37);
            this.label2.TabIndex = 62;
            this.label2.Text = "Elegir profesional";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.ForeColor = System.Drawing.Color.Black;
            this.botonAceptar.Location = new System.Drawing.Point(141, 494);
            this.botonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(150, 61);
            this.botonAceptar.TabIndex = 71;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // dgvProfesionales
            // 
            this.dgvProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesionales.Location = new System.Drawing.Point(56, 96);
            this.dgvProfesionales.Name = "dgvProfesionales";
            this.dgvProfesionales.Size = new System.Drawing.Size(317, 366);
            this.dgvProfesionales.TabIndex = 72;
            this.dgvProfesionales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfecionales_CellClick);
            this.dgvProfesionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfecionales_CellContentClick);
            // 
            // cargarProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 566);
            this.Controls.Add(this.dgvProfesionales);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "cargarProfesionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cargarProfecionales";
            this.Load += new System.EventHandler(this.cargarProfecionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.DataGridView dgvProfesionales;
    }
}