using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BL.Users.Login log = new BL.Users.Login();
            dt = log.logonTest(txt_User.Text,txt_PWD.Text);


            if (dt.Rows.Count > 0)
            {
                this.Hide();
                frm_Main fm = new PL.frm_Main();
                Program.uname = txt_User.Text;
                fm.Show();

            }else
            {
                MessageBox.Show("كلمة المرور أو إسم المستخدم غير صحيح");
            }
            
        }

       
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
