namespace GOLESTAN_PROJECT
{
    partial class Moderator_UserList_Form
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
            this.form_title_lbl = new System.Windows.Forms.Label();
            this.Students_display_panel = new System.Windows.Forms.Panel();
            this.Users_listView = new System.Windows.Forms.ListView();
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_field = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.update_userlist_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.regEnable_btn = new System.Windows.Forms.Button();
            this.Students_display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(25, 9);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(138, 45);
            this.form_title_lbl.TabIndex = 17;
            this.form_title_lbl.Text = "دانشجویان";
            // 
            // Students_display_panel
            // 
            this.Students_display_panel.Controls.Add(this.Users_listView);
            this.Students_display_panel.Location = new System.Drawing.Point(33, 68);
            this.Students_display_panel.Name = "Students_display_panel";
            this.Students_display_panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Students_display_panel.Size = new System.Drawing.Size(550, 370);
            this.Students_display_panel.TabIndex = 16;
            // 
            // Users_listView
            // 
            this.Users_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentName,
            this.student_field,
            this.studentId});
            this.Users_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Users_listView.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_listView.FullRowSelect = true;
            this.Users_listView.HideSelection = false;
            this.Users_listView.Location = new System.Drawing.Point(0, 0);
            this.Users_listView.MultiSelect = false;
            this.Users_listView.Name = "Users_listView";
            this.Users_listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Users_listView.RightToLeftLayout = true;
            this.Users_listView.Size = new System.Drawing.Size(550, 370);
            this.Users_listView.TabIndex = 0;
            this.Users_listView.UseCompatibleStateImageBehavior = false;
            this.Users_listView.View = System.Windows.Forms.View.Details;
            // 
            // studentName
            // 
            this.studentName.Text = "نام کاربر";
            this.studentName.Width = 150;
            // 
            // student_field
            // 
            this.student_field.Text = "رشته";
            this.student_field.Width = 150;
            // 
            // studentId
            // 
            this.studentId.Text = "کدملی      ";
            this.studentId.Width = 150;
            // 
            // update_userlist_btn
            // 
            this.update_userlist_btn.AutoSize = true;
            this.update_userlist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_userlist_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.update_userlist_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.update_userlist_btn.Location = new System.Drawing.Point(33, 466);
            this.update_userlist_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_userlist_btn.Name = "update_userlist_btn";
            this.update_userlist_btn.Size = new System.Drawing.Size(178, 41);
            this.update_userlist_btn.TabIndex = 19;
            this.update_userlist_btn.Text = "به روز رسانی";
            this.update_userlist_btn.UseVisualStyleBackColor = true;
            this.update_userlist_btn.Click += new System.EventHandler(this.update_userlist_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.AutoSize = true;
            this.Remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Remove_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Remove_btn.Location = new System.Drawing.Point(657, 183);
            this.Remove_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(178, 41);
            this.Remove_btn.TabIndex = 26;
            this.Remove_btn.Text = "حذف کاربر";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.AutoSize = true;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.edit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.edit_btn.Location = new System.Drawing.Point(657, 246);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(178, 41);
            this.edit_btn.TabIndex = 30;
            this.edit_btn.Text = "ویرایش اطلاعات کاربر";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // regEnable_btn
            // 
            this.regEnable_btn.AutoSize = true;
            this.regEnable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regEnable_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.regEnable_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.regEnable_btn.Location = new System.Drawing.Point(657, 322);
            this.regEnable_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regEnable_btn.Name = "regEnable_btn";
            this.regEnable_btn.Size = new System.Drawing.Size(178, 41);
            this.regEnable_btn.TabIndex = 31;
            this.regEnable_btn.Text = "منع ثبت نام";
            this.regEnable_btn.UseVisualStyleBackColor = true;
            this.regEnable_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Moderator_UserList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.regEnable_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.update_userlist_btn);
            this.Controls.Add(this.form_title_lbl);
            this.Controls.Add(this.Students_display_panel);
            this.Name = "Moderator_UserList_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Moderator_StudentList_Form";
            this.Load += new System.EventHandler(this.Moderator_StudentList_Form_Load);
            this.Students_display_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form_title_lbl;
        private System.Windows.Forms.Panel Students_display_panel;
        private System.Windows.Forms.ListView Users_listView;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader student_field;
        private System.Windows.Forms.ColumnHeader studentId;
        private System.Windows.Forms.Button update_userlist_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button regEnable_btn;
    }
}