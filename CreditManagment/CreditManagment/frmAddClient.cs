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
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool i = MemberGlobal.Insert_Edit_Delete(string.Format("insert into Clients values ('{0}','{1}')",txtName.Text,txtPhoneNumber.Text));
            if (i == true)
                MessageBox.Show("Added Successfully!");
            else
                MessageBox.Show("Error!");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count != 0)
            {
 bool i = MemberGlobal.Insert_Edit_Delete(string.Format("update Clients set nameCL='{0}' , phone='{1}' where idCL='{2}'"
     ,txtName.Text,txtPhoneNumber.Text,dgv.CurrentRow.Cells[0].Value.ToString()));
            if (i == true)
                MessageBox.Show("Modified Successfully!");
            else
                MessageBox.Show("Error!");
                
            }
            else
                MessageBox.Show("Select aClient To Modify!");

        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch_Client.Text !="")
            {

                DataTable i = MemberGlobal.rechercher(string.Format(" select * from Clients where nameCL like '{0}%' ", txtSearch_Client.Text));
                if (i.Rows.Count != 0)
                    dgv.DataSource = i;
                else
                    MessageBox.Show("Not Found !");
            }
            else
            {

                MessageBox.Show("Please write a client name!");


            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtName.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
