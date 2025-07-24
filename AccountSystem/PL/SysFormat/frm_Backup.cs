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
    public partial class frm_Backup : Form
    {
        DAL.cn con = new DAL.cn();
        public frm_Backup()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Backup  files(*.Bak)|*.bak";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string BakName = sfd.FileName + "-" + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToShortTimeString().Replace(':', '-') + ".bak";
                    string cmdText = "backup database AccDB to disk='"+ BakName+"'";
                    con.openConnection();
                    con.ExcuteText(cmdText);
                    con.closeConnection();
                    MessageBox.Show("تم عمل نسخة إحتياطية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("نص الخطأ"+ex,"خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            
        }
    }
}
