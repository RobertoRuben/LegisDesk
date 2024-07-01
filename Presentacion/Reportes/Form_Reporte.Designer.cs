
namespace Presentacion.Reportes
{
    partial class Form_Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reporte));
            this.Sp_Listado_Normas_ArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsReporte = new Presentacion.Reportes.DsReporte();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_Listado_Normas_ArticulosTableAdapter = new Presentacion.Reportes.DsReporteTableAdapters.Sp_Listado_Normas_ArticulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_Normas_ArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_Listado_Normas_ArticulosBindingSource
            // 
            this.Sp_Listado_Normas_ArticulosBindingSource.DataMember = "Sp_Listado_Normas_Articulos";
            this.Sp_Listado_Normas_ArticulosBindingSource.DataSource = this.DsReporte;
            // 
            // DsReporte
            // 
            this.DsReporte.DataSetName = "DsReporte";
            this.DsReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsNormas";
            reportDataSource1.Value = this.Sp_Listado_Normas_ArticulosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.RptNormas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(811, 633);
            this.reportViewer1.TabIndex = 0;
            // 
            // Sp_Listado_Normas_ArticulosTableAdapter
            // 
            this.Sp_Listado_Normas_ArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 633);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Normas";
            this.Load += new System.EventHandler(this.Form_Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_Normas_ArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_Listado_Normas_ArticulosBindingSource;
        private DsReporte DsReporte;
        private DsReporteTableAdapters.Sp_Listado_Normas_ArticulosTableAdapter Sp_Listado_Normas_ArticulosTableAdapter;
    }
}