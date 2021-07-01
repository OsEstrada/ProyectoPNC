namespace SistemaBiblioteca.Presentacion.Reportes
{
    partial class FrmReporteLibros
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ListarLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsBiblioteca = new SistemaBiblioteca.Presentacion.Reportes.DsBiblioteca();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListarLibrosTableAdapter = new SistemaBiblioteca.Presentacion.Reportes.DsBibliotecaTableAdapters.ListarLibrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListarLibrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarLibrosBindingSource
            // 
            this.ListarLibrosBindingSource.DataMember = "ListarLibros";
            this.ListarLibrosBindingSource.DataSource = this.DsBiblioteca;
            // 
            // DsBiblioteca
            // 
            this.DsBiblioteca.DataSetName = "DsBiblioteca";
            this.DsBiblioteca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DimGray;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ListadoLibros";
            reportDataSource1.Value = this.ListarLibrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaBiblioteca.Presentacion.Reportes.RptLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ListarLibrosTableAdapter
            // 
            this.ListarLibrosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteLibros";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListarLibrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsBiblioteca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListarLibrosBindingSource;
        private DsBiblioteca DsBiblioteca;
        private DsBibliotecaTableAdapters.ListarLibrosTableAdapter ListarLibrosTableAdapter;
    }
}