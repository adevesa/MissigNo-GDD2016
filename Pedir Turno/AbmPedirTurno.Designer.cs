namespace ClinicaFrba.Cancelar_Atencion
{
    partial class AbmPedirTurno
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
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bono = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bono);
            this.panel1.Controls.Add(this.dgvEspecialidades);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.botonVolver);
            this.panel1.Controls.Add(this.botonAceptar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 558);
            this.panel1.TabIndex = 0;
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Location = new System.Drawing.Point(415, 158);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.Size = new System.Drawing.Size(240, 294);
            this.dgvEspecialidades.TabIndex = 73;
            this.dgvEspecialidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidades_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(415, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 37);
            this.label2.TabIndex = 72;
            this.label2.Text = "Especialidades:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(190, 481);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(172, 50);
            this.botonVolver.TabIndex = 50;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.botonAceptar.ForeColor = System.Drawing.Color.Black;
            this.botonAceptar.Location = new System.Drawing.Point(402, 481);
            this.botonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(172, 50);
            this.botonAceptar.TabIndex = 49;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pedido de Turno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bono
            // 
            this.bono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bono.FormattingEnabled = true;
            this.bono.Location = new System.Drawing.Point(137, 172);
            this.bono.Name = "bono";
            this.bono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bono.Size = new System.Drawing.Size(225, 33);
            this.bono.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(130, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 37);
            this.label3.TabIndex = 102;
            this.label3.Text = "Elegir bono";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbmPedirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmPedirTurno";
            this.Text = "Clinica FRBA-Pedir Turno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AbmPedirTurno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bono;
    }
}