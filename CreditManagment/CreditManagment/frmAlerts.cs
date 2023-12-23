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
    public partial class frmAlerts : Form
    {
        public frmAlerts()
        {
            InitializeComponent();
        }

        private void frmAlerts_Load(object sender, EventArgs e)
        {
            DataTable db = MemberGlobal.rechercher("SELECT C.idCL AS 'Client ID', C.nameCL AS 'Client Name', ISNULL(DebtData.totalDebts, 0) AS 'Total Debts', ISNULL(PaymentData.totalPayments, 0) AS 'Total Payments', ISNULL(DebtData.totalDebts, 0) - ISNULL(PaymentData.totalPayments, 0) AS 'Debt Balance' FROM Clients AS C LEFT JOIN (SELECT clientID, SUM(amount * quantity) AS totalDebts FROM Debts GROUP BY clientID) AS DebtData ON C.idCL = DebtData.clientID LEFT JOIN (SELECT clientID, SUM(amountPaid) AS totalPayments FROM clientPayments GROUP BY clientID) AS PaymentData ON C.idCL = PaymentData.clientID WHERE ISNULL(DebtData.totalDebts, 0) - ISNULL(PaymentData.totalPayments, 0) > 0;");
            if (db.Rows.Count != 0)
                dataGridView1.DataSource = db;
        }
    }
}
