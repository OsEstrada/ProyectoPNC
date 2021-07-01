﻿namespace SistemaBiblioteca.Presentacion.Reportes
{
    partial class FrmReportePrestamos
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
            this.ListarPrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsBiblioteca = new SistemaBiblioteca.Presentacion.Reportes.DsBiblioteca();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListarPrestamosTableAdapter = new SistemaBiblioteca.Presentacion.Reportes.DsBibliotecaTableAdapters.ListarPrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListarPrestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarPrestamosBindingSource
            // 
            this.ListarPrestamosBindingSource.DataMember = "ListarPrestamos";
            this.ListarPrestamosBindingSource.DataSource = this.DsBiblioteca;
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
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListarPrestamosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaBiblioteca.Presentacion.Reportes.RptPrestamosActivos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ListarPrestamosTableAdapter
            // 
            this.ListarPrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportePrestamos";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListarPrestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsBiblioteca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListarPrestamosBindingSource;
        private DsBiblioteca DsBiblioteca;
        private DsBibliotecaTableAdapters.ListarPrestamosTableAdapter ListarPrestamosTableAdapter;
    }
}