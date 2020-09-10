namespace AmaurysAutoSong
{
    partial class usuarioscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarioscs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtconfirmarPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chInventario = new System.Windows.Forms.CheckBox();
            this.chReportes = new System.Windows.Forms.CheckBox();
            this.chCategorias = new System.Windows.Forms.CheckBox();
            this.chVentas = new System.Windows.Forms.CheckBox();
            this.chProductos = new System.Windows.Forms.CheckBox();
            this.chCompas = new System.Windows.Forms.CheckBox();
            this.chComprobantes = new System.Windows.Forms.CheckBox();
            this.chproveedores = new System.Windows.Forms.CheckBox();
            this.chClientes = new System.Windows.Forms.CheckBox();
            this.chUsuarios = new System.Windows.Forms.CheckBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbuscaruser = new System.Windows.Forms.TextBox();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(3, 9);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 10;
            this.txtid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(394, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.txtconfirmarPass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtapellido);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 175);
            this.panel1.TabIndex = 20;
            // 
            // txtconfirmarPass
            // 
            this.txtconfirmarPass.Location = new System.Drawing.Point(199, 134);
            this.txtconfirmarPass.Name = "txtconfirmarPass";
            this.txtconfirmarPass.PasswordChar = '*';
            this.txtconfirmarPass.Size = new System.Drawing.Size(184, 20);
            this.txtconfirmarPass.TabIndex = 27;
            this.txtconfirmarPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtconfirmarPass_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Confirmar Password:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chInventario);
            this.groupBox1.Controls.Add(this.chReportes);
            this.groupBox1.Controls.Add(this.chCategorias);
            this.groupBox1.Controls.Add(this.chVentas);
            this.groupBox1.Controls.Add(this.chProductos);
            this.groupBox1.Controls.Add(this.chCompas);
            this.groupBox1.Controls.Add(this.chComprobantes);
            this.groupBox1.Controls.Add(this.chproveedores);
            this.groupBox1.Controls.Add(this.chClientes);
            this.groupBox1.Controls.Add(this.chUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(422, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 130);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accesos";
            // 
            // chInventario
            // 
            this.chInventario.AutoSize = true;
            this.chInventario.BackColor = System.Drawing.Color.Transparent;
            this.chInventario.ForeColor = System.Drawing.Color.Black;
            this.chInventario.Location = new System.Drawing.Point(320, 26);
            this.chInventario.Name = "chInventario";
            this.chInventario.Size = new System.Drawing.Size(116, 24);
            this.chInventario.TabIndex = 9;
            this.chInventario.Text = "Inventario";
            this.chInventario.UseVisualStyleBackColor = false;
            // 
            // chReportes
            // 
            this.chReportes.AutoSize = true;
            this.chReportes.BackColor = System.Drawing.Color.Transparent;
            this.chReportes.ForeColor = System.Drawing.Color.Black;
            this.chReportes.Location = new System.Drawing.Point(320, 53);
            this.chReportes.Name = "chReportes";
            this.chReportes.Size = new System.Drawing.Size(103, 24);
            this.chReportes.TabIndex = 8;
            this.chReportes.Text = "Reportes";
            this.chReportes.UseVisualStyleBackColor = false;
            // 
            // chCategorias
            // 
            this.chCategorias.AutoSize = true;
            this.chCategorias.BackColor = System.Drawing.Color.Transparent;
            this.chCategorias.ForeColor = System.Drawing.Color.Black;
            this.chCategorias.Location = new System.Drawing.Point(320, 83);
            this.chCategorias.Name = "chCategorias";
            this.chCategorias.Size = new System.Drawing.Size(118, 24);
            this.chCategorias.TabIndex = 7;
            this.chCategorias.Text = "Categorias";
            this.chCategorias.UseVisualStyleBackColor = false;
            // 
            // chVentas
            // 
            this.chVentas.AutoSize = true;
            this.chVentas.BackColor = System.Drawing.Color.Transparent;
            this.chVentas.ForeColor = System.Drawing.Color.Black;
            this.chVentas.Location = new System.Drawing.Point(153, 83);
            this.chVentas.Name = "chVentas";
            this.chVentas.Size = new System.Drawing.Size(86, 24);
            this.chVentas.TabIndex = 6;
            this.chVentas.Text = "Ventas";
            this.chVentas.UseVisualStyleBackColor = false;
            // 
            // chProductos
            // 
            this.chProductos.AutoSize = true;
            this.chProductos.BackColor = System.Drawing.Color.Transparent;
            this.chProductos.ForeColor = System.Drawing.Color.Black;
            this.chProductos.Location = new System.Drawing.Point(440, 26);
            this.chProductos.Name = "chProductos";
            this.chProductos.Size = new System.Drawing.Size(114, 24);
            this.chProductos.TabIndex = 5;
            this.chProductos.Text = "Productos";
            this.chProductos.UseVisualStyleBackColor = false;
            // 
            // chCompas
            // 
            this.chCompas.AutoSize = true;
            this.chCompas.BackColor = System.Drawing.Color.Transparent;
            this.chCompas.ForeColor = System.Drawing.Color.Black;
            this.chCompas.Location = new System.Drawing.Point(153, 53);
            this.chCompas.Name = "chCompas";
            this.chCompas.Size = new System.Drawing.Size(104, 24);
            this.chCompas.TabIndex = 4;
            this.chCompas.Text = "Compras";
            this.chCompas.UseVisualStyleBackColor = false;
            // 
            // chComprobantes
            // 
            this.chComprobantes.AutoSize = true;
            this.chComprobantes.BackColor = System.Drawing.Color.Transparent;
            this.chComprobantes.ForeColor = System.Drawing.Color.Black;
            this.chComprobantes.Location = new System.Drawing.Point(153, 26);
            this.chComprobantes.Name = "chComprobantes";
            this.chComprobantes.Size = new System.Drawing.Size(152, 24);
            this.chComprobantes.TabIndex = 3;
            this.chComprobantes.Text = "Comprobantes";
            this.chComprobantes.UseVisualStyleBackColor = false;
            // 
            // chproveedores
            // 
            this.chproveedores.AutoSize = true;
            this.chproveedores.BackColor = System.Drawing.Color.Transparent;
            this.chproveedores.ForeColor = System.Drawing.Color.Black;
            this.chproveedores.Location = new System.Drawing.Point(7, 83);
            this.chproveedores.Name = "chproveedores";
            this.chproveedores.Size = new System.Drawing.Size(133, 24);
            this.chproveedores.TabIndex = 2;
            this.chproveedores.Text = "Proveedores";
            this.chproveedores.UseVisualStyleBackColor = false;
            // 
            // chClientes
            // 
            this.chClientes.AutoSize = true;
            this.chClientes.BackColor = System.Drawing.Color.Transparent;
            this.chClientes.ForeColor = System.Drawing.Color.Black;
            this.chClientes.Location = new System.Drawing.Point(7, 53);
            this.chClientes.Name = "chClientes";
            this.chClientes.Size = new System.Drawing.Size(97, 24);
            this.chClientes.TabIndex = 1;
            this.chClientes.Text = "Clientes";
            this.chClientes.UseVisualStyleBackColor = false;
            // 
            // chUsuarios
            // 
            this.chUsuarios.AutoSize = true;
            this.chUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.chUsuarios.ForeColor = System.Drawing.Color.Black;
            this.chUsuarios.Location = new System.Drawing.Point(7, 26);
            this.chUsuarios.Name = "chUsuarios";
            this.chUsuarios.Size = new System.Drawing.Size(103, 24);
            this.chUsuarios.TabIndex = 0;
            this.chUsuarios.Text = "Usuarios";
            this.chUsuarios.UseVisualStyleBackColor = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtusuario.Location = new System.Drawing.Point(199, 78);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtusuario.Size = new System.Drawing.Size(184, 20);
            this.txtusuario.TabIndex = 24;
            this.txtusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusuario_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(111, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Usuario:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(199, 106);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(184, 20);
            this.txtpass.TabIndex = 22;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // txtapellido
            // 
            this.txtapellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellido.Location = new System.Drawing.Point(199, 52);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(184, 20);
            this.txtapellido.TabIndex = 21;
            this.txtapellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtapellido_KeyDown);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(199, 26);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(184, 20);
            this.txtnombre.TabIndex = 20;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(95, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(97, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombres:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtbuscaruser);
            this.panel2.Controls.Add(this.dgvusuarios);
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Location = new System.Drawing.Point(26, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 397);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(280, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 31;
            this.button1.Text = "   Nuevo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(654, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Buscar:";
            // 
            // txtbuscaruser
            // 
            this.txtbuscaruser.Location = new System.Drawing.Point(725, 3);
            this.txtbuscaruser.Name = "txtbuscaruser";
            this.txtbuscaruser.Size = new System.Drawing.Size(255, 20);
            this.txtbuscaruser.TabIndex = 29;
            this.txtbuscaruser.TextChanged += new System.EventHandler(this.txtbuscaruser_TextChanged);
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvusuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvusuarios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.EnableHeadersVisualStyles = false;
            this.dgvusuarios.Location = new System.Drawing.Point(3, 33);
            this.dgvusuarios.Name = "dgvusuarios";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvusuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvusuarios.Size = new System.Drawing.Size(979, 302);
            this.dgvusuarios.TabIndex = 28;
            this.dgvusuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellDoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Black;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(548, 341);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(123, 53);
            this.btneliminar.TabIndex = 27;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Black;
            this.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(409, 341);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(133, 53);
            this.btnagregar.TabIndex = 26;
            this.btnagregar.Text = "   Guardar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // usuarioscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuarioscs";
            this.Text = "usuarioscs";
            this.Load += new System.EventHandler(this.usuarioscs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtconfirmarPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chInventario;
        private System.Windows.Forms.CheckBox chReportes;
        private System.Windows.Forms.CheckBox chCategorias;
        private System.Windows.Forms.CheckBox chVentas;
        private System.Windows.Forms.CheckBox chProductos;
        private System.Windows.Forms.CheckBox chCompas;
        private System.Windows.Forms.CheckBox chComprobantes;
        private System.Windows.Forms.CheckBox chproveedores;
        private System.Windows.Forms.CheckBox chClientes;
        private System.Windows.Forms.CheckBox chUsuarios;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbuscaruser;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
    }
}