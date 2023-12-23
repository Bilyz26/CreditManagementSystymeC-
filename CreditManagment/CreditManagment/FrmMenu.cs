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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
       
        private Form activeform = null;
        private void openChildFormInPanelFormes(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();

            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormes.Controls.Add(childForm);
            panelFormes.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }


        private void makebtnSilver()
        {
            btnaide.BackColor = Color.Silver;
            btnalerts.BackColor = Color.Silver;
            btnanalytic.BackColor = Color.Silver;
            btnFrmClient.BackColor = Color.Silver;
            btnFrmDebts.BackColor = Color.Silver;
            btnFrmpay.BackColor = Color.Silver;


            //--------------------------------------------------------------------------------------------------------
            
        }
        private void makebtnwhite(object sender)
        {

            Button b = (Button)sender;

           
            b.BackColor = Color.White;
        }


        private void btnaide_Click(object sender, EventArgs e)
        {
            
        }

        private void totaleDebts()
        {
            DataTable db = MemberGlobal.rechercher("SELECT C.idCL AS 'Client ID', C.nameCL AS 'Client Name'," +
                   " ISNULL(DebtData.totalDebts, 0) AS 'Total Debts', ISNULL(PaymentData.totalPayments, 0) AS " +
                   "'Total Payments', ISNULL(DebtData.totalDebts, 0) - ISNULL(PaymentData.totalPayments, 0) " +
                   "AS 'Debt Balance' FROM Clients AS C LEFT JOIN (SELECT clientID, SUM(amount * quantity) " +
                   "AS totalDebts FROM Debts GROUP BY clientID) AS DebtData ON C.idCL = DebtData.clientID " +
                   "LEFT JOIN (SELECT clientID, SUM(amountPaid) AS totalPayments FROM clientPayments GROUP" +
                   " BY clientID) AS PaymentData ON C.idCL = PaymentData.clientID WHERE " +
                   "ISNULL(DebtData.totalDebts, 0) - ISNULL(PaymentData.totalPayments, 0) > 0;");
            lbl.Text = db.Rows.Count.ToString();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            totaleDebts();
        }

        private void btnFrmDebts_Click(object sender, EventArgs e)
        {
            totaleDebts();
            openChildFormInPanelFormes(new frmAddCredit());
            makebtnSilver();
            makebtnwhite(sender);

        }

        private void btnFrmClient_Click(object sender, EventArgs e)
        {
            totaleDebts();
            openChildFormInPanelFormes(new frmAddClient()); makebtnSilver();
            makebtnwhite(sender);
        }

        private void btnFrmpay_Click(object sender, EventArgs e)
        {
            totaleDebts();
            openChildFormInPanelFormes(new frmPAy()); makebtnSilver();
            makebtnwhite(sender);
        }

        private void btnanalytic_Click(object sender, EventArgs e)
        {
            totaleDebts();
            openChildFormInPanelFormes(new frmAnalytics()); makebtnSilver();
            makebtnwhite(sender);
        }

        private void btnalerts_Click(object sender, EventArgs e)
        {
            totaleDebts();
            openChildFormInPanelFormes(new frmAlerts()); makebtnSilver();
            makebtnwhite(sender);
        }
    }
}
