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

namespace AccountSystem.PL.Reports
{
    public partial class frm_end_balance : Form
    {
        BL.Accounts.cls_accounts ca = new BL.Accounts.cls_accounts();
        BL.SysFormat.cls_sysFormat csf = new BL.SysFormat.cls_sysFormat();
        public frm_end_balance()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_end_balance_Load(object sender, EventArgs e)
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

        private void btn_show_Click(object sender, EventArgs e)
        {
            double tdebit = 0;
            double tcredit = 0;
            double tbal = 0;

            DataTable dt = new DataTable();
            dt.Clear();
            dt = ca.get_final_account(Convert.ToDouble(txt_exch.Text),Convert.ToDateTime(dtp_from.Value),Convert.ToDateTime(dtp_to.Value ),Convert.ToInt32(txt_rtype.Text));
            dgv_end_balance.DataSource = dt;
            dgv_end_balance.Columns[3].DefaultCellStyle.Format = "n2";
            dgv_end_balance.Columns[4].DefaultCellStyle.Format = "n2";
            dgv_end_balance.Columns[5].DefaultCellStyle.Format = "n2";
            for (int i = 0; i < dgv_end_balance.Rows.Count; i++)
            {
                tdebit = tdebit + Convert.ToDouble(dgv_end_balance.Rows[i].Cells[3].Value);
                tcredit=tcredit + Convert.ToDouble(dgv_end_balance.Rows[i].Cells[4].Value);
            }

            txt_tdebit.Text = tdebit.ToString("0.00");
            txt_tcredit.Text= tcredit.ToString("0.00");
            txt_tdeff.Text=Math.Abs(tdebit-tcredit).ToString("0.00");

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("fdate");
            dt.Columns.Add("tdate");
            dt.Columns.Add("currname");
            dt.Columns.Add("currexch");
            dt.Columns.Add("rtype");
            dt.Columns.Add("accno");
            dt.Columns.Add("accparentno");
            dt.Columns.Add("accname");
            dt.Columns.Add("accdebit");
            dt.Columns.Add("acccredit");
            dt.Columns.Add("balance");
            dt.Columns.Add("tdebit");
            dt.Columns.Add("tcredit");
            dt.Columns.Add("tbalance");

            for (int i = 0; i < dgv_end_balance.Rows.Count; i++)
            {
                        //         1               2          3             4              5                                           6                                      7                                       8                                       9                                       10                                       11            12               13               14     
                dt.Rows.Add(dtp_from.Value ,dtp_to.Value,cb_currency.Text,txt_exch.Text,txt_rtype.Text ,dgv_end_balance.Rows[i].Cells[0].Value, dgv_end_balance.Rows[i].Cells[1].Value, dgv_end_balance.Rows[i].Cells[2].Value, dgv_end_balance.Rows[i].Cells[3].Value, dgv_end_balance.Rows[i].Cells[4].Value, dgv_end_balance.Rows[i].Cells[5].Value,txt_tdebit.Text,txt_tcredit.Text,txt_tdeff.Text);
            }
            ReportDocument repdoc = new ReportDocument();
            repdoc.Load(@"D:\AccSys\AccountSystem\AccountSystem\PL\Reports\rpt_profits_losses.rpt");
            PL.Reports.frm_Report_Viewer frv = new frm_Report_Viewer();
            repdoc.SetDataSource(dt);
            frv.CRV.ReportSource = repdoc;
            frv.ShowDialog();

        }
    }
}
