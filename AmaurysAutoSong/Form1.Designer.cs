namespace AmaurysAutoSong
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblusuarioconectado = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarsesion = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.btntransacciones = new System.Windows.Forms.Button();
            this.btnadministracion = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelTransacciones = new System.Windows.Forms.Panel();
            this.btnatras1 = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.panelAdministracion = new System.Windows.Forms.Panel();
            this.btncategorias = new System.Windows.Forms.Button();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMenuPrincipal.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelTransacciones.SuspendLayout();
            this.panelAdministracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Firebrick;
            this.panelSuperior.Controls.Add(this.pictureBox3);
            this.panelSuperior.Controls.Add(this.lblusuarioconectado);
            this.panelSuperior.Controls.Add(this.pictureBox2);
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1185, 45);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(193, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lblusuarioconectado
            // 
            this.lblusuarioconectado.AutoSize = true;
            this.lblusuarioconectado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuarioconectado.ForeColor = System.Drawing.Color.Black;
            this.lblusuarioconectado.Location = new System.Drawing.Point(253, 11);
            this.lblusuarioconectado.Name = "lblusuarioconectado";
            this.lblusuarioconectado.Size = new System.Drawing.Size(34, 23);
            this.lblusuarioconectado.TabIndex = 4;
            this.lblusuarioconectado.Text = "----";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1099, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 29);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1139, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(504, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amaurys AutoSound";
            // 
            // PanelMenuPrincipal
            // 
            this.PanelMenuPrincipal.BackColor = System.Drawing.Color.Firebrick;
            this.PanelMenuPrincipal.Controls.Add(this.btnSalir);
            this.PanelMenuPrincipal.Controls.Add(this.btnCerrarsesion);
            this.PanelMenuPrincipal.Controls.Add(this.btnInventario);
            this.PanelMenuPrincipal.Controls.Add(this.btnreportes);
            this.PanelMenuPrincipal.Controls.Add(this.btntransacciones);
            this.PanelMenuPrincipal.Controls.Add(this.btnadministracion);
            this.PanelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuPrincipal.Location = new System.Drawing.Point(0, 45);
            this.PanelMenuPrincipal.Name = "PanelMenuPrincipal";
            this.PanelMenuPrincipal.Size = new System.Drawing.Size(179, 560);
            this.PanelMenuPrincipal.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(6, 517);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(167, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.BackColor = System.Drawing.Color.Black;
            this.btnCerrarsesion.FlatAppearance.BorderSize = 2;
            this.btnCerrarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarsesion.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarsesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarsesion.Image")));
            this.btnCerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarsesion.Location = new System.Drawing.Point(0, 209);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(179, 53);
            this.btnCerrarsesion.TabIndex = 4;
            this.btnCerrarsesion.Text = "   Cerrar Sesion";
            this.btnCerrarsesion.UseVisualStyleBackColor = false;
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Black;
            this.btnInventario.FlatAppearance.BorderSize = 2;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 117);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(179, 49);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnreportes
            // 
            this.btnreportes.BackColor = System.Drawing.Color.Black;
            this.btnreportes.FlatAppearance.BorderSize = 2;
            this.btnreportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportes.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportes.ForeColor = System.Drawing.Color.White;
            this.btnreportes.Image = ((System.Drawing.Image)(resources.GetObject("btnreportes.Image")));
            this.btnreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportes.Location = new System.Drawing.Point(0, 163);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(179, 49);
            this.btnreportes.TabIndex = 2;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.UseVisualStyleBackColor = false;
            this.btnreportes.Click += new System.EventHandler(this.btnreportes_Click);
            // 
            // btntransacciones
            // 
            this.btntransacciones.BackColor = System.Drawing.Color.Black;
            this.btntransacciones.FlatAppearance.BorderSize = 2;
            this.btntransacciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btntransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntransacciones.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransacciones.ForeColor = System.Drawing.Color.White;
            this.btntransacciones.Image = ((System.Drawing.Image)(resources.GetObject("btntransacciones.Image")));
            this.btntransacciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntransacciones.Location = new System.Drawing.Point(0, 61);
            this.btntransacciones.Name = "btntransacciones";
            this.btntransacciones.Size = new System.Drawing.Size(179, 57);
            this.btntransacciones.TabIndex = 1;
            this.btntransacciones.Text = " Transacciones";
            this.btntransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntransacciones.UseVisualStyleBackColor = false;
            this.btntransacciones.Click += new System.EventHandler(this.btntransacciones_Click);
            // 
            // btnadministracion
            // 
            this.btnadministracion.BackColor = System.Drawing.Color.Black;
            this.btnadministracion.FlatAppearance.BorderSize = 2;
            this.btnadministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnadministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadministracion.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadministracion.ForeColor = System.Drawing.Color.White;
            this.btnadministracion.Image = ((System.Drawing.Image)(resources.GetObject("btnadministracion.Image")));
            this.btnadministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadministracion.Location = new System.Drawing.Point(0, 6);
            this.btnadministracion.Name = "btnadministracion";
            this.btnadministracion.Size = new System.Drawing.Size(179, 56);
            this.btnadministracion.TabIndex = 0;
            this.btnadministracion.Text = "Administracion";
            this.btnadministracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadministracion.UseVisualStyleBackColor = false;
            this.btnadministracion.Click += new System.EventHandler(this.btnadministracion_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContenedor.Controls.Add(this.panelTransacciones);
            this.panelContenedor.Controls.Add(this.panelAdministracion);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(179, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1006, 560);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelTransacciones
            // 
            this.panelTransacciones.BackColor = System.Drawing.Color.Firebrick;
            this.panelTransacciones.Controls.Add(this.btnatras1);
            this.panelTransacciones.Controls.Add(this.btnVentas);
            this.panelTransacciones.Controls.Add(this.btnCompras);
            this.panelTransacciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTransacciones.Location = new System.Drawing.Point(179, 0);
            this.panelTransacciones.Name = "panelTransacciones";
            this.panelTransacciones.Size = new System.Drawing.Size(179, 560);
            this.panelTransacciones.TabIndex = 3;
            this.panelTransacciones.Visible = false;
            // 
            // btnatras1
            // 
            this.btnatras1.BackColor = System.Drawing.Color.Red;
            this.btnatras1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnatras1.FlatAppearance.BorderSize = 0;
            this.btnatras1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnatras1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatras1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras1.ForeColor = System.Drawing.Color.White;
            this.btnatras1.Image = ((System.Drawing.Image)(resources.GetObject("btnatras1.Image")));
            this.btnatras1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnatras1.Location = new System.Drawing.Point(0, 493);
            this.btnatras1.Name = "btnatras1";
            this.btnatras1.Size = new System.Drawing.Size(179, 67);
            this.btnatras1.TabIndex = 5;
            this.btnatras1.Text = "Atras";
            this.btnatras1.UseVisualStyleBackColor = false;
            this.btnatras1.Click += new System.EventHandler(this.btnatras1_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Black;
            this.btnVentas.FlatAppearance.BorderSize = 2;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 61);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(179, 50);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Black;
            this.btnCompras.FlatAppearance.BorderSize = 2;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 6);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(179, 56);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // panelAdministracion
            // 
            this.panelAdministracion.BackColor = System.Drawing.Color.Firebrick;
            this.panelAdministracion.Controls.Add(this.btncategorias);
            this.panelAdministracion.Controls.Add(this.btnComprobante);
            this.panelAdministracion.Controls.Add(this.btnAtras);
            this.panelAdministracion.Controls.Add(this.btnProveedores);
            this.panelAdministracion.Controls.Add(this.btnClientes);
            this.panelAdministracion.Controls.Add(this.btnProductos);
            this.panelAdministracion.Controls.Add(this.btnUsuarios);
            this.panelAdministracion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdministracion.Location = new System.Drawing.Point(0, 0);
            this.panelAdministracion.Name = "panelAdministracion";
            this.panelAdministracion.Size = new System.Drawing.Size(179, 560);
            this.panelAdministracion.TabIndex = 2;
            this.panelAdministracion.Visible = false;
            // 
            // btncategorias
            // 
            this.btncategorias.BackColor = System.Drawing.Color.Black;
            this.btncategorias.FlatAppearance.BorderSize = 2;
            this.btncategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorias.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorias.ForeColor = System.Drawing.Color.White;
            this.btncategorias.Image = ((System.Drawing.Image)(resources.GetObject("btncategorias.Image")));
            this.btncategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorias.Location = new System.Drawing.Point(0, 6);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(179, 49);
            this.btncategorias.TabIndex = 6;
            this.btncategorias.Text = "Categorias";
            this.btncategorias.UseVisualStyleBackColor = false;
            this.btncategorias.Click += new System.EventHandler(this.btncategorias_Click);
            // 
            // btnComprobante
            // 
            this.btnComprobante.BackColor = System.Drawing.Color.Black;
            this.btnComprobante.FlatAppearance.BorderSize = 2;
            this.btnComprobante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobante.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.ForeColor = System.Drawing.Color.White;
            this.btnComprobante.Image = ((System.Drawing.Image)(resources.GetObject("btnComprobante.Image")));
            this.btnComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobante.Location = new System.Drawing.Point(0, 98);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(179, 49);
            this.btnComprobante.TabIndex = 3;
            this.btnComprobante.Text = "    Comprobantes";
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Red;
            this.btnAtras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(0, 493);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(179, 67);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Black;
            this.btnProveedores.FlatAppearance.BorderSize = 2;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 190);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(179, 49);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "  Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Black;
            this.btnClientes.FlatAppearance.BorderSize = 2;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 52);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(179, 49);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.BorderSize = 2;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 144);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(179, 50);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnUsuarios.FlatAppearance.BorderSize = 2;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 236);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(179, 56);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 605);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.PanelMenuPrincipal);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMenuPrincipal.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelTransacciones.ResumeLayout(false);
            this.panelAdministracion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelMenuPrincipal;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarsesion;
        private System.Windows.Forms.Panel panelTransacciones;
        private System.Windows.Forms.Button btnatras1;
        private System.Windows.Forms.Panel panelAdministracion;
        private System.Windows.Forms.Button btnAtras;
        public System.Windows.Forms.Button btnreportes;
        public System.Windows.Forms.Button btntransacciones;
        public System.Windows.Forms.Button btnadministracion;
        public System.Windows.Forms.Button btnInventario;
        public System.Windows.Forms.Button btnComprobante;
        public System.Windows.Forms.Button btnVentas;
        public System.Windows.Forms.Button btnCompras;
        public System.Windows.Forms.Button btnProveedores;
        public System.Windows.Forms.Button btnClientes;
        public System.Windows.Forms.Button btnProductos;
        public System.Windows.Forms.Button btnUsuarios;
        public System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lblusuarioconectado;
    }
}

