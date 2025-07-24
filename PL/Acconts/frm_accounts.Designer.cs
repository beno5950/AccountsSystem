namespace AccountSystem.PL.Acconts
{
    partial class frm_accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_accounts));
            this.gp_accounts = new System.Windows.Forms.GroupBox();
            this.tv_accounts = new System.Windows.Forms.TreeView();
            this.gp_inputs = new System.Windows.Forms.GroupBox();
            this.txt_palance = new System.Windows.Forms.TextBox();
            this.txt_credit = new System.Windows.Forms.TextBox();
            this.txt_debit = new System.Windows.Forms.TextBox();
            this.txt_acclevel = new System.Windows.Forms.TextBox();
            this.txt_accname = new System.Windows.Forms.TextBox();
            this.txt_accparent = new System.Windows.Forms.TextBox();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tag = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_acctype = new System.Windows.Forms.ComboBox();
            this.cb_report = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_accounts = new System.Windows.Forms.Button();
            this.gp_accounts.SuspendLayout();
            this.gp_inputs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_accounts
            // 
            this.gp_accounts.Controls.Add(this.tv_accounts);
            this.gp_accounts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_accounts.ForeColor = System.Drawing.Color.Red;
            this.gp_accounts.Location = new System.Drawing.Point(3, 1);
            this.gp_accounts.Name = "gp_accounts";
            this.gp_accounts.Size = new System.Drawing.Size(408, 362);
            this.gp_accounts.TabIndex = 0;
            this.gp_accounts.TabStop = false;
            this.gp_accounts.Text = "الدليل المحاسبي";
            // 
            // tv_accounts
            // 
            this.tv_accounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_accounts.ForeColor = System.Drawing.Color.Red;
            this.tv_accounts.Location = new System.Drawing.Point(3, 22);
            this.tv_accounts.Name = "tv_accounts";
            this.tv_accounts.RightToLeftLayout = true;
            this.tv_accounts.Size = new System.Drawing.Size(402, 337);
            this.tv_accounts.TabIndex = 0;
            this.tv_accounts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_accounts_AfterSelect);
            // 
            // gp_inputs
            // 
            this.gp_inputs.Controls.Add(this.txt_palance);
            this.gp_inputs.Controls.Add(this.txt_credit);
            this.gp_inputs.Controls.Add(this.txt_debit);
            this.gp_inputs.Controls.Add(this.txt_acclevel);
            this.gp_inputs.Controls.Add(this.txt_accname);
            this.gp_inputs.Controls.Add(this.txt_accparent);
            this.gp_inputs.Controls.Add(this.txt_accno);
            this.gp_inputs.Controls.Add(this.label7);
            this.gp_inputs.Controls.Add(this.label6);
            this.gp_inputs.Controls.Add(this.label5);
            this.gp_inputs.Controls.Add(this.label4);
            this.gp_inputs.Controls.Add(this.label3);
            this.gp_inputs.Controls.Add(this.label2);
            this.gp_inputs.Controls.Add(this.label1);
            this.gp_inputs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_inputs.ForeColor = System.Drawing.Color.Red;
            this.gp_inputs.Location = new System.Drawing.Point(414, 1);
            this.gp_inputs.Name = "gp_inputs";
            this.gp_inputs.Size = new System.Drawing.Size(420, 241);
            this.gp_inputs.TabIndex = 1;
            this.gp_inputs.TabStop = false;
            this.gp_inputs.Text = "المدخلات";
            // 
            // txt_palance
            // 
            this.txt_palance.Location = new System.Drawing.Point(9, 206);
            this.txt_palance.Name = "txt_palance";
            this.txt_palance.Size = new System.Drawing.Size(293, 26);
            this.txt_palance.TabIndex = 7;
            this.txt_palance.Text = "0.00";
            // 
            // txt_credit
            // 
            this.txt_credit.Location = new System.Drawing.Point(9, 180);
            this.txt_credit.Name = "txt_credit";
            this.txt_credit.Size = new System.Drawing.Size(293, 26);
            this.txt_credit.TabIndex = 6;
            this.txt_credit.Text = "0.00";
            // 
            // txt_debit
            // 
            this.txt_debit.Location = new System.Drawing.Point(9, 150);
            this.txt_debit.Name = "txt_debit";
            this.txt_debit.Size = new System.Drawing.Size(293, 26);
            this.txt_debit.TabIndex = 5;
            this.txt_debit.Text = "0.00";
            // 
            // txt_acclevel
            // 
            this.txt_acclevel.Location = new System.Drawing.Point(9, 119);
            this.txt_acclevel.Name = "txt_acclevel";
            this.txt_acclevel.Size = new System.Drawing.Size(293, 26);
            this.txt_acclevel.TabIndex = 4;
            // 
            // txt_accname
            // 
            this.txt_accname.Location = new System.Drawing.Point(9, 90);
            this.txt_accname.Name = "txt_accname";
            this.txt_accname.Size = new System.Drawing.Size(293, 26);
            this.txt_accname.TabIndex = 3;
            // 
            // txt_accparent
            // 
            this.txt_accparent.Location = new System.Drawing.Point(9, 61);
            this.txt_accparent.Name = "txt_accparent";
            this.txt_accparent.Size = new System.Drawing.Size(293, 26);
            this.txt_accparent.TabIndex = 2;
            // 
            // txt_accno
            // 
            this.txt_accno.Enabled = false;
            this.txt_accno.Location = new System.Drawing.Point(120, 31);
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.Size = new System.Drawing.Size(182, 26);
            this.txt_accno.TabIndex = 1;
            this.txt_accno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_accno_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(369, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "رصيد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(373, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "دائن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(369, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "مدين";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(315, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "مستوى الحساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(330, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "إسم الحساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(333, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "الحساب الأب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحساب";
            // 
            // txt_tag
            // 
            this.txt_tag.Location = new System.Drawing.Point(308, 29);
            this.txt_tag.Name = "txt_tag";
            this.txt_tag.Size = new System.Drawing.Size(35, 26);
            this.txt_tag.TabIndex = 8;
            this.txt_tag.Visible = false;
            this.txt_tag.TextChanged += new System.EventHandler(this.txt_tag_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_tag);
            this.groupBox3.Controls.Add(this.cb_acctype);
            this.groupBox3.Controls.Add(this.cb_report);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(417, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cb_acctype
            // 
            this.cb_acctype.FormattingEnabled = true;
            this.cb_acctype.Location = new System.Drawing.Point(9, 60);
            this.cb_acctype.Name = "cb_acctype";
            this.cb_acctype.Size = new System.Drawing.Size(293, 27);
            this.cb_acctype.TabIndex = 9;
            // 
            // cb_report
            // 
            this.cb_report.FormattingEnabled = true;
            this.cb_report.Location = new System.Drawing.Point(9, 29);
            this.cb_report.Name = "cb_report";
            this.cb_report.Size = new System.Drawing.Size(293, 27);
            this.cb_report.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(337, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "نوع الحساب";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(363, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "التقرير";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_exit);
            this.groupBox4.Controls.Add(this.btn_del);
            this.groupBox4.Controls.Add(this.btn_update);
            this.groupBox4.Controls.Add(this.btn_save);
            this.groupBox4.Controls.Add(this.btn_new);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(417, 354);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 73);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.ForeColor = System.Drawing.Color.Maroon;
            this.btn_exit.Location = new System.Drawing.Point(11, 19);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 44);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_del
            // 
            this.btn_del.ForeColor = System.Drawing.Color.Maroon;
            this.btn_del.Location = new System.Drawing.Point(92, 19);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 44);
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "حذف";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.ForeColor = System.Drawing.Color.Maroon;
            this.btn_update.Location = new System.Drawing.Point(173, 19);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 44);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_save.Location = new System.Drawing.Point(254, 19);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 44);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.ForeColor = System.Drawing.Color.Maroon;
            this.btn_new.Location = new System.Drawing.Point(335, 19);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 44);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_accounts
            // 
            this.btn_accounts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accounts.ForeColor = System.Drawing.Color.Green;
            this.btn_accounts.Location = new System.Drawing.Point(6, 373);
            this.btn_accounts.Name = "btn_accounts";
            this.btn_accounts.Size = new System.Drawing.Size(402, 44);
            this.btn_accounts.TabIndex = 4;
            this.btn_accounts.Text = "الدليل المحاسبي";
            this.btn_accounts.UseVisualStyleBackColor = true;
            this.btn_accounts.Click += new System.EventHandler(this.btn_accounts_Click);
            // 
            // frm_accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 429);
            this.Controls.Add(this.btn_accounts);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gp_inputs);
            this.Controls.Add(this.gp_accounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_accounts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الحسابات";
            this.gp_accounts.ResumeLayout(false);
            this.gp_inputs.ResumeLayout(false);
            this.gp_inputs.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_accounts;
        private System.Windows.Forms.TreeView tv_accounts;
        private System.Windows.Forms.GroupBox gp_inputs;
        private System.Windows.Forms.TextBox txt_palance;
        private System.Windows.Forms.TextBox txt_credit;
        private System.Windows.Forms.TextBox txt_debit;
        private System.Windows.Forms.TextBox txt_acclevel;
        private System.Windows.Forms.TextBox txt_accname;
        private System.Windows.Forms.TextBox txt_accparent;
        private System.Windows.Forms.TextBox txt_accno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_acctype;
        private System.Windows.Forms.ComboBox cb_report;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_tag;
        private System.Windows.Forms.Button btn_accounts;
    }
}