using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditManagment
{
    public partial class frmModifyCredit : Form
    {
        public frmModifyCredit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

                DataTable i = MemberGlobal.rechercher(string.Format(" select Debts.idDBTS as 'ID Debt', nameCL as 'Client Name', Debts.clientID,Debts.amount,Debts.datePAY as 'date',Categories.nameCAT as 'Service Type',Debts.categoryID,Debts.Quantity from Debts inner join Clients on clientID=idCL inner join Categories on idCAT=categoryID  where nameCL like '{0}%' ", txtSearch_Client.Text));
                if (i.Rows.Count != 0)
                    dgv.DataSource = i;
                else
                    MessageBox.Show("Not Found!");
           
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count != 0)
            {
               bool i= MemberGlobal.Insert_Edit_Delete(string.Format(" update Debts set   amount={0}, datePAY='{1}', categoryID={2}, Quantity={3} where idDBTS={4}"
                    ,  txtAmount.Text, dtpPaiment.Value, idCAT, NUDQuantity.Value,dgv.CurrentRow.Cells[0].Value.ToString()));
                if (i == true)
                    MessageBox.Show("Modified Successfully!");
                else
                    MessageBox.Show("Error!");
            }
        }

        SqlDataAdapter da_cat = new SqlDataAdapter("select * from Categories ", MemberGlobal.cnxstring);
        DataSet Ds = new DataSet();
        int idCAT;
        private void cmbTypeService_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MemberGlobal.rechercher(string.Format("select idCAT from Categories where nameCAT='{0}' ", cmbTypeService.Text));
            idCAT = int.Parse(dt.Rows[0][0].ToString());
          
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
txtAmount.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            txtNameClient.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            NUDQuantity.Value = int.Parse(dgv.CurrentRow.Cells[7].Value.ToString());
            dtpPaiment.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            cmbTypeService.Text = dgv.CurrentRow.Cells[5].Value.ToString();
        }

        private void frmModifyCredit_Load(object sender, EventArgs e)
        {
            
            da_cat.Fill(Ds, "m");
            cmbTypeService.SelectedIndexChanged -= new EventHandler(cmbTypeService_SelectedIndexChanged);
            cmbTypeService.DataSource = Ds.Tables[0];
            idCAT = 1;
            cmbTypeService.DisplayMember = "nameCAT";
            cmbTypeService.SelectedIndexChanged += new EventHandler(cmbTypeService_SelectedIndexChanged);
        }
    }
}
