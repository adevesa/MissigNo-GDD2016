﻿namespace ClinicaFrba.Abm_Afiliado
{
    partial class AbmConsultaFamiliar
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
            this.eleccionSexo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonQuitar = new System.Windows.Forms.Button();
            this.butonAgregar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmar.ForeColor = System.Drawing.Color.Black;
            this.botonConfirmar.Location = new System.Drawing.Point(487, 467);
            this.botonConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(109, 46);
            this.botonConfirmar.TabIndex = 94;
            this.botonConfirmar.Text = "Confirmar";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // eleccionSexo
            // 
            this.eleccionSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eleccionSexo.FormattingEnabled = true;
            this.eleccionSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.eleccionSexo.Location = new System.Drawing.Point(444, -36);
            this.eleccionSexo.Name = "eleccionSexo";
            this.eleccionSexo.Size = new System.Drawing.Size(226, 28);
            this.eleccionSexo.TabIndex = 93;
            this.eleccionSexo.Text = "Sexo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.ID,
            this.Sexo});
            this.dataGridView1.Location = new System.Drawing.Point(51, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 296);
            this.dataGridView1.TabIndex = 92;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // botonQuitar
            // 
            this.botonQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.botonQuitar.ForeColor = System.Drawing.Color.Black;
            this.botonQuitar.Location = new System.Drawing.Point(617, 295);
            this.botonQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.botonQuitar.Name = "botonQuitar";
            this.botonQuitar.Size = new System.Drawing.Size(109, 46);
            this.botonQuitar.TabIndex = 91;
            this.botonQuitar.Text = "Quitar";
            this.botonQuitar.UseVisualStyleBackColor = true;
            // 
            // butonAgregar
            // 
            this.butonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.butonAgregar.ForeColor = System.Drawing.Color.Black;
            this.butonAgregar.Location = new System.Drawing.Point(617, 141);
            this.butonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.butonAgregar.Name = "butonAgregar";
            this.butonAgregar.Size = new System.Drawing.Size(109, 46);
            this.butonAgregar.TabIndex = 90;
            this.butonAgregar.Text = "Agregar";
            this.butonAgregar.UseVisualStyleBackColor = true;
            this.butonAgregar.Click += new System.EventHandler(this.butonAgregar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(248, 467);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(109, 46);
            this.botonVolver.TabIndex = 89;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 37);
            this.label4.TabIndex = 95;
            this.label4.Text = "Asociar familiares";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.botonConfirmar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.botonVolver);
            this.panel1.Controls.Add(this.botonQuitar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.butonAgregar);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 542);
            this.panel1.TabIndex = 96;
            // 
            // AbmConsultaFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eleccionSexo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmConsultaFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbmConsultaFamiliar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AbmConsultaFamiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.ComboBox eleccionSexo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.Button botonQuitar;
        private System.Windows.Forms.Button butonAgregar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}