using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL.Acconts
{
    public partial class frm_accounts : Form
    {
        BL.Accounts.cls_accounts ca = new BL.Accounts.cls_accounts();
        public frm_accounts()
        {
            InitializeComponent();
            fill_cb();
        }
        
        void fill_cb()
        {
            Create_Node();
            cb_report.DataSource = ca.Get_All_FinalAcc();
            cb_report.ValueMember = "Acc_Rep_NO";
            cb_report.DisplayMember = "Acc_Rep_Aname";

            cb_acctype.DataSource = ca.Get_All_AccType();
            cb_acctype.ValueMember = "Acc_Type_No";
            cb_acctype.DisplayMember = "Acc_Type_Aname";
        }
        
        private void Create_Node()
        {
            TreeNode tn;
            tv_accounts.Nodes.Clear();
            DataView dv = new DataView(ca.Get_All_Accounts());
            dv.RowFilter = "Acc_Parent_No=0";
            foreach (DataRowView drv in dv)
            {
                tn = new TreeNode(drv["Acc_No"].ToString()+"   "+drv["Acc_Aname"].ToString());
                tn.Tag = drv["Acc_No"].ToString();
                tv_accounts.Nodes.Add(tn);
            }
            foreach (TreeNode tnode in tv_accounts.Nodes)
            {
                Node_Child(tnode);
            }

        }

        void Node_Child(TreeNode nd)
        {
            TreeNode ctn;
            
            DataView dv = new DataView(ca.Get_All_Accounts());
            dv.RowFilter = "Acc_Parent_No="+Convert.ToInt32(nd.Tag) ;
            foreach (DataRowView drv in dv)
            {
                ctn = new TreeNode(drv["Acc_No"].ToString() + "   " + drv["Acc_Aname"].ToString());
                ctn.Tag = drv["Acc_No"].ToString();
                nd.Nodes.Add(ctn);
                Node_Child(ctn);
            }

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tv_accounts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txt_tag.Text = tv_accounts.SelectedNode.Tag.ToString();
            btn_save.Enabled = false;
        }

        private void txt_tag_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=ca.Get_Account_Alone(Convert.ToInt32( txt_tag.Text));
            if (dt.Rows.Count>0)
            {
                txt_accno.Text = dt.Rows[0][0].ToString();
                txt_accparent.Text= dt.Rows[0][1].ToString();
                txt_accname .Text= dt.Rows[0][2].ToString();
                txt_acclevel.Text= dt.Rows[0][3].ToString();
                txt_debit.Text= dt.Rows[0][4].ToString();
                txt_credit.Text= dt.Rows[0][5].ToString();
                txt_palance.Text= dt.Rows[0][6].ToString();
                cb_report.SelectedValue= dt.Rows[0][7].ToString();
                cb_acctype.SelectedValue= dt.Rows[0][8].ToString();
            }
        }

        void clearnce()
        {
            foreach (var c in gp_inputs.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;  
                }
            }
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            clearnce();
            txt_accno.Enabled = true;
            txt_accno.Focus();
            btn_save.Enabled = true;
            cb_acctype.Enabled = true;
            cb_report.Enabled = true;
        }

        private void txt_accno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >=48 && e.KeyChar<=57)
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                ca.Account_Add(Convert.ToInt32(txt_accno.Text ),Convert.ToInt32(txt_accparent.Text ),txt_accname.Text ,Convert.ToInt32(txt_acclevel.Text),Convert.ToDouble(txt_debit.Text ),Convert.ToDouble(txt_credit.Text ),Convert.ToDouble(txt_palance.Text ),Convert.ToInt32(cb_report.SelectedValue ),Convert.ToInt32(cb_acctype.SelectedValue ));
                Create_Node();
                btn_save.Enabled = false;
                MessageBox.Show("تمت عملية الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("هناك خطأ في اإدخال البيانات .. يرجى تصحيحه","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ca.Account_Test(Convert.ToInt32(txt_accno.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الحساب مرتبط بحسابات فرعية و لا يمكن تعديله", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt1 = new DataTable();
                dt1 = ca.Journal_Test(Convert.ToInt32(txt_accno.Text));
                if (dt1.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الحساب قد أجريت عليه عملية محاسبية و لا يمكن تعديلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ca.Account_Edit(Convert.ToInt32(txt_accno.Text), Convert.ToInt32(txt_accparent.Text), txt_accname.Text, Convert.ToInt32(txt_acclevel.Text), Convert.ToDouble(txt_debit.Text), Convert.ToDouble(txt_credit.Text), Convert.ToDouble(txt_palance.Text), Convert.ToInt32(cb_report.SelectedValue), Convert.ToInt32(cb_acctype.SelectedValue));
                Create_Node();
                btn_save.Enabled = false;
                MessageBox.Show("تمت عملية التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("هناك خطأ في اإدخال البيانات .. يرجى تصحيحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ca.Account_Test(Convert.ToInt32(txt_accno.Text ));
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("هذا الحساب مرتبط بحسابات فرعية و لا يمكن حذفه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt1 = new DataTable();
            dt1 = ca.Journal_Test(Convert.ToInt32(txt_accno.Text));
            if (dt1.Rows.Count > 0)
            {
                MessageBox.Show("هذا الحساب قد أجريت عليه عملية محاسبية و لا يمكن حذفه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل تريد حذف هذا الحساب","تنبيه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                ca.AccountDel(Convert.ToInt32( txt_accno.Text ));
                Create_Node();
                clearnce();
                MessageBox.Show("تمت عملية الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btn_accounts_Click(object sender, EventArgs e)
        {
            ReportDocument Rdoc = new ReportDocument();
            Rdoc.Load(@"D:\AccSys\AccountSystem\AccountSystem\PL\Reports\rpt_ChartOfAccount.rpt");
            PL.Reports.frm_Report_Viewer frv = new Reports.frm_Report_Viewer();
            frv.CRV.ReportSource = Rdoc;
            frv.ShowDialog();
        }
    }
}
