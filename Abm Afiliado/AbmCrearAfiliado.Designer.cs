namespace ClinicaFrba.Abm_Afiliado
{
    partial class AbmEditarAfiliado
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.AnioDeBaja = new System.Windows.Forms.NumericUpDown();
            this.MesDeBaja = new System.Windows.Forms.NumericUpDown();
            this.DiaDeBaja = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.estadoCivil = new System.Windows.Forms.ComboBox();
            this.botonQuitar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.butonAgregar = new System.Windows.Forms.Button();
            this.textoTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonConfirmar2 = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.textoDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textoDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textoApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnioDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaDeBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AnioDeBaja);
            this.panel1.Controls.Add(this.MesDeBaja);
            this.panel1.Controls.Add(this.DiaDeBaja);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.estadoCivil);
            this.panel1.Controls.Add(this.botonQuitar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.butonAgregar);
            this.panel1.Controls.Add(this.textoTelefono);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BotonConfirmar2);
            this.panel1.Controls.Add(this.botonVolver);
            this.panel1.Controls.Add(this.textoDocumento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textoDireccion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textoApellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textoNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 744);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboBox2.Location = new System.Drawing.Point(602, 345);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(226, 28);
            this.comboBox2.TabIndex = 77;
            this.comboBox2.Text = "Sexo";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.comboBox1.Location = new System.Drawing.Point(602, 297);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 28);
            this.comboBox1.TabIndex = 60;
            this.comboBox1.Text = "Elija uno";
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
            this.dataGridView1.Location = new System.Drawing.Point(46, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 281);
            this.dataGridView1.TabIndex = 59;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "Asociar familiares";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnioDeBaja
            // 
            this.AnioDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnioDeBaja.Location = new System.Drawing.Point(319, 296);
            this.AnioDeBaja.Margin = new System.Windows.Forms.Padding(2);
            this.AnioDeBaja.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.AnioDeBaja.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.AnioDeBaja.Name = "AnioDeBaja";
            this.AnioDeBaja.Size = new System.Drawing.Size(61, 28);
            this.AnioDeBaja.TabIndex = 57;
            this.AnioDeBaja.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // MesDeBaja
            // 
            this.MesDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesDeBaja.Location = new System.Drawing.Point(255, 296);
            this.MesDeBaja.Margin = new System.Windows.Forms.Padding(2);
            this.MesDeBaja.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MesDeBaja.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MesDeBaja.Name = "MesDeBaja";
            this.MesDeBaja.Size = new System.Drawing.Size(34, 28);
            this.MesDeBaja.TabIndex = 56;
            this.MesDeBaja.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DiaDeBaja
            // 
            this.DiaDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaDeBaja.Location = new System.Drawing.Point(191, 296);
            this.DiaDeBaja.Margin = new System.Windows.Forms.Padding(2);
            this.DiaDeBaja.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.DiaDeBaja.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiaDeBaja.Name = "DiaDeBaja";
            this.DiaDeBaja.Size = new System.Drawing.Size(34, 28);
            this.DiaDeBaja.TabIndex = 55;
            this.DiaDeBaja.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(294, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 29);
            this.label12.TabIndex = 54;
            this.label12.Text = "/";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(230, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 29);
            this.label13.TabIndex = 53;
            this.label13.Text = "/";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // estadoCivil
            // 
            this.estadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivil.FormattingEnabled = true;
            this.estadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.estadoCivil.Location = new System.Drawing.Point(602, 186);
            this.estadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Size = new System.Drawing.Size(226, 28);
            this.estadoCivil.TabIndex = 52;
            this.estadoCivil.Text = "Elija uno";
            // 
            // botonQuitar
            // 
            this.botonQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.botonQuitar.ForeColor = System.Drawing.Color.Black;
            this.botonQuitar.Location = new System.Drawing.Point(718, 587);
            this.botonQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.botonQuitar.Name = "botonQuitar";
            this.botonQuitar.Size = new System.Drawing.Size(109, 46);
            this.botonQuitar.TabIndex = 51;
            this.botonQuitar.Text = "Quitar";
            this.botonQuitar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(41, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 29);
            this.label11.TabIndex = 50;
            this.label11.Text = "Nacimiento";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butonAgregar
            // 
            this.butonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.butonAgregar.ForeColor = System.Drawing.Color.Black;
            this.butonAgregar.Location = new System.Drawing.Point(719, 464);
            this.butonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.butonAgregar.Name = "butonAgregar";
            this.butonAgregar.Size = new System.Drawing.Size(109, 46);
            this.butonAgregar.TabIndex = 47;
            this.butonAgregar.Text = "Agregar";
            this.butonAgregar.UseVisualStyleBackColor = true;
            // 
            // textoTelefono
            // 
            this.textoTelefono.BackColor = System.Drawing.Color.White;
            this.textoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTelefono.Location = new System.Drawing.Point(601, 243);
            this.textoTelefono.Name = "textoTelefono";
            this.textoTelefono.Size = new System.Drawing.Size(226, 28);
            this.textoTelefono.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(456, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 29);
            this.label10.TabIndex = 40;
            this.label10.Text = "Plan médico";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(456, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Estado civíl";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(456, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Teléfono";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BotonConfirmar2
            // 
            this.BotonConfirmar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonConfirmar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConfirmar2.ForeColor = System.Drawing.Color.Black;
            this.BotonConfirmar2.Location = new System.Drawing.Point(235, 698);
            this.BotonConfirmar2.Margin = new System.Windows.Forms.Padding(2);
            this.BotonConfirmar2.Name = "BotonConfirmar2";
            this.BotonConfirmar2.Size = new System.Drawing.Size(109, 46);
            this.BotonConfirmar2.TabIndex = 35;
            this.BotonConfirmar2.Text = "Confirmar";
            this.BotonConfirmar2.UseVisualStyleBackColor = true;
            this.BotonConfirmar2.Click += new System.EventHandler(this.BotonConfirmar2_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(601, 698);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(109, 46);
            this.botonVolver.TabIndex = 34;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // textoDocumento
            // 
            this.textoDocumento.BackColor = System.Drawing.Color.White;
            this.textoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDocumento.Location = new System.Drawing.Point(191, 187);
            this.textoDocumento.Name = "textoDocumento";
            this.textoDocumento.Size = new System.Drawing.Size(234, 28);
            this.textoDocumento.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textoDireccion
            // 
            this.textoDireccion.BackColor = System.Drawing.Color.White;
            this.textoDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDireccion.Location = new System.Drawing.Point(191, 241);
            this.textoDireccion.Name = "textoDireccion";
            this.textoDireccion.Size = new System.Drawing.Size(234, 28);
            this.textoDireccion.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(41, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Dirección";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textoApellido
            // 
            this.textoApellido.BackColor = System.Drawing.Color.White;
            this.textoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoApellido.Location = new System.Drawing.Point(602, 132);
            this.textoApellido.Name = "textoApellido";
            this.textoApellido.Size = new System.Drawing.Size(226, 28);
            this.textoApellido.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(456, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nombre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textoNombre
            // 
            this.textoNombre.BackColor = System.Drawing.Color.White;
            this.textoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNombre.Location = new System.Drawing.Point(191, 130);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(234, 28);
            this.textoNombre.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 55);
            this.label1.TabIndex = 25;
            this.label1.Text = "Crear Afiliado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbmEditarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 766);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbmEditarAfiliado";
            this.Text = "Clinica FRBA-Crear Afiliado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AbmAfiliado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnioDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MesDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaDeBaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butonAgregar;
        private System.Windows.Forms.TextBox textoTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonConfirmar2;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TextBox textoDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textoDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textoApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoNombre;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox estadoCivil;
        private System.Windows.Forms.Button botonQuitar;
        private System.Windows.Forms.NumericUpDown AnioDeBaja;
        private System.Windows.Forms.NumericUpDown MesDeBaja;
        private System.Windows.Forms.NumericUpDown DiaDeBaja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}