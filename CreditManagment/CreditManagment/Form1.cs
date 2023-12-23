using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CreditManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DB_CreditMAnagerDataSet.Tables["DataTable1"]));
            this.reportViewer1.RefreshReport();
            //// TODO: cette ligne de code charge les données dans la table 'DB_CreditMAnagerDataSet.Debts'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.DebtsTableAdapter.Fill(this.DB_CreditMAnagerDataSet.Debts);
            //// TODO: cette ligne de code charge les données dans la table 'DB_CreditMAnagerDataSet.DataTable1'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.DataTable1TableAdapter.Fill(this.DB_CreditMAnagerDataSet.DataTable1, frmPAy.NRr);


            //this.reportViewer1.RefreshReport();

           
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
