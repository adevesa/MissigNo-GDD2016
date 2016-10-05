namespace ClinicaFrba.Pedir_Turno
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
            this.textoIDTurno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoTipoCancelacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoMotivo = new System.Windows.Forms.TextBox();
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
            // textoIDTurno
            // 
            this.textoIDTurno.BackColor = System.Drawing.Color.White;
            this.textoIDTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoIDTurno.Location = new System.Drawing.Point(94, 80);
            this.textoIDTurno.Name = "textoIDTurno";
            this.textoIDTurno.Size = new System.Drawing.Size(391, 47);
            this.textoIDTurno.TabIndex = 64;
            this.textoIDTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 42);
            this.label1.TabIndex = 63;
            this.label1.Text = "ID de turno a cancelar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textoTipoCancelacion
            // 
            this.textoTipoCancelacion.BackColor = System.Drawing.Color.White;
            this.textoTipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTipoCancelacion.Location = new System.Drawing.Point(286, 163);
            this.textoTipoCancelacion.Name = "textoTipoCancelacion";
            this.textoTipoCancelacion.Size = new System.Drawing.Size(245, 31);
            this.textoTipoCancelacion.TabIndex = 66;
            this.textoTipoCancelacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 29);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tipo de cancelacion";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 68;
            this.label2.Text = "Motivo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textoMotivo
            // 
            this.textoMotivo.Location = new System.Drawing.Point(40, 270);
            this.textoMotivo.Multiline = true;
            this.textoMotivo.Name = "textoMotivo";
            this.textoMotivo.Size = new System.Drawing.Size(491, 96);
            this.textoMotivo.TabIndex = 70;
            this.textoMotivo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // AbmCancelarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaFrba.Properties.Resources.silver_light_blue_wave_abstract_backgrounds_powerpoint;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 456);
            this.Controls.Add(this.textoMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textoTipoCancelacion);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.textoIDTurno);
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
        private System.Windows.Forms.TextBox textoIDTurno;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoTipoCancelacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoMotivo;
    }
}