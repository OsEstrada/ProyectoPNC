namespace SistemaBiblioteca.Presentacion
{
    partial class FrmEjemplarPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvListadoEjemplares = new System.Windows.Forms.DataGridView();
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
            this.label15 = new System.Windows.Forms.Label();
            this.BtnCancelar2 = new System.Windows.Forms.Button();
            this.picLibro = new System.Windows.Forms.PictureBox();
            this.DgvListadoLibro = new System.Windows.Forms.DataGridView();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.TxtIdioma = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.BtnBuscarLibro = new System.Windows.Forms.Button();
            this.BtnAgregarEjemplar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoEjemplares)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tableLayoutPanel2.Controls.Add(this.DgvListadoEjemplares, 0, 1);
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
            // DgvListadoEjemplares
            // 
            this.DgvListadoEjemplares.AllowUserToAddRows = false;
            this.DgvListadoEjemplares.AllowUserToDeleteRows = false;
            this.DgvListadoEjemplares.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListadoEjemplares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvListadoEjemplares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListadoEjemplares.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvListadoEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadoEjemplares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListadoEjemplares.Location = new System.Drawing.Point(0, 40);
            this.DgvListadoEjemplares.Margin = new System.Windows.Forms.Padding(0);
            this.DgvListadoEjemplares.Name = "DgvListadoEjemplares";
            this.DgvListadoEjemplares.RowHeadersVisible = false;
            this.DgvListadoEjemplares.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListadoEjemplares.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvListadoEjemplares.RowTemplate.Height = 24;
            this.DgvListadoEjemplares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoEjemplares.Size = new System.Drawing.Size(1482, 632);
            this.DgvListadoEjemplares.TabIndex = 0;
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 959F));
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
            this.panel4.Controls.Add(this.BtnAgregarEjemplar);
            this.panel4.Controls.Add(this.BtnBuscarLibro);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtBuscarLibro);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.CboEstado);
            this.panel4.Controls.Add(this.LblEstado);
            this.panel4.Controls.Add(this.LblIdioma);
            this.panel4.Controls.Add(this.TxtIdioma);
            this.panel4.Controls.Add(this.txtPais);
            this.panel4.Controls.Add(this.LblPais);
            this.panel4.Controls.Add(this.TxtUbicacion);
            this.panel4.Controls.Add(this.LblUbicacion);
            this.panel4.Controls.Add(this.TxtEditorial);
            this.panel4.Controls.Add(this.LblEditorial);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.BtnCancelar2);
            this.panel4.Controls.Add(this.picLibro);
            this.panel4.Controls.Add(this.DgvListadoLibro);
            this.panel4.Controls.Add(this.BtnActualizar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(264, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(953, 706);
            this.panel4.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(68, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Seleccionar Libro";
            // 
            // BtnCancelar2
            // 
            this.BtnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar2.Location = new System.Drawing.Point(712, 590);
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
            // DgvListadoLibro
            // 
            this.DgvListadoLibro.AllowUserToAddRows = false;
            this.DgvListadoLibro.AllowUserToDeleteRows = false;
            this.DgvListadoLibro.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListadoLibro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvListadoLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListadoLibro.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListadoLibro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvListadoLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListadoLibro.DefaultCellStyle = dataGridViewCellStyle9;
            this.DgvListadoLibro.Location = new System.Drawing.Point(72, 94);
            this.DgvListadoLibro.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListadoLibro.Name = "DgvListadoLibro";
            this.DgvListadoLibro.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListadoLibro.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvListadoLibro.RowHeadersVisible = false;
            this.DgvListadoLibro.RowHeadersWidth = 51;
            this.DgvListadoLibro.RowTemplate.Height = 24;
            this.DgvListadoLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoLibro.Size = new System.Drawing.Size(840, 196);
            this.DgvListadoLibro.TabIndex = 10;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(72, 590);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(200, 30);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // CboEstado
            // 
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Items.AddRange(new object[] {
            "Disponible",
            "Prestado"});
            this.CboEstado.Location = new System.Drawing.Point(158, 504);
            this.CboEstado.MaxDropDownItems = 4;
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(290, 21);
            this.CboEstado.TabIndex = 55;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblEstado.Location = new System.Drawing.Point(80, 507);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(54, 13);
            this.LblEstado.TabIndex = 46;
            this.LblEstado.Text = "Estado (*)";
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblIdioma.Location = new System.Drawing.Point(489, 468);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(40, 13);
            this.LblIdioma.TabIndex = 47;
            this.LblIdioma.Text = "Idioma";
            // 
            // TxtIdioma
            // 
            this.TxtIdioma.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtIdioma.Location = new System.Drawing.Point(551, 465);
            this.TxtIdioma.Name = "TxtIdioma";
            this.TxtIdioma.Size = new System.Drawing.Size(282, 22);
            this.TxtIdioma.TabIndex = 54;
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.txtPais.Location = new System.Drawing.Point(158, 465);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(290, 22);
            this.txtPais.TabIndex = 53;
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblPais.Location = new System.Drawing.Point(80, 468);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(27, 13);
            this.LblPais.TabIndex = 48;
            this.LblPais.Text = "País";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtUbicacion.Location = new System.Drawing.Point(158, 397);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(675, 22);
            this.TxtUbicacion.TabIndex = 51;
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblUbicacion.Location = new System.Drawing.Point(80, 400);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(69, 13);
            this.LblUbicacion.TabIndex = 49;
            this.LblUbicacion.Text = "Ubicación (*)";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtEditorial.Location = new System.Drawing.Point(158, 428);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(675, 22);
            this.TxtEditorial.TabIndex = 52;
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblEditorial.Location = new System.Drawing.Point(80, 431);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(62, 13);
            this.LblEditorial.TabIndex = 50;
            this.LblEditorial.Text = "Editorial (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Datos Ejemplar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.libro;
            this.pictureBox1.Location = new System.Drawing.Point(29, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(69, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "(*) Indica que el dato es obligatorio.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Frase o código";
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Location = new System.Drawing.Point(158, 55);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(531, 22);
            this.txtBuscarLibro.TabIndex = 62;
            // 
            // BtnBuscarLibro
            // 
            this.BtnBuscarLibro.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnBuscarLibro.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnBuscarLibro.FlatAppearance.BorderSize = 0;
            this.BtnBuscarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarLibro.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarLibro.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarLibro.Location = new System.Drawing.Point(697, 49);
            this.BtnBuscarLibro.Name = "BtnBuscarLibro";
            this.BtnBuscarLibro.Size = new System.Drawing.Size(136, 30);
            this.BtnBuscarLibro.TabIndex = 64;
            this.BtnBuscarLibro.Text = "Buscar Libro";
            this.BtnBuscarLibro.UseVisualStyleBackColor = false;
            this.BtnBuscarLibro.Click += new System.EventHandler(this.BtnBuscarLibro_Click);
            // 
            // BtnAgregarEjemplar
            // 
            this.BtnAgregarEjemplar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAgregarEjemplar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAgregarEjemplar.FlatAppearance.BorderSize = 0;
            this.BtnAgregarEjemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarEjemplar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarEjemplar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarEjemplar.Location = new System.Drawing.Point(72, 590);
            this.BtnAgregarEjemplar.Name = "BtnAgregarEjemplar";
            this.BtnAgregarEjemplar.Size = new System.Drawing.Size(200, 30);
            this.BtnAgregarEjemplar.TabIndex = 65;
            this.BtnAgregarEjemplar.Text = "Agregar Ejemplar";
            this.BtnAgregarEjemplar.UseVisualStyleBackColor = false;
            this.BtnAgregarEjemplar.Click += new System.EventHandler(this.BtnAgregarEjemplar_Click_1);
            // 
            // FrmEjemplarPrincipal
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
            this.Name = "FrmEjemplarPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEjemplarPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TabPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoEjemplares)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DgvListadoEjemplares;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox picLibro;
        private System.Windows.Forms.DataGridView DgvListadoLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.TextBox TxtIdioma;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.Button BtnBuscarLibro;
        private System.Windows.Forms.Button BtnAgregarEjemplar;
    }
}