namespace AccountSystem.PL.SysFormat
{
    partial class frm_currencies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_currencies));
            this.gp_currencies = new System.Windows.Forms.GroupBox();
            this.dgv_currencies = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.gp_inputs = new System.Windows.Forms.GroupBox();
            this.rb_frign = new System.Windows.Forms.RadioButton();
            this.rb_local = new System.Windows.Forms.RadioButton();
            this.txt_part = new System.Windows.Forms.TextBox();
            this.txt_exch = new System.Windows.Forms.TextBox();
            this.txt_symbol = new System.Windows.Forms.TextBox();
            this.txt_ecname = new System.Windows.Forms.TextBox();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_ctrl = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.gp_currencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currencies)).BeginInit();
            this.gp_inputs.SuspendLayout();
            this.gp_ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_currencies
            // 
            this.gp_currencies.Controls.Add(this.dgv_currencies);
            this.gp_currencies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_currencies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gp_currencies.Location = new System.Drawing.Point(5, 3);
            this.gp_currencies.Name = "gp_currencies";
            this.gp_currencies.Size = new System.Drawing.Size(408, 183);
            this.gp_currencies.TabIndex = 3;
            this.gp_currencies.TabStop = false;
            this.gp_currencies.Text = "العملات";
            // 
            // dgv_currencies
            // 
            this.dgv_currencies.AllowUserToAddRows = false;
            this.dgv_currencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_currencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_currencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_currencies.Location = new System.Drawing.Point(3, 22);
            this.dgv_currencies.Name = "dgv_currencies";
            this.dgv_currencies.RowHeadersVisible = false;
            this.dgv_currencies.Size = new System.Drawing.Size(402, 158);
            this.dgv_currencies.TabIndex = 0;
            this.dgv_currencies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_currencies_CellClick);
            // 
            // btn_edit
            // 
            this.btn_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_edit.Location = new System.Drawing.Point(169, 18);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(78, 38);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // gp_inputs
            // 
            this.gp_inputs.Controls.Add(this.rb_frign);
            this.gp_inputs.Controls.Add(this.rb_local);
            this.gp_inputs.Controls.Add(this.txt_part);
            this.gp_inputs.Controls.Add(this.txt_exch);
            this.gp_inputs.Controls.Add(this.txt_symbol);
            this.gp_inputs.Controls.Add(this.txt_ecname);
            this.gp_inputs.Controls.Add(this.txt_cname);
            this.gp_inputs.Controls.Add(this.label6);
            this.gp_inputs.Controls.Add(this.label5);
            this.gp_inputs.Controls.Add(this.label4);
            this.gp_inputs.Controls.Add(this.label3);
            this.gp_inputs.Controls.Add(this.label2);
            this.gp_inputs.Controls.Add(this.label1);
            this.gp_inputs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_inputs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gp_inputs.Location = new System.Drawing.Point(5, 185);
            this.gp_inputs.Name = "gp_inputs";
            this.gp_inputs.Size = new System.Drawing.Size(408, 208);
            this.gp_inputs.TabIndex = 4;
            this.gp_inputs.TabStop = false;
            this.gp_inputs.Text = "المدخلات";
            // 
            // rb_frign
            // 
            this.rb_frign.AutoSize = true;
            this.rb_frign.Enabled = false;
            this.rb_frign.Location = new System.Drawing.Point(59, 175);
            this.rb_frign.Name = "rb_frign";
            this.rb_frign.Size = new System.Drawing.Size(89, 23);
            this.rb_frign.TabIndex = 7;
            this.rb_frign.TabStop = true;
            this.rb_frign.Text = "عملة أجنبية";
            this.rb_frign.UseVisualStyleBackColor = true;
            // 
            // rb_local
            // 
            this.rb_local.AutoSize = true;
            this.rb_local.Enabled = false;
            this.rb_local.Location = new System.Drawing.Point(207, 175);
            this.rb_local.Name = "rb_local";
            this.rb_local.Size = new System.Drawing.Size(88, 23);
            this.rb_local.TabIndex = 6;
            this.rb_local.TabStop = true;
            this.rb_local.Text = "عملة محلية";
            this.rb_local.UseVisualStyleBackColor = true;
            // 
            // txt_part
            // 
            this.txt_part.Enabled = false;
            this.txt_part.Location = new System.Drawing.Point(9, 144);
            this.txt_part.Name = "txt_part";
            this.txt_part.Size = new System.Drawing.Size(303, 26);
            this.txt_part.TabIndex = 5;
            // 
            // txt_exch
            // 
            this.txt_exch.Enabled = false;
            this.txt_exch.Location = new System.Drawing.Point(9, 115);
            this.txt_exch.Name = "txt_exch";
            this.txt_exch.Size = new System.Drawing.Size(303, 26);
            this.txt_exch.TabIndex = 4;
            // 
            // txt_symbol
            // 
            this.txt_symbol.Enabled = false;
            this.txt_symbol.Location = new System.Drawing.Point(9, 86);
            this.txt_symbol.Name = "txt_symbol";
            this.txt_symbol.Size = new System.Drawing.Size(303, 26);
            this.txt_symbol.TabIndex = 3;
            // 
            // txt_ecname
            // 
            this.txt_ecname.Enabled = false;
            this.txt_ecname.Location = new System.Drawing.Point(9, 57);
            this.txt_ecname.Name = "txt_ecname";
            this.txt_ecname.Size = new System.Drawing.Size(303, 26);
            this.txt_ecname.TabIndex = 2;
            // 
            // txt_cname
            // 
            this.txt_cname.Enabled = false;
            this.txt_cname.Location = new System.Drawing.Point(9, 29);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(303, 26);
            this.txt_cname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(336, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "نوع العملة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(366, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "الفكة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(353, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "الصرف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(363, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "الرمز";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(322, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "الإسم اللاتيني";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(336, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "إسم العملة";
            // 
            // gp_ctrl
            // 
            this.gp_ctrl.Controls.Add(this.btn_edit);
            this.gp_ctrl.Controls.Add(this.btn_exit);
            this.gp_ctrl.Controls.Add(this.btn_del);
            this.gp_ctrl.Controls.Add(this.btn_save);
            this.gp_ctrl.Controls.Add(this.btn_new);
            this.gp_ctrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ctrl.Location = new System.Drawing.Point(5, 395);
            this.gp_ctrl.Name = "gp_ctrl";
            this.gp_ctrl.Size = new System.Drawing.Size(408, 68);
            this.gp_ctrl.TabIndex = 5;
            this.gp_ctrl.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_exit.Location = new System.Drawing.Point(9, 18);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 38);
            this.btn_exit.TabIndex = 11;
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
            this.btn_del.TabIndex = 10;
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
            this.btn_save.TabIndex = 8;
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
            // frm_currencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 465);
            this.Controls.Add(this.gp_currencies);
            this.Controls.Add(this.gp_inputs);
            this.Controls.Add(this.gp_ctrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_currencies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "العملات";
            this.gp_currencies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currencies)).EndInit();
            this.gp_inputs.ResumeLayout(false);
            this.gp_inputs.PerformLayout();
            this.gp_ctrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gp_currencies;
        private System.Windows.Forms.DataGridView dgv_currencies;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.GroupBox gp_inputs;
        private System.Windows.Forms.RadioButton rb_frign;
        private System.Windows.Forms.RadioButton rb_local;
        private System.Windows.Forms.TextBox txt_part;
        private System.Windows.Forms.TextBox txt_exch;
        private System.Windows.Forms.TextBox txt_symbol;
        private System.Windows.Forms.TextBox txt_ecname;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp_ctrl;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
    }
}