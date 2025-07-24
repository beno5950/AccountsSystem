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
    public partial class frm_Backup_Restore : Form
    {
        DAL.cn con = new DAL.cn();
        public frm_Backup_Restore()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_backup_restore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Restore Files(*.bak)|*.bak";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string cmdText = "alter database AccDB set offline with rollback immediate ; restore database AccDB from disk='" + ofd.FileName + "'with replace ;";
                    con.openConnection();
                    con.ExcuteText(cmdText);
                    con.closeConnection();
                    MessageBox.Show("تم إسترجاع النسخة الإحتياطية بنجاح", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("نص الخطأ"+ex, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
