namespace ClinicaFrba.Compra_Bono
{
    partial class ComprarBonoDesdeAdministrador
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
            this.textoCantidadDeBonos = new System.Windows.Forms.TextBox();
            this.boxUserAfiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConfirmar.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmar.ForeColor = System.Drawing.Color.Black;
            this.botonConfirmar.Location = new System.Drawing.Point(110, 284);
            this.botonConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(141, 50);
            this.botonConfirmar.TabIndex = 68;
            this.botonConfirmar.Text = "Confirmar";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // textoCantidadDeBonos
            // 
            this.textoCantidadDeBonos.BackColor = System.Drawing.Color.White;
            this.textoCantidadDeBonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCantidadDeBonos.Location = new System.Drawing.Point(380, 189);
            this.textoCantidadDeBonos.Name = "textoCantidadDeBonos";
            this.textoCantidadDeBonos.Size = new System.Drawing.Size(192, 38);
            this.textoCantidadDeBonos.TabIndex = 67;
            this.textoCantidadDeBonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoCantidadDeBonos.TextChanged += new System.EventHandler(this.textoCantidadDeBonos_TextChanged);
            this.textoCantidadDeBonos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoCantidadesDeBonos_KeyPress);
            // 
            // boxUserAfiliado
            // 
            this.boxUserAfiliado.BackColor = System.Drawing.Color.White;
            this.boxUserAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUserAfiliado.Location = new System.Drawing.Point(299, 92);
            this.boxUserAfiliado.Name = "boxUserAfiliado";
            this.boxUserAfiliado.Size = new System.Drawing.Size(273, 38);
            this.boxUserAfiliado.TabIndex = 69;
            this.boxUserAfiliado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxUserAfiliado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 41);
            this.label1.TabIndex = 66;
            this.label1.Text = "Comprar bonos a afiliado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 41);
            this.label8.TabIndex = 70;
            this.label8.Text = "Username Afiliado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 24F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 41);
            this.label2.TabIndex = 71;
            this.label2.Text = "Cantidad de Bonos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F);
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(316, 284);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(141, 50);
            this.botonVolver.TabIndex = 72;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComprarBonoDesdeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 366);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxUserAfiliado);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.textoCantidadDeBonos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ComprarBonoDesdeAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica FRBA- Compra Bonos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.TextBox textoCantidadDeBonos;
        private System.Windows.Forms.TextBox boxUserAfiliado;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonVolver;
    }
}