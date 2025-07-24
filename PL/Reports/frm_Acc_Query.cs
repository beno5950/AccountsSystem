using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL.Reports
{
    public partial class frm_Acc_Query : Form
    {
        BL.SysFormat.cls_sysFormat csf = new BL.SysFormat.cls_sysFormat();
        PL.Acconts.frm_search fs = new Acconts.frm_search();
        DAL.cn con = new DAL.cn();
        PL.Reports.frm_acc_sheet fas = new frm_acc_sheet();
        public frm_Acc_Query()
        {
            InitializeComponent();
        }

        private void frm_Acc_Query_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = csf.Get_All_Currencies();
            cb_currency.DataSource = dt;
            cb_currency.DisplayMember = "Curr_Aname";
            cb_currency.ValueMember = "Curr_No";

        }

        private void cb_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = csf.Get_Curr_Exch(cb_currency.Text);
            txt_exch.Text = dt.Rows[0][2].ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            fs.ShowDialog();
            txt_accno.Text = fs.dgv_results.CurrentRow.Cells[0].Value.ToString();
            txt_accname.Text = fs.dgv_results.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string qry;
            string process_type = "tbl_Journal_Hdr.pno=0";
            if (chk_Journal.Checked==false && chk_Bond_in.Checked==false &&chk_bond_out.Checked==false)
            {
                MessageBox.Show("يجب إختيار عملية واحدة على الأقل","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            
            if (chk_Journal.Checked==true)
            {
                process_type = process_type + "" + "or tbl_Journal_Hdr.pno=1";
            }

            if (chk_bond_out.Checked == true)
            {
                process_type = process_type + "" + "or tbl_Journal_Hdr.pno=2";
            }

            if (chk_Bond_in.Checked == true)
            {
                process_type = process_type + "" + "or tbl_Journal_Hdr.pno=3";
            }

            if (txt_accno.Text == "")
            {
                MessageBox.Show("يجب إدخال رقم الحساب المطلوب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                qry = "SELECT  dbo.tbl_Journal_Hdr.J_Date AS التاريخ, dbo.tbl_Journal_Details.Acc_No AS [رقم الحساب], dbo.tbl_Accounts.Acc_Aname AS [إسم الحساب],  dbo.tbl_Journal_Details.Acc_Debit/"+Convert.ToDouble(txt_exch.Text)+" AS[رصيد مدين], dbo.tbl_Journal_Details.Acc_Credit/"+Convert.ToDouble(txt_exch.Text)+" AS[رصيد دائن], dbo.tbl_Journal_Details.Acc_Note AS البيان, dbo.tbl_Process.p_name AS العملية FROM            dbo.tbl_Journal_Hdr INNER JOIN     dbo.tbl_Journal_Details ON dbo.tbl_Journal_Hdr.J_No = dbo.tbl_Journal_Details.J_No INNER JOIN    dbo.tbl_Accounts ON dbo.tbl_Journal_Details.Acc_No = dbo.tbl_Accounts.Acc_No INNER JOIN   dbo.tbl_Process ON dbo.tbl_Journal_Hdr.pno = dbo.tbl_Process.p_no WHERE(dbo.tbl_Journal_Details.Acc_No = '"+Convert.ToInt32(txt_accno.Text)+"') AND(dbo.tbl_Journal_Hdr.J_Date BETWEEN CONVERT(DATETIME, '"+dtp_from.Value.Month+"/"+dtp_from.Value.Day+"/"+dtp_from.Value.Year+"', 102) AND  CONVERT(DATETIME, '"+dtp_to.Value.Month+"/"+dtp_to.Value.Day+"/"+dtp_to.Value.Year+"', 102)) AND(dbo.tbl_Journal_Hdr.J_Post = 1)";
                DataTable dt = new DataTable();
                dt = con.selectData(qry);
                if (dt.Rows.Count>0)
                {
                    fas.dtp_from.Value = dtp_from.Value;
                    fas.dtp_to.Value = dtp_to.Value;
                    fas.cb_currency.Text = cb_currency.Text;
                    fas.txt_exch.Text = txt_exch.Text;
                    fas.txt_accno.Text = txt_accno.Text;
                    fas.txt_accname.Text = txt_accname.Text;
                    fas.dgv_acc_sheet.DataSource = dt;

                    double acc_debit = 0;
                    double acc_credit = 0;
                    double acc_deff = 0;
                    for (int i=0;i<fas.dgv_acc_sheet.Rows.Count;i++)
                    {
                        acc_debit = acc_debit + Convert.ToDouble(fas.dgv_acc_sheet.Rows[i].Cells[3].Value);
                        acc_credit=acc_credit+ Convert.ToDouble(fas.dgv_acc_sheet.Rows[i].Cells[4].Value);
                    }
                    fas.txt_tdebit.Text = acc_debit.ToString();
                    fas.txt_tcredit.Text = acc_credit.ToString();
                    acc_deff = Convert.ToDouble(fas.txt_tdebit.Text) - Convert.ToDouble(fas.txt_tcredit.Text);
                    fas.txt_tdeff.Text = acc_deff.ToString();
                    fas.ShowDialog();
                }else
                {
                    MessageBox.Show("لا توجد حركة ضمن الفترة الزمنية المحدد لهذا الحساب","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
