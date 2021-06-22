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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregarEjemplar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.LblMateria = new System.Windows.Forms.Label();
            this.LblNoPaginas = new System.Windows.Forms.Label();
            this.LblNoEdicion = new System.Windows.Forms.Label();
            this.LblAnioEdicion = new System.Windows.Forms.Label();
            this.CboEdicionAnio = new System.Windows.Forms.ComboBox();
            this.NmEdicionNo = new System.Windows.Forms.NumericUpDown();
            this.NmPaginas = new System.Windows.Forms.NumericUpDown();
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
            this.picEditorial = new System.Windows.Forms.PictureBox();
            this.picLibro = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoLibros)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmEdicionNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 699);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.tabPage1);
            this.TabPrincipal.Controls.Add(this.tabPage2);
            this.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPrincipal.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TabPrincipal.Location = new System.Drawing.Point(2, 26);
            this.TabPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(988, 671);
            this.TabPrincipal.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 646);
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
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(974, 640);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DgvListadoLibros
            // 
            this.DgvListadoLibros.AllowUserToAddRows = false;
            this.DgvListadoLibros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListadoLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListadoLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListadoLibros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListadoLibros.Location = new System.Drawing.Point(2, 42);
            this.DgvListadoLibros.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListadoLibros.Name = "DgvListadoLibros";
            this.DgvListadoLibros.ReadOnly = true;
            this.DgvListadoLibros.RowHeadersVisible = false;
            this.DgvListadoLibros.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListadoLibros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListadoLibros.RowTemplate.Height = 24;
            this.DgvListadoLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoLibros.Size = new System.Drawing.Size(970, 556);
            this.DgvListadoLibros.TabIndex = 0;
            this.DgvListadoLibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoLibros_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnBuscar);
            this.panel2.Controls.Add(this.TxtBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
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
            this.TxtBuscar.Size = new System.Drawing.Size(603, 22);
            this.TxtBuscar.TabIndex = 4;
            this.TxtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnEliminar);
            this.panel3.Controls.Add(this.LblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 602);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 36);
            this.panel3.TabIndex = 2;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.basura_24;
            this.BtnEliminar.Location = new System.Drawing.Point(3, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(30, 29);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(774, 10);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(79, 13);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "Total registros:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.BtnAgregarEjemplar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.TxtDescripcion);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.TxtMateria);
            this.tabPage2.Controls.Add(this.LblMateria);
            this.tabPage2.Controls.Add(this.LblNoPaginas);
            this.tabPage2.Controls.Add(this.LblNoEdicion);
            this.tabPage2.Controls.Add(this.LblAnioEdicion);
            this.tabPage2.Controls.Add(this.CboEdicionAnio);
            this.tabPage2.Controls.Add(this.NmEdicionNo);
            this.tabPage2.Controls.Add(this.NmPaginas);
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
            this.tabPage2.Controls.Add(this.picEditorial);
            this.tabPage2.Controls.Add(this.picLibro);
            this.tabPage2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(980, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Total Ejemplares:";
            // 
            // BtnAgregarEjemplar
            // 
            this.BtnAgregarEjemplar.BackColor = System.Drawing.Color.White;
            this.BtnAgregarEjemplar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAgregarEjemplar.FlatAppearance.BorderSize = 0;
            this.BtnAgregarEjemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarEjemplar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarEjemplar.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregarEjemplar.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.más_30;
            this.BtnAgregarEjemplar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarEjemplar.Location = new System.Drawing.Point(690, 300);
            this.BtnAgregarEjemplar.Name = "BtnAgregarEjemplar";
            this.BtnAgregarEjemplar.Size = new System.Drawing.Size(138, 43);
            this.BtnAgregarEjemplar.TabIndex = 9;
            this.BtnAgregarEjemplar.Text = "Agregar Ejemplar";
            this.BtnAgregarEjemplar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAgregarEjemplar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 353);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(684, 186);
            this.dataGridView1.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(140, 311);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Ejemplares";
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
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtDescripcion.Location = new System.Drawing.Point(219, 180);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(609, 55);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label13.Location = new System.Drawing.Point(140, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Descripción";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtMateria.Location = new System.Drawing.Point(583, 143);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(245, 22);
            this.TxtMateria.TabIndex = 4;
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblMateria.Location = new System.Drawing.Point(512, 146);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(46, 13);
            this.LblMateria.TabIndex = 0;
            this.LblMateria.Text = "Materia";
            // 
            // LblNoPaginas
            // 
            this.LblNoPaginas.AutoSize = true;
            this.LblNoPaginas.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblNoPaginas.Location = new System.Drawing.Point(640, 247);
            this.LblNoPaginas.Name = "LblNoPaginas";
            this.LblNoPaginas.Size = new System.Drawing.Size(79, 13);
            this.LblNoPaginas.TabIndex = 35;
            this.LblNoPaginas.Text = "No. de Páginas";
            // 
            // LblNoEdicion
            // 
            this.LblNoEdicion.AutoSize = true;
            this.LblNoEdicion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblNoEdicion.Location = new System.Drawing.Point(419, 247);
            this.LblNoEdicion.Name = "LblNoEdicion";
            this.LblNoEdicion.Size = new System.Drawing.Size(76, 13);
            this.LblNoEdicion.TabIndex = 29;
            this.LblNoEdicion.Text = "No. de Edición";
            // 
            // LblAnioEdicion
            // 
            this.LblAnioEdicion.AutoSize = true;
            this.LblAnioEdicion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblAnioEdicion.Location = new System.Drawing.Point(140, 247);
            this.LblAnioEdicion.Name = "LblAnioEdicion";
            this.LblAnioEdicion.Size = new System.Drawing.Size(64, 13);
            this.LblAnioEdicion.TabIndex = 28;
            this.LblAnioEdicion.Text = "Año Edición";
            // 
            // CboEdicionAnio
            // 
            this.CboEdicionAnio.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.CboEdicionAnio.FormattingEnabled = true;
            this.CboEdicionAnio.Location = new System.Drawing.Point(219, 245);
            this.CboEdicionAnio.Name = "CboEdicionAnio";
            this.CboEdicionAnio.Size = new System.Drawing.Size(127, 23);
            this.CboEdicionAnio.TabIndex = 6;
            // 
            // NmEdicionNo
            // 
            this.NmEdicionNo.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.NmEdicionNo.Location = new System.Drawing.Point(515, 245);
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
            // NmPaginas
            // 
            this.NmPaginas.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.NmPaginas.Location = new System.Drawing.Point(745, 245);
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
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtISBN.Location = new System.Drawing.Point(219, 143);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(245, 22);
            this.TxtISBN.TabIndex = 3;
            // 
            // LblISBN
            // 
            this.LblISBN.AutoSize = true;
            this.LblISBN.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblISBN.Location = new System.Drawing.Point(140, 146);
            this.LblISBN.Name = "LblISBN";
            this.LblISBN.Size = new System.Drawing.Size(30, 13);
            this.LblISBN.TabIndex = 0;
            this.LblISBN.Text = "ISBN";
            // 
            // TxtAutor
            // 
            this.TxtAutor.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtAutor.Location = new System.Drawing.Point(220, 105);
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
            this.BtnActualizar.Location = new System.Drawing.Point(142, 587);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(200, 30);
            this.BtnActualizar.TabIndex = 11;
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
            this.BtnCancelar.Location = new System.Drawing.Point(628, 587);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(200, 30);
            this.BtnCancelar.TabIndex = 12;
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
            this.BtnInsertar.Location = new System.Drawing.Point(142, 587);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(200, 30);
            this.BtnInsertar.TabIndex = 11;
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
            this.LblAutor.Location = new System.Drawing.Point(140, 108);
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
            // picEditorial
            // 
            this.picEditorial.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.editorial;
            this.picEditorial.Location = new System.Drawing.Point(101, 305);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 20);
            this.panel1.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(992, 699);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmEdicionNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLibro)).EndInit();
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picLibro;
        private System.Windows.Forms.PictureBox picEditorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAgregarEjemplar;
        private System.Windows.Forms.Label label1;
    }
}