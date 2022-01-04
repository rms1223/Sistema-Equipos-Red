namespace InterfazGrafica.Fomularios.Meraki
{
    partial class Listar_Redes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar_Redes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direccionamientoIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estandarDePuertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.estado_sistema = new System.Windows.Forms.Label();
            this.estado_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datagridview_listarRedes = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opciones = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.template_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_ce = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.proveedor_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proveedor = new System.Windows.Forms.Label();
            this.total_registros = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_listarRedes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.xToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelosDeEquiposToolStripMenuItem,
            this.direccionamientoIPToolStripMenuItem,
            this.exportarDatosToolStripMenuItem,
            this.estandarDePuertosToolStripMenuItem});
            this.xToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.xToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xToolStripMenuItem.Image")));
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.xToolStripMenuItem.Text = "Menú";
            // 
            // modelosDeEquiposToolStripMenuItem
            // 
            this.modelosDeEquiposToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modelosDeEquiposToolStripMenuItem.Image")));
            this.modelosDeEquiposToolStripMenuItem.Name = "modelosDeEquiposToolStripMenuItem";
            this.modelosDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modelosDeEquiposToolStripMenuItem.Text = "Modelos de Equipos";
            this.modelosDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.ModelosDeEquiposToolStripMenuItem_Click);
            // 
            // direccionamientoIPToolStripMenuItem
            // 
            this.direccionamientoIPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("direccionamientoIPToolStripMenuItem.Image")));
            this.direccionamientoIPToolStripMenuItem.Name = "direccionamientoIPToolStripMenuItem";
            this.direccionamientoIPToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.direccionamientoIPToolStripMenuItem.Text = "Direccionamiento IP";
            this.direccionamientoIPToolStripMenuItem.Click += new System.EventHandler(this.DireccionamientoIPToolStripMenuItem_Click);
            // 
            // exportarDatosToolStripMenuItem
            // 
            this.exportarDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportarDatosToolStripMenuItem.Image")));
            this.exportarDatosToolStripMenuItem.Name = "exportarDatosToolStripMenuItem";
            this.exportarDatosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportarDatosToolStripMenuItem.Text = "Exportar Datos";
            this.exportarDatosToolStripMenuItem.Click += new System.EventHandler(this.ExportarDatosToolStripMenuItem_Click);
            // 
            // estandarDePuertosToolStripMenuItem
            // 
            this.estandarDePuertosToolStripMenuItem.Name = "estandarDePuertosToolStripMenuItem";
            this.estandarDePuertosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.estandarDePuertosToolStripMenuItem.Text = "Estandar de Puertos";
            this.estandarDePuertosToolStripMenuItem.Click += new System.EventHandler(this.EstandarDePuertosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.estado_sistema);
            this.panel1.Controls.Add(this.estado_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.datagridview_listarRedes);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 694);
            this.panel1.TabIndex = 1;
            // 
            // estado_sistema
            // 
            this.estado_sistema.AutoSize = true;
            this.estado_sistema.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_sistema.ForeColor = System.Drawing.Color.Blue;
            this.estado_sistema.Location = new System.Drawing.Point(115, 140);
            this.estado_sistema.Name = "estado_sistema";
            this.estado_sistema.Size = new System.Drawing.Size(25, 15);
            this.estado_sistema.TabIndex = 28;
            this.estado_sistema.Text = "......";
            // 
            // estado_name
            // 
            this.estado_name.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_name.ForeColor = System.Drawing.Color.Gray;
            this.estado_name.Location = new System.Drawing.Point(14, 139);
            this.estado_name.Name = "estado_name";
            this.estado_name.Size = new System.Drawing.Size(95, 34);
            this.estado_name.TabIndex = 27;
            this.estado_name.Text = "Estado de Registros en el Sevidor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Equipos No Conectados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Equipos Conectados";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // datagridview_listarRedes
            // 
            this.datagridview_listarRedes.AllowUserToAddRows = false;
            this.datagridview_listarRedes.AllowUserToDeleteRows = false;
            this.datagridview_listarRedes.AllowUserToOrderColumns = true;
            this.datagridview_listarRedes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_listarRedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_listarRedes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridview_listarRedes.BackgroundColor = System.Drawing.Color.White;
            this.datagridview_listarRedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_listarRedes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_listarRedes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_listarRedes.ColumnHeadersHeight = 25;
            this.datagridview_listarRedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado,
            this.name,
            this.serial,
            this.ip,
            this.mac,
            this.modelo,
            this.tags,
            this.notes,
            this.Opciones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_listarRedes.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_listarRedes.EnableHeadersVisualStyles = false;
            this.datagridview_listarRedes.Location = new System.Drawing.Point(12, 319);
            this.datagridview_listarRedes.Name = "datagridview_listarRedes";
            this.datagridview_listarRedes.RowHeadersVisible = false;
            this.datagridview_listarRedes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridview_listarRedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_listarRedes.Size = new System.Drawing.Size(1090, 349);
            this.datagridview_listarRedes.TabIndex = 19;
            this.datagridview_listarRedes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // serial
            // 
            this.serial.HeaderText = "Serial";
            this.serial.Name = "serial";
            // 
            // ip
            // 
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            // 
            // mac
            // 
            this.mac.HeaderText = "MAC";
            this.mac.Name = "mac";
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            // 
            // tags
            // 
            this.tags.HeaderText = "Tags";
            this.tags.Name = "tags";
            // 
            // notes
            // 
            this.notes.HeaderText = "Ubicación";
            this.notes.Name = "notes";
            // 
            // Opciones
            // 
            this.Opciones.HeaderText = "Opciones";
            this.Opciones.LinkColor = System.Drawing.Color.Gray;
            this.Opciones.Name = "Opciones";
            this.Opciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Opciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Opciones.Text = "Ver Opciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.template_nombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nombre_ce);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.codigo);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.proveedor_name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.proveedor);
            this.groupBox2.Controls.Add(this.total_registros);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(202, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 289);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Datos";
            // 
            // template_nombre
            // 
            this.template_nombre.Location = new System.Drawing.Point(330, 171);
            this.template_nombre.Name = "template_nombre";
            this.template_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.template_nombre.Size = new System.Drawing.Size(212, 16);
            this.template_nombre.TabIndex = 24;
            this.template_nombre.Text = "......";
            this.template_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(206, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Configuración:";
            // 
            // nombre_ce
            // 
            this.nombre_ce.Location = new System.Drawing.Point(327, 125);
            this.nombre_ce.Name = "nombre_ce";
            this.nombre_ce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nombre_ce.Size = new System.Drawing.Size(212, 16);
            this.nombre_ce.TabIndex = 22;
            this.nombre_ce.Text = "......";
            this.nombre_ce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(206, 127);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre CE:";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(330, 82);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(209, 20);
            this.codigo.TabIndex = 20;
            this.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Codigo_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(567, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // proveedor_name
            // 
            this.proveedor_name.AutoSize = true;
            this.proveedor_name.Location = new System.Drawing.Point(330, 24);
            this.proveedor_name.Name = "proveedor_name";
            this.proveedor_name.Size = new System.Drawing.Size(120, 13);
            this.proveedor_name.TabIndex = 18;
            this.proveedor_name.Text = "Fundación Omar Dengo";
            this.proveedor_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(206, 86);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Codigo CE:";
            // 
            // proveedor
            // 
            this.proveedor.Location = new System.Drawing.Point(214, 24);
            this.proveedor.Name = "proveedor";
            this.proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.proveedor.Size = new System.Drawing.Size(100, 16);
            this.proveedor.TabIndex = 16;
            this.proveedor.Text = "Proveedor:";
            // 
            // total_registros
            // 
            this.total_registros.AutoSize = true;
            this.total_registros.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_registros.Location = new System.Drawing.Point(486, 252);
            this.total_registros.Name = "total_registros";
            this.total_registros.Size = new System.Drawing.Size(110, 15);
            this.total_registros.TabIndex = 2;
            this.total_registros.Text = "Total de Registros: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(204, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar Dispositivo:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(330, 213);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(209, 20);
            this.txt_buscar.TabIndex = 11;
            this.txt_buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(567, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Listar_Redes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Listar_Redes";
            this.Text = "Listar_Redes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_listarRedes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridview_listarRedes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label proveedor;
        private System.Windows.Forms.Label total_registros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label proveedor_name;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nombre_ce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label template_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem modelosDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direccionamientoIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDatosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem estandarDePuertosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewLinkColumn Opciones;
        private System.Windows.Forms.Label estado_sistema;
        private System.Windows.Forms.Label estado_name;
    }
}