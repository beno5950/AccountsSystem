using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem.PL.Journals
{
    public partial class frm_journal : Form
    {
        BL.SysFormat.cls_sysFormat sf = new BL.SysFormat.cls_sysFormat();
        BL.Journals.cls_Journals cj = new BL.Journals.cls_Journals();
        BL.Users.cls_Users cu = new BL.Users.cls_Users();
    
        public frm_journal()
        {
            InitializeComponent();
            show();
        }

       void show()
        {
            cb_currency.DataSource = sf.Get_All_Currencies();
            cb_currency.ValueMember = "Curr_No";
            cb_currency.DisplayMember = "Curr_Aname";

        }
        private void txt_accno_KeyDown(object sender, KeyEventArgs e)
        {
            PL.Acconts.frm_search fs = new Acconts.frm_search();
            if (e.KeyCode==Keys.Enter)
            {
                fs.txt_search.Text = txt_accno.Text;
                fs.ShowDialog();
                if (fs.IsOk==true)
                {
                    txt_accno.Text = fs.dgv_results.CurrentRow.Cells[0].Value.ToString();
                    txt_accname.Text= fs.dgv_results.CurrentRow.Cells[2].Value.ToString();
                    txt_debit.Focus();
                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            BL.Journals.cls_Journals cj = new BL.Journals.cls_Journals();
            txt_jno.Text = cj.Generate_Jno().Rows[0][0].ToString();
            txt_note.Text = "";
            Clear();
            dgv_jouranal.Rows.Clear();
            Total_Bal();
        }

        private void cb_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt= sf.Get_Curr_Exch(cb_currency.Text);
            if (dt.Rows.Count>0)
            {
                txt_exch.Text = dt.Rows[0][2].ToString();
                txt_note.Focus();

            }
        }

        void Enter_Row()
        {
            double TD = Convert.ToDouble(txt_debit.Text) * Convert.ToDouble(txt_exch.Text);
            double TC = Convert.ToDouble(txt_crdit .Text) * Convert.ToDouble(txt_exch.Text);

            dgv_jouranal.Rows.Add(txt_jno.Text,txt_accno.Text ,txt_accname.Text,txt_debit.Text ,txt_crdit.Text ,cb_currency.SelectedValue,cb_currency.Text ,txt_exch.Text,txt_exp.Text,TD,TC  );
        }

        void Clear()
        {
            txt_accno.Text = "";
            txt_accno.Focus();
            txt_accname.Text = "";
            txt_debit.Text = "0.00";
            txt_crdit.Text = "0.00";
            
            txt_exp.Text = "";

        }

        void Total_Bal()
        {
            double TD = 0;
            double TC = 0;
            for (int i=0;i<dgv_jouranal.Rows.Count;i++ )
            {
                TD = TD + Convert.ToDouble(dgv_jouranal.Rows [i].Cells[9].Value );
                TC = TC + Convert.ToDouble(dgv_jouranal.Rows[i].Cells[10].Value);
            }
            txt_Tdebit.Text = TD.ToString("0.00");
            txt_Tcredit.Text = TC.ToString("0.00");
            txt_Deff.Text = (TD - TC).ToString("0.00");
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_accno.Text =="")
            {
                MessageBox.Show("يجب إختيار رقم الحساب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDouble(txt_debit .Text )==0.00 &&Convert.ToDouble(txt_crdit.Text )==0.00)
            {
                MessageBox.Show("لا يوجد مبلغ في طرف القيد ..! يرجي إدخال المبلغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToDouble(txt_exch.Text)==0.00)
            {
                MessageBox.Show("يرجى إختيار عملة لطرف القيد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i=0;i<dgv_jouranal.Rows.Count;i++)
            {
                if(dgv_jouranal.Rows[i].Cells[1].Value.ToString()==txt_accno.Text)
                {
                    MessageBox.Show("لا يمكن تكرار حساب معين","تنبيه",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                    Clear();
                    return;
                }

            }
            //Entering data into DataGridView
            Enter_Row();
            //Clear Data from TextBoxes
            Clear();
            //Calculating Total of Debi and Credit Balances
            Total_Bal();
        }

        private void حذفصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_jouranal.Rows.RemoveAt(dgv_jouranal.CurrentRow.Index );
            Total_Bal();
        }

        private void dgv_jouranal_DoubleClick(object sender, EventArgs e)
        {
            txt_accno.Text = dgv_jouranal.CurrentRow.Cells[1].Value.ToString();
            txt_accname.Text = dgv_jouranal.CurrentRow.Cells[2].Value.ToString();
            txt_debit.Text= dgv_jouranal.CurrentRow.Cells[3].Value.ToString();
            txt_crdit.Text = dgv_jouranal.CurrentRow.Cells[4].Value.ToString();
            cb_currency.SelectedValue= dgv_jouranal.CurrentRow.Cells[5].Value.ToString();
            txt_exch.Text= dgv_jouranal.CurrentRow.Cells[7].Value.ToString();
            txt_exp .Text= dgv_jouranal.CurrentRow.Cells[8].Value.ToString();
            dgv_jouranal.Rows.RemoveAt(dgv_jouranal.CurrentRow.Index);
            Total_Bal();
        }

        private void تعديلصفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_accno.Text = dgv_jouranal.CurrentRow.Cells[1].Value.ToString();
            txt_accname.Text = dgv_jouranal.CurrentRow.Cells[2].Value.ToString();
            txt_debit.Text = dgv_jouranal.CurrentRow.Cells[3].Value.ToString();
            txt_crdit.Text = dgv_jouranal.CurrentRow.Cells[4].Value.ToString();
            cb_currency.SelectedValue = dgv_jouranal.CurrentRow.Cells[5].Value.ToString();
            txt_exch.Text = dgv_jouranal.CurrentRow.Cells[7].Value.ToString();
            txt_exp.Text = dgv_jouranal.CurrentRow.Cells[8].Value.ToString();
            dgv_jouranal.Rows.RemoveAt(dgv_jouranal.CurrentRow.Index);
            Total_Bal();
        }
       void Jouranl_Header_Add()
        {
            
            DateTime jdate =Convert.ToDateTime( dtp_jdate.Value.ToLongDateString());
            DateTime adate = DateTime.Now;
            int uno =Convert.ToInt32( cu.Get_User_No(Program.uname).Rows[0][0].ToString());
            int jtype = 0;
            if (rb_general.Checked==true)
            {
                jtype = 1;
            }
            if (rb_wait.Checked==true)
            {
                jtype = 4;
            }
            int jpost = 0;
            if (chk_post.Checked==true)
            {
                jpost = 1;
            }
            else
            {
                jpost = 0;
            }
            int ptype = 1;
            cj.Journal_Hdr_Add(Convert.ToInt32(txt_jno.Text ),jdate,jtype,txt_note.Text,jpost,Convert.ToDouble(txt_Tdebit.Text ),Convert.ToDouble(txt_Tcredit.Text),Convert.ToDouble(txt_Deff.Text ),uno,adate,Convert.ToInt32(cb_currency.SelectedValue),Convert.ToDouble(txt_exch.Text ),ptype);
        }
        void Journal_Details_Add()
        {
            for (int i=0;i<dgv_jouranal.Rows.Count;i++)
            {
                if (dgv_jouranal.Rows.Count >0)
                {
                    int accno =Convert.ToInt32( dgv_jouranal.Rows[i].Cells[1].Value.ToString());
                    double accdeb = Convert.ToDouble(dgv_jouranal.Rows[i].Cells[3].Value.ToString());
                    double acccred= Convert.ToDouble(dgv_jouranal.Rows[i].Cells[4].Value.ToString());
                    string accnote = dgv_jouranal.Rows[i].Cells[8].Value.ToString();
                    int jno= Convert.ToInt32(dgv_jouranal.Rows[i].Cells[0].Value.ToString());
                    cj.Journal_Details_Add(accno, accdeb, acccred, accnote, jno);
                }
            }

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_Deff.Text) != 0.00 && rb_general.Checked == true)
                {
                    MessageBox.Show("القيد المحاسبي غير متوازن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToDouble(txt_Deff.Text) == 0.00 || (Convert.ToDouble(txt_Deff.Text) != 0.00 && rb_wait.Checked == true))
                {
                    Jouranl_Header_Add();
                    Journal_Details_Add();
                    show();
                    MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch
            {
                MessageBox.Show("يجب التأكد من البيانات التي تريد ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //---------------
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            txt_ju_no.Text = txt_search.Text;
        }
       void  clear_Data()
        {
            txt_jno.Text = "0";
            dtp_jdate.Value = DateTime.Now;
            rb_general.Checked = true;
            chk_post.Checked = false;
            txt_note.Text = string.Empty;
            txt_Tdebit.Text = "0.00";
            txt_Tcredit.Text = "0.00";
            txt_Deff.Text = "0.00";
        }
        private void txt_ju_no_TextChanged(object sender, EventArgs e)
        {
            //Get Data from tbl_Journal_Hdr
            DataTable dt1 = new DataTable();
            dt1 = cj.Show_Journal_Header(Convert.ToInt32(txt_ju_no.Text));

            if (dt1.Rows.Count > 0)
            {
                txt_jno.Text = dt1.Rows[0][0].ToString();
                dtp_jdate.Text = dt1.Rows[0][1].ToString();
                if (dt1.Rows[0][2].ToString() == "1")
                {
                    rb_general.Checked = true;
                }
                if (dt1.Rows[0][2].ToString() == "4")
                {
                    rb_wait.Checked = true;
                }
                txt_note.Text = dt1.Rows[0][3].ToString();
                if (dt1.Rows[0][4].ToString() == "1")
                {
                    chk_post.Checked = true;
                }
                else
                {
                    chk_post.Checked = false;
                }
                cb_currency.SelectedValue = Convert.ToInt32(dt1.Rows[0][12].ToString());
                txt_exch.Text = dt1.Rows[0][14].ToString();
                txt_Tdebit.Text = dt1.Rows[0][5].ToString();
                txt_Tcredit.Text = dt1.Rows[0][6].ToString();
                txt_Deff.Text = dt1.Rows[0][7].ToString();
                txt_ptype.Text= dt1.Rows[0][16].ToString();
            }
            else
            {
                clear_Data();
            }

            //Get Data from tbl_Journal_Details
                DataTable dt2 = new DataTable();
                dt2 = cj.Show_Journal_Details(Convert.ToInt32(txt_ju_no.Text));
                if (dt2.Rows.Count>0)
                {
                    dgv_jouranal.Rows.Clear();
                    int i = 0;
                    dgv_jouranal.RowCount = dt2.Rows.Count;
                    for (int j=0;j<dgv_jouranal.Rows.Count;j++)
                    {
                        dgv_jouranal.Rows[i].Cells[0].Value = dt2.Rows[j][5].ToString();
                        dgv_jouranal.Rows[i].Cells[1].Value = dt2.Rows[j][0].ToString();
                        dgv_jouranal.Rows[i].Cells[2].Value = dt2.Rows[j][1].ToString();
                        dgv_jouranal.Rows[i].Cells[3].Value = dt2.Rows[j][2].ToString();
                        dgv_jouranal.Rows[i].Cells[4].Value = dt2.Rows[j][3].ToString();
                        dgv_jouranal.Rows[i].Cells[5].Value = dt1.Rows[0][12].ToString();
                        dgv_jouranal.Rows[i].Cells[6].Value = dt1.Rows[0][13].ToString();
                        dgv_jouranal.Rows[i].Cells[7].Value = dt1.Rows[0][14].ToString();
                        dgv_jouranal.Rows[i].Cells[8].Value = dt2.Rows[j][4].ToString();
                        dgv_jouranal.Rows[i].Cells[9].Value =Convert.ToDouble( dt2.Rows[j][2].ToString())*Convert.ToDouble(dt1.Rows[0][14].ToString());
                        dgv_jouranal.Rows[i].Cells[10].Value = Convert.ToDouble(dt2.Rows[j][3].ToString()) * Convert.ToDouble(dt1.Rows[0][14].ToString());
                        i++;
                    }

            }else
            {
                dgv_jouranal.Rows.Clear();
                MessageBox.Show("رقم القيد الذي تبحث عنه غير موجود..إدخل رقم صحيح!!","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

           

        }
        void Jouranl_Header_Update()
        {
            DateTime jdate = Convert.ToDateTime(dtp_jdate.Value.ToLongDateString());
            DateTime Edate = DateTime.Now;
            int jno = Convert.ToInt32(cj.Get_User_No(Program.uname).Rows[0][0].ToString());
            int jtype = 0;
            if (rb_general.Checked == true)
            {
                jtype = 1;
            }
            if (rb_wait.Checked == true)
            {
                jtype = 4;
            }
            int jpost = 0;
            if (chk_post.Checked == true)
            {
                jpost = 1;
            }
            else
            {
                jpost = 0;
            }
            cj.Journal_Hdr_Update(Convert.ToInt32(txt_jno.Text), jdate, jtype, txt_note.Text, jpost, Convert.ToDouble(txt_Tdebit.Text), Convert.ToDouble(txt_Tcredit.Text), Convert.ToDouble(txt_Deff.Text), jno, Edate, Convert.ToInt32(cb_currency.SelectedValue), Convert.ToDouble(txt_exch.Text));
        }

       

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ptype.Text=="سند صرف"||txt_ptype.Text=="سند قبض")
                {
                    MessageBox.Show("هذا القيد ناتج عن عملية  صرف أو قبض لا يمكن تعديله", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chk_post.Checked==true)
                {
                    MessageBox.Show("هذا القيد مرحل لا يمكن تعديله", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                if (Convert.ToDouble(txt_Deff.Text)!=0.00 && rb_general.Checked==true)
                {
                    MessageBox.Show("القيد المحاسبي غير متوازن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(Convert.ToDouble(txt_Deff.Text) == 0.00 ||(Convert.ToDouble(txt_Deff.Text) != 0.00 && rb_wait.Checked==true))
                {
                    Jouranl_Header_Update();
                    cj.Del_Journal_Details(Convert.ToInt32(txt_ju_no.Text ));
                    Journal_Details_Add();
                    show();
                    MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            catch
            {
                MessageBox.Show("يجب التأكد من البيانات التي تريد تعديلها","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ptype.Text == "سند صرف" || txt_ptype.Text == "سند قبض")
                {
                    MessageBox.Show("هذا القيد ناتج عن عملية  صرف أو قبض لا يمكن حذفه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chk_post.Checked == true)
                {
                    MessageBox.Show("هذا القيد مرحل لا يمكن حذفه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                if (MessageBox.Show("هل تريد حذف القيد المحاسبي","تنبيه حذف",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes )
                {
                    cj.Del_Journal_Details(Convert.ToInt32(txt_ju_no.Text));
                    cj.Del_Journal_Header(Convert.ToInt32(txt_ju_no.Text));
                    clear_Data();
                    dgv_jouranal.Rows.Clear();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch
            {
                MessageBox.Show("", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
           txt_ju_no.Text = cj.Get_Journal_First().Rows[0][0].ToString();

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            txt_ju_no.Text = cj.Get_Journal_Last().Rows[0][0].ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int jmax=Convert.ToInt32( cj.Get_Journal_Last().Rows[0][0].ToString());
            if (Convert.ToInt32( txt_ju_no.Text )== jmax)
            {
                MessageBox.Show("هذا أخر قيد محاسبي","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;

            }else
            {
                txt_ju_no.Text =(Convert.ToInt32( txt_ju_no.Text) + 1).ToString();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int jmin = Convert.ToInt32(cj.Get_Journal_First().Rows[0][0].ToString());
            if (Convert.ToInt32(txt_ju_no.Text) == jmin)
            {
                MessageBox.Show("هذا أول قيد محاسبي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                txt_ju_no.Text = (Convert.ToInt32(txt_ju_no.Text) - 1).ToString();
            }
        }
        
    }
}
