using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL.SysFormat
{
    public partial class frm_cash : Form
    {
        BL.SysFormat.cls_sysFormat sf = new BL.SysFormat.cls_sysFormat();
        public frm_cash()
        {
            InitializeComponent();
            
        }

        void show()
        {
            dgv_cash.DataSource = sf.Get_All_Cash(Convert.ToInt32(txt_funtion.Text));
            dgv_cash.Columns[0].HeaderText = "رقم الحساب";
            dgv_cash.Columns[1].HeaderText = "إسم الحساب";
            


        }
        private void btn_display_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_accno.Text = string.Empty;
            txt_accname.Text = string.Empty;
            txt_accno.Enabled = true;
            txt_accno.Focus();
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_accno_KeyDown(object sender, KeyEventArgs e)
        {
            PL.Acconts.frm_search fs = new Acconts.frm_search();
            if (e.KeyCode==Keys.Enter)
            {
                fs.txt_search.Text = txt_accno.Text;
                fs.ShowDialog();
                if (fs.IsOk ==true)
                {
                    txt_accno.Text = fs.dgv_results.CurrentRow.Cells[0].Value.ToString();
                    txt_accname.Text = fs.dgv_results.CurrentRow.Cells[2].Value.ToString();
                    btn_save.Focus();

                }
                

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            try
            {
                sf.Add_cash(Convert.ToInt32(txt_accno.Text),txt_accname.Text,Convert.ToInt32(txt_funtion.Text));
                show();
                MessageBox.Show("تمت عملية الحفظ بنجاح","عملية الحفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("تأكد من البيانات التي قمت بإدخالها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الحساب","تنبية",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                sf.Del_cash(Convert.ToInt32(txt_accno.Text ),Convert.ToInt32(txt_funtion.Text ));
                show();
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_cash_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_accno.Text = dgv_cash.CurrentRow.Cells[0].Value.ToString();
            txt_accname.Text = dgv_cash.CurrentRow.Cells[1].Value.ToString();
        }

        private void txt_accno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
