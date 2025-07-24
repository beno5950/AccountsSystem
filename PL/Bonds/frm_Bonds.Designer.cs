namespace AccountSystem.PL.Bonds
{
    partial class frm_Bonds
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Bonds));
            this.btn_enter = new System.Windows.Forms.Button();
            this.cb_currency = new System.Windows.Forms.ComboBox();
            this.txt_exp = new System.Windows.Forms.TextBox();
            this.txt_exch = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_accname = new System.Windows.Forms.TextBox();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gp_ctrl = new System.Windows.Forms.GroupBox();
            this.txt_uno = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_Tamount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.تعديلصفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفصفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.gp_bhd = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_cash = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_cash_accno = new System.Windows.Forms.TextBox();
            this.chk_post = new System.Windows.Forms.CheckBox();
            this.txt_bond_no = new System.Windows.Forms.TextBox();
            this.txt_jno = new System.Windows.Forms.TextBox();
            this.txt_btype = new System.Windows.Forms.TextBox();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.dtp_bdate = new System.Windows.Forms.DateTimePicker();
            this.txt_bno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_inputs = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_bonds = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp_bonds = new System.Windows.Forms.GroupBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.gp_ctrl.SuspendLayout();
            this.cMenuStrip.SuspendLayout();
            this.gp_bhd.SuspendLayout();
            this.gp_inputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bonds)).BeginInit();
            this.gp_bonds.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.Image = ((System.Drawing.Image)(resources.GetObject("btn_enter.Image")));
            this.btn_enter.Location = new System.Drawing.Point(7, 27);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(45, 35);
            this.btn_enter.TabIndex = 9;
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // cb_currency
            // 
            this.cb_currency.FormattingEnabled = true;
            this.cb_currency.Location = new System.Drawing.Point(329, 37);
            this.cb_currency.Name = "cb_currency";
            this.cb_currency.Size = new System.Drawing.Size(125, 27);
            this.cb_currency.TabIndex = 6;
            this.cb_currency.SelectedIndexChanged += new System.EventHandler(this.cb_currency_SelectedIndexChanged);
            // 
            // txt_exp
            // 
            this.txt_exp.Location = new System.Drawing.Point(58, 38);
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(189, 26);
            this.txt_exp.TabIndex = 8;
            // 
            // txt_exch
            // 
            this.txt_exch.Location = new System.Drawing.Point(254, 38);
            this.txt_exch.Name = "txt_exch";
            this.txt_exch.ReadOnly = true;
            this.txt_exch.Size = new System.Drawing.Size(68, 26);
            this.txt_exch.TabIndex = 7;
            this.txt_exch.Text = "0.00";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(462, 38);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(114, 26);
            this.txt_amount.TabIndex = 4;
            this.txt_amount.Text = "0.00";
            // 
            // txt_accname
            // 
            this.txt_accname.Location = new System.Drawing.Point(582, 38);
            this.txt_accname.Name = "txt_accname";
            this.txt_accname.ReadOnly = true;
            this.txt_accname.Size = new System.Drawing.Size(223, 26);
            this.txt_accname.TabIndex = 3;
            // 
            // txt_accno
            // 
            this.txt_accno.Location = new System.Drawing.Point(811, 38);
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.Size = new System.Drawing.Size(100, 26);
            this.txt_accno.TabIndex = 2;
            this.txt_accno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_accno_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(204, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "البيان";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(403, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "العملة";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(269, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "الصرف";
            // 
            // btn_exit
            // 
            this.btn_exit.ForeColor = System.Drawing.Color.Maroon;
            this.btn_exit.Location = new System.Drawing.Point(3, 23);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(95, 50);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_del
            // 
            this.btn_del.ForeColor = System.Drawing.Color.Maroon;
            this.btn_del.Location = new System.Drawing.Point(235, 23);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 50);
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "حذف";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ForeColor = System.Drawing.Color.Maroon;
            this.btn_edit.Location = new System.Drawing.Point(311, 23);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 50);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_save.Location = new System.Drawing.Point(386, 23);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 50);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.ForeColor = System.Drawing.Color.Maroon;
            this.btn_new.Location = new System.Drawing.Point(461, 23);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 50);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(839, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "إجمالي السند";
            // 
            // gp_ctrl
            // 
            this.gp_ctrl.Controls.Add(this.btn_print);
            this.gp_ctrl.Controls.Add(this.btn_exit);
            this.gp_ctrl.Controls.Add(this.btn_del);
            this.gp_ctrl.Controls.Add(this.btn_edit);
            this.gp_ctrl.Controls.Add(this.btn_save);
            this.gp_ctrl.Controls.Add(this.btn_new);
            this.gp_ctrl.Controls.Add(this.txt_uno);
            this.gp_ctrl.Controls.Add(this.txt_user);
            this.gp_ctrl.Controls.Add(this.txt_Tamount);
            this.gp_ctrl.Controls.Add(this.label13);
            this.gp_ctrl.Controls.Add(this.label12);
            this.gp_ctrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ctrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gp_ctrl.Location = new System.Drawing.Point(2, 444);
            this.gp_ctrl.Name = "gp_ctrl";
            this.gp_ctrl.Size = new System.Drawing.Size(920, 82);
            this.gp_ctrl.TabIndex = 1;
            this.gp_ctrl.TabStop = false;
            // 
            // txt_uno
            // 
            this.txt_uno.Location = new System.Drawing.Point(604, 50);
            this.txt_uno.Name = "txt_uno";
            this.txt_uno.ReadOnly = true;
            this.txt_uno.Size = new System.Drawing.Size(113, 26);
            this.txt_uno.TabIndex = 14;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(723, 50);
            this.txt_user.Name = "txt_user";
            this.txt_user.ReadOnly = true;
            this.txt_user.Size = new System.Drawing.Size(113, 26);
            this.txt_user.TabIndex = 14;
            // 
            // txt_Tamount
            // 
            this.txt_Tamount.Location = new System.Drawing.Point(733, 19);
            this.txt_Tamount.Name = "txt_Tamount";
            this.txt_Tamount.ReadOnly = true;
            this.txt_Tamount.Size = new System.Drawing.Size(100, 26);
            this.txt_Tamount.TabIndex = 14;
            this.txt_Tamount.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(857, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "المستخدم";
            // 
            // تعديلصفToolStripMenuItem
            // 
            this.تعديلصفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("تعديلصفToolStripMenuItem.Image")));
            this.تعديلصفToolStripMenuItem.Name = "تعديلصفToolStripMenuItem";
            this.تعديلصفToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.تعديلصفToolStripMenuItem.Text = "تعديل  صف";
            this.تعديلصفToolStripMenuItem.Click += new System.EventHandler(this.تعديلصفToolStripMenuItem_Click);
            // 
            // حذفصفToolStripMenuItem
            // 
            this.حذفصفToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("حذفصفToolStripMenuItem.Image")));
            this.حذفصفToolStripMenuItem.Name = "حذفصفToolStripMenuItem";
            this.حذفصفToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.حذفصفToolStripMenuItem.Text = "حذف صف";
            this.حذفصفToolStripMenuItem.Click += new System.EventHandler(this.حذفصفToolStripMenuItem_Click);
            // 
            // cMenuStrip
            // 
            this.cMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفصفToolStripMenuItem,
            this.تعديلصفToolStripMenuItem});
            this.cMenuStrip.Name = "cMenuStrip";
            this.cMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cMenuStrip.Size = new System.Drawing.Size(125, 48);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(533, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "المبلغ";
            // 
            // gp_bhd
            // 
            this.gp_bhd.Controls.Add(this.btn_search);
            this.gp_bhd.Controls.Add(this.cb_cash);
            this.gp_bhd.Controls.Add(this.txt_search);
            this.gp_bhd.Controls.Add(this.txt_cash_accno);
            this.gp_bhd.Controls.Add(this.chk_post);
            this.gp_bhd.Controls.Add(this.txt_bond_no);
            this.gp_bhd.Controls.Add(this.txt_jno);
            this.gp_bhd.Controls.Add(this.txt_btype);
            this.gp_bhd.Controls.Add(this.btn_first);
            this.gp_bhd.Controls.Add(this.btn_prev);
            this.gp_bhd.Controls.Add(this.btn_next);
            this.gp_bhd.Controls.Add(this.btn_last);
            this.gp_bhd.Controls.Add(this.label8);
            this.gp_bhd.Controls.Add(this.txt_note);
            this.gp_bhd.Controls.Add(this.dtp_bdate);
            this.gp_bhd.Controls.Add(this.txt_bno);
            this.gp_bhd.Controls.Add(this.label3);
            this.gp_bhd.Controls.Add(this.label2);
            this.gp_bhd.Controls.Add(this.label1);
            this.gp_bhd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_bhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gp_bhd.Location = new System.Drawing.Point(2, 3);
            this.gp_bhd.Name = "gp_bhd";
            this.gp_bhd.Size = new System.Drawing.Size(920, 85);
            this.gp_bhd.TabIndex = 2;
            this.gp_bhd.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(10, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 26);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_cash
            // 
            this.cb_cash.FormattingEnabled = true;
            this.cb_cash.Location = new System.Drawing.Point(428, 47);
            this.cb_cash.Name = "cb_cash";
            this.cb_cash.Size = new System.Drawing.Size(125, 27);
            this.cb_cash.TabIndex = 6;
            this.cb_cash.SelectedIndexChanged += new System.EventHandler(this.cb_cash_SelectedIndexChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(93, 50);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(154, 26);
            this.txt_search.TabIndex = 28;
            // 
            // txt_cash_accno
            // 
            this.txt_cash_accno.Location = new System.Drawing.Point(319, 46);
            this.txt_cash_accno.Name = "txt_cash_accno";
            this.txt_cash_accno.ReadOnly = true;
            this.txt_cash_accno.Size = new System.Drawing.Size(103, 26);
            this.txt_cash_accno.TabIndex = 7;
            this.txt_cash_accno.Text = "0.00";
            // 
            // chk_post
            // 
            this.chk_post.AutoSize = true;
            this.chk_post.Location = new System.Drawing.Point(253, 49);
            this.chk_post.Name = "chk_post";
            this.chk_post.Size = new System.Drawing.Size(57, 23);
            this.chk_post.TabIndex = 22;
            this.chk_post.Text = "مرحل";
            this.chk_post.UseVisualStyleBackColor = true;
            // 
            // txt_bond_no
            // 
            this.txt_bond_no.Location = new System.Drawing.Point(79, 16);
            this.txt_bond_no.Name = "txt_bond_no";
            this.txt_bond_no.ReadOnly = true;
            this.txt_bond_no.Size = new System.Drawing.Size(100, 26);
            this.txt_bond_no.TabIndex = 23;
            this.txt_bond_no.Text = "0";
            this.txt_bond_no.TextChanged += new System.EventHandler(this.txt_bond_no_TextChanged);
            // 
            // txt_jno
            // 
            this.txt_jno.Location = new System.Drawing.Point(300, 16);
            this.txt_jno.Name = "txt_jno";
            this.txt_jno.Size = new System.Drawing.Size(74, 26);
            this.txt_jno.TabIndex = 2;
            this.txt_jno.Text = "0";
            // 
            // txt_btype
            // 
            this.txt_btype.Location = new System.Drawing.Point(380, 16);
            this.txt_btype.Name = "txt_btype";
            this.txt_btype.Size = new System.Drawing.Size(74, 26);
            this.txt_btype.TabIndex = 2;
            this.txt_btype.Text = "0";
            // 
            // btn_first
            // 
            this.btn_first.Image = ((System.Drawing.Image)(resources.GetObject("btn_first.Image")));
            this.btn_first.Location = new System.Drawing.Point(11, 15);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(34, 26);
            this.btn_first.TabIndex = 27;
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.Image")));
            this.btn_prev.Location = new System.Drawing.Point(46, 15);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(30, 26);
            this.btn_prev.TabIndex = 26;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(183, 15);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(29, 26);
            this.btn_next.TabIndex = 25;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Image = ((System.Drawing.Image)(resources.GetObject("btn_last.Image")));
            this.btn_last.Location = new System.Drawing.Point(213, 15);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(35, 26);
            this.btn_last.TabIndex = 24;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(559, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "الصندوق";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(625, 50);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(211, 26);
            this.txt_note.TabIndex = 1;
            // 
            // dtp_bdate
            // 
            this.dtp_bdate.Location = new System.Drawing.Point(462, 19);
            this.dtp_bdate.Name = "dtp_bdate";
            this.dtp_bdate.Size = new System.Drawing.Size(200, 26);
            this.dtp_bdate.TabIndex = 18;
            // 
            // txt_bno
            // 
            this.txt_bno.Location = new System.Drawing.Point(736, 19);
            this.txt_bno.Name = "txt_bno";
            this.txt_bno.ReadOnly = true;
            this.txt_bno.Size = new System.Drawing.Size(100, 26);
            this.txt_bno.TabIndex = 17;
            this.txt_bno.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(873, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "البيان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(668, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ السند";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(858, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم السند";
            // 
            // gp_inputs
            // 
            this.gp_inputs.Controls.Add(this.btn_enter);
            this.gp_inputs.Controls.Add(this.cb_currency);
            this.gp_inputs.Controls.Add(this.txt_exp);
            this.gp_inputs.Controls.Add(this.txt_exch);
            this.gp_inputs.Controls.Add(this.txt_amount);
            this.gp_inputs.Controls.Add(this.txt_accname);
            this.gp_inputs.Controls.Add(this.txt_accno);
            this.gp_inputs.Controls.Add(this.label11);
            this.gp_inputs.Controls.Add(this.label10);
            this.gp_inputs.Controls.Add(this.label9);
            this.gp_inputs.Controls.Add(this.label7);
            this.gp_inputs.Controls.Add(this.label6);
            this.gp_inputs.Controls.Add(this.label5);
            this.gp_inputs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_inputs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gp_inputs.Location = new System.Drawing.Point(2, 90);
            this.gp_inputs.Name = "gp_inputs";
            this.gp_inputs.Size = new System.Drawing.Size(920, 69);
            this.gp_inputs.TabIndex = 3;
            this.gp_inputs.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(736, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "إسم الحساب";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(839, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "رقم الحساب";
            // 
            // dgv_bonds
            // 
            this.dgv_bonds.AllowUserToAddRows = false;
            this.dgv_bonds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bonds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bonds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column4});
            this.dgv_bonds.ContextMenuStrip = this.cMenuStrip;
            this.dgv_bonds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bonds.Location = new System.Drawing.Point(3, 22);
            this.dgv_bonds.Name = "dgv_bonds";
            this.dgv_bonds.RowHeadersVisible = false;
            this.dgv_bonds.Size = new System.Drawing.Size(914, 265);
            this.dgv_bonds.TabIndex = 0;
            this.dgv_bonds.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bonds_CellDoubleClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "رقم السند";
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم الحساب";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "إسم الحساب";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "المبلغ";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "رقم العملة";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "العملة";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الصرف";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "البيان";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "إجمالي المبلغ";
            this.Column4.Name = "Column4";
            // 
            // gp_bonds
            // 
            this.gp_bonds.Controls.Add(this.dgv_bonds);
            this.gp_bonds.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_bonds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gp_bonds.Location = new System.Drawing.Point(2, 160);
            this.gp_bonds.Name = "gp_bonds";
            this.gp_bonds.Size = new System.Drawing.Size(920, 290);
            this.gp_bonds.TabIndex = 4;
            this.gp_bonds.TabStop = false;
            // 
            // btn_print
            // 
            this.btn_print.ForeColor = System.Drawing.Color.Maroon;
            this.btn_print.Location = new System.Drawing.Point(154, 23);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 50);
            this.btn_print.TabIndex = 15;
            this.btn_print.Text = "طباعة";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click_1);
            // 
            // frm_Bonds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 529);
            this.Controls.Add(this.gp_ctrl);
            this.Controls.Add(this.gp_bhd);
            this.Controls.Add(this.gp_inputs);
            this.Controls.Add(this.gp_bonds);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Bonds";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_Bonds_Load);
            this.gp_ctrl.ResumeLayout(false);
            this.gp_ctrl.PerformLayout();
            this.cMenuStrip.ResumeLayout(false);
            this.gp_bhd.ResumeLayout(false);
            this.gp_bhd.PerformLayout();
            this.gp_inputs.ResumeLayout(false);
            this.gp_inputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bonds)).EndInit();
            this.gp_bonds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.ComboBox cb_currency;
        private System.Windows.Forms.TextBox txt_exp;
        private System.Windows.Forms.TextBox txt_exch;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_accname;
        private System.Windows.Forms.TextBox txt_accno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gp_ctrl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem تعديلصفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفصفToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cMenuStrip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gp_bhd;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_cash;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_cash_accno;
        private System.Windows.Forms.CheckBox chk_post;
        private System.Windows.Forms.TextBox txt_bond_no;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.DateTimePicker dtp_bdate;
        private System.Windows.Forms.TextBox txt_bno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp_inputs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_uno;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_Tamount;
        private System.Windows.Forms.DataGridView dgv_bonds;
        public System.Windows.Forms.GroupBox gp_bonds;
        public System.Windows.Forms.TextBox txt_jno;
        public System.Windows.Forms.TextBox txt_btype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_print;
    }
}