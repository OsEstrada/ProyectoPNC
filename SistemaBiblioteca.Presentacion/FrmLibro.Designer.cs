namespace SistemaBiblioteca.Presentacion
{
    partial class FrmLibro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvListadoLibros = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblId = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnCancelar2 = new System.Windows.Forms.Button();
            this.picLibro = new System.Windows.Forms.PictureBox();
            this.GrpEjemplares = new System.Windows.Forms.GroupBox();
            this.btnAgregarEjemplar = new System.Windows.Forms.Button();
            this.btnModificarEjemplar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEliminarEjemplares = new System.Windows.Forms.Button();
            this.DgvEjemplares = new System.Windows.Forms.DataGridView();
            this.SeleccionarEjemplar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblTotalEjemplares = new System.Windows.Forms.Label();
            this.picEditorial = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblidLibro = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.LblMateria = new System.Windows.Forms.Label();
            this.LblISBN = new System.Windows.Forms.Label();
            this.LblNoPaginas = new System.Windows.Forms.Label();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.LblNoEdicion = new System.Windows.Forms.Label();
            this.NmPaginas = new System.Windows.Forms.NumericUpDown();
            this.LblAnioEdicion = new System.Windows.Forms.Label();
            this.NmEdicionNo = new System.Windows.Forms.NumericUpDown();
            this.CboEdicionAnio = new System.Windows.Forms.ComboBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoLibros)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibro)).BeginInit();
            this.GrpEjemplares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEjemplares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmEdicionNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TabPrincipal, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1490, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabPrincipal.Controls.Add(this.tabPage1);
            this.TabPrincipal.Controls.Add(this.tabPage2);
            this.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPrincipal.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TabPrincipal.Location = new System.Drawing.Point(0, 23);
            this.TabPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TabPrincipal.Multiline = true;
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.Padding = new System.Drawing.Point(0, 0);
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1490, 738);
            this.TabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabPrincipal.TabIndex = 1;
            this.TabPrincipal.SelectedIndexChanged += new System.EventHandler(this.TabPrincipal_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1482, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Controls.Add(this.DgvListadoLibros, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1482, 712);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DgvListadoLibros
            // 
            this.DgvListadoLibros.AllowUserToAddRows = false;
            this.DgvListadoLibros.AllowUserToDeleteRows = false;
            this.DgvListadoLibros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListadoLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListadoLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListadoLibros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadoLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListadoLibros.Location = new System.Drawing.Point(0, 40);
            this.DgvListadoLibros.Margin = new System.Windows.Forms.Padding(0);
            this.DgvListadoLibros.Name = "DgvListadoLibros";
            this.DgvListadoLibros.RowHeadersVisible = false;
            this.DgvListadoLibros.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListadoLibros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListadoLibros.RowTemplate.Height = 24;
            this.DgvListadoLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoLibros.Size = new System.Drawing.Size(1482, 632);
            this.DgvListadoLibros.TabIndex = 0;
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 69;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1482, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAgregar.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.más_24;
            this.btnAgregar.Location = new System.Drawing.Point(1391, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 29);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEditar.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.Editar;
            this.btnEditar.Location = new System.Drawing.Point(1423, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(30, 29);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.basura_24;
            this.BtnEliminar.Location = new System.Drawing.Point(1449, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(30, 29);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frase o código";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.busqueda;
            this.BtnBuscar.Location = new System.Drawing.Point(631, 1);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(42, 30);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(97, 6);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(531, 22);
            this.TxtBuscar.TabIndex = 4;
            this.TxtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 672);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1482, 40);
            this.panel3.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(3, 7);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(79, 13);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "Total registros:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1482, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1482, 712);
            this.tableLayoutPanel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.LblId);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.BtnCancelar2);
            this.panel4.Controls.Add(this.picLibro);
            this.panel4.Controls.Add(this.GrpEjemplares);
            this.panel4.Controls.Add(this.LblTitulo);
            this.panel4.Controls.Add(this.LblidLibro);
            this.panel4.Controls.Add(this.LblAutor);
            this.panel4.Controls.Add(this.TxtTitulo);
            this.panel4.Controls.Add(this.TxtDescripcion);
            this.panel4.Controls.Add(this.BtnInsertar);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.BtnCancelar);
            this.panel4.Controls.Add(this.TxtMateria);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.BtnActualizar);
            this.panel4.Controls.Add(this.TxtAutor);
            this.panel4.Controls.Add(this.LblMateria);
            this.panel4.Controls.Add(this.LblISBN);
            this.panel4.Controls.Add(this.LblNoPaginas);
            this.panel4.Controls.Add(this.TxtISBN);
            this.panel4.Controls.Add(this.LblNoEdicion);
            this.panel4.Controls.Add(this.NmPaginas);
            this.panel4.Controls.Add(this.LblAnioEdicion);
            this.panel4.Controls.Add(this.NmEdicionNo);
            this.panel4.Controls.Add(this.CboEdicionAnio);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(344, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(794, 706);
            this.panel4.TabIndex = 0;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.LblId.ForeColor = System.Drawing.Color.DarkRed;
            this.LblId.Location = new System.Drawing.Point(668, 26);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(25, 13);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "No.";
            this.LblId.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(68, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Información Básica";
            // 
            // BtnCancelar2
            // 
            this.BtnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar2.Location = new System.Drawing.Point(566, 649);
            this.BtnCancelar2.Name = "BtnCancelar2";
            this.BtnCancelar2.Size = new System.Drawing.Size(200, 30);
            this.BtnCancelar2.TabIndex = 45;
            this.BtnCancelar2.Text = "Cancelar";
            this.BtnCancelar2.UseVisualStyleBackColor = true;
            this.BtnCancelar2.Visible = false;
            this.BtnCancelar2.Click += new System.EventHandler(this.BtnCancelar2_Click);
            // 
            // picLibro
            // 
            this.picLibro.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.libro;
            this.picLibro.Location = new System.Drawing.Point(29, 20);
            this.picLibro.Name = "picLibro";
            this.picLibro.Size = new System.Drawing.Size(33, 31);
            this.picLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLibro.TabIndex = 39;
            this.picLibro.TabStop = false;
            // 
            // GrpEjemplares
            // 
            this.GrpEjemplares.Controls.Add(this.btnAgregarEjemplar);
            this.GrpEjemplares.Controls.Add(this.btnModificarEjemplar);
            this.GrpEjemplares.Controls.Add(this.label2);
            this.GrpEjemplares.Controls.Add(this.BtnEliminarEjemplares);
            this.GrpEjemplares.Controls.Add(this.DgvEjemplares);
            this.GrpEjemplares.Controls.Add(this.LblTotalEjemplares);
            this.GrpEjemplares.Controls.Add(this.picEditorial);
            this.GrpEjemplares.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpEjemplares.Location = new System.Drawing.Point(39, 336);
            this.GrpEjemplares.Name = "GrpEjemplares";
            this.GrpEjemplares.Size = new System.Drawing.Size(727, 283);
            this.GrpEjemplares.TabIndex = 44;
            this.GrpEjemplares.TabStop = false;
            this.GrpEjemplares.Text = "          ";
            this.GrpEjemplares.Visible = false;
            // 
            // btnAgregarEjemplar
            // 
            this.btnAgregarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEjemplar.FlatAppearance.BorderSize = 0;
            this.btnAgregarEjemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEjemplar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAgregarEjemplar.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.más_24;
            this.btnAgregarEjemplar.Location = new System.Drawing.Point(624, 23);
            this.btnAgregarEjemplar.Name = "btnAgregarEjemplar";
            this.btnAgregarEjemplar.Size = new System.Drawing.Size(30, 29);
            this.btnAgregarEjemplar.TabIndex = 48;
            this.btnAgregarEjemplar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarEjemplar.UseVisualStyleBackColor = true;
            this.btnAgregarEjemplar.Click += new System.EventHandler(this.btnAgregarEjemplar_Click);
            // 
            // btnModificarEjemplar
            // 
            this.btnModificarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarEjemplar.FlatAppearance.BorderSize = 0;
            this.btnModificarEjemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEjemplar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnModificarEjemplar.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.Editar;
            this.btnModificarEjemplar.Location = new System.Drawing.Point(657, 23);
            this.btnModificarEjemplar.Name = "btnModificarEjemplar";
            this.btnModificarEjemplar.Size = new System.Drawing.Size(30, 29);
            this.btnModificarEjemplar.TabIndex = 47;
            this.btnModificarEjemplar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarEjemplar.UseVisualStyleBackColor = true;
            this.btnModificarEjemplar.Click += new System.EventHandler(this.btnModificarEjemplar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(30, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mantenimiento de ejemplares";
            // 
            // BtnEliminarEjemplares
            // 
            this.BtnEliminarEjemplares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarEjemplares.FlatAppearance.BorderSize = 0;
            this.BtnEliminarEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarEjemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarEjemplares.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnEliminarEjemplares.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.basura_24;
            this.BtnEliminarEjemplares.Location = new System.Drawing.Point(685, 23);
            this.BtnEliminarEjemplares.Name = "BtnEliminarEjemplares";
            this.BtnEliminarEjemplares.Size = new System.Drawing.Size(30, 29);
            this.BtnEliminarEjemplares.TabIndex = 44;
            this.BtnEliminarEjemplares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminarEjemplares.UseVisualStyleBackColor = true;
            this.BtnEliminarEjemplares.Click += new System.EventHandler(this.BtnEliminarEjemplares_Click);
            // 
            // DgvEjemplares
            // 
            this.DgvEjemplares.AllowUserToAddRows = false;
            this.DgvEjemplares.AllowUserToDeleteRows = false;
            this.DgvEjemplares.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvEjemplares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvEjemplares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEjemplares.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEjemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarEjemplar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEjemplares.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvEjemplares.Location = new System.Drawing.Point(31, 57);
            this.DgvEjemplares.Margin = new System.Windows.Forms.Padding(2);
            this.DgvEjemplares.Name = "DgvEjemplares";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEjemplares.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvEjemplares.RowHeadersVisible = false;
            this.DgvEjemplares.RowHeadersWidth = 51;
            this.DgvEjemplares.RowTemplate.Height = 24;
            this.DgvEjemplares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEjemplares.Size = new System.Drawing.Size(684, 186);
            this.DgvEjemplares.TabIndex = 10;
            // 
            // SeleccionarEjemplar
            // 
            this.SeleccionarEjemplar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SeleccionarEjemplar.HeaderText = "Seleccionar";
            this.SeleccionarEjemplar.Name = "SeleccionarEjemplar";
            this.SeleccionarEjemplar.Width = 71;
            // 
            // LblTotalEjemplares
            // 
            this.LblTotalEjemplares.AutoSize = true;
            this.LblTotalEjemplares.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblTotalEjemplares.Location = new System.Drawing.Point(30, 254);
            this.LblTotalEjemplares.Name = "LblTotalEjemplares";
            this.LblTotalEjemplares.Size = new System.Drawing.Size(90, 13);
            this.LblTotalEjemplares.TabIndex = 41;
            this.LblTotalEjemplares.Text = "Total Ejemplares:";
            // 
            // picEditorial
            // 
            this.picEditorial.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.editorial;
            this.picEditorial.Location = new System.Drawing.Point(10, -4);
            this.picEditorial.Name = "picEditorial";
            this.picEditorial.Size = new System.Drawing.Size(33, 31);
            this.picEditorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditorial.TabIndex = 40;
            this.picEditorial.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblTitulo.Location = new System.Drawing.Point(69, 74);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(49, 13);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Título (*)";
            // 
            // LblidLibro
            // 
            this.LblidLibro.AutoSize = true;
            this.LblidLibro.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.LblidLibro.ForeColor = System.Drawing.Color.DarkRed;
            this.LblidLibro.Location = new System.Drawing.Point(699, 26);
            this.LblidLibro.Name = "LblidLibro";
            this.LblidLibro.Size = new System.Drawing.Size(0, 13);
            this.LblidLibro.TabIndex = 42;
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblAutor.Location = new System.Drawing.Point(68, 109);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(51, 13);
            this.LblAutor.TabIndex = 0;
            this.LblAutor.Text = "Autor(es)";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtTitulo.Location = new System.Drawing.Point(148, 71);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(608, 22);
            this.TxtTitulo.TabIndex = 1;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtDescripcion.Location = new System.Drawing.Point(147, 181);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(609, 55);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnInsertar.FlatAppearance.BorderSize = 0;
            this.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.ForeColor = System.Drawing.Color.White;
            this.BtnInsertar.Location = new System.Drawing.Point(70, 290);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(200, 30);
            this.BtnInsertar.TabIndex = 11;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label13.Location = new System.Drawing.Point(68, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Descripción";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(556, 290);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(200, 30);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtMateria
            // 
            this.TxtMateria.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtMateria.Location = new System.Drawing.Point(511, 144);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(245, 22);
            this.TxtMateria.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(68, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "(*) Indica que el dato es obligatorio.";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(39, 649);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(200, 30);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtAutor
            // 
            this.TxtAutor.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtAutor.Location = new System.Drawing.Point(148, 106);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(608, 22);
            this.TxtAutor.TabIndex = 2;
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblMateria.Location = new System.Drawing.Point(440, 147);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(46, 13);
            this.LblMateria.TabIndex = 0;
            this.LblMateria.Text = "Materia";
            // 
            // LblISBN
            // 
            this.LblISBN.AutoSize = true;
            this.LblISBN.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblISBN.Location = new System.Drawing.Point(68, 147);
            this.LblISBN.Name = "LblISBN";
            this.LblISBN.Size = new System.Drawing.Size(30, 13);
            this.LblISBN.TabIndex = 0;
            this.LblISBN.Text = "ISBN";
            // 
            // LblNoPaginas
            // 
            this.LblNoPaginas.AutoSize = true;
            this.LblNoPaginas.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblNoPaginas.Location = new System.Drawing.Point(568, 248);
            this.LblNoPaginas.Name = "LblNoPaginas";
            this.LblNoPaginas.Size = new System.Drawing.Size(79, 13);
            this.LblNoPaginas.TabIndex = 35;
            this.LblNoPaginas.Text = "No. de Páginas";
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtISBN.Location = new System.Drawing.Point(147, 144);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(245, 22);
            this.TxtISBN.TabIndex = 3;
            // 
            // LblNoEdicion
            // 
            this.LblNoEdicion.AutoSize = true;
            this.LblNoEdicion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblNoEdicion.Location = new System.Drawing.Point(347, 248);
            this.LblNoEdicion.Name = "LblNoEdicion";
            this.LblNoEdicion.Size = new System.Drawing.Size(76, 13);
            this.LblNoEdicion.TabIndex = 29;
            this.LblNoEdicion.Text = "No. de Edición";
            // 
            // NmPaginas
            // 
            this.NmPaginas.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.NmPaginas.Location = new System.Drawing.Point(673, 246);
            this.NmPaginas.Name = "NmPaginas";
            this.NmPaginas.Size = new System.Drawing.Size(83, 23);
            this.NmPaginas.TabIndex = 8;
            this.NmPaginas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NmPaginas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblAnioEdicion
            // 
            this.LblAnioEdicion.AutoSize = true;
            this.LblAnioEdicion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblAnioEdicion.Location = new System.Drawing.Point(68, 248);
            this.LblAnioEdicion.Name = "LblAnioEdicion";
            this.LblAnioEdicion.Size = new System.Drawing.Size(64, 13);
            this.LblAnioEdicion.TabIndex = 28;
            this.LblAnioEdicion.Text = "Año Edición";
            // 
            // NmEdicionNo
            // 
            this.NmEdicionNo.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.NmEdicionNo.Location = new System.Drawing.Point(443, 246);
            this.NmEdicionNo.Name = "NmEdicionNo";
            this.NmEdicionNo.Size = new System.Drawing.Size(83, 23);
            this.NmEdicionNo.TabIndex = 7;
            this.NmEdicionNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NmEdicionNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CboEdicionAnio
            // 
            this.CboEdicionAnio.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.CboEdicionAnio.FormattingEnabled = true;
            this.CboEdicionAnio.Location = new System.Drawing.Point(147, 246);
            this.CboEdicionAnio.Name = "CboEdicionAnio";
            this.CboEdicionAnio.Size = new System.Drawing.Size(127, 23);
            this.CboEdicionAnio.TabIndex = 6;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1490, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLibro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TabPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoLibros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibro)).EndInit();
            this.GrpEjemplares.ResumeLayout(false);
            this.GrpEjemplares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEjemplares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmEdicionNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DgvListadoLibros;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label LblISBN;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Label LblMateria;
        private System.Windows.Forms.Label LblNoPaginas;
        private System.Windows.Forms.Label LblNoEdicion;
        private System.Windows.Forms.Label LblAnioEdicion;
        private System.Windows.Forms.ComboBox CboEdicionAnio;
        private System.Windows.Forms.NumericUpDown NmEdicionNo;
        private System.Windows.Forms.NumericUpDown NmPaginas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox picLibro;
        private System.Windows.Forms.PictureBox picEditorial;
        private System.Windows.Forms.DataGridView DgvEjemplares;
        private System.Windows.Forms.Label LblTotalEjemplares;
        private System.Windows.Forms.Label LblidLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpEjemplares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEliminarEjemplares;
        private System.Windows.Forms.Button BtnCancelar2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarEjemplar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregarEjemplar;
        private System.Windows.Forms.Button btnModificarEjemplar;
    }
}