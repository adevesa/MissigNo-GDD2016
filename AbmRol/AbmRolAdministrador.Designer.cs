namespace ClinicaFrba.AbmRol
{
    partial class AbmRolAdministrador
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
            this.botonRegistrarLlegada = new System.Windows.Forms.Button();
            this.botonComprarBono = new System.Windows.Forms.Button();
            this.botonCrearAfiliado = new System.Windows.Forms.Button();
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.botonCerrarSesion);
            this.panel1.Controls.Add(this.botonRegistrarLlegada);
            this.panel1.Controls.Add(this.botonComprarBono);
            this.panel1.Controls.Add(this.botonCrearAfiliado);
            this.panel1.Location = new System.Drawing.Point(11, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 569);
            this.panel1.TabIndex = 11;
            // 
            // botonRegistrarLlegada
            // 
            this.botonRegistrarLlegada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRegistrarLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarLlegada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonRegistrarLlegada.Location = new System.Drawing.Point(141, 347);
            this.botonRegistrarLlegada.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegistrarLlegada.Name = "botonRegistrarLlegada";
            this.botonRegistrarLlegada.Size = new System.Drawing.Size(493, 139);
            this.botonRegistrarLlegada.TabIndex = 22;
            this.botonRegistrarLlegada.Text = "Registrar llegada";
            this.botonRegistrarLlegada.UseVisualStyleBackColor = true;
            this.botonRegistrarLlegada.Click += new System.EventHandler(this.botonRegistrarLlegada_Click);
            // 
            // botonComprarBono
            // 
            this.botonComprarBono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonComprarBono.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonComprarBono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonComprarBono.Location = new System.Drawing.Point(141, 188);
            this.botonComprarBono.Margin = new System.Windows.Forms.Padding(2);
            this.botonComprarBono.Name = "botonComprarBono";
            this.botonComprarBono.Size = new System.Drawing.Size(493, 139);
            this.botonComprarBono.TabIndex = 21;
            this.botonComprarBono.Text = "Comprar bono a afiliado";
            this.botonComprarBono.UseVisualStyleBackColor = true;
            this.botonComprarBono.Click += new System.EventHandler(this.botonModificarAfiliado_Click);
            // 
            // botonCrearAfiliado
            // 
            this.botonCrearAfiliado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCrearAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearAfiliado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonCrearAfiliado.Location = new System.Drawing.Point(141, 25);
            this.botonCrearAfiliado.Margin = new System.Windows.Forms.Padding(2);
            this.botonCrearAfiliado.Name = "botonCrearAfiliado";
            this.botonCrearAfiliado.Size = new System.Drawing.Size(493, 139);
            this.botonCrearAfiliado.TabIndex = 20;
            this.botonCrearAfiliado.Text = "Administrar afiliado";
            this.botonCrearAfiliado.UseVisualStyleBackColor = true;
            this.botonCrearAfiliado.Click += new System.EventHandler(this.botonCrearAfiliado_Click);
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.botonCerrarSesion.Location = new System.Drawing.Point(313, 508);
            this.botonCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Size = new System.Drawing.Size(158, 46);
            this.botonCerrarSesion.TabIndex = 36;
            this.botonCerrarSesion.Text = "Cerrar sesión";
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // AbmRolAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmRolAdministrador";
            this.Text = "Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AbmRolAdministrador_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonRegistrarLlegada;
        private System.Windows.Forms.Button botonComprarBono;
        private System.Windows.Forms.Button botonCrearAfiliado;
        private System.Windows.Forms.Button botonCerrarSesion;
    }
}