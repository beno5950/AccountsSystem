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
    public partial class frm_trail_balance : Form
    {
        BL.Accounts.cls_accounts ca = new BL.Accounts.cls_accounts(); 
        BL.SysFormat.cls_sysFormat csf = new BL.SysFormat.cls_sysFormat(); 
        public frm_trail_balance()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_trail_balance_Load(object sender, EventArgs e)
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
            double balance = 0;
            DataTable dt = new DataTable();
            dt = ca.get_trail_balance(Convert.ToDouble(txt_exch.Text),Convert.ToDateTime(dtp_from.Value),Convert.ToDateTime(dtp_to.Value));
            if (dt.Rows.Count >0)
            {
                dgv_trail_balance.DataSource = dt;
                dgv_trail_balance.Columns[2].DefaultCellStyle.Format = "n2";
                dgv_trail_balance.Columns[2].DefaultCellStyle.ForeColor = Color.Yellow;
                dgv_trail_balance.Columns[2].DefaultCellStyle.BackColor = Color.Brown;

                dgv_trail_balance.Columns[3].DefaultCellStyle.Format = "n2";
                dgv_trail_balance.Columns[3].DefaultCellStyle.ForeColor = Color.White;
                dgv_trail_balance.Columns[3].DefaultCellStyle.BackColor = Color.Black;
            }
            else
            {
                MessageBox.Show("هذه الفترة لا توجد فيها حركة","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            for (int i = 0; i < dgv_trail_balance.Rows.Count; i++)
            {
                tdebit = tdebit + Convert.ToDouble(dgv_trail_balance.Rows[i].Cells[2].Value);
                tcredit=tcredit+ Convert.ToDouble(dgv_trail_balance.Rows[i].Cells[3].Value);
            }
            txt_tdebit.Text = tdebit.ToString("0.00");
            txt_tcredit.Text = tcredit.ToString("0.00");
            txt_tdeff.Text = (tdebit - tcredit).ToString("0.00");


           
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2.Clear();
            dt2.Columns.Add("fdate");
            dt2.Columns.Add("tdate");
            dt2.Columns.Add("currname");
            dt2.Columns.Add("currexch");
            dt2.Columns.Add("accno");
            dt2.Columns.Add("accname");
            dt2.Columns.Add("accdebit");
            dt2.Columns.Add("acccredit");
            dt2.Columns.Add("tdebit");
            dt2.Columns.Add("tcredit");
            dt2.Columns.Add("tbalance");

            for (int i = 0; i < dgv_trail_balance.Rows.Count; i++)
            {
                dt2.Rows.Add(dtp_from.Value, dtp_to.Value, cb_currency.Text, txt_exch.Text, dgv_trail_balance.Rows[i].Cells[0].Value, dgv_trail_balance.Rows[i].Cells[1].Value, dgv_trail_balance.Rows[i].Cells[2].Value, dgv_trail_balance.Rows[i].Cells[3].Value, txt_tdebit.Text, txt_tcredit.Text, txt_tdeff.Text);
            }

            ReportDocument rptdoc = new ReportDocument();
            rptdoc.Load(@"D:\AccSys\AccountSystem\AccountSystem\PL\Reports\rpt_trail_balance.rpt");
            PL.Reports.frm_Report_Viewer frv = new frm_Report_Viewer();
            rptdoc.SetDataSource(dt2);
            frv.CRV.ReportSource = rptdoc;
            frv.ShowDialog();
        }
    }
}
