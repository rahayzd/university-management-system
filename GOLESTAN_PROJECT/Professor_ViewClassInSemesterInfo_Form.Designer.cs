namespace GOLESTAN_PROJECT
{
    partial class Professor_ViewClassInSemesterInfo_Form
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
            this.studentmark_tbox = new System.Windows.Forms.TextBox();
            this.mark_lbl = new System.Windows.Forms.Label();
            this.Update_ClassListview_btn = new System.Windows.Forms.Button();
            this.submit_mark_btn = new System.Windows.Forms.Button();
            this.semester_lbl = new System.Windows.Forms.Label();
            this.form_title_lbl = new System.Windows.Forms.Label();
            this.Semester_display_panel = new System.Windows.Forms.Panel();
            this.SemesterClassStudent_listView = new System.Windows.Forms.ListView();
            this.student_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester_display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentmark_tbox
            // 
            this.studentmark_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentmark_tbox.Location = new System.Drawing.Point(722, 333);
            this.studentmark_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentmark_tbox.MaxLength = 20;
            this.studentmark_tbox.Name = "studentmark_tbox";
            this.studentmark_tbox.Size = new System.Drawing.Size(137, 33);
            this.studentmark_tbox.TabIndex = 42;
            this.studentmark_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentmark_tbox_KeyPress);
            // 
            // mark_lbl
            // 
            this.mark_lbl.AutoSize = true;
            this.mark_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mark_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.mark_lbl.Location = new System.Drawing.Point(646, 337);
            this.mark_lbl.Name = "mark_lbl";
            this.mark_lbl.Size = new System.Drawing.Size(43, 29);
            this.mark_lbl.TabIndex = 41;
            this.mark_lbl.Text = "نمره";
            // 
            // Update_ClassListview_btn
            // 
            this.Update_ClassListview_btn.AutoSize = true;
            this.Update_ClassListview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_ClassListview_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Update_ClassListview_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Update_ClassListview_btn.Location = new System.Drawing.Point(667, 182);
            this.Update_ClassListview_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update_ClassListview_btn.Name = "Update_ClassListview_btn";
            this.Update_ClassListview_btn.Size = new System.Drawing.Size(192, 54);
            this.Update_ClassListview_btn.TabIndex = 40;
            this.Update_ClassListview_btn.Text = "به روز رسانی";
            this.Update_ClassListview_btn.UseVisualStyleBackColor = true;
            // 
            // submit_mark_btn
            // 
            this.submit_mark_btn.AutoSize = true;
            this.submit_mark_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_mark_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.submit_mark_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.submit_mark_btn.Location = new System.Drawing.Point(667, 391);
            this.submit_mark_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit_mark_btn.Name = "submit_mark_btn";
            this.submit_mark_btn.Size = new System.Drawing.Size(192, 54);
            this.submit_mark_btn.TabIndex = 39;
            this.submit_mark_btn.Text = "ثبت نمره";
            this.submit_mark_btn.UseVisualStyleBackColor = true;
            this.submit_mark_btn.Click += new System.EventHandler(this.submit_mark_btn_Click);
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.semester_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.semester_lbl.Location = new System.Drawing.Point(18, 87);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.semester_lbl.Size = new System.Drawing.Size(121, 34);
            this.semester_lbl.TabIndex = 38;
            this.semester_lbl.Text = "ترم تحصیلی:";
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(16, 13);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(198, 45);
            this.form_title_lbl.TabIndex = 37;
            this.form_title_lbl.Text = "دانشجویان درس";
            // 
            // Semester_display_panel
            // 
            this.Semester_display_panel.Controls.Add(this.SemesterClassStudent_listView);
            this.Semester_display_panel.Location = new System.Drawing.Point(24, 140);
            this.Semester_display_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Semester_display_panel.Name = "Semester_display_panel";
            this.Semester_display_panel.Size = new System.Drawing.Size(563, 374);
            this.Semester_display_panel.TabIndex = 36;
            // 
            // SemesterClassStudent_listView
            // 
            this.SemesterClassStudent_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.student_name,
            this.student_id,
            this.student_mark});
            this.SemesterClassStudent_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemesterClassStudent_listView.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterClassStudent_listView.HideSelection = false;
            this.SemesterClassStudent_listView.Location = new System.Drawing.Point(0, 0);
            this.SemesterClassStudent_listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SemesterClassStudent_listView.MultiSelect = false;
            this.SemesterClassStudent_listView.Name = "SemesterClassStudent_listView";
            this.SemesterClassStudent_listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SemesterClassStudent_listView.RightToLeftLayout = true;
            this.SemesterClassStudent_listView.Size = new System.Drawing.Size(563, 374);
            this.SemesterClassStudent_listView.TabIndex = 1;
            this.SemesterClassStudent_listView.UseCompatibleStateImageBehavior = false;
            this.SemesterClassStudent_listView.View = System.Windows.Forms.View.Details;
            // 
            // student_name
            // 
            this.student_name.Text = "نام دانشجو";
            this.student_name.Width = 200;
            // 
            // student_id
            // 
            this.student_id.Text = "کدملی";
            this.student_id.Width = 150;
            // 
            // student_mark
            // 
            this.student_mark.Text = "نمره";
            this.student_mark.Width = 150;
            // 
            // Professor_ViewClassInSemesterInfo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.studentmark_tbox);
            this.Controls.Add(this.mark_lbl);
            this.Controls.Add(this.Update_ClassListview_btn);
            this.Controls.Add(this.submit_mark_btn);
            this.Controls.Add(this.semester_lbl);
            this.Controls.Add(this.form_title_lbl);
            this.Controls.Add(this.Semester_display_panel);
            this.Name = "Professor_ViewClassInSemesterInfo_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Professor_ViewClassInSemesterInfo_Form";
            this.Load += new System.EventHandler(this.Professor_ViewClassInSemesterInfo_Form_Load);
            this.Semester_display_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentmark_tbox;
        private System.Windows.Forms.Label mark_lbl;
        private System.Windows.Forms.Button Update_ClassListview_btn;
        private System.Windows.Forms.Button submit_mark_btn;
        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.Label form_title_lbl;
        private System.Windows.Forms.Panel Semester_display_panel;
        private System.Windows.Forms.ListView SemesterClassStudent_listView;
        private System.Windows.Forms.ColumnHeader student_name;
        private System.Windows.Forms.ColumnHeader student_id;
        private System.Windows.Forms.ColumnHeader student_mark;
    }
}