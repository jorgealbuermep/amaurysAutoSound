namespace AmaurysAutoSong
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumerocompra = new System.Windows.Forms.TextBox();
            this.dtfechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtItbis = new System.Windows.Forms.TextBox();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.btneliminarOrden = new System.Windows.Forms.Button();
            this.dgvbuscarproducto = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnguardarcompra = new System.Windows.Forms.Button();
            this.btnEliminardetalle = new System.Windows.Forms.Button();
            this.btnAgregardetalle = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.txtidetalle = new System.Windows.Forms.TextBox();
            this.cbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.txtidcabecera = new System.Windows.Forms.TextBox();
            this.txtcomprobante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtfechafactura = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbtipoDocumento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscarproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(431, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden De Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. de Compra:";
            // 
            // txtnumerocompra
            // 
            this.txtnumerocompra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnumerocompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerocompra.Location = new System.Drawing.Point(155, 3);
            this.txtnumerocompra.Name = "txtnumerocompra";
            this.txtnumerocompra.ReadOnly = true;
            this.txtnumerocompra.Size = new System.Drawing.Size(244, 24);
            this.txtnumerocompra.TabIndex = 2;
            // 
            // dtfechaEmision
            // 
            this.dtfechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaEmision.Location = new System.Drawing.Point(155, 35);
            this.dtfechaEmision.Name = "dtfechaEmision";
            this.dtfechaEmision.Size = new System.Drawing.Size(244, 24);
            this.dtfechaEmision.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "fecha de Emision:";
            // 
            // cbproveedor
            // 
            this.cbproveedor.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(155, 65);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(244, 24);
            this.cbproveedor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(385, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subtotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(412, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Itbis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(369, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(407, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(463, 17);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(118, 24);
            this.txtSubtotal.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(463, 107);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(118, 24);
            this.txtTotal.TabIndex = 12;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(463, 47);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(118, 24);
            this.txtDescuento.TabIndex = 13;
            // 
            // txtItbis
            // 
            this.txtItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItbis.Location = new System.Drawing.Point(463, 77);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new System.Drawing.Size(118, 24);
            this.txtItbis.TabIndex = 14;
            // 
            // gbDetalles
            // 
            this.gbDetalles.BackColor = System.Drawing.Color.Firebrick;
            this.gbDetalles.Controls.Add(this.button2);
            this.gbDetalles.Controls.Add(this.label9);
            this.gbDetalles.Controls.Add(this.txtproducto);
            this.gbDetalles.Controls.Add(this.btneliminarOrden);
            this.gbDetalles.Controls.Add(this.dgvbuscarproducto);
            this.gbDetalles.Controls.Add(this.btnNuevo);
            this.gbDetalles.Controls.Add(this.btnExportar);
            this.gbDetalles.Controls.Add(this.btnguardarcompra);
            this.gbDetalles.Controls.Add(this.btnEliminardetalle);
            this.gbDetalles.Controls.Add(this.btnAgregardetalle);
            this.gbDetalles.Controls.Add(this.dgvDetalles);
            this.gbDetalles.Controls.Add(this.txtcantidad);
            this.gbDetalles.Controls.Add(this.Cantidad);
            this.gbDetalles.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalles.ForeColor = System.Drawing.Color.Black;
            this.gbDetalles.Location = new System.Drawing.Point(34, 221);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Size = new System.Drawing.Size(1061, 431);
            this.gbDetalles.TabIndex = 16;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles De Compra";
            this.gbDetalles.Enter += new System.EventHandler(this.gbDetalles_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(932, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 58);
            this.button2.TabIndex = 40;
            this.button2.Text = "Buscar Compras";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(6, 41);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(308, 26);
            this.txtproducto.TabIndex = 38;
            this.txtproducto.TextChanged += new System.EventHandler(this.txtproducto_TextChanged);
            // 
            // btneliminarOrden
            // 
            this.btneliminarOrden.BackColor = System.Drawing.Color.Black;
            this.btneliminarOrden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btneliminarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarOrden.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarOrden.ForeColor = System.Drawing.Color.White;
            this.btneliminarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btneliminarOrden.Image")));
            this.btneliminarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminarOrden.Location = new System.Drawing.Point(320, 367);
            this.btneliminarOrden.Name = "btneliminarOrden";
            this.btneliminarOrden.Size = new System.Drawing.Size(148, 48);
            this.btneliminarOrden.TabIndex = 36;
            this.btneliminarOrden.Text = "  Eliminar";
            this.btneliminarOrden.UseVisualStyleBackColor = false;
            this.btneliminarOrden.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvbuscarproducto
            // 
            this.dgvbuscarproducto.AllowUserToAddRows = false;
            this.dgvbuscarproducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvbuscarproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscarproducto.ColumnHeadersVisible = false;
            this.dgvbuscarproducto.EnableHeadersVisualStyles = false;
            this.dgvbuscarproducto.Location = new System.Drawing.Point(6, 64);
            this.dgvbuscarproducto.Name = "dgvbuscarproducto";
            this.dgvbuscarproducto.Size = new System.Drawing.Size(308, 39);
            this.dgvbuscarproducto.TabIndex = 37;
            this.dgvbuscarproducto.Visible = false;
            this.dgvbuscarproducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbuscarproducto_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(24, 367);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(138, 48);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Black;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(474, 367);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(134, 48);
            this.btnExportar.TabIndex = 35;
            this.btnExportar.Text = "    Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnguardarcompra
            // 
            this.btnguardarcompra.BackColor = System.Drawing.Color.Black;
            this.btnguardarcompra.Enabled = false;
            this.btnguardarcompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnguardarcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcompra.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcompra.ForeColor = System.Drawing.Color.White;
            this.btnguardarcompra.Image = ((System.Drawing.Image)(resources.GetObject("btnguardarcompra.Image")));
            this.btnguardarcompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardarcompra.Location = new System.Drawing.Point(170, 367);
            this.btnguardarcompra.Name = "btnguardarcompra";
            this.btnguardarcompra.Size = new System.Drawing.Size(144, 48);
            this.btnguardarcompra.TabIndex = 28;
            this.btnguardarcompra.Text = "  Guardar";
            this.btnguardarcompra.UseVisualStyleBackColor = false;
            this.btnguardarcompra.Click += new System.EventHandler(this.btnguardarcompra_Click);
            // 
            // btnEliminardetalle
            // 
            this.btnEliminardetalle.BackColor = System.Drawing.Color.Black;
            this.btnEliminardetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminardetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminardetalle.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminardetalle.ForeColor = System.Drawing.Color.White;
            this.btnEliminardetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminardetalle.Image")));
            this.btnEliminardetalle.Location = new System.Drawing.Point(621, 29);
            this.btnEliminardetalle.Name = "btnEliminardetalle";
            this.btnEliminardetalle.Size = new System.Drawing.Size(72, 45);
            this.btnEliminardetalle.TabIndex = 26;
            this.btnEliminardetalle.UseVisualStyleBackColor = false;
            this.btnEliminardetalle.Click += new System.EventHandler(this.btnEliminardetalle_Click);
            // 
            // btnAgregardetalle
            // 
            this.btnAgregardetalle.BackColor = System.Drawing.Color.Black;
            this.btnAgregardetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAgregardetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregardetalle.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregardetalle.ForeColor = System.Drawing.Color.White;
            this.btnAgregardetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregardetalle.Image")));
            this.btnAgregardetalle.Location = new System.Drawing.Point(543, 29);
            this.btnAgregardetalle.Name = "btnAgregardetalle";
            this.btnAgregardetalle.Size = new System.Drawing.Size(72, 45);
            this.btnAgregardetalle.TabIndex = 25;
            this.btnAgregardetalle.UseVisualStyleBackColor = false;
            this.btnAgregardetalle.Click += new System.EventHandler(this.btnAgregardetalle_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalles.EnableHeadersVisualStyles = false;
            this.dgvDetalles.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDetalles.Location = new System.Drawing.Point(6, 109);
            this.dgvDetalles.Name = "dgvDetalles";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalles.Size = new System.Drawing.Size(1045, 252);
            this.dgvDetalles.TabIndex = 24;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(392, 41);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(145, 26);
            this.txtcantidad.TabIndex = 17;
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.BackColor = System.Drawing.Color.Transparent;
            this.Cantidad.ForeColor = System.Drawing.Color.Black;
            this.Cantidad.Location = new System.Drawing.Point(317, 44);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(78, 16);
            this.Cantidad.TabIndex = 16;
            this.Cantidad.Text = "Cantidad:";
            // 
            // txtidetalle
            // 
            this.txtidetalle.Location = new System.Drawing.Point(976, 3);
            this.txtidetalle.Name = "txtidetalle";
            this.txtidetalle.Size = new System.Drawing.Size(48, 20);
            this.txtidetalle.TabIndex = 19;
            this.txtidetalle.Visible = false;
            // 
            // cbTipoComprobante
            // 
            this.cbTipoComprobante.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoComprobante.FormattingEnabled = true;
            this.cbTipoComprobante.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.cbTipoComprobante.Location = new System.Drawing.Point(178, 76);
            this.cbTipoComprobante.Name = "cbTipoComprobante";
            this.cbTipoComprobante.Size = new System.Drawing.Size(183, 24);
            this.cbTipoComprobante.TabIndex = 22;
            // 
            // txtidcabecera
            // 
            this.txtidcabecera.Location = new System.Drawing.Point(870, 3);
            this.txtidcabecera.Name = "txtidcabecera";
            this.txtidcabecera.Size = new System.Drawing.Size(100, 20);
            this.txtidcabecera.TabIndex = 23;
            this.txtidcabecera.Visible = false;
            // 
            // txtcomprobante
            // 
            this.txtcomprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomprobante.Location = new System.Drawing.Point(177, 106);
            this.txtcomprobante.Name = "txtcomprobante";
            this.txtcomprobante.Size = new System.Drawing.Size(183, 24);
            this.txtcomprobante.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(39, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "fecha de Factura:";
            // 
            // dtfechafactura
            // 
            this.dtfechafactura.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechafactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechafactura.Location = new System.Drawing.Point(178, 16);
            this.dtfechafactura.Name = "dtfechafactura";
            this.dtfechafactura.Size = new System.Drawing.Size(183, 25);
            this.dtfechafactura.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtnumerocompra);
            this.panel1.Controls.Add(this.dtfechaEmision);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbproveedor);
            this.panel1.Location = new System.Drawing.Point(34, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 165);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(185, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 48);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbtipoDocumento);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtfechafactura);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtcomprobante);
            this.groupBox2.Controls.Add(this.cbTipoComprobante);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtItbis);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtDescuento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(508, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 165);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos De Factura";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "No. De Comprobante:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tipo De Comprobante:";
            // 
            // cbtipoDocumento
            // 
            this.cbtipoDocumento.FormattingEnabled = true;
            this.cbtipoDocumento.Items.AddRange(new object[] {
            "Factura",
            "Conduce"});
            this.cbtipoDocumento.Location = new System.Drawing.Point(178, 47);
            this.cbtipoDocumento.Name = "cbtipoDocumento";
            this.cbtipoDocumento.Size = new System.Drawing.Size(183, 24);
            this.cbtipoDocumento.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tipo De Documento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(57, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 16);
            this.label13.TabIndex = 41;
            this.label13.Text = "Proveedor:";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1097, 695);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtidcabecera);
            this.Controls.Add(this.txtidetalle);
            this.Controls.Add(this.gbDetalles);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.gbDetalles.ResumeLayout(false);
            this.gbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscarproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminardetalle;
        private System.Windows.Forms.Button btnAgregardetalle;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Button btnguardarcompra;
        private System.Windows.Forms.TextBox txtidetalle;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtnumerocompra;
        public System.Windows.Forms.DateTimePicker dtfechaEmision;
        public System.Windows.Forms.ComboBox cbproveedor;
        public System.Windows.Forms.TextBox txtSubtotal;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtDescuento;
        public System.Windows.Forms.TextBox txtItbis;
        public System.Windows.Forms.ComboBox cbTipoComprobante;
        public System.Windows.Forms.TextBox txtidcabecera;
        public System.Windows.Forms.TextBox txtcomprobante;
        public System.Windows.Forms.DateTimePicker dtfechafactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneliminarOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.DataGridView dgvbuscarproducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbtipoDocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
    }
}