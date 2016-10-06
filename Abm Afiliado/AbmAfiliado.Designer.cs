namespace ClinicaFrba.Abm_Afiliado
{
    partial class AbmAdministrarAfiliado
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
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonBorrarAfiliado = new System.Windows.Forms.Button();
            this.botonModificarAfiliado = new System.Windows.Forms.Button();
            this.botonCrearAfiliado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.botonVolver);
            this.panel1.Controls.Add(this.botonBorrarAfiliado);
            this.panel1.Controls.Add(this.botonModificarAfiliado);
            this.panel1.Controls.Add(this.botonCrearAfiliado);
            this.panel1.Location = new System.Drawing.Point(11, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 529);
            this.panel1.TabIndex = 9;
            // 
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(343, 483);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(109, 46);
            this.botonVolver.TabIndex = 35;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonBorrarAfiliado
            // 
            this.botonBorrarAfiliado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBorrarAfiliado.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 36F);
            this.botonBorrarAfiliado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonBorrarAfiliado.Location = new System.Drawing.Point(141, 324);
            this.botonBorrarAfiliado.Margin = new System.Windows.Forms.Padding(2);
            this.botonBorrarAfiliado.Name = "botonBorrarAfiliado";
            this.botonBorrarAfiliado.Size = new System.Drawing.Size(493, 139);
            this.botonBorrarAfiliado.TabIndex = 22;
            this.botonBorrarAfiliado.Text = "Borrar Afiliado";
            this.botonBorrarAfiliado.UseVisualStyleBackColor = true;
            this.botonBorrarAfiliado.Click += new System.EventHandler(this.botonBorrarAfiliado_Click);
            // 
            // botonModificarAfiliado
            // 
            this.botonModificarAfiliado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonModificarAfiliado.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 36F);
            this.botonModificarAfiliado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonModificarAfiliado.Location = new System.Drawing.Point(141, 165);
            this.botonModificarAfiliado.Margin = new System.Windows.Forms.Padding(2);
            this.botonModificarAfiliado.Name = "botonModificarAfiliado";
            this.botonModificarAfiliado.Size = new System.Drawing.Size(493, 139);
            this.botonModificarAfiliado.TabIndex = 21;
            this.botonModificarAfiliado.Text = "Modificar Afiliado";
            this.botonModificarAfiliado.UseVisualStyleBackColor = true;
            this.botonModificarAfiliado.Click += new System.EventHandler(this.botonModificarAfiliado_Click);
            // 
            // botonCrearAfiliado
            // 
            this.botonCrearAfiliado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCrearAfiliado.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearAfiliado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonCrearAfiliado.Location = new System.Drawing.Point(141, 2);
            this.botonCrearAfiliado.Margin = new System.Windows.Forms.Padding(2);
            this.botonCrearAfiliado.Name = "botonCrearAfiliado";
            this.botonCrearAfiliado.Size = new System.Drawing.Size(493, 139);
            this.botonCrearAfiliado.TabIndex = 20;
            this.botonCrearAfiliado.Text = "Crear Afiliado";
            this.botonCrearAfiliado.UseVisualStyleBackColor = true;
            this.botonCrearAfiliado.Click += new System.EventHandler(this.botonCrearAfiliado_Click);
            // 
            // AbmAdministrarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmAdministrarAfiliado";
            this.Text = "Clinica FRBA - Afiliado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AbmAfiliado_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonBorrarAfiliado;
        private System.Windows.Forms.Button botonModificarAfiliado;
        private System.Windows.Forms.Button botonCrearAfiliado;
        private System.Windows.Forms.Button botonVolver;
    }
}