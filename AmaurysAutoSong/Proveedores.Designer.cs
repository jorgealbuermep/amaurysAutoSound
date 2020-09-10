namespace AmaurysAutoSong
{
    partial class Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoProveedor = new System.Windows.Forms.ComboBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombreProveedor = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtapellidoProveedor = new System.Windows.Forms.TextBox();
            this.lblrnc = new System.Windows.Forms.Label();
            this.ttxrnc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtemailproveedor = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.dgvproveedores = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtidproeedor = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(390, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedores";
            // 
            // cbTipoProveedor
            // 
            this.cbTipoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoProveedor.FormattingEnabled = true;
            this.cbTipoProveedor.Items.AddRange(new object[] {
            "Formal",
            "Informal"});
            this.cbTipoProveedor.Location = new System.Drawing.Point(14, 19);
            this.cbTipoProveedor.Name = "cbTipoProveedor";
            this.cbTipoProveedor.Size = new System.Drawing.Size(300, 28);
            this.cbTipoProveedor.TabIndex = 1;
            this.cbTipoProveedor.Text = "Tipo De Proveedor";
            this.cbTipoProveedor.SelectedIndexChanged += new System.EventHandler(this.cbTipoProveedor_SelectedIndexChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Black;
            this.lblnombre.Location = new System.Drawing.Point(10, 53);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(84, 20);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnombreProveedor
            // 
            this.txtnombreProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombreProveedor.Location = new System.Drawing.Point(94, 53);
            this.txtnombreProveedor.Name = "txtnombreProveedor";
            this.txtnombreProveedor.Size = new System.Drawing.Size(220, 20);
            this.txtnombreProveedor.TabIndex = 3;
            this.txtnombreProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombreProveedor_KeyDown);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.BackColor = System.Drawing.Color.Transparent;
            this.lblapellido.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.ForeColor = System.Drawing.Color.Black;
            this.lblapellido.Location = new System.Drawing.Point(4, 76);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(90, 20);
            this.lblapellido.TabIndex = 4;
            this.lblapellido.Text = "Apellido:";
            this.lblapellido.Click += new System.EventHandler(this.lblapellido_Click);
            // 
            // txtapellidoProveedor
            // 
            this.txtapellidoProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellidoProveedor.Location = new System.Drawing.Point(94, 79);
            this.txtapellidoProveedor.Name = "txtapellidoProveedor";
            this.txtapellidoProveedor.Size = new System.Drawing.Size(220, 20);
            this.txtapellidoProveedor.TabIndex = 5;
            this.txtapellidoProveedor.TextChanged += new System.EventHandler(this.txtapellidoProveedor_TextChanged);
            // 
            // lblrnc
            // 
            this.lblrnc.AutoSize = true;
            this.lblrnc.BackColor = System.Drawing.Color.Transparent;
            this.lblrnc.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrnc.ForeColor = System.Drawing.Color.Black;
            this.lblrnc.Location = new System.Drawing.Point(36, 108);
            this.lblrnc.Name = "lblrnc";
            this.lblrnc.Size = new System.Drawing.Size(58, 20);
            this.lblrnc.TabIndex = 6;
            this.lblrnc.Text = "RNC:";
            // 
            // ttxrnc
            // 
            this.ttxrnc.Location = new System.Drawing.Point(94, 105);
            this.ttxrnc.Name = "ttxrnc";
            this.ttxrnc.Size = new System.Drawing.Size(220, 20);
            this.ttxrnc.TabIndex = 7;
            this.ttxrnc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttxrnc_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(395, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefono:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(415, 57);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 20);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtemailproveedor
            // 
            this.txtemailproveedor.Location = new System.Drawing.Point(493, 55);
            this.txtemailproveedor.Name = "txtemailproveedor";
            this.txtemailproveedor.Size = new System.Drawing.Size(280, 20);
            this.txtemailproveedor.TabIndex = 11;
            this.txtemailproveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemailproveedor_KeyDown);
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbldescripcion.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.ForeColor = System.Drawing.Color.Black;
            this.lbldescripcion.Location = new System.Drawing.Point(376, 79);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(113, 20);
            this.lbldescripcion.TabIndex = 12;
            this.lbldescripcion.Text = "descripcion:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(493, 81);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(280, 56);
            this.txtdescripcion.TabIndex = 13;
            // 
            // dgvproveedores
            // 
            this.dgvproveedores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvproveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproveedores.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedores.EnableHeadersVisualStyles = false;
            this.dgvproveedores.Location = new System.Drawing.Point(25, 52);
            this.dgvproveedores.Name = "dgvproveedores";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvproveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvproveedores.Size = new System.Drawing.Size(830, 265);
            this.dgvproveedores.TabIndex = 14;
            this.dgvproveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproveedores_CellDoubleClick);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Black;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(149, 323);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(129, 58);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(284, 323);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 58);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "   Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtidproeedor
            // 
            this.txtidproeedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidproeedor.Location = new System.Drawing.Point(3, 7);
            this.txtidproeedor.Name = "txtidproeedor";
            this.txtidproeedor.Size = new System.Drawing.Size(100, 13);
            this.txtidproeedor.TabIndex = 17;
            this.txtidproeedor.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(419, 323);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 58);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "   Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.cbTipoProveedor);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Controls.Add(this.txtnombreProveedor);
            this.panel1.Controls.Add(this.lblapellido);
            this.panel1.Controls.Add(this.txtapellidoProveedor);
            this.panel1.Controls.Add(this.lblrnc);
            this.panel1.Controls.Add(this.ttxrnc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Controls.Add(this.lbldescripcion);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtemailproveedor);
            this.panel1.Location = new System.Drawing.Point(50, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 156);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvproveedores);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Location = new System.Drawing.Point(50, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 391);
            this.panel2.TabIndex = 22;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(523, 25);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(332, 20);
            this.txtbuscar.TabIndex = 22;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Buscar:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(494, 26);
            this.txtTelefono.Mask = "(999) 000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(279, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtidproeedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoProveedor;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombreProveedor;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.TextBox txtapellidoProveedor;
        private System.Windows.Forms.Label lblrnc;
        private System.Windows.Forms.TextBox ttxrnc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtemailproveedor;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.DataGridView dgvproveedores;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtidproeedor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
    }
}