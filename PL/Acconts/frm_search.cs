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
    public partial class frm_search : Form
    {

        public bool IsOk = false;
        public frm_search()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            BL.Accounts.cls_accounts ca = new BL.Accounts.cls_accounts();
            dgv_results.DataSource = ca.Search_In_Account(txt_search.Text);
            dgv_results.Columns[0].HeaderText = "رقم الحساب";
            dgv_results.Columns[1].Visible = false ;
            dgv_results.Columns[2].HeaderText = "إسم الحساب";
            dgv_results.Columns[3].Visible = false;
            dgv_results.Columns[4].Visible = false;
            dgv_results.Columns[5].Visible = false;
            dgv_results.Columns[6].Visible = false;
            dgv_results.Columns[7].Visible = false;
            dgv_results.Columns[8].Visible = false;

        }

        private void dgv_results_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsOk = true;
            Close();
        }
    }
}
