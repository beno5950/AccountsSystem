namespace AccountSystem.PL.SysFormat
{
    partial class frm_cash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cash));
            this.gp_cash = new System.Windows.Forms.GroupBox();
            this.dgv_cash = new System.Windows.Forms.DataGridView();
            this.btn_display = new System.Windows.Forms.Button();
            this.gp_inputs = new System.Windows.Forms.GroupBox();
            this.txt_funtion = new System.Windows.Forms.TextBox();
            this.txt_accname = new System.Windows.Forms.TextBox();
            this.txt_accno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_ctrl = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.gp_cash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cash)).BeginInit();
            this.gp_inputs.SuspendLayout();
            this.gp_ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_cash
            // 
            this.gp_cash.Controls.Add(this.dgv_cash);
            this.gp_cash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_cash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gp_cash.Location = new System.Drawing.Point(1, 1);
            this.gp_cash.Name = "gp_cash";
            this.gp_cash.Size = new System.Drawing.Size(408, 183);
            this.gp_cash.TabIndex = 0;
            this.gp_cash.TabStop = false;
            this.gp_cash.Text = "النقدية";
            // 
            // dgv_cash
            // 
            this.dgv_cash.AllowUserToAddRows = false;
            this.dgv_cash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cash.Location = new System.Drawing.Point(3, 22);
            this.dgv_cash.Name = "dgv_cash";
            this.dgv_cash.RowHeadersVisible = false;
            this.dgv_cash.Size = new System.Drawing.Size(402, 158);
            this.dgv_cash.TabIndex = 0;
            this.dgv_cash.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cash_CellClick);
            // 
            // btn_display
            // 
            this.btn_display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_display.Location = new System.Drawing.Point(169, 18);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(78, 38);
            this.btn_display.TabIndex = 1;
            this.btn_display.Text = "عرض";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // gp_inputs
            // 
            this.gp_inputs.Controls.Add(this.txt_funtion);
            this.gp_inputs.Controls.Add(this.txt_accname);
            this.gp_inputs.Controls.Add(this.txt_accno);
            this.gp_inputs.Controls.Add(this.label2);
            this.gp_inputs.Controls.Add(this.label1);
            this.gp_inputs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_inputs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gp_inputs.Location = new System.Drawing.Point(1, 190);
            this.gp_inputs.Name = "gp_inputs";
            this.gp_inputs.Size = new System.Drawing.Size(408, 104);
            this.gp_inputs.TabIndex = 1;
            this.gp_inputs.TabStop = false;
            this.gp_inputs.Text = "المدخلات";
            // 
            // txt_funtion
            // 
            this.txt_funtion.Location = new System.Drawing.Point(294, 29);
            this.txt_funtion.Name = "txt_funtion";
            this.txt_funtion.Size = new System.Drawing.Size(32, 26);
            this.txt_funtion.TabIndex = 6;
            // 
            // txt_accname
            // 
            this.txt_accname.Enabled = false;
            this.txt_accname.Location = new System.Drawing.Point(9, 57);
            this.txt_accname.Name = "txt_accname";
            this.txt_accname.Size = new System.Drawing.Size(281, 26);
            this.txt_accname.TabIndex = 2;
            // 
            // txt_accno
            // 
            this.txt_accno.Enabled = false;
            this.txt_accno.Location = new System.Drawing.Point(9, 29);
            this.txt_accno.Name = "txt_accno";
            this.txt_accno.Size = new System.Drawing.Size(281, 26);
            this.txt_accno.TabIndex = 1;
            this.txt_accno.TextChanged += new System.EventHandler(this.txt_accno_TextChanged);
            this.txt_accno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_accno_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(325, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "إسم الحساب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(327, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحساب";
            // 
            // gp_ctrl
            // 
            this.gp_ctrl.Controls.Add(this.btn_display);
            this.gp_ctrl.Controls.Add(this.btn_exit);
            this.gp_ctrl.Controls.Add(this.btn_del);
            this.gp_ctrl.Controls.Add(this.btn_save);
            this.gp_ctrl.Controls.Add(this.btn_new);
            this.gp_ctrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ctrl.Location = new System.Drawing.Point(1, 297);
            this.gp_ctrl.Name = "gp_ctrl";
            this.gp_ctrl.Size = new System.Drawing.Size(408, 68);
            this.gp_ctrl.TabIndex = 2;
            this.gp_ctrl.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_exit.Location = new System.Drawing.Point(9, 18);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 38);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_del
            // 
            this.btn_del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_del.Location = new System.Drawing.Point(92, 18);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 38);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "حذف";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_save.Location = new System.Drawing.Point(250, 18);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 38);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_new.Location = new System.Drawing.Point(327, 18);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 38);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 367);
            this.Controls.Add(this.gp_ctrl);
            this.Controls.Add(this.gp_inputs);
            this.Controls.Add(this.gp_cash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.gp_cash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cash)).EndInit();
            this.gp_inputs.ResumeLayout(false);
            this.gp_inputs.PerformLayout();
            this.gp_ctrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_cash;
        private System.Windows.Forms.GroupBox gp_inputs;
        private System.Windows.Forms.TextBox txt_accname;
        private System.Windows.Forms.TextBox txt_accno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp_ctrl;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        public System.Windows.Forms.TextBox txt_funtion;
        public System.Windows.Forms.GroupBox gp_cash;
        private System.Windows.Forms.Button btn_display;
    }
}