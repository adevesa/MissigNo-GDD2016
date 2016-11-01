namespace ClinicaFrba.Compra_Bono
{
    partial class AbmComprarBono
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConfirmar.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmar.ForeColor = System.Drawing.Color.Black;
            this.botonConfirmar.Location = new System.Drawing.Point(221, 444);
            this.botonConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(151, 64);
            this.botonConfirmar.TabIndex = 65;
            this.botonConfirmar.Text = "Confirmar";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // textoCantidadDeBonos
            // 
            this.textoCantidadDeBonos.BackColor = System.Drawing.Color.White;
            this.textoCantidadDeBonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCantidadDeBonos.Location = new System.Drawing.Point(39, 122);
            this.textoCantidadDeBonos.Name = "textoCantidadDeBonos";
            this.textoCantidadDeBonos.Size = new System.Drawing.Size(521, 62);
            this.textoCantidadDeBonos.TabIndex = 64;
            this.textoCantidadDeBonos.Text = "Ingrese un número";
            this.textoCantidadDeBonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoCantidadDeBonos.TextChanged += new System.EventHandler(this.textoCantidadDeBonos_TextChanged);
            this.textoCantidadDeBonos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoCantidadesDeBonos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 47);
            this.label1.TabIndex = 63;
            this.label1.Text = "Cantidad de bonos a comprar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(112, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 47);
            this.label2.TabIndex = 66;
            this.label2.Text = "Para usuario(opcional)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxUsuario
            // 
            this.boxUsuario.BackColor = System.Drawing.Color.White;
            this.boxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUsuario.Location = new System.Drawing.Point(39, 286);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(521, 62);
            this.boxUsuario.TabIndex = 67;
            this.boxUsuario.Text = "Ingrese un username";
            this.boxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AbmComprarBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 519);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.textoCantidadDeBonos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmComprarBono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica FRBA-Comprar Bono";
            this.Load += new System.EventHandler(this.AbmComprarBono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.TextBox textoCantidadDeBonos;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxUsuario;
    }
}