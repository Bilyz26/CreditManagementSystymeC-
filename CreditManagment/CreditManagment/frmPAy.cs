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
    public partial class frmPAy : Form
    {
        public frmPAy()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            DataTable i = MemberGlobal.rechercher(string.Format(" SELECT  Clients.idCL AS 'clientID', Clients.nameCL AS 'Client Name',ISNULL(debt.totalDebts, 0) AS 'Total Debts',    ISNULL(payment.totalPaid, 0) AS 'Total Paid', (ISNULL(debt.totalDebts, 0) - ISNULL(payment.totalPaid, 0)) AS 'Pending Debts' " +
                " FROM Clients" +
                " LEFT JOIN(SELECT clientID, SUM(amount * Quantity) AS totalDebts FROM Debts GROUP BY clientID) AS debt ON Clients.idCL = debt.clientID" +
                " LEFT JOIN(SELECT clientID, SUM(amountPaid) AS totalPaid FROM clientPayments GROUP BY clientID) AS payment ON Clients.idCL = payment.clientID " +
                "WHERE Clients.nameCL LIKE '{0}%' ", txtSearch_Client.Text));

            if (i.Rows.Count != 0)
                dgv.DataSource = i;
            else
                MessageBox.Show("Not Found!");

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            txtName.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            DataTable db = MemberGlobal.rechercher("SELECT D.* FROM Debts AS D LEFT JOIN clientPayments AS CP" +
                " ON D.idDBTS = CP.idDBTS WHERE D.clientID = " + dgv.CurrentRow.Cells[0].Value.ToString() + "  AND CP.idDBTS IS NULL; ");
            dataGridView1.DataSource = db;
        }




        public static int NRr;
        string d;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //loed new receipt after adding new paiment
         
            double aP;
            if (dataGridView1.Rows.Count != 0 && txtNR.Text != "")
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {aP = double.Parse(row.Cells[2].Value.ToString()) * double.Parse(row.Cells[5].Value.ToString());
                   d= string.Format("insert into clientPayments values ({0},{1},'{2}',{3},{4})", row.Cells[1].Value, aP, dateTimePicker1.Value,
                                                                    row.Cells[0].Value, txtNR.Text);
                    
                    
                    MemberGlobal.Insert_Edit_Delete(d);
                    

                }
                NRr = int.Parse(txtNR.Text);
           
                Form1 f = new Form1();
                f.Show();
                MemberGlobal.vider(this);

                NRiceipt();
            }
        }

        private void frmPAy_Load(object sender, EventArgs e)
        {

            NRiceipt();

        }
        private void NRiceipt ()
        {
            int NR;
            DataTable db = MemberGlobal.rechercher("select max(NR) from clientPayments ");
            if (db.Rows[0][0].ToString() == "")
            {
                NR = 10000;

                txtNR.Text = dateTimePicker1.Value.Year.ToString() + NR.ToString();
            }
            else
            {
                int test;
                test = int.Parse(dateTimePicker1.Value.Year.ToString()) + 99999;

                if(test <= int.Parse(db.Rows[0][0].ToString()))
                {
                    NR = int.Parse(db.Rows[0][0].ToString()) + 1;
                txtNR.Text = NR.ToString();
                }
                else
                {
                    NR= int.Parse(db.Rows[0][0].ToString()) + 1;
                    txtNR.Text = dateTimePicker1.Value.Year.ToString() + NR.ToString();
                }


            }
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        //----------------------------------------------------------------------------------------------------------
        

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReceipt f = new frmReceipt();
            f.Show();
        }
    }
}
