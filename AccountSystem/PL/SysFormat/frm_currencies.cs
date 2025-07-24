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
    public partial class frm_currencies : Form
    {
        BL.SysFormat.cls_sysFormat sf = new BL.SysFormat.cls_sysFormat();
        public frm_currencies()
        {
            InitializeComponent();
            show();
        }

        void show()
        {
            dgv_currencies.DataSource = sf.Get_All_Currencies();
            dgv_currencies.Columns[0].HeaderText = "رقم العملة";
            dgv_currencies.Columns[1].HeaderText = "إسم العملة";
            dgv_currencies.Columns[2].Visible = false;
            dgv_currencies.Columns[3].Visible = false;
            dgv_currencies.Columns[4].Visible = false;
            dgv_currencies.Columns[5].Visible = false;
            dgv_currencies.Columns[6].Visible = false;
        }

        void clearance()
        {
            foreach (var c in gp_inputs.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                    ((TextBox)c).Enabled = true;
                }
            }
            txt_cname.Focus();
            rb_local.Enabled = true;
            rb_frign.Enabled = true;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            clearance();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int ctype = 0;
                if (rb_local.Checked==true)
                {
                    ctype = 1;
                }else
                {
                    ctype = 2;
                }
                sf.Currency_Add(txt_cname.Text,txt_ecname.Text,txt_symbol.Text ,Convert.ToDouble(txt_exch.Text ),txt_part.Text, ctype);
                show();
                MessageBox.Show("تمت عملية الحفظ بنجاح","عملية الحفظ",MessageBoxButtons.OK ,MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show("تأكد من البيانات التي قمت بإدخالها"+ex,"تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void dgv_currencies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearance();
            txt_cname.Text = dgv_currencies.CurrentRow.Cells[1].Value.ToString();
            txt_ecname .Text= dgv_currencies.CurrentRow.Cells[2].Value.ToString();
            txt_symbol.Text= dgv_currencies.CurrentRow.Cells[3].Value.ToString();
            txt_exch.Text= dgv_currencies.CurrentRow.Cells[4].Value.ToString();
            txt_part.Text= dgv_currencies.CurrentRow.Cells[5].Value.ToString();
            if (dgv_currencies.CurrentRow.Cells[6].Value.ToString()=="1")
            {
                rb_local.Checked = true;
            }else
            {
                rb_frign.Checked = true;
            }
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int ctype = 0;
                if (rb_local.Checked == true)
                {
                    ctype = 1;
                }
                else
                {
                    ctype = 2;
                }

                int cno = 0;
                cno = Convert.ToInt32(dgv_currencies.CurrentRow.Cells[0].Value );
                sf.Currency_edit(cno, txt_cname.Text, txt_ecname.Text, txt_symbol.Text, Convert.ToDouble(txt_exch.Text), txt_part.Text, ctype);
                show();
                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("تأكد من البيانات التي قمت بإدخالها" + ex, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذه العملة أم لا","تنبيه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                sf.Currency_del(Convert.ToInt32(dgv_currencies.CurrentRow.Cells[0].Value ));
                show();
                clearance();
                MessageBox.Show("تمت عملية الحذف بنجاح","عملية الحذف",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
