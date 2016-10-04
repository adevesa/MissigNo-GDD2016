namespace ClinicaFrba.AbmRol
{
    partial class AbmRolAfiliado
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
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            this.botonPedirTurno = new System.Windows.Forms.Button();
            this.botonComprarBonos = new System.Windows.Forms.Button();
            this.botonCancelarTurno = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.botonCerrarSesion);
            this.panel1.Controls.Add(this.botonPedirTurno);
            this.panel1.Controls.Add(this.botonComprarBonos);
            this.panel1.Controls.Add(this.botonCancelarTurno);
            this.panel1.Location = new System.Drawing.Point(11, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 569);
            this.panel1.TabIndex = 10;
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.botonCerrarSesion.Location = new System.Drawing.Point(319, 508);
            this.botonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Size = new System.Drawing.Size(158, 46);
            this.botonCerrarSesion.TabIndex = 35;
            this.botonCerrarSesion.Text = "Cerrar sesión";
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonPedirTurno
            // 
            this.botonPedirTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonPedirTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPedirTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonPedirTurno.Location = new System.Drawing.Point(141, 176);
            this.botonPedirTurno.Margin = new System.Windows.Forms.Padding(2);
            this.botonPedirTurno.Name = "botonPedirTurno";
            this.botonPedirTurno.Size = new System.Drawing.Size(493, 139);
            this.botonPedirTurno.TabIndex = 22;
            this.botonPedirTurno.Text = "Pedir turno";
            this.botonPedirTurno.UseVisualStyleBackColor = true;
            this.botonPedirTurno.Click += new System.EventHandler(this.botonPedirTurno_Click);
            // 
            // botonComprarBonos
            // 
            this.botonComprarBonos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonComprarBonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonComprarBonos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonComprarBonos.Location = new System.Drawing.Point(141, 24);
            this.botonComprarBonos.Margin = new System.Windows.Forms.Padding(2);
            this.botonComprarBonos.Name = "botonComprarBonos";
            this.botonComprarBonos.Size = new System.Drawing.Size(493, 139);
            this.botonComprarBonos.TabIndex = 21;
            this.botonComprarBonos.Text = "Comprar bonos";
            this.botonComprarBonos.UseVisualStyleBackColor = true;
            this.botonComprarBonos.Click += new System.EventHandler(this.botonModificarAfiliado_Click);
            // 
            // botonCancelarTurno
            // 
            this.botonCancelarTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonCancelarTurno.Location = new System.Drawing.Point(141, 332);
            this.botonCancelarTurno.Margin = new System.Windows.Forms.Padding(2);
            this.botonCancelarTurno.Name = "botonCancelarTurno";
            this.botonCancelarTurno.Size = new System.Drawing.Size(493, 139);
            this.botonCancelarTurno.TabIndex = 20;
            this.botonCancelarTurno.Text = "Cancelar turno";
            this.botonCancelarTurno.UseVisualStyleBackColor = true;
            this.botonCancelarTurno.Click += new System.EventHandler(this.botonCancelarTurno_Click);
            // 
            // AbmRolAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmRolAfiliado";
            this.Text = "Afiliado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AbmRolAfiliado_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonCerrarSesion;
        private System.Windows.Forms.Button botonPedirTurno;
        private System.Windows.Forms.Button botonComprarBonos;
        private System.Windows.Forms.Button botonCancelarTurno;
    }
}