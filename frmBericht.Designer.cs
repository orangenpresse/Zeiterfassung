namespace Zeiterfassung
{
    partial class frmBericht
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Bericht = new Zeiterfassung.Bericht();
            this.BerichtZeitenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bericht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BerichtZeitenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Bericht_BerichtZeiten";
            reportDataSource1.Value = this.BerichtZeitenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Zeiterfassung.CVJMReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(716, 656);
            this.reportViewer1.TabIndex = 0;
            // 
            // Bericht
            // 
            this.Bericht.DataSetName = "Bericht";
            this.Bericht.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BerichtZeitenBindingSource
            // 
            this.BerichtZeitenBindingSource.DataMember = "BerichtZeiten";
            this.BerichtZeitenBindingSource.DataSource = this.Bericht;
            // 
            // frmBericht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(716, 656);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBericht";
            this.Text = "Bericht";
            this.Load += new System.EventHandler(this.frmBericht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bericht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BerichtZeitenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BerichtZeitenBindingSource;
        private Bericht Bericht;








    }
}