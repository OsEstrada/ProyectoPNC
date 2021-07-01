namespace SistemaBiblioteca.Presentacion
{
    partial class FrmLogin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MtbContrasenia = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblIniciarSesion = new System.Windows.Forms.Label();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.MtbContrasenia);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblIniciarSesion);
            this.panel1.Controls.Add(this.BtnIniciarSesion);
            this.panel1.Controls.Add(this.LblContrasenia);
            this.panel1.Controls.Add(this.LblUser);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, -11);
            this.panel1.MaximumSize = new System.Drawing.Size(579, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 380);
            this.panel1.TabIndex = 0;
            // 
            // MtbContrasenia
            // 
            this.MtbContrasenia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MtbContrasenia.ForeColor = System.Drawing.Color.Black;
            this.MtbContrasenia.Location = new System.Drawing.Point(168, 187);
            this.MtbContrasenia.Name = "MtbContrasenia";
            this.MtbContrasenia.PromptChar = '*';
            this.MtbContrasenia.Size = new System.Drawing.Size(321, 25);
            this.MtbContrasenia.TabIndex = 2;
            this.MtbContrasenia.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(131, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaBiblioteca.Presentacion.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(131, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // LblIniciarSesion
            // 
            this.LblIniciarSesion.AutoSize = true;
            this.LblIniciarSesion.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblIniciarSesion.Location = new System.Drawing.Point(196, 64);
            this.LblIniciarSesion.Name = "LblIniciarSesion";
            this.LblIniciarSesion.Size = new System.Drawing.Size(214, 37);
            this.LblIniciarSesion.TabIndex = 0;
            this.LblIniciarSesion.Text = "INICIAR SESIÓN";
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(168, 250);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(321, 30);
            this.BtnIniciarSesion.TabIndex = 3;
            this.BtnIniciarSesion.Text = "Iniciar Sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblContrasenia.Location = new System.Drawing.Point(57, 192);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.Size = new System.Drawing.Size(67, 15);
            this.LblContrasenia.TabIndex = 0;
            this.LblContrasenia.Text = "Contraseña";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUser.Location = new System.Drawing.Point(77, 151);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(47, 15);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(168, 146);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(321, 25);
            this.TxtUsuario.TabIndex = 1;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(604, 357);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblIniciarSesion;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.MaskedTextBox MtbContrasenia;
    }
}