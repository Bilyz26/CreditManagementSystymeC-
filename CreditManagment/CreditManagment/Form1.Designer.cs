namespace CreditManagment
{
    partial class Form1
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
            this.DebtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_CreditMAnagerDataSet = new CreditManagment.DB_CreditMAnagerDataSet();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DebtsTableAdapter = new CreditManagment.DB_CreditMAnagerDataSetTableAdapters.DebtsTableAdapter();
            this.DataTable1TableAdapter = new CreditManagment.DB_CreditMAnagerDataSetTableAdapters.DataTable1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DebtsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_CreditMAnagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DebtsBindingSource
            // 
            this.DebtsBindingSource.DataMember = "Debts";
            this.DebtsBindingSource.DataSource = this.DB_CreditMAnagerDataSet;
            // 
            // DB_CreditMAnagerDataSet
            // 
            this.DB_CreditMAnagerDataSet.DataSetName = "DB_CreditMAnagerDataSet";
            this.DB_CreditMAnagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DB_CreditMAnagerDataSet;
            // 
            // DebtsTableAdapter
            // 
            this.DebtsTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 200;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreditManagment.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(490, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 50;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DebtsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_CreditMAnagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource DebtsBindingSource;
        private DB_CreditMAnagerDataSet DB_CreditMAnagerDataSet;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DB_CreditMAnagerDataSetTableAdapters.DebtsTableAdapter DebtsTableAdapter;
        private DB_CreditMAnagerDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}