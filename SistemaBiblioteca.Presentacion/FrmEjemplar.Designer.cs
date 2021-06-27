namespace SistemaBiblioteca.Presentacion
{
    partial class FrmEjemplar
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
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.TxtIdioma = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtUbicacion.Location = new System.Drawing.Point(122, 42);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(245, 22);
            this.TxtUbicacion.TabIndex = 1;
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblUbicacion.Location = new System.Drawing.Point(44, 45);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(69, 13);
            this.LblUbicacion.TabIndex = 0;
            this.LblUbicacion.Text = "Ubicación (*)";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtEditorial.Location = new System.Drawing.Point(122, 73);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(245, 22);
            this.TxtEditorial.TabIndex = 2;
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblEditorial.Location = new System.Drawing.Point(44, 76);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(62, 13);
            this.LblEditorial.TabIndex = 0;
            this.LblEditorial.Text = "Editorial (*)";
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblIdioma.Location = new System.Drawing.Point(44, 143);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(40, 13);
            this.LblIdioma.TabIndex = 0;
            this.LblIdioma.Text = "Idioma";
            // 
            // TxtIdioma
            // 
            this.TxtIdioma.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.TxtIdioma.Location = new System.Drawing.Point(122, 140);
            this.TxtIdioma.Name = "TxtIdioma";
            this.TxtIdioma.Size = new System.Drawing.Size(245, 22);
            this.TxtIdioma.TabIndex = 4;
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.txtPais.Location = new System.Drawing.Point(122, 109);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(245, 22);
            this.txtPais.TabIndex = 3;
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblPais.Location = new System.Drawing.Point(44, 109);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(27, 13);
            this.LblPais.TabIndex = 0;
            this.LblPais.Text = "País";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(47, 232);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(150, 30);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(217, 232);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 30);
            this.BtnCancelar.TabIndex = 7;
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
            this.BtnInsertar.Location = new System.Drawing.Point(47, 232);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(150, 30);
            this.BtnInsertar.TabIndex = 6;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.LblEstado.Location = new System.Drawing.Point(44, 178);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(54, 13);
            this.LblEstado.TabIndex = 0;
            this.LblEstado.Text = "Estado (*)";
            // 
            // CboEstado
            // 
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Items.AddRange(new object[] {
            "Disponible",
            "Prestado"});
            this.CboEstado.Location = new System.Drawing.Point(122, 178);
            this.CboEstado.MaxDropDownItems = 4;
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(245, 21);
            this.CboEstado.TabIndex = 5;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(44, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(*) Indica que el dato es obligatorio.";
            // 
            // FrmEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboEstado);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.LblIdioma);
            this.Controls.Add(this.TxtIdioma);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.TxtUbicacion);
            this.Controls.Add(this.LblUbicacion);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.LblEditorial);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmEjemplar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.TextBox TxtIdioma;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Label label3;
    }
}