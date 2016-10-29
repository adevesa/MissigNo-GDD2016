namespace ClinicaFrba
{
    partial class Logueo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IngresarContraseña = new System.Windows.Forms.TextBox();
            this.IngresarUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IniciarSesion);
            this.panel1.Controls.Add(this.IngresarUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IngresarContraseña);
            this.panel1.Location = new System.Drawing.Point(11, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 568);
            this.panel1.TabIndex = 8;
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarSesion.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IniciarSesion.Location = new System.Drawing.Point(293, 469);
            this.IniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(236, 73);
            this.IniciarSesion.TabIndex = 20;
            this.IniciarSesion.Text = "Iniciar sesión";
            this.IniciarSesion.UseVisualStyleBackColor = true;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(322, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 61);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(272, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 61);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contraseña";
            // 
            // IngresarContraseña
            // 
            this.IngresarContraseña.BackColor = System.Drawing.Color.White;
            this.IngresarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.IngresarContraseña.Location = new System.Drawing.Point(161, 367);
            this.IngresarContraseña.Name = "IngresarContraseña";
            this.IngresarContraseña.Size = new System.Drawing.Size(520, 44);
            this.IngresarContraseña.TabIndex = 3;
            this.IngresarContraseña.UseSystemPasswordChar = true;
            // 
            // IngresarUsuario
            // 
            this.IngresarUsuario.BackColor = System.Drawing.Color.White;
            this.IngresarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.IngresarUsuario.Location = new System.Drawing.Point(161, 214);
            this.IngresarUsuario.Name = "IngresarUsuario";
            this.IngresarUsuario.Size = new System.Drawing.Size(520, 44);
            this.IngresarUsuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 44);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bienvenido a la clínica FRBA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Logueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Logueo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica FRBA-Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Logueo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IngresarContraseña;
        private System.Windows.Forms.TextBox IngresarUsuario;
        private System.Windows.Forms.Label label3;
    }
}

