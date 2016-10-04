namespace ClinicaFrba.AbmRol
{
    partial class AbmRolProfesional
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
            this.botonCrearAgenda = new System.Windows.Forms.Button();
            this.botonRegistrarResultados = new System.Windows.Forms.Button();
            this.botonCancelarTurno = new System.Windows.Forms.Button();
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.botonCerrarSesion);
            this.panel1.Controls.Add(this.botonCrearAgenda);
            this.panel1.Controls.Add(this.botonRegistrarResultados);
            this.panel1.Controls.Add(this.botonCancelarTurno);
            this.panel1.Location = new System.Drawing.Point(11, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 569);
            this.panel1.TabIndex = 11;
            // 
            // botonCrearAgenda
            // 
            this.botonCrearAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCrearAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearAgenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonCrearAgenda.Location = new System.Drawing.Point(141, 347);
            this.botonCrearAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.botonCrearAgenda.Name = "botonCrearAgenda";
            this.botonCrearAgenda.Size = new System.Drawing.Size(493, 139);
            this.botonCrearAgenda.TabIndex = 22;
            this.botonCrearAgenda.Text = "Crear agenda";
            this.botonCrearAgenda.UseVisualStyleBackColor = true;
            this.botonCrearAgenda.Click += new System.EventHandler(this.botonCrearAgenda_Click);
            // 
            // botonRegistrarResultados
            // 
            this.botonRegistrarResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRegistrarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarResultados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonRegistrarResultados.Location = new System.Drawing.Point(141, 188);
            this.botonRegistrarResultados.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegistrarResultados.Name = "botonRegistrarResultados";
            this.botonRegistrarResultados.Size = new System.Drawing.Size(493, 139);
            this.botonRegistrarResultados.TabIndex = 21;
            this.botonRegistrarResultados.Text = "Registrar resultados";
            this.botonRegistrarResultados.UseVisualStyleBackColor = true;
            this.botonRegistrarResultados.Click += new System.EventHandler(this.botonRegistrarResultados_Click);
            // 
            // botonCancelarTurno
            // 
            this.botonCancelarTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonCancelarTurno.Location = new System.Drawing.Point(141, 25);
            this.botonCancelarTurno.Margin = new System.Windows.Forms.Padding(2);
            this.botonCancelarTurno.Name = "botonCancelarTurno";
            this.botonCancelarTurno.Size = new System.Drawing.Size(493, 139);
            this.botonCancelarTurno.TabIndex = 20;
            this.botonCancelarTurno.Text = "Cancelar turno";
            this.botonCancelarTurno.UseVisualStyleBackColor = true;
            this.botonCancelarTurno.Click += new System.EventHandler(this.botonCrearAfiliado_Click);
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.botonCerrarSesion.Location = new System.Drawing.Point(318, 510);
            this.botonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Size = new System.Drawing.Size(158, 46);
            this.botonCerrarSesion.TabIndex = 36;
            this.botonCerrarSesion.Text = "Cerrar sesión";
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // AbmRolProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmRolProfesional";
            this.Text = "Profesional";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AbmRolProfesional_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonCrearAgenda;
        private System.Windows.Forms.Button botonRegistrarResultados;
        private System.Windows.Forms.Button botonCancelarTurno;
        private System.Windows.Forms.Button botonCerrarSesion;
    }
}