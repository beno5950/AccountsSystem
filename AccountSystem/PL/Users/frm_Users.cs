using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;



namespace AccountSystem.PL.Users
{
    public partial class frm_Users : Form
    {
        BL.Users.cls_Users cu = new BL.Users.cls_Users();
        public frm_Users()
        {
            InitializeComponent();
            Show_data();

        }

       void Show_data()
        {
            dgv_users.DataSource = cu.Get_All_Users();
            dgv_users.Columns[0].HeaderText = "رقم المستخدم";
            dgv_users.Columns[1].Visible = false;
            dgv_users.Columns[2].HeaderText = "المستخدم";
            dgv_users.Columns[3].Visible = false;
            dgv_users.Columns[4].HeaderText = "التلفون";
            dgv_users.Columns[5].Visible = false;
            dgv_users.Columns[6].Visible = false;
            dgv_users.Columns[7].Visible = false;
            dgv_users.Columns[8].Visible = false;
        }
           
      
        private void btn_new_Click(object sender, EventArgs e)
        {

            
            foreach (var c in this.groupBox1.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
            txt_uno.Text = cu.Generate_Uid().Rows[0][0].ToString();
            pb_image.Image = null;
            btn_save.Enabled = true;
            txt_fname.Focus();
        }

        private void txt_email_Validated(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+$");
            if (!reg.IsMatch(txt_email.Text))
            {
                MessageBox.Show("الصيغة التي أدخلتها غير صحيحة ","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txt_email.Focus();
            }
        }

        private void btn_brwose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "All file|*.gif;*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_image.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pb_image.Image = null;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bimg;
                int status = 0;
                int utype = 0;

                if (chk_lock .Checked==true)
                {
                    status = 0;
                }else
                {
                    status = 1;
                }

                if (rb_admin.Checked==true)
                {
                    utype = 1;
                }else
                {
                    utype = 0;
                }

                MemoryStream ms = new MemoryStream();
                pb_image.Image.Save(ms,pb_image.Image.RawFormat);
                bimg = ms.ToArray();

                cu.Add_User(Convert.ToInt32( txt_uno.Text),txt_fname.Text,txt_name.Text,txt_pwd.Text,txt_tel.Text,txt_email.Text,status,utype,bimg);
                Show_data();
                MessageBox.Show("تمت عملية الحفظ بنجاح","تنبية",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void dgv_users_DoubleClick(object sender, EventArgs e)
        {
            txt_uno.Text = dgv_users.CurrentRow.Cells[0].Value.ToString();
            txt_fname.Text= dgv_users.CurrentRow.Cells[1].Value.ToString();
            txt_name.Text= dgv_users.CurrentRow.Cells[2].Value.ToString();
            txt_pwd.Text= dgv_users.CurrentRow.Cells[3].Value.ToString();
            txt_tel.Text= dgv_users.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text= dgv_users.CurrentRow.Cells[5].Value.ToString();
            if (Convert.ToInt32( dgv_users.CurrentRow.Cells[6].Value)==1)
            {
                chk_lock.Checked = true;
            }else
            {
                chk_lock.Checked = false;
            }

            if (Convert.ToInt32(dgv_users.CurrentRow.Cells[7].Value) == 1)
            {
                rb_admin.Checked = true;
            }else
            {
                rb_limit.Checked = true;
            }

            if (dgv_users.CurrentRow.Cells[8].Value.ToString()=="")
            {
                pb_image.Image = null;
            }else
            {
                byte[] bimg = (byte[])dgv_users.CurrentRow.Cells[8].Value;
                MemoryStream ms = new MemoryStream(bimg);
                pb_image.Image = Image.FromStream(ms);

            }
            
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bimg;
                int status = 0;
                int utype = 0;

                if (chk_lock.Checked == true)
                {
                    status = 0;
                }
                else
                {
                    status = 1;
                }

                if (rb_admin.Checked == true)
                {
                    utype = 1;
                }
                else
                {
                    utype = 0;
                }

                MemoryStream ms = new MemoryStream();
                pb_image.Image.Save(ms, pb_image.Image.RawFormat);
                bimg = ms.ToArray();

                cu.Edit_User(Convert.ToInt32(txt_uno.Text), txt_fname.Text, txt_name.Text, txt_pwd.Text, txt_tel.Text, txt_email.Text, status, utype, bimg);
                Show_data();
                MessageBox.Show("تمت عملية التعديل بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالفعل حذف هذا السجل؟","تنبيه حذف",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                cu.Del_User(Convert.ToInt32 (txt_uno.Text));
                Show_data();
                MessageBox.Show("تمت عملية الحذف بنجاح","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
        }
    }
}
