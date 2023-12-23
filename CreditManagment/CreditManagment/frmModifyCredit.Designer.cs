namespace CreditManagment
{
    partial class frmModifyCredit
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbTypeService = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPaiment = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtSearch_Client = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Service type:";
            // 
            // NUDQuantity
            // 
            this.NUDQuantity.Location = new System.Drawing.Point(408, 115);
            this.NUDQuantity.Name = "NUDQuantity";
            this.NUDQuantity.Size = new System.Drawing.Size(120, 20);
            this.NUDQuantity.TabIndex = 39;
            // 
            // cmbTypeService
            // 
            this.cmbTypeService.FormattingEnabled = true;
            this.cmbTypeService.Location = new System.Drawing.Point(218, 115);
            this.cmbTypeService.Name = "cmbTypeService";
            this.cmbTypeService.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeService.TabIndex = 38;
            this.cmbTypeService.SelectedIndexChanged += new System.EventHandler(this.cmbTypeService_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Date de Paiment:";
            // 
            // dtpPaiment
            // 
            this.dtpPaiment.Location = new System.Drawing.Point(218, 78);
            this.dtpPaiment.Name = "dtpPaiment";
            this.dtpPaiment.Size = new System.Drawing.Size(200, 20);
            this.dtpPaiment.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Write\'s Client Name:";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(31, 229);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(520, 150);
            this.dgv.TabIndex = 34;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // txtSearch_Client
            // 
            this.txtSearch_Client.Location = new System.Drawing.Point(170, 203);
            this.txtSearch_Client.Name = "txtSearch_Client";
            this.txtSearch_Client.Size = new System.Drawing.Size(100, 20);
            this.txtSearch_Client.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(289, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(218, 51);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 31;
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(218, 16);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(100, 20);
            this.txtNameClient.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Client Name:";
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(466, 404);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 42;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // frmModifyCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 439);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NUDQuantity);
            this.Controls.Add(this.cmbTypeService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpPaiment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtSearch_Client);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtNameClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModifyCredit";
            this.Text = "frmModifyCredit";
            this.Load += new System.EventHandler(this.frmModifyCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUDQuantity;
        private System.Windows.Forms.ComboBox cmbTypeService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPaiment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtSearch_Client;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModify;
    }
}