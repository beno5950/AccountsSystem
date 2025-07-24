
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace AccountSystem.PL
{
    public partial class frm_Main : Form
    {
        PL.Bonds.frm_Bonds fb = new Bonds.frm_Bonds();
        public frm_Main()
        {
            InitializeComponent();
        }

        private void بياناتالإتصالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_ConFormat cf = new SysFormat.frm_ConFormat();
            cf.ShowDialog();
        }

        private void بياناتالشركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_Company fc = new SysFormat.frm_Company();
            fc.ShowDialog();
        }

        private void تبديلالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Users.frm_Users fu = new Users.frm_Users();
            fu.ShowDialog();
        }

        private void دليلالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Acconts.frm_accounts fa = new Acconts.frm_accounts();
            fa.ShowDialog();
        }

        private void الصناديقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_cash fc = new SysFormat.frm_cash();
            fc.Text = "الصناديق";
            fc.gp_cash.Text = "الصناديق";
            fc.txt_funtion.Text = "1";
            fc.ShowDialog();
        }

        private void البنوكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_cash fc = new SysFormat.frm_cash();
            fc.Text = "البنوك";
            fc.gp_cash.Text = "البنوك";
            fc.txt_funtion.Text = "2";
            fc.ShowDialog();
        }

        private void العملاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_currencies fc = new SysFormat.frm_currencies();
            fc.ShowDialog(); 

        }

        private void قيداليوميةالعامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Journals.frm_journal fj = new Journals.frm_journal();
            fj.ShowDialog();
        }

        private void سندالصرقToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            fb.Text = "سند صرف";
            fb.gp_bonds.Text = "بيانات سند الصرف";
            fb.txt_btype.Text = "2";
            fb.ShowDialog();
        }

        private void سندالقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fb.Text = "سند قبض";
            fb.gp_bonds.Text = "بيانات سند القبض";
            fb.txt_btype.Text = "3";
            fb.ShowDialog();
        }

        private void عمانسخةإحتاطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_Backup fb = new SysFormat.frm_Backup();
            fb.ShowDialog();

        }

        private void إسترجاعالنسخةالإحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.SysFormat.frm_Backup_Restore br = new SysFormat.frm_Backup_Restore();
            br.ShowDialog();
        }

        private void طباعةالدليلالمحاسبيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument Rdoc = new ReportDocument();
            Rdoc.Load(@"D:\AccSys\AccountSystem\AccountSystem\PL\Reports\rpt_ChartOfAccount.rpt");
            PL.Reports.frm_Report_Viewer frv = new Reports.frm_Report_Viewer();
            frv.CRV.ReportSource = Rdoc;
            frv.ShowDialog();

        }

        private void كشفحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Reports.frm_Acc_Query faq = new Reports.frm_Acc_Query();
            faq.ShowDialog();
        }

        private void ميزانالمراجعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Reports.frm_trail_balance ftb = new Reports.frm_trail_balance();
            ftb.ShowDialog();

        }

        private void الميزانيةالعموميةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Reports.frm_end_balance feb = new Reports.frm_end_balance();
            feb.txt_rtype.Text = "1";
            feb.Text = "الميزانية العمومية";
            feb.ShowDialog();
        }

        private void الأرباحوالخسائرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Reports.frm_end_balance feb = new Reports.frm_end_balance();
            feb.txt_rtype.Text = "2";
            feb.Text = "الأرباح و الخسائر";
            feb.ShowDialog();
        }
    }
}
