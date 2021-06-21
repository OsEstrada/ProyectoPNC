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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvListadoLibros = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.LblISBN = new System.Windows.Forms.Label();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NmPaginas = new System.Windows.Forms.NumericUpDown();
            this.NmEdicionNo = new System.Windows.Forms.NumericUpDown();
            this.CboEdicionAnio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNoEdicion = new System.Windows.Forms.Label();
            this.LblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.TxtIdioma = new System.Windows.Forms.TextBox();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.LblNoPaginas = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.LblMateria = new System.Windows.Forms.Label();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LblEjemplar = new System.Windows.Forms.Label();
            this.NmEjemplar = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.picEditorial = new System.Windows.Forms.PictureBox();
            this.picLibro = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoLibros)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmEdicionNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmEjemplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TabPrincipal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 632);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.tabPage1);
            this.TabPrincipal.Controls.Add(this.tabPage2);
            this.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPrincipal.Location = new System.Drawing.Point(2, 26);
            this.TabPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(988, 604);
            this.TabPrincipal.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(980, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(974, 572);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DgvListadoLibros
            // 
            this.DgvListadoLibros.AllowUserToAddRows = false;
            this.DgvListadoLibros.AllowUserToDeleteRows = false;
            this.DgvListadoLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListadoLibros.Location = new System.Drawing.Point(2, 42);
            this.DgvListadoLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvListadoLibros.Name = "DgvListadoLibros";
            this.DgvListadoLibros.RowHeadersWidth = 51;
            this.DgvListadoLibros.RowTemplate.Height = 24;
            this.DgvListadoLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoLibros.Size = new System.Drawing.Size(970, 488);
            this.DgvListadoLibros.TabIndex = 0;
            this.DgvListadoLibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoLibros_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 36);
            this.panel2.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(712, 6);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(170, 22);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(88, 6);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(603, 20);
            this.TxtBuscar.TabIndex = 4;
            this.TxtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnEliminar);
            this.panel3.Controls.Add(this.LblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 534);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 36);
            this.panel3.TabIndex = 2;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(88, 6);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(80, 22);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(774, 10);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(76, 13);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "Total registros:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.picEditorial);
            this.tabPage2.Controls.Add(this.picLibro);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.LblEjemplar);
            this.tabPage2.Controls.Add(this.NmEjemplar);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.TxtDescripcion);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.TxtUbicacion);
            this.tabPage2.Controls.Add(this.LblUbicacion);
            this.tabPage2.Controls.Add(this.TxtMateria);
            this.tabPage2.Controls.Add(this.LblMateria);
            this.tabPage2.Controls.Add(this.LblNoPaginas);
            this.tabPage2.Controls.Add(this.LblIdioma);
            this.tabPage2.Controls.Add(this.TxtIdioma);
            this.tabPage2.Controls.Add(this.txtPais);
            this.tabPage2.Controls.Add(this.LblPais);
            this.tabPage2.Controls.Add(this.LblNoEdicion);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.CboEdicionAnio);
            this.tabPage2.Controls.Add(this.NmEdicionNo);
            this.tabPage2.Controls.Add(this.NmPaginas);
            this.tabPage2.Controls.Add(this.TxtEditorial);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TxtISBN);
            this.tabPage2.Controls.Add(this.LblISBN);
            this.tabPage2.Controls.Add(this.TxtAutor);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.TxtTitulo);
            this.tabPage2.Controls.Add(this.LblAutor);
            this.tabPage2.Controls.Add(this.LblTitulo);
            this.tabPage2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(980, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtISBN.Location = new System.Drawing.Point(219, 149);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(245, 22);
            this.TxtISBN.TabIndex = 3;
            // 
            // LblISBN
            // 
            this.LblISBN.AutoSize = true;
            this.LblISBN.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblISBN.Location = new System.Drawing.Point(140, 152);
            this.LblISBN.Name = "LblISBN";
            this.LblISBN.Size = new System.Drawing.Size(30, 13);
            this.LblISBN.TabIndex = 0;
            this.LblISBN.Text = "ISBN";
            // 
            // TxtAutor
            // 
            this.TxtAutor.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtAutor.Location = new System.Drawing.Point(220, 111);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(608, 22);
            this.TxtAutor.TabIndex = 2;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(143, 509);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(200, 30);
            this.BtnActualizar.TabIndex = 14;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(140, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "(*) Indica que el dato es obligatorio.";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(629, 509);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(200, 30);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnInsertar.FlatAppearance.BorderSize = 0;
            this.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.ForeColor = System.Drawing.Color.White;
            this.BtnInsertar.Location = new System.Drawing.Point(143, 509);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(200, 30);
            this.BtnInsertar.TabIndex = 14;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtId.Location = new System.Drawing.Point(745, 16);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(82, 22);
            this.TxtId.TabIndex = 0;
            this.TxtId.Visible = false;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtTitulo.Location = new System.Drawing.Point(220, 70);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(608, 22);
            this.TxtTitulo.TabIndex = 1;
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblAutor.Location = new System.Drawing.Point(140, 114);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(51, 13);
            this.LblAutor.TabIndex = 0;
            this.LblAutor.Text = "Autor(es)";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblTitulo.Location = new System.Drawing.Point(141, 73);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(49, 13);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Título (*)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 20);
            this.panel1.TabIndex = 0;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtEditorial.Location = new System.Drawing.Point(219, 390);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(609, 22);
            this.TxtEditorial.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(141, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Editorial";
            // 
            // NmPaginas
            // 
            this.NmPaginas.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.NmPaginas.Location = new System.Drawing.Point(745, 430);
            this.NmPaginas.Name = "NmPaginas";
            this.NmPaginas.Size = new System.Drawing.Size(83, 22);
            this.NmPaginas.TabIndex = 13;
            // 
            // NmEdicionNo
            // 
            this.NmEdicionNo.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.NmEdicionNo.Location = new System.Drawing.Point(493, 430);
            this.NmEdicionNo.Name = "NmEdicionNo";
            this.NmEdicionNo.Size = new System.Drawing.Size(98, 22);
            this.NmEdicionNo.TabIndex = 12;
            // 
            // CboEdicionAnio
            // 
            this.CboEdicionAnio.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.CboEdicionAnio.FormattingEnabled = true;
            this.CboEdicionAnio.Location = new System.Drawing.Point(219, 430);
            this.CboEdicionAnio.Name = "CboEdicionAnio";
            this.CboEdicionAnio.Size = new System.Drawing.Size(127, 21);
            this.CboEdicionAnio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(140, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Año";
            // 
            // LblNoEdicion
            // 
            this.LblNoEdicion.AutoSize = true;
            this.LblNoEdicion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblNoEdicion.Location = new System.Drawing.Point(387, 432);
            this.LblNoEdicion.Name = "LblNoEdicion";
            this.LblNoEdicion.Size = new System.Drawing.Size(76, 13);
            this.LblNoEdicion.TabIndex = 29;
            this.LblNoEdicion.Text = "No. de Edición";
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblPais.Location = new System.Drawing.Point(140, 189);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(27, 13);
            this.LblPais.TabIndex = 0;
            this.LblPais.Text = "País";
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.txtPais.Location = new System.Drawing.Point(219, 186);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(245, 22);
            this.txtPais.TabIndex = 5;
            // 
            // TxtIdioma
            // 
            this.TxtIdioma.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtIdioma.Location = new System.Drawing.Point(583, 186);
            this.TxtIdioma.Name = "TxtIdioma";
            this.TxtIdioma.Size = new System.Drawing.Size(245, 22);
            this.TxtIdioma.TabIndex = 6;
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblIdioma.Location = new System.Drawing.Point(512, 189);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(40, 13);
            this.LblIdioma.TabIndex = 0;
            this.LblIdioma.Text = "Idioma";
            // 
            // LblNoPaginas
            // 
            this.LblNoPaginas.AutoSize = true;
            this.LblNoPaginas.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblNoPaginas.Location = new System.Drawing.Point(640, 432);
            this.LblNoPaginas.Name = "LblNoPaginas";
            this.LblNoPaginas.Size = new System.Drawing.Size(79, 13);
            this.LblNoPaginas.TabIndex = 35;
            this.LblNoPaginas.Text = "No. de Páginas";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtMateria.Location = new System.Drawing.Point(583, 149);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(245, 22);
            this.TxtMateria.TabIndex = 4;
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblMateria.Location = new System.Drawing.Point(512, 152);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(46, 13);
            this.LblMateria.TabIndex = 0;
            this.LblMateria.Text = "Materia";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtUbicacion.Location = new System.Drawing.Point(219, 297);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(372, 22);
            this.TxtUbicacion.TabIndex = 8;
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblUbicacion.Location = new System.Drawing.Point(141, 300);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.LblUbicacion.TabIndex = 38;
            this.LblUbicacion.Text = "Ubicación";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtDescripcion.Location = new System.Drawing.Point(219, 225);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(609, 55);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label13.Location = new System.Drawing.Point(141, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Descripción";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label14.Location = new System.Drawing.Point(700, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "No.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(140, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Información Básica";
            // 
            // LblEjemplar
            // 
            this.LblEjemplar.AutoSize = true;
            this.LblEjemplar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblEjemplar.Location = new System.Drawing.Point(625, 300);
            this.LblEjemplar.Name = "LblEjemplar";
            this.LblEjemplar.Size = new System.Drawing.Size(95, 13);
            this.LblEjemplar.TabIndex = 0;
            this.LblEjemplar.Text = "No. de Ejemplares";
            // 
            // NmEjemplar
            // 
            this.NmEjemplar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.NmEjemplar.Location = new System.Drawing.Point(745, 297);
            this.NmEjemplar.Name = "NmEjemplar";
            this.NmEjemplar.Size = new System.Drawing.Size(83, 22);
            this.NmEjemplar.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(140, 347);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Información de Edición";
            // 
            // picEditorial
            // 
            this.picEditorial.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.editorial;
            this.picEditorial.Location = new System.Drawing.Point(101, 341);
            this.picEditorial.Name = "picEditorial";
            this.picEditorial.Size = new System.Drawing.Size(33, 31);
            this.picEditorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditorial.TabIndex = 40;
            this.picEditorial.TabStop = false;
            // 
            // picLibro
            // 
            this.picLibro.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.libro;
            this.picLibro.Location = new System.Drawing.Point(101, 19);
            this.picLibro.Name = "picLibro";
            this.picLibro.Size = new System.Drawing.Size(33, 31);
            this.picLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLibro.TabIndex = 39;
            this.picLibro.TabStop = false;
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(992, 632);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLibro";
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
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmEdicionNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmEjemplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DgvListadoLibros;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Label LblMateria;
        private System.Windows.Forms.Label LblNoPaginas;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.TextBox TxtIdioma;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.Label LblNoEdicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboEdicionAnio;
        private System.Windows.Forms.NumericUpDown NmEdicionNo;
        private System.Windows.Forms.NumericUpDown NmPaginas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LblEjemplar;
        private System.Windows.Forms.NumericUpDown NmEjemplar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picLibro;
        private System.Windows.Forms.PictureBox picEditorial;
    }
}