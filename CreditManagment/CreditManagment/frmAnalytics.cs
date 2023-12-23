using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditManagment
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
        }

        private void frmAnalytics_Load(object sender, EventArgs e)
        {
            DataTable db = MemberGlobal.rechercher("SELECT SUM(TotalDebt) - SUM(TotalPayment) AS" +
                " 'Total Debt Balance' FROM (SELECT D.clientID," +
                " SUM(D.amount * D.quantity) AS TotalDebt, 0 AS TotalPayment FROM Debts AS D GROUP" +
                " BY D.clientID UNION ALL SELECT CP.clientID, 0 AS TotalDebt, SUM(CP.amountPaid)" +
                " AS TotalPayment FROM clientPayments AS CP GROUP BY CP.clientID) AS CombinedData;");
            if (db.Rows.Count != 0)
                lbl.Text = db.Rows[0][0].ToString() + "DH";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable db = MemberGlobal.rechercher(string.Format("SELECT C.idCL AS 'Client ID', C.nameCL AS " +
                "'Client Name', D.amount AS 'Debt Amount',D.Quantity, D.datePAY AS 'Debt Date' FROM Clients AS C INNER " +
                "JOIN Debts AS D ON C.idCL = D.clientID WHERE D.datePAY >= '{0}' AND D.datePAY <= '{1}';",dtp1.Value,dtp2.Value));
            if (db.Rows.Count != 0)
                dataGridView1.DataSource = db;
        }
    }
}
