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
    public partial class frmAddCredit : Form
    {
        public frmAddCredit()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch_Client.Text != "")
            {

                DataTable i= MemberGlobal.rechercher(string.Format(" select * from Clients where nameCL like '{0}%' " , txtSearch_Client.Text));
                if (i.Rows.Count != 0)
                    dgv.DataSource = i;
                else
                    MessageBox.Show("Error!");
            }
            
           
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count != 0 && txtAmount.Text!=""&& NUDQuantity.Value!=0 )
            {

                bool i = MemberGlobal.Insert_Edit_Delete(string.Format("insert into Debts values({0},{1},'{2}'," +
                    "{3},{4} )", dgv.CurrentRow.Cells[0].Value.ToString(), txtAmount.Text, dtpPaiment.Value,cmbTypeService.SelectedValue.ToString(), NUDQuantity.Value));
                if (i == true)
                    MessageBox.Show("Added Successfully!");
                else
                    MessageBox.Show("Error!");
            }
            else
            {


                MessageBox.Show("Please Select a Client!");

            }
            MemberGlobal.vider(this);
        }
 SqlDataAdapter da_cat = new SqlDataAdapter("select * from Categories ", MemberGlobal.cnxstring);
           DataSet Ds = new DataSet();
        
        private void cmbTypeService_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        private void frmAddCredit_Load(object sender, EventArgs e)
        {


           
            da_cat.Fill(Ds, "m");
            cmbTypeService.SelectedIndexChanged -= new EventHandler(cmbTypeService_SelectedIndexChanged);
            cmbTypeService.DataSource = Ds.Tables[0];
            cmbTypeService.ValueMember = "idCAT";
            cmbTypeService.DisplayMember ="nameCAT";
            cmbTypeService.SelectedIndexChanged += new EventHandler(cmbTypeService_SelectedIndexChanged);
           
           


                

            
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            txtNameClient.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            frmModifyCredit f = new frmModifyCredit();
            f.Show();
        }
    }
}
