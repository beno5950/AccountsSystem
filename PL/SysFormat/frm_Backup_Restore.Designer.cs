namespace AccountSystem.PL.SysFormat
{
    partial class frm_Backup_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Backup_Restore));
            this.btn_backup_restore = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_backup_restore
            // 
            this.btn_backup_restore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup_restore.ForeColor = System.Drawing.Color.Maroon;
            this.btn_backup_restore.Location = new System.Drawing.Point(18, 36);
            this.btn_backup_restore.Name = "btn_backup_restore";
            this.btn_backup_restore.Size = new System.Drawing.Size(165, 46);
            this.btn_backup_restore.TabIndex = 0;
            this.btn_backup_restore.Text = "إسترجاع النسخة الإحتياطية";
            this.btn_backup_restore.UseVisualStyleBackColor = true;
            this.btn_backup_restore.Click += new System.EventHandler(this.btn_backup_restore_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Maroon;
            this.btn_exit.Location = new System.Drawing.Point(189, 36);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 46);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_Backup_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 115);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_backup_restore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Backup_Restore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إسترجاع النسخة الإحتياطية";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_backup_restore;
        private System.Windows.Forms.Button btn_exit;
    }
}