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
    public partial class frm_acc_sheet : Form
    {
        public frm_acc_sheet()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("jdate");
            dt.Columns.Add("accno");
            dt.Columns.Add("accname");
            dt.Columns.Add("accdebit",typeof(float));
            dt.Columns.Add("acccredit", typeof(float));
            dt.Columns.Add("note");
            dt.Columns.Add("ptype");
            dt.Columns.Add("fdate");
            dt.Columns.Add("tdate");
            dt.Columns.Add("currname");
            dt.Columns.Add("currexch");
            dt.Columns.Add("tdebit", typeof(float));
            dt.Columns.Add("tcredit", typeof(float));
            dt.Columns.Add("tdeff", typeof(float));
            for (int i = 0; i < dgv_acc_sheet.Rows.Count; i++)
            {
                dt.Rows.Add(dgv_acc_sheet.Rows[i].Cells[0].Value, dgv_acc_sheet.Rows[i].Cells[1].Value, dgv_acc_sheet.Rows[i].Cells[2].Value, dgv_acc_sheet.Rows[i].Cells[3].Value, dgv_acc_sheet.Rows[i].Cells[4].Value, dgv_acc_sheet.Rows[i].Cells[5].Value, dgv_acc_sheet.Rows[i].Cells[6].Value,dtp_from.Value,dtp_to.Value,cb_currency.Text,txt_exch.Text,txt_tdebit.Text,txt_tcredit.Text,txt_tdeff.Text);
            }

            ReportDocument repdoc = new ReportDocument();
            repdoc.Load(@"D:\AccSys\AccountSystem\AccountSystem\PL\Reports\rpt_acc_sheet.rpt");
            PL.Reports.frm_Report_Viewer frv = new frm_Report_Viewer();
            repdoc.SetDataSource(dt);
            frv.CRV.ReportSource = repdoc;
            frv.ShowDialog();




           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
