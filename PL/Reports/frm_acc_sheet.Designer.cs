namespace AccountSystem.PL.Reports
{
    partial class frm_acc_sheet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_accname = new System.Windows.Forms.TextBox();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.txt_exch = new System.Windows.Forms.TextBox();
            this.cb_currency = new System.Windows.Forms.ComboBox();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_acc_sheet = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.txt_tdeff = new System.Windows.Forms.TextBox();
            this.txt_tcredit = new System.Windows.Forms.TextBox();
            this.txt_tdebit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acc_sheet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_accname);
            this.groupBox1.Controls.Add(this.txt_accno);
            this.groupBox1.Controls.Add(this.txt_exch);
            this.groupBox1.Controls.Add(this.cb_currency);
            this.groupBox1.Controls.Add(this.dtp_to);
            this.groupBox1.Controls.Add(this.dtp_from);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_accname
            // 
            this.txt_accname.Location = new System.Drawing.Point(94, 56);
            this.txt_accname.Name = "txt_accname";
            this.txt_accname.ReadOnly = true;
            this.txt_accname.Size = new System.Drawing.Size(121, 26);
            this.txt_accname.TabIndex = 3;
            // 
            // txt_accno
            // 
            this.txt_accno.Location = new System.Drawing.Point(94, 22);
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.ReadOnly = true;
            this.txt_accno.Size = new System.Drawing.Size(121, 26);
            this.txt_accno.TabIndex = 3;
            // 
            // txt_exch
            // 
            this.txt_exch.Location = new System.Drawing.Point(300, 56);
            this.txt_exch.Name = "txt_exch";
            this.txt_exch.ReadOnly = true;
            this.txt_exch.Size = new System.Drawing.Size(121, 26);
            this.txt_exch.TabIndex = 3;
            // 
            // cb_currency
            // 
            this.cb_currency.FormattingEnabled = true;
            this.cb_currency.Location = new System.Drawing.Point(299, 22);
            this.cb_currency.Name = "cb_currency";
            this.cb_currency.Size = new System.Drawing.Size(121, 27);
            this.cb_currency.TabIndex = 2;
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(500, 56);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 26);
            this.dtp_to.TabIndex = 1;
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(500, 22);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 26);
            this.dtp_from.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "إسم الحساب";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "رقم الحساب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "الصرف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "العملة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "إلى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "من";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_acc_sheet);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(6, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "كشف حساب";
            // 
            // dgv_acc_sheet
            // 
            this.dgv_acc_sheet.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_acc_sheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_acc_sheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_acc_sheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_acc_sheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_acc_sheet.Location = new System.Drawing.Point(3, 22);
            this.dgv_acc_sheet.Name = "dgv_acc_sheet";
            this.dgv_acc_sheet.RowHeadersVisible = false;
            this.dgv_acc_sheet.Size = new System.Drawing.Size(800, 261);
            this.dgv_acc_sheet.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_exit);
            this.groupBox3.Controls.Add(this.btn_show);
            this.groupBox3.Controls.Add(this.txt_tdeff);
            this.groupBox3.Controls.Add(this.txt_tcredit);
            this.groupBox3.Controls.Add(this.txt_tdebit);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(1, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(816, 97);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(23, 53);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 38);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(104, 53);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 38);
            this.btn_show.TabIndex = 4;
            this.btn_show.Text = "عرض";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // txt_tdeff
            // 
            this.txt_tdeff.Location = new System.Drawing.Point(104, 15);
            this.txt_tdeff.Name = "txt_tdeff";
            this.txt_tdeff.ReadOnly = true;
            this.txt_tdeff.Size = new System.Drawing.Size(121, 26);
            this.txt_tdeff.TabIndex = 3;
            // 
            // txt_tcredit
            // 
            this.txt_tcredit.Location = new System.Drawing.Point(369, 15);
            this.txt_tcredit.Name = "txt_tcredit";
            this.txt_tcredit.ReadOnly = true;
            this.txt_tcredit.Size = new System.Drawing.Size(121, 26);
            this.txt_tcredit.TabIndex = 3;
            // 
            // txt_tdebit
            // 
            this.txt_tdebit.Location = new System.Drawing.Point(595, 15);
            this.txt_tdebit.Name = "txt_tdebit";
            this.txt_tdebit.ReadOnly = true;
            this.txt_tdebit.Size = new System.Drawing.Size(121, 26);
            this.txt_tdebit.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "االرصيد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "رصيد دائن";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(734, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "رصيد مدين";
            // 
            // frm_acc_sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_acc_sheet";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "كشف حساب";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acc_sheet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_accname;
        public System.Windows.Forms.TextBox txt_accno;
        public System.Windows.Forms.TextBox txt_exch;
        public System.Windows.Forms.ComboBox cb_currency;
        public System.Windows.Forms.DateTimePicker dtp_to;
        public System.Windows.Forms.DateTimePicker dtp_from;
        public System.Windows.Forms.TextBox txt_tdeff;
        public System.Windows.Forms.TextBox txt_tcredit;
        public System.Windows.Forms.TextBox txt_tdebit;
        public System.Windows.Forms.DataGridView dgv_acc_sheet;
    }
}