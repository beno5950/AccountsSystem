using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;





namespace AccountSystem.PL.SysFormat
{
    public partial class frm_Company : Form
    {
        BL.SysFormat.cls_sysFormat cs = new BL.SysFormat.cls_sysFormat();
        public frm_Company()
        {
            InitializeComponent();
            dgv_table();



        }

        void dgv_table()
        {
            dgv_cdata.DataSource = cs.Get_all_Cdata();
            dgv_cdata.Columns[0].Visible = false;
            dgv_cdata.Columns[1].HeaderText = "الإسم";
            dgv_cdata.Columns[2].Visible = false;
            dgv_cdata.Columns[3].HeaderText = "العنوان";
            dgv_cdata.Columns[4].Visible = false;
            dgv_cdata.Columns[5].HeaderText = "تلفون";
            dgv_cdata.Columns[6].HeaderText = "فاكس";
            dgv_cdata.Columns[7].Visible = false;
            dgv_cdata.Columns[8].Visible = false;
            dgv_cdata.Columns[9].Visible = false;
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "All file|*.gif;*.jpg;*.png;*.bmp";
            if(ofd.ShowDialog ()==DialogResult.OK)
            {
                pb_logo.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pb_logo.Image = null;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {


           foreach(var c in this.Controls)
            {
                if (c is TextBox )
                {
                    ((TextBox)c).Text = string.Empty;
                    ((TextBox)c).Enabled = true;

                }
            }
            pb_logo.Image = null;
            btn_browse.Enabled = true;
            btn_save.Enabled = true;
            txt_aname.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i=0;i<dgv_cdata.Rows.Count;i++)
            {
                if (dgv_cdata.Rows[i].Cells[1].Value.ToString()==txt_aname.Text)
                {
                    MessageBox.Show("هذا الإسم موجود مسبقً..قم بإدال إسم أخر","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return;
                }
            }

            byte[] Bimg;
            if(pb_logo.Image == null)
            {
                MessageBox.Show("يجب إدخال الصورة","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }else
            {
                MemoryStream ms = new MemoryStream();
                pb_logo.Image.Save(ms, pb_logo.Image.RawFormat);
                Bimg=ms.ToArray();
                cs.AddCompany(txt_aname.Text,txt_ename.Text,txt_aaddress.Text,txt_eaddress.Text,txt_tel.Text,txt_fax.Text,txt_email.Text,txt_website.Text,Bimg);
                dgv_table();
                MessageBox.Show("تمت عملية الحفظ ينجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void txt_aname_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new  CultureInfo("ar-ye"));
        }

        private void txt_ename_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txt_aaddress_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-ye"));
        }

        private void txt_eaddress_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txt_website_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void dgv_cdata_DoubleClick(object sender, EventArgs e)
        {
            txt_aname.Text = dgv_cdata.CurrentRow.Cells[1].Value.ToString();
            txt_ename.Text= dgv_cdata.CurrentRow.Cells[2].Value.ToString();
            txt_aaddress.Text= dgv_cdata.CurrentRow.Cells[3].Value.ToString();
            txt_eaddress.Text= dgv_cdata.CurrentRow.Cells[4].Value.ToString();
            txt_tel.Text= dgv_cdata.CurrentRow.Cells[5].Value.ToString();
            txt_fax.Text= dgv_cdata.CurrentRow.Cells[6].Value.ToString();
            txt_email.Text= dgv_cdata.CurrentRow.Cells[7].Value.ToString();
            txt_website.Text= dgv_cdata.CurrentRow.Cells[8].Value.ToString();

            byte[] Bimg=(byte[])dgv_cdata.CurrentRow.Cells[9].Value;
            MemoryStream ms = new MemoryStream(Bimg);
            pb_logo.Image = Image.FromStream(ms);


            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;

                }
            }
            btn_browse.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            byte[] Bimg;
            if (pb_logo.Image == null)
            {
                MessageBox.Show("يجب إدخال الصورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pb_logo.Image.Save(ms, pb_logo.Image.RawFormat);
                Bimg = ms.ToArray();
                int cno =Convert.ToInt32( dgv_cdata.CurrentRow.Cells[0].Value);
                cs.EditCompany(cno,txt_aname.Text, txt_ename.Text, txt_aaddress.Text, txt_eaddress.Text, txt_tel.Text, txt_fax.Text, txt_email.Text, txt_website.Text, Bimg);
                dgv_table();
                MessageBox.Show("تمت عملية الحذف ينجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل تريد حذف هذا السجل","تنبيه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))==DialogResult.Yes)
            {
                cs.DelCompany(Convert.ToInt32( dgv_cdata.CurrentRow.Cells[0].Value));
                dgv_table();
                MessageBox.Show("تمت عملية التعديل ينجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = string.Empty;
                        ((TextBox)c).Enabled = false;

                    }
                }
                btn_browse.Enabled = false;
                pb_logo.Image = null;

            }
        }

        private void txt_email_Validated(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+$");
            if (!reg.IsMatch(txt_email.Text))
            {
                MessageBox.Show("الصيغة التي لأدخلتها غير صحيحة","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_email.Focus();
            }
           
        }

        private void txt_website_Validated(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(\w+\.)*\w+([-.]\w+)*\.\w+$");
            if (!reg.IsMatch(txt_website.Text))
            {
                MessageBox.Show("الصيغة التي أدخلتها غير صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_website.Focus();
            }

        }
    }
}
