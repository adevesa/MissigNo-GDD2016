namespace ClinicaFrba.Cancelar_Atencion
{
    partial class AbmCancelarTurno
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
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoMotivo = new System.Windows.Forms.TextBox();
            this.textoIDTurno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoCancelacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmar.ForeColor = System.Drawing.Color.Black;
            this.botonConfirmar.Location = new System.Drawing.Point(218, 371);
            this.botonConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(151, 64);
            this.botonConfirmar.TabIndex = 65;
            this.botonConfirmar.Text = "Confirmar";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 63;
            this.label1.Text = "N° Turno a cancelar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 68;
            this.label2.Text = "Motivo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textoMotivo
            // 
            this.textoMotivo.Location = new System.Drawing.Point(40, 270);
            this.textoMotivo.Multiline = true;
            this.textoMotivo.Name = "textoMotivo";
            this.textoMotivo.Size = new System.Drawing.Size(491, 96);
            this.textoMotivo.TabIndex = 70;
            this.textoMotivo.Text = "Escriba el motivo...";
            this.textoMotivo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textoIDTurno
            // 
            this.textoIDTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textoIDTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoIDTurno.FormattingEnabled = true;
            this.textoIDTurno.Location = new System.Drawing.Point(131, 74);
            this.textoIDTurno.Name = "textoIDTurno";
            this.textoIDTurno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textoIDTurno.Size = new System.Drawing.Size(298, 37);
            this.textoIDTurno.TabIndex = 98;
            this.textoIDTurno.SelectedIndexChanged += new System.EventHandler(this.textoIDTurno_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 29);
            this.label3.TabIndex = 99;
            this.label3.Text = "Tipo de cancelación";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tipoCancelacion
            // 
            this.tipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCancelacion.Location = new System.Drawing.Point(41, 174);
            this.tipoCancelacion.Name = "tipoCancelacion";
            this.tipoCancelacion.Size = new System.Drawing.Size(473, 47);
            this.tipoCancelacion.TabIndex = 100;
            this.tipoCancelacion.TextChanged += new System.EventHandler(this.tipoCancelacion_TextChanged);
            // 
            // AbmCancelarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 456);
            this.Controls.Add(this.tipoCancelacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoIDTurno);
            this.Controls.Add(this.textoMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmCancelarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Turno";
            this.Load += new System.EventHandler(this.Cancelar_Turno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConfirmar;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoMotivo;
        private System.Windows.Forms.ComboBox textoIDTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tipoCancelacion;
    }
}